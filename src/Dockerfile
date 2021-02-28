#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Courses.API/Courses.API.csproj", "src/Courses.API/"]
COPY ["src/Courses.Application/Courses.Application.csproj", "src/Courses.Application/"]
COPY ["src/Courses.Domain/Courses.Domain.csproj", "src/Courses.Domain/"]
COPY ["src/Courses.Data/Courses.Data.csproj", "src/Courses.Data/"]
RUN dotnet restore "src/Courses.API/Courses.API.csproj"
COPY . .
WORKDIR "/src/src/Courses.API"
RUN dotnet build "Courses.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Courses.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Courses.API.dll"]