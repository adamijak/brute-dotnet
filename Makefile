SHELL=bash

publish:
	dotnet publish -c Release App/App.csproj
	cp App/bin/Release/net7.0/linux-x64/publish/App out
	zip out.zip out Makefile main.c App/src/*.cs App/App.csproj

clean:
	rm out.zip out

test:
	dotnet test