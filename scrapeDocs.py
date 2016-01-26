from lxml import html
import requests
import json
import argparse
import re
from lxml import etree as ET

def pp(e):
    return ET.tostring(e, pretty_print=True)


def clean(str):
    c = str.replace(u"\u00A0", " ")
    c = c.replace(u"\xa0", " ")
    c = c.replace(u'\x96', " ")
    c = c.replace(u'\xae', " ")

    c = c.replace("// ", "")
    c = re.sub(" +$", "", c)
    c = re.sub("^ +", "", c)
    c = re.sub("  ", " ", c)
    c = re.sub("\r\n", "", c)
    return c

def parseParamName(str):
    bits = str.split("=")
    pname = bits[0]
    pdefault = ''
    if len(bits) > 1:
        pdefault = bits[1]

    return pname,pdefault

def getData(url, numfuncs):

    if not numfuncs:
        numfuncs = 1000

    numfuncs = int(numfuncs)

    #print "URL: " + url
    #print numfuncs

    data = {
        'url': url,
        'functions': []
    }

    page = requests.get(url)
    tree = html.fromstring(page.content)

    titlePath = '//html/body/div/p/strong/text()'

    #print page.content

    basePath = '//html/body/div/table/tbody/tr/td[@class="doctext"]/div[@id="help"]'

    data['title'] = clean(tree.xpath(titlePath)[0])
    data['description'] = clean(tree.xpath(basePath + '/p[@class="p_Function"]/span/text()')[0])

    # get function descriptions
    paramNames = tree.xpath(basePath + '/p[@class="p_FunctionParameter"]/span[@class="f_FunctionParameter"]/text()')
    paramDescs = tree.xpath(basePath + '/p[@class="p_ParameterDesrciption"]')
    functionParamDescs = {}

    i=0
    for name in paramNames:
        pname, pdefault = parseParamName(name)

        textelements = paramDescs[i].xpath('./*/text()')
        text = ''
        for t in textelements:
            text += t

        if paramDescs[i].tail:
            text += paramDescs[i].tail

        name = clean(pname)
        functionParamDescs[name] = {
            'name': clean(name),
            'description': clean(text),
            'default': clean(pdefault)
        }
        i += 1


    #print functionParamDescs

    classes = ["f_Keywords", "f_Functions", "f_Param", "f_Indicators"]
    contains = ' or '.join('contains(@class,("%s"))' % c for c in classes)

    codeBasePath = basePath + '/div/table[@class="help"]/tr/td/p[@class="p_CodeExample"]/span[%s]/text()' % contains
    code = tree.xpath(codeBasePath)

    p=0

    function = {}
    paramName = ''
    paramType = ''
    paramDefault = ''
    prev = ''
    paramCheck = False

    numf = 0
    for c in code:
        c = clean(c)
        print c
        if re.search(data['title'], c):
            if function:
                if numf < numfuncs:
                    data['functions'].append(function)
                    numf += 1

            function = {
                'parameters': [],
                'name': c,
                'returnType': prev
            }
            paramCheck = True
            p = 0


        elif paramCheck and p == 0:
            #print "p==0 %s" % c
            if not re.search('[A-Za-z]+', c):
                p = 0
            else:
                paramType = c
                #print "paramType %s" % c
                p = 1

        elif paramCheck and p == 1:
            #print "p==1 %s" % c
            paramName, paramDefault = parseParamName(c)
            #print "paramName %s" % c
            try:
                description = functionParamDescs[paramName]['description']
            except Exception:
                description = ''
            function['parameters'].append({
                'name': clean(paramName),
                'type': clean(paramType),
                'default': clean(paramDefault),
                'description': clean(description)
            })
            p = 0


        prev = c

    if numf < numfuncs:
        data['functions'].append(function)


    # Do cleanup and type swapping here
    for f in data['functions']:
        f['returnType'] = f['returnType'].replace("datetime", "DateTime");
        #if f['returnType'] == 'string':
        if 'parameters' in f:
            for p in f['parameters']:
                if p['type'] == 'argument':
                    p['type'] = 'string'
                    p['name'] = 'argument'

                if "[]" in p['name']:
                    p['name'] = p['type'].replace("[]", "");
                    p['type'] = p['type'] + "[]";

                if p['name'] == "double":
                    p['name'] = "array"

                p['type'] = p['type'].replace("color", "COLOR");
                p['type'] = p['type'].replace("const ", "");
                p['type'] = p['type'].replace("datetime", "DateTime");


    return data


def main():
    baseUrl = 'http://mm.l/mql4/docs.mql4.com/'
    functionsList = 'functionlist-tmp.txt'
    functionsList = 'functionlist.txt'
    jsonFile = 'function.dump.json'

    functions = []
    lines = [line.rstrip('\n') for line in open(functionsList)]

    for url in lines:
        bits = url.split(" ")
        url = bits[0]
        numfuncs = None
        if len(bits) > 1:
            numfuncs = bits[1]
        functions.append(getData(baseUrl + url + '.html', numfuncs))

    with open(jsonFile, "w") as f:
    	f.write(json.dumps(functions, indent=4))

if __name__ == "__main__":
    main()



