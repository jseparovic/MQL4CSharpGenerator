#!/bin/bash

echo [
firstrun=1
for i in `cat functionlist.txt`
do
    if [ $firstrun -eq 1 ]
    then
        firstrun=0
    else
        echo ,
    fi

    python scrapeDocs.py -u $i
    if [ "$?" != "0" ]
    then
        exit 1
    fi
done

echo ]