SHELL=bash

run:
	dotnet run

test: publish
	./test.sh

publish:
	dotnet publish -c Release -r linux-x64 --self-contained
	mkdir out -p
	cp ./bin/Release/net6.0/linux-x64/publish/app ./app
	zip ./app.zip ./app ./src/* ./app.csproj ./Makefile ./main.c
 
