dotnet publish

cp -r classlib/bin/Debug/netstandard2.0/publish/ host/bin/Debug/netcoreapp2.1/publish/

dotnet --additional-deps host/bin/Debug/netcoreapp2.1/publish/classlib.deps.json host/bin/Debug/netcoreapp2.1/publish/host.dll