# Property Search

ASP.NET Core 2.1 MVC Web app with bootstrap and jquery to implement simple search app for listing property details related to search criteria.

Basic form with minimal validation. Small list of results from static in memory data source returned. On click of list item, an ajax call is made to return image of property selected.

### Working example

To see the finished project visit: https://dhpropertysearch.azurewebsites.net/

This is hosted in Azure app services in a Docker container.

### Installing

You can run this locally using dotnet

```
dotnet build
dotnet run
```

Alternatively you can run it through Docker. 

```
docker build -t repo/image-name .
docker run --rm -p 8080:80 repo/image-name
```
Browse to http://localhost:8080/

## Running the tests

There is 1 example unit test for the PropertyController. Tests use AutoFixture to create dummy inputs. Moq to mock repositories. Test framework is MSTest.

To run tests run:

```
dotnet test
```
If using docker, these will run on build.


## Deployment

This is automatically deployed to Azure App Services (https://dhpropertysearch.azurewebsites.net/) on push to the docker repository dh99/propertysearch. There is a webhook pushing the latest image from Docker Hub to Azure. 

To run latest image run:
```
docker run --rm -p 8080:80 dh99/propertysearch:latest
```
