# 📘 Avaliação Técnica – Clean Architecture + Banco de dados local

Este repositório contém minha entrega referente à avaliação técnica baseada no repositório original do professor:  
[https://github.com/victoricoma/avaliacao-tp2-helpapp](https://github.com/victoricoma/avaliacao-tp2-helpapp)

---

## ✅ Objetivo

Implementar os repositórios `Category` e `Product` seguindo os padrões da Clean Architecture, aplicar a migration `Initial` e conectar a aplicação com uma instância de banco de dados local.

---

## 🚀 Funcionalidades implementadas

- [x] Repositórios `CategoryRepository` e `ProductRepository`
- [x] Configurações com `EntityTypeConfiguration` para `Category` e `Product`
- [x] Injeção de dependência configurada (`DependencyInjectionAPI`)
- [x] Migration `Initial` criada com `HasData()` para categorias
- [x] Instanciar banco de dados local
- [x] Criar migration via `Add-Migration Initial`

---
# 🔧 Comandos utilizados
## Criação da migration
uso do comando `Add-Migration Initial`

## Aplicação no banco de dados (Local)
uso do comando `Update-Database`

# 🔗 String de conexão

"ConnectionStrings": {
  "DefaultConnection": "Data Source=PEDRO_F_LEITE\\SQLEXPRESS01;Initial Catalog=avaliacao_tp2_pedroleite;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True"
}

# ☁️ Configuração no SSMS

Banco de dados nomeado: avaliacao_tp2_pedroleite

Migration aplicada com sucesso diretamente do Visual Studio Terminal

# 🖼️ Prints de evidência (opcional)
Insira prints aqui comprovando:

Aplicação bem-sucedida da migration no Azure

Tabelas e dados populados

# 👨‍💻 Dados do aluno
Nome: Pedro Ferreira Leite
Curso: Desenvolvimento de Software Multiplataforma – 3º Semestre

Professor: Victor Icoma

Branch da entrega: avaliacao-PedroFerreiraLeite

## 🧱 Estrutura da aplicação

 ┣ 📂 HelpApp.Domain
 ┣ 📂 HelpApp.Application
 ┣ 📂 HelpApp.Infra.Data
 ┃ ┃ ┣ 📂 Migrations
 ┃ ┃ ┣ 📂 Repositories
 ┃ ┃ ┗ 📂 EntityConfiguration
 ┗ 📂 HelpApp.API
 ┗ 📂 HelpApp.Infra.IoC