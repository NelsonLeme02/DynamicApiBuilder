# Use a imagem oficial do .NET SDK para build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copie o csproj e restaure quaisquer dependências (isso é feito em separado para aproveitar o cache do Docker)
COPY DynamicApiBuilder/DynamicApiBuilder.sln ./
COPY DynamicApiBuilder/DynamicApiBuilder.Function/DynamicApiBuilder.Function.csproj DynamicApiBuilder/DynamicApiBuilder.Function/
COPY DynamicApiBuilder/DynamicApiBuilder.Domain/DynamicApiBuilder.Domain.csproj DynamicApiBuilder/DynamicApiBuilder.Domain/
COPY DynamicApiBuilder/DynamicApiBuilder.Infrestructure/DynamicApiBuilder.Infrestructure.csproj DynamicApiBuilder/DynamicApiBuilder.Infrestructure/
COPY DynamicApiBuilder/DynamicApiBuilder.Application/DynamicApiBuilder.Application.csproj DynamicApiBuilder/DynamicApiBuilder.Application/
COPY DynamicApiBuilder/DynamicApiBuilder.UnityTest/DynamicApiBuilder.UnityTest.csproj DynamicApiBuilder/DynamicApiBuilder.UnityTest/
COPY DynamicApiBuilder/DynamicApiBuilder.FunctionalTest/DynamicApiBuilder.FunctionalTest.csproj DynamicApiBuilder/DynamicApiBuilder.FunctionalTest/

# Copie o restante do código e compile
COPY DynamicApiBuilder/ ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Use uma imagem menor do runtime Azure Functions para rodar a aplicação
FROM mcr.microsoft.com/azure-functions/dotnet:4
WORKDIR /home/site/wwwroot
COPY --from=build-env /app/out .

# Exponha a porta 80 para a Azure Functions runtime
EXPOSE 80

 
