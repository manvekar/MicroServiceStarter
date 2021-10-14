<a href="https://dot.net/architecture">
   <img src="https://github.com/dotnet-architecture/eShopOnContainers/raw/dev/img/eshop_logo.png" alt="eShop logo" title="eShopOnContainers" align="right" height="60" />
</a>
# .NET Microservices Sample Reference Application inspired from eShopOnContainers

A microservices starter template application based on .NET Core reference application, to be based on a simplified microservices architecture and Docker containers.

## Getting Started

Make sure you have [installed](https://docs.docker.com/docker-for-windows/install/) and [configured](https://github.com/dotnet-architecture/eShopOnContainers/wiki/Windows-setup#configure-docker) docker in your environment. After that, you can run the below commands from the **/src/** directory and get started with the `microServiceStarter` immediately.

```powershell
docker-compose build
docker-compose up
```

You should be able to browse different components of the application by using the below URLs :

```
Web MVC :  http://host.docker.internal:6100/
Identity.API :  http://host.docker.internal:6500/
```

>Note: compared to eShopOnContainers the ports for containers have been configred on ports 6XXX instead so you can parallely run the Microsoft eShopOnContainers app.

This App uses 
DotnetCore for APIs and other laters
Postgres as Identity database build on IdentityServer4

