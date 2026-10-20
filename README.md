# 💘 Cltinder API

API REST desenvolvida em **ASP.NET Core** inspirada no funcionamento de aplicativos de relacionamento (estilo Tinder), permitindo gerenciamento de usuários, curtidas (likes) e combinações (matches).

---

## 🚀 Tecnologias utilizadas

* C#
* ASP.NET Core
* Swagger (OpenAPI)
* Git & GitHub

---

## 📌 Funcionalidades

✔️ Cadastro de usuários
✔️ Listagem de usuários
✔️ Atualização e remoção de usuários
✔️ Sistema de likes entre usuários
✔️ Remoção de likes
✔️ Criação e listagem de matches

---

## 📂 Estrutura do projeto

```bash
CltinderApi/
│
├── Controllers/
├── Models/
├── Services/
├── Program.cs
└── appsettings.json
```

---

## 🔗 Repositório

Acesse o projeto no GitHub:
👉 https://github.com/byteaugusto/cltinder-api-hub

---

## 🔗 Endpoints da API

### 👤 Usuário

* `GET /api/Usuario` → Listar todos
* `POST /api/Usuario` → Criar usuário
* `GET /api/Usuario/{id}` → Buscar por ID
* `PUT /api/Usuario/{id}` → Atualizar
* `DELETE /api/Usuario/{id}` → Remover

### 👍 Like

* `POST /api/Like` → Curtir usuário
* `GET /api/Like` → Listar likes
* `DELETE /api/Like/{id}` → Remover like

### 💘 Match

* `POST /api/Match` → Criar match
* `GET /api/Match` → Listar matches

---

## 📄 Documentação (Swagger)

A documentação interativa da API está disponível via Swagger:

```bash
https://localhost:7208/swagger/index.html
```

Nela você pode:

* Testar endpoints
* Ver exemplos de request/response
* Conferir códigos HTTP

---

## ▶️ Como executar o projeto

1. Clone o repositório:

```bash
git clone https://github.com/byteaugusto/cltinder-api-hub.git
```

2. Acesse a pasta:

```bash
cd cltinder-api-hub
```

3. Execute o projeto:

```bash
dotnet run
```

4. Acesse no navegador:

```bash
https://localhost:7208/swagger/index.html
```

---
## 👨‍💻 Autor

Desenvolvido por **Matheus Augusto**
📌 Desenvolvedor Back-end em formação

---

## ⭐ Observação

Projeto de portfólio desenvolvido para praticar conceitos de APIs REST, CRUD e organização em camadas (Controller, Service, Model), com documentação via Swagger.


---
﻿# cltinder-api-hub
