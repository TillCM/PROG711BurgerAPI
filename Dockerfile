FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
EXPOSE 80
#create working directory to copy files into 
WORKDIR /app
COPY /BurgerApi/BurgerApi.csproj .
#add Nuget packages by copying the csproj file and running restore
RUN ls -l
RUN dotnet restore BurgerApi.csproj 
#copy over the entire app and build an exe file to run the app
#/app/BurgerAPI
COPY BurgerApi ./
RUN dotnet publish BurgerApi.csproj -c release -o publishedApp
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
ENV TZ=Africa/Johannesburg
RUN apt-get update
RUN apt-get upgrade -y
RUN apt-get install -y tzdata curl
COPY --from=build /app/publishedApp .
HEALTHCHECK CMD curl --fail http://localhost:80 || exit 1
ENTRYPOINT ["dotnet", "BurgerApi.dll"]