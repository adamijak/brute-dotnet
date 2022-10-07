#! /bin/bash

FAILED=0

for filein in ./datapub/*.in ; do
    fileout=${filein::-3}.out
	./app < $filein | cmp --silent - $fileout
    if [[ $? -eq 1 ]];
    then
        echo Test $filein failed!
        FAILED=$((FAILED + 1))
    fi
done

if [[ $FAILED -eq 0 ]];
then
    echo All tests have passed!
fi