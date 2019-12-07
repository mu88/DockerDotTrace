FROM mcr.microsoft.com/windows/servercore:1903

COPY bin/Release/netcoreapp3.0/win-x64/* ./

ENTRYPOINT ["TestWithDocker.exe"]