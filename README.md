# MQL4DocScraper

This scraper will be used in conjunction with MQL4CSharp to populate the MQL commands part of the application

Run:
'''
  python scrapeDocs.py <relativeUrl>
'''

For example:
'''
  python scrapeDocs.py /objects/objectmove
'''

Output:
'''
{
    "url": "http://docs.mql4.com/objects/objectmove", 
    "functions": [
        {
            "returnType": "bool", 
            "name": "ObjectMove", 
            "parameters": [
                {
                    "type": "string", 
                    "name": "object_name", 
                    "description": "[in]  Name of the object."
                }, 
                {
                    "type": "int", 
                    "name": "point_index", 
                    "description": "[in]  Index of the anchor point. The number of anchor points depends on the type of object"
                }, 
                {
                    "type": "datetime", 
                    "name": "time", 
                    "description": "[in]  Time coordinate of the selected anchor point."
                }, 
                {
                    "type": "double", 
                    "name": "price", 
                    "description": "[in]  Price coordinate of the selected anchor point."
                }
            ]
        }, 
        {
            "returnType": "bool", 
            "name": "ObjectMove", 
            "parameters": [
                {
                    "type": "string", 
                    "name": "object_name", 
                    "description": "[in]  Name of the object."
                }, 
                {
                    "type": "int", 
                    "name": "point_index", 
                    "description": "[in]  Index of the anchor point. The number of anchor points depends on the type of object"
                }, 
                {
                    "type": "datetime", 
                    "name": "time", 
                    "description": "[in]  Time coordinate of the selected anchor point."
                }, 
                {
                    "type": "double", 
                    "name": "price", 
                    "description": "[in]  Price coordinate of the selected anchor point."
                }
            ]
        }
    ], 
    "description": "The function changes coordinates of the specified anchor point of the object at the specified chart. There are two variants of the function:", 
    "title": "ObjectMove"
}
'''

TODO: write a script to output the c# function based on the docs, associated enum value, and to also create the mql4 function
