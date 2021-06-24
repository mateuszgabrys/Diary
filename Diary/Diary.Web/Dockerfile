#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Diary.Web/Diary.Web.csproj", "Diary.Web/"]
RUN dotnet restore "Diary.Web/Diary.Web.csproj"
COPY . .
WORKDIR "/src/Diary.Web"
RUN dotnet build "Diary.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Diary.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Diary.Web.dll"]
