FROM microsoft/dotnet:latest

WORKDIR /app
COPY ./HousingProvider.Data.Library /app/HousingProvider.Data.Library
COPY ./HousingProvider.Data.Service /app/HousingProvider.Data.Service

WORKDIR /app/HousingProvider.Data.Library
RUN dotnet restore
RUN dotnet build

WORKDIR /app/HousingProvider.Data.Service
RUN dotnet restore
RUN dotnet build

ENV ASPNETCORE_URLS="http://+:80"

CMD ["dotnet", "run"]
