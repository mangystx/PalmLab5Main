FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PalmLab5Main2/PalmLab5Main2.csproj", "PalmLab5Main2/"]
RUN dotnet restore "PalmLab5Main2/PalmLab5Main2.csproj"
COPY . .
WORKDIR "/src/PalmLab5Main2"
RUN dotnet build "PalmLab5Main2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PalmLab5Main2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PalmLab5Main2.dll"]
