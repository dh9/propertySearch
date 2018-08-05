FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY PropertySearch/*.csproj ./PropertySearch/
COPY PropertySearch.Tests/*.csproj ./PropertySearch.Tests/
RUN dotnet restore

# copy and build everything else
COPY PropertySearch/. ./PropertySearch/
COPY PropertySearch.Tests/. ./PropertySearch.Tests/

RUN dotnet build

FROM build AS testrunner
WORKDIR /app/PropertySearch.Tests
ENTRYPOINT ["dotnet", "test","--logger:trx"]

FROM build AS test
WORKDIR /app/PropertySearch.Tests
RUN dotnet test

FROM test AS publish
WORKDIR /app/PropertySearch
RUN dotnet publish -o out

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=publish /app/PropertySearch/out ./
ENTRYPOINT ["dotnet", "PropertySearch.dll"]
