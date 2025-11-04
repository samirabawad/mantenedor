# Etapa base con SDK de .NET 8
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS dev

# Establecer el directorio de trabajo dentro del contenedor
WORKDIR /app

# Copiar solo el archivo .csproj al principio (para aprovechar cache de Docker)
COPY Mantenedor_oficial_salaventasOLD/*.csproj ./Mantenedor_oficial_salaventasOLD/

# Restaurar dependencias
RUN dotnet restore ./Mantenedor_oficial_salaventasOLD/Mantenedor_oficial_salaventasOLD.csproj

# Copiar todo el código del proyecto (una vez restaurado)
COPY . ./

# Establecer el directorio de trabajo dentro del proyecto principal
WORKDIR /app/Mantenedor_oficial_salaventasOLD

# Exponer el puerto del Mantenedor
EXPOSE 5097

# Comando para correr la API en modo desarrollo con hot reload
CMD ["dotnet", "watch", "run", "--urls=http://0.0.0.0:5097"]
