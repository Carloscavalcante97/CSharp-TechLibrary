# CSharp-TechLibrary

CSharp-TechLibrary é uma API desenvolvida em **.NET 9**, projetada para demonstrar conceitos fundamentais e avançados da linguagem **C#**.  
O projeto adota os princípios do **Domain-Driven Design (DDD)** para uma estruturação clara e eficaz do código.  
![Example-Image]
## Funcionalidades

- **Cadastro de Despesas**: Permite registrar despesas pessoais com detalhes como título, data e hora, descrição, valor e tipo de pagamento.  
- **Consulta de Despesas**: Possibilita a visualização e filtragem das despesas cadastradas.  
- **Atualização e Exclusão**: Facilita a modificação ou remoção de registros de despesas existentes.  

### Construído com

![badge-dot-net]
![badge-windows]
![badge-visual-studio]
![badge-mysql]
![badge-swagger]

## Tecnologias Utilizadas

- **.NET 9**: Framework principal para o desenvolvimento da API.  
- **Entity Framework Core**: Utilizado como ORM para interagir com o banco de dados **SQLite**, simplificando as operações de CRUD.  
- **FluentValidation**: Implementado para validar as entradas de dados de forma fluente e desacoplada.  
- **Swagger**: Fornece uma interface interativa para documentação e testes dos endpoints da API.  

## Estrutura do Projeto

O repositório está organizado da seguinte forma:

- **TechLibrary.Api**: Contém os controladores e configurações da API.  
- **TechLibrary.Communication**: Inclui as classes de comunicação, como DTOs e ViewModels.  
- **TechLibrary.Exception**: Gerencia as exceções e tratamentos de erro da aplicação.  

## Como Executar o Projeto

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/Carloscavalcante97/CSharp-TechLibrary.git
2. Preencha as informações no arquivo `appsettings.Development.json`.
3. Execute a API e aproveite o seu teste :)

<!-- Links -->
[dot-net-sdk]: https://dotnet.microsoft.com/en-us/download/dotnet/8.0

<!-- Images -->
[Example-Image]: Images/Example.png

<!-- Badges -->
[badge-dot-net]: https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=fff&style=for-the-badge
[badge-windows]: https://img.shields.io/badge/Windows-0078D4?logo=windows&logoColor=fff&style=for-the-badge
[badge-visual-studio]: https://img.shields.io/badge/Visual%20Studio-5C2D91?logo=visualstudio&logoColor=fff&style=for-the-badge
[badge-mysql]: https://img.shields.io/badge/MySQL-4479A1?logo=mysql&logoColor=fff&style=for-the-badge
[badge-swagger]: https://img.shields.io/badge/Swagger-85EA2D?logo=swagger&logoColor=000&style=for-the-badge
