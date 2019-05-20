# Hosting

## Generate publish files

```
dotnet publish
dotnet publish --configuration Release
```

Output defaults to: 

1.  `./bin/[configuration]/[framework]/publish/`            for a framework-dependent deployment 
or 
2.  `./bin/[configuration]/[framework]/[runtime]/publish/`  for a self-contained deployment.

## Ubuntu 14.04 hosting

1.  Make directory to host files
2.  Copy files
3.  Change files ownership
2.  Setup Nginx sites-available
3.  Setup link to sites-enabled
4.  Setup supervisor
5.  Setup haproxy

