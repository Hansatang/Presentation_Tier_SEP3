FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Presentation_Tier_SEP3/Presentation_Tier_SEP3.csproj", "Presentation_Tier_SEP3/"]
RUN dotnet restore "Presentation_Tier_SEP3/Presentation_Tier_SEP3.csproj"
COPY . .
WORKDIR "/src/Presentation_Tier_SEP3"
RUN dotnet build "Presentation_Tier_SEP3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Presentation_Tier_SEP3.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Presentation_Tier_SEP3.dll"]
