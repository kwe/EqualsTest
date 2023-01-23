FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Equals/Equals.csproj", "Equals/"]
RUN dotnet restore "Equals/Equals.csproj"
COPY . .
WORKDIR "/src/Equals"
RUN dotnet build "Equals.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Equals.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Equals.dll"]
