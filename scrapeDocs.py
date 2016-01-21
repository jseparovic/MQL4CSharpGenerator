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
    return c

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
        text = paramDescs[i].text
        a = paramDescs[i].xpath('./a/text()')

        if a:
            text += clean(a[0])

        if paramDescs[i].tail:
            text += paramDescs[i].tail
        functionParamDescs[name] = clean(text)
        i += 1


    codeBasePath = basePath + '/div/table[@class="help"]/tr/td/p[@class="p_CodeExample"]/span/text()'
    code = tree.xpath(codeBasePath)

    i=0
    j=0
    p=0

    function = {}
    paramName = ''
    paramType = ''

    for c in code:
        c = clean(c)
        if re.search('[a-z0-9();]+', c):
            if re.search('\(', c):
                continue;
            if re.search('\);', c):
                data['functions'].append(function);
                i=0;
                continue;
            if re.search('Script program start', c):
                break;

            if i == 0:
                function = {
                    'parameters': [],
                    'returnType': c.replace(" ", "")
                }
            elif i == 1:
                function['name'] = c
            elif j == 0:
                paramType = c;
                j+=1
            elif j == 1:
                paramName = c;
                j+=1
            elif j == 2:
                function['parameters'].append({'name': paramName, 'type': paramType, 'description': functionParamDescs[paramName]})
                j=0
            i+=1

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



