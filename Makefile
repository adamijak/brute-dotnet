SHELL=bash

run:
	dotnet run

test: publish
	./test.sh

publish:
	dotnet publish -c Release --self-contained
	cp bin/Release/net6.0/linux-x64/publish/app app
	zip app.zip Makefile main.c app src/* app.csproj

clean:
	rm app.zip app
