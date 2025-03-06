# Base image with ASP.NET Core runtime

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

WORKDIR /app

EXPOSE 80

EXPOSE 443


# Build stage

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src


# Copy project files

COPY ["Review/Review.csproj", "Review/"]

COPY ["BusinessLayer/BusinessLayer.csproj", "BusinessLayer/"]

COPY ["ModelLayer/ModelLayer.csproj", "ModelLayer/"]

COPY ["RepositoryLayer/RepositoryLayer.csproj", "RepositoryLayer/"]


# Restore dependencies

RUN dotnet restore "Review/Review.csproj"


# Copy everything and build the project

COPY . .

WORKDIR "/src/Review"

RUN dotnet build "Review.csproj" -c Release -o /app/build


# Publish the app

FROM build AS publish

RUN dotnet publish "Review.csproj" -c Release -o /app/publish /p:UseAppHost=false


# Final runtime stage

FROM base AS final

WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Review.dll"]

