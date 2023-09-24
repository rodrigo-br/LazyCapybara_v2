# LazyCapybara v2



## :memo: O que soluciona?

Uma repúblico possui alguns quartos com medidores individuais de consumo de energia elétrica.
O objetivo da calculadora é gerar valores de contas individuais para cada inquilino através de uma divisão das contas de água e luz, levando em consideração a diferença de consumo registrada nos medidores.

Além disso, Lazy Capybara também tem como objetivo manter um registro e histórico de inquilinos, contas e informações adicionais sobre os quartos.
Pretende ser uma aplicação escalável, possibilitando diversas novas configurações com facilidade, além de permitir adicionar, editar ou remover quartos, informações sobre inquilinos e registros dos medidores (para caso algum registro seja adicionado com erro).

## :up: Sobre a v1 e por que atualizar?

A LazyCapybara calculator v1 é apenas uma calculadora, sem nenhum tipo de registro. Por conta disso e de um mau planejamento de UI/UX, possui muitos campos para preencher em uma única tela, faz-se necessário anotações manuais e registro manual dos valores importantes.
A LazyCapybara v2 visa não só solucionar todos estes problemas, como também trazer novas funcionalidades e um design mais atraente.

## :wrench: Tecnologias utilizadas

- C#
- DotNet 7
- Entity Framework Core
- WindowsForms
- PostgreSQL
- ASP.NET Core Web Api
- JWT
- Identity
- XUnit, Moq e Postman para testes
- EF Tools
- Git
- Auto-mapper
- DotNetEnv e Secrets
- Docker e Docker-Compose
- SMTP :grey_question:
- Blazor :grey_question:

## :construction: Em desenvolvimento

:ballot_box_with_check: ~~Modelagem inicial das entidades Quarto e Inquilino~~

:ballot_box_with_check: ~~Server Side Validations para os modelos iniciais~~

:ballot_box_with_check: ~~Serviços de manipulação de objetos Quarto e Inquilino~~

:ballot_box_with_check: ~~Formulários iniciais para testes de criação e atribuição de valores~~

:ballot_box_with_check: ~~Organização inicial do projeto~~

:ballot_box_with_check: ~~DTOs para Quarto e Inquilino~~

:ballot_box_with_check: ~~Profiles de mapeamento entre DTOs e Models~~

:white_square_button: Interfaces de serviços permitindo acesso aos Models pela aplicação principal

:white_square_button: Remover referência ao Models da aplicação principal

:white_square_button: Montar testes unitários com boa cobertura

:white_square_button: Modelar banco de dados

:white_square_button: Conectar com banco de dados

:white_square_button: Implementar métodos dos repositórios para Quarto e Inquilino

:white_square_button: :soon: (...) 