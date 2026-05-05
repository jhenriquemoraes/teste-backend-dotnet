# 🚗 Teste Técnico - Back-end .NET

Este repositório contém a implementação de um teste técnico para avaliação de conhecimentos em desenvolvimento back-end utilizando .NET.

---

## 📌 Objetivo

Desenvolver soluções simples, organizadas e legíveis para problemas comuns de back-end, incluindo:

* Manipulação de strings
* Lógica de programação
* Estruturação de APIs REST
* Organização de código

---

## 🧱 Estrutura do Projeto

```
/OficinaApi
  /Controllers
    OrcamentosController.cs

  /Models
    CriarOrcamentoRequest.cs
    ItemOrcamentoRequest.cs

  /Services
    OrcamentoService.cs
```

---

## 🚀 Tecnologias Utilizadas

* .NET 8
* ASP.NET Core Web API
* C#
* Swagger (OpenAPI)

---

## 🔧 Como executar o projeto

### Pré-requisitos

* .NET 8 SDK instalado

### Passos

```bash
git clone https://github.com/SEU-USUARIO/NOME-REPO.git
cd OficinaApi
dotnet run
```

A API estará disponível em:

```
https://localhost:5001/swagger
```

---

## 📬 Endpoint implementado

### ➤ Criar Orçamento

**POST** `/api/orcamentos`

### Exemplo de requisição:

```json
{
  "clienteId": 10,
  "veiculoId": 25,
  "itens": [
    {
      "descricao": "Troca de óleo",
      "quantidade": 1,
      "valorUnitario": 120.00
    },
    {
      "descricao": "Filtro de óleo",
      "quantidade": 1,
      "valorUnitario": 45.00
    }
  ]
}
```

---

## ✅ Regras de Negócio

* `clienteId` é obrigatório
* `veiculoId` é obrigatório
* Deve existir pelo menos 1 item
* Cada item deve conter:

  * descrição válida
  * quantidade maior que zero
  * valor unitário maior que zero
* O valor total é calculado automaticamente pela API

---

## 📤 Respostas da API

### ✔ Sucesso

* Retorna o orçamento com valor total calculado
* Status inicial: `Aberto`

### ❌ Erro

* Retorna mensagem clara indicando o problema encontrado

---

## 🧠 Decisões Técnicas

* Utilização de **Service Layer** para separar regras de negócio do controller
* Uso de **DTOs** para entrada de dados
* Validações realizadas manualmente para maior controle e clareza
* Estrutura simples e objetiva, adequada ao escopo do teste

---

## 💡 Considerações

O foco deste projeto foi demonstrar:

* Clareza na implementação
* Organização do código
* Boas práticas básicas de API REST

Sem aplicar complexidade desnecessária ao escopo proposto.

---

## 👨‍💻 Autor

Henrique Moraes  
[LinkedIn](https://www.linkedin.com/in/jhenriquesmoraes/)
