#!/bin/bash

for i in `cat functionlist.txt`
do
    echo ">>>>>>>>>>>" $i
    python scrapeDocs.py -u $i
    if [ "$?" != "0" ]
    then
        exit 1
    fi

done