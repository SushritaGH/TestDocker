# Use the .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory
WORKDIR /src

# Copy the project file and restore dependencies
COPY DockerApp/DockerApp.csproj DockerApp/
RUN dotnet restore "./DockerApp/DockerApp.csproj"

# Copy the rest of the application code
COPY . .

# Publish the app
RUN dotnet publish "DockerApp/DockerApp.csproj" -c Release -o /app

# Use the .NET runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
COPY --from=build /app .

# Set entry point for the container
ENTRYPOINT ["dotnet", "DockerApp.dll"]
