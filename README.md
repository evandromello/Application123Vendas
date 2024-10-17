# Api 123Vendas


Este projeto é destinado a manipulação das vendas da empresa 123Vendas 

## Como rodar o projeto

Após configurar seu ambiente .NET com o Visual Studio, rode os seguintes comandos:

```console
dotnet restore
```

Após será necessário criar seu banco SQL local seguindo os seguintes passos:

```console
dotnet ef database update
```

Com o banco criado já é possível validar a api localmente.
Rode os comandos:

```console
dotnet build
dotnet run
```

É possível testar a API usando o postman ou o próprio swagger da aplicação.
