# LazyCapybara v2



## :memo: O que soluciona?

Uma rep�blico possui alguns quartos com medidores individuais de consumo de energia el�trica.
O objetivo da calculadora � gerar valores de contas individuais para cada inquilino atrav�s de uma divis�o das contas de �gua e luz, levando em considera��o a diferen�a de consumo registrada nos medidores.

Al�m disso, Lazy Capybara tamb�m tem como objetivo manter um registro e hist�rico de inquilinos, contas e informa��es adicionais sobre os quartos.
Pretende ser uma aplica��o escal�vel, possibilitando diversas novas configura��es com facilidade, al�m de permitir adicionar, editar ou remover quartos, informa��es sobre inquilinos e registros dos medidores (para caso algum registro seja adicionado com erro).

## :up: Sobre a v1 e por que atualizar?

A LazyCapybara calculator v1 � apenas uma calculadora, sem nenhum tipo de registro. Por conta disso e de um mau planejamento de UI/UX, possui muitos campos para preencher em uma �nica tela, faz-se necess�rio anota��es manuais e registro manual dos valores importantes.
A LazyCapybara v2 visa n�o s� solucionar todos estes problemas, como tamb�m trazer novas funcionalidades e um design mais atraente.

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

:ballot_box_with_check: ~~Servi�os de manipula��o de objetos Quarto e Inquilino~~

:ballot_box_with_check: ~~Formul�rios iniciais para testes de cria��o e atribui��o de valores~~

:ballot_box_with_check: ~~Organiza��o inicial do projeto~~

:ballot_box_with_check: ~~DTOs para Quarto e Inquilino~~

:ballot_box_with_check: ~~Profiles de mapeamento entre DTOs e Models~~

:white_square_button: Interfaces de servi�os permitindo acesso aos Models pela aplica��o principal

:white_square_button: Remover refer�ncia ao Models da aplica��o principal

:white_square_button: Montar testes unit�rios com boa cobertura

:white_square_button: Modelar banco de dados

:white_square_button: Conectar com banco de dados

:white_square_button: Implementar m�todos dos reposit�rios para Quarto e Inquilino

:white_square_button: :soon: (...) 