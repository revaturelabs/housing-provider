FROM microsoft/dotnet:latest

WORKDIR /app
COPY ./HousingProvider.Business.Library /app/HousingProvider.Business.Library
COPY ./HousingProvider.Business.Service /app/HousingProvider.Business.Service

WORKDIR /app/HousingProvider.Business.Library
RUN dotnet restore
RUN dotnet build

WORKDIR /app/HousingProvider.Business.Service
RUN dotnet restore
RUN dotnet build

ENV ASPNETCORE_URLS="http://+:80"

CMD ["dotnet", "run"]
