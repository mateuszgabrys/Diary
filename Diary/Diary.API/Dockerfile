#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Diary.API/Diary.API.csproj", "Diary.API/"]
RUN dotnet restore "Diary.API/Diary.API.csproj"
COPY . .
WORKDIR "/src/Diary.API"
RUN dotnet build "Diary.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Diary.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Diary.API.dll"]
