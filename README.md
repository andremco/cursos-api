# API Crud Cursos

API Rest que expõe operações CRUD de cursos feita em .Net Core 3.1

## Pré requisitos para roda local

- Visual Studio ou algum outro IDE que rode .Net Core 3.1
- Conexão com banco de dados Sql Server
- Docker (opcional)
- SDK .Net Core 3.1
 
## Link da api no azure

[Link API](https://coursesapi20210228202147.azurewebsites.net/swagger/)

## Scripts para realizar build local

Foi criado alguns arquivos em powershell, para realizar o build de forma mais fácil

```sh
.\PrivateBuild.ps1
```
ou simplesmente clica no arquivo build.bat.

## Docker

Para rodar o projeto no docker, altere a variável de ambiente ConnectionStringSqlServer no docker-compose.yml, para uma conexão do sql server, script de base dados na pasta /database. E depois rode o seguinte comando, na raíz do projeto:

```sh
docker-compose up -d --build
```

## Arquitetura da API
- Utilizando injeção de dependências nas classes
- Padrão singleton utilizando uma instância somente
- Repositórios para abstrair o acesso a camada do banco de dados
- Services onde é feita toda a lógica da aplicação
- Validações na camada domain do projeto

## Basic Auth
A Api está protegida por uma autenticação simples, o usuário prédefinido é admin - 123456, no swagger em Authorize tem dois campos para setar username -> admin, password -> 123456.
Ou se preferir, para fazer requisições passar o seguinte cabeçalho -H "Authorization: Basic YWRtaW46MTIzNDU2"

## Integração com DevOps
Foi criado para este projeto, uma pipeline que roda cada commit na branch main, executando somente uma build automático.