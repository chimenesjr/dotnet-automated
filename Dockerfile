FROM gcr.io/google-appengine/aspnetcore:2.1

COPY /bin/Release/netcoreapp2.1/. /app

ENV ASPNETCORE_URLS=http://*:8080

WORKDIR /app

EXPOSE 8080

ENTRYPOINT [ "dotnet", "dotnet-automated.dll"]