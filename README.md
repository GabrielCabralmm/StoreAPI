# 🛒 StoreAPI_CP2

API desenvolvida em **ASP.NET Core** para gerenciamento de clientes e produtos, utilizando **Entity Framework Core** com banco de dados **Oracle**.

---

## 📌 Objetivo

Esta API tem como objetivo fornecer endpoints para operações CRUD de:

* 👤 Clientes
* 📦 Produtos

Sendo utilizada como parte de avaliação prática (CP2), aplicando conceitos de:

* Web API REST
* Entity Framework Core
* Integração com banco de dados Oracle
* Migrations

---

## 🛠️ Tecnologias Utilizadas

* ASP.NET Core
* Entity Framework Core
* Oracle Database
* Swagger (OpenAPI)
* C#

---

## ⚙️ Configuração do Projeto

### 🔹 Pré-requisitos

* .NET SDK instalado (recomendado .NET 6 ou superior)
* Banco Oracle acessível
* Visual Studio ou VS Code

---

## ▶️ Como Executar o Projeto

1. Clone o repositório:

```
git clone <url-do-repositorio>
```

2. Acesse a pasta do projeto:

```
cd StoreAPI_CP2
```

3. Restaure os pacotes:

```
dotnet restore
```

4. Execute o projeto:

```
dotnet run
```

---

## 📄 Swagger

Após executar a aplicação, acesse:

```
https://localhost:7001/swagger
```

Ou a porta configurada no seu ambiente.

---

## 📁 Estrutura do Projeto

```
StoreAPI_CP2
│
├── Controllers
│   ├── ClienteController.cs
│   └── ProdutoController.cs
│
├── Data
│   └── ApplicationContext.cs
│
├── Entities
│   ├── ClienteEntity.cs
│   └── ProdutoEntity.cs
│
├── appsettings.json
├── appsettings.Development.json
└── Program.cs
```

---

## 🔄 Endpoints Principais

### 👤 Cliente

* GET /Cliente
* GET /Cliente/{id}
* POST /Cliente
* PUT /Cliente/{id}
* DELETE /Cliente/{id}

---

### 📦 Produto

* GET /Produto
* GET /Produto/{id}
* POST /Produto
* PUT /Produto/{id}
* DELETE /Produto/{id}

---

## ✅ Status

✔ Projeto funcional
✔ Conexão com Oracle configurada
✔ Migrations operacionais
✔ Swagger ativo

---
