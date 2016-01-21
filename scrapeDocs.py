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
    c = c.replace("// ", "")
    c = re.sub(" +$", "", c)
    return c

def parseParamName(str):
    bits = str.split("=")
    pname = bits[0]
    pdefault = ''
    if len(bits) > 1:
        pdefault = bits[1]

    return pname,pdefault

def getData(url):

    data = {
        'url': url,
        'functions': []
    }

    page = requests.get(url)
    tree = html.fromstring(page.content)

    basePath = '//html/body/div/table/tbody/tr/td[@class="doctext"]/div[@id="help"]'

    data['title'] = tree.xpath(basePath + '/h1/text()')[0]
    data['description'] = tree.xpath(basePath + '/p[@class="p_Function"]/span/text()')[0]

    # get function descriptions
    paramNames = tree.xpath(basePath + '/p[@class="p_FunctionParameter"]/span[@class="f_FunctionParameter"]/text()')
    paramDescs = tree.xpath(basePath + '/p[@class="p_ParameterDesrciption"]/span[@class="f_ParameterDesrciption"]')
    functionParamDescs = {}

    i=0
    for name in paramNames:
        pname, pdefault = parseParamName(name)

        text = paramDescs[i].text
        a = paramDescs[i].xpath('./a/text()')

        if a:
            text += clean(a[0])

        if paramDescs[i].tail:
            text += paramDescs[i].tail

        name = clean(pname)
        functionParamDescs[name] = {
            'name': name,
            'description': clean(text),
            'default': clean(pdefault)
        }
        i += 1

    print functionParamDescs

    classes = ["f_Keywords", "f_Functions", "f_Param", "f_Comments"]
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

    for c in code:
        c = clean(c)
#        print c
        if re.search(data['title'], c):
            if function:
                data['functions'].append(function)

            function = {
                'parameters': [],
                'name': c,
                'returnType': prev
            }
            paramCheck = True
            p = 0


        elif paramCheck and p == 0:
            if not re.search('[A-Za-z]+', c):
                p = 0
            else:
                paramType = c
                print "paramType %s" % c
                p = 1

        elif paramCheck and p == 1:
            paramName, paramDefault = parseParamName(c)
            print "paramName %s" % c
            p = 2

        elif paramCheck and p == 2:
            function['parameters'].append({
                'name': paramName,
                'type': paramType,
                'default': paramDefault,
                'description': functionParamDescs[paramName]['description']
            })
            p = 0

        prev = c

    data['functions'].append(function)

    return data


baseUrl = 'http://docs.mql4.com/'




def usage():
    print "python scrapeDocs.py -u <relativeurl>"

def main():
    parser = argparse.ArgumentParser()
    parser.add_argument('-u',  '--url')
    args = parser.parse_args()


    if args.url:
        data = getData(baseUrl + args.url)
        print json.dumps(data, indent=4)
    else:
        print "Must enter a relative url. Eg. objects/objectmove"


if __name__ == "__main__":
    main()



