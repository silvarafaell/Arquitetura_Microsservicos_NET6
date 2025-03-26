### Curso na Udemy de Arquitetura de Microsserviços do 0 com ASP.NET, .NET 6 e C#

### Ferramentas Instaladas
- Visual Studio 2022
- Git e o Git Bash
- MySQL
- MySQL Workbench
- HeidiSQL
- Postman
- Docker

### WebService
- É uma aplicação em que é interoperavel e que é hospedada e pode ser acessada através de protocolo HTTP

### Rest
- É um estilo de arquitetura de software para sistemas distribuidos de hipermidia, como a World Wide Web. Um padrão arquitetural basicamente leve por natureza. Então quando você tiver limitações de banda prefira web services REST

### Rapida Introducao aos Microserviços
- O que são Microserviços  
 - Um estilo arquitetural
 - Aplicações Independentes
 - Uma alternativa as aplicações "monoliticas" tradicionais;
 - As aplicações são implementadas como um conjunto de pequenos serviços, cada um dos quais sendo executado como um processo indendepente e cada um dos quais se comunicando com os outros por meio de algum tipo de protocolo bem conhecido
   - Microserviços trazem vários benefícios e riscos que devem ser considerados
 - Microserviços são uma aplicação única composta por um conjunto de serviços menores
 - Vantangens dos Microserviços
    - Facil de compreender(dificil de compreender o todo)
    - Muito facil de testar,implantar,gerenciar,versionar e escolar serviços unicos
    - ciclo de mudanças desacoplado
    - mais facil de escalar os times de desenvolvimento
    - liberdade para experimentar novas linguages ou frameworks

### Criando o Primeiro Microserviço
 - Apresentação da Seção

### Migrations
- dotnet ef migrations add AddProductDataTableOnDB
- dotnet ef database update

### Autenticação com Oauth2,OpenID,JWT,Duende e Identity Server
- OAuth2
  - OAuth2 é um protocolo aberto que permite autorização de forma  simples e padronizada entre aplicações web,mobile e aplicações desktop.
  - Autorização
  - OAuth2 utiliza um acess token e a aplicação cliente usa esse token para acessar uma API ou endpoints.
  - OAuth2 determina também como os endpoints serão usados em diferentes tipos de aplicações
- OpenID Connect
  - OpenID Connect é simplesmente uma camada de identificação no topo do protocolo OAuth2
  - Através do OpenID Connect uma aplicação pode receber um Identity Token além de um access token se for o caso
  - O OpenID connect define como os diferentes tipos de aplicações cliente podem obter de forma segura um token do Identity Server
- Introdução ao Identity Server
  - Identity Server 5 - Duende Identity Server é uma implementação do OpenId Connect e Oauth 2 e é altamente otimizado para resolver problemas de segurança comuns em aplicações atuais, sejam elas mobile,nativas ou mesmo aplicações web.
- Terminologias do Identity Server
  - Client é um componente de software que requisita um token a um Identity Server, as vezes para autenticar um usuário ou para acessar um recurso.
  - API Resource normalmente representam uma funcionalidade que um cliente precisa invocar - normalmente implementados através de Web APIs.
  - Identity Resource (Claims) informações relacionadas a identidade do usuário. Ex: nome, email e etc.
  - Identity Token - a resposta a um processo de autenticação
  - Access Token possibilita o acesso do usuário a um API Resource.
 - dotnet new --install Duende.IdentityServer.Templates
 - dotnet new isui
- Migrations GeekShoppingIdentityServer
  - dotnet ef migrations add AddDefaultSecurityTablesOnDB
  - dotnet ef database update
- Desafio:
  - Identity Server e Validação JWT são conceitos diferentes, mas podem ser utilizados de maneiras complementares. Vou explicar ambos brevemente e como você pode usá-los em conjunto no contexto de uma aplicação React ou Angular.
     - 1 Validação JWT (JSON Web Token): o JWT é um formato de token de segurança que pode ser usado para representar informações entre duas partes de forma segura. É 
         frequentemente utilizado para autenticação e autorização em aplicações web e APIs. O JWT contém informações codificadas em formato JSON, assinadas digitalmente, e 
         pode ser usado para validar a identidade do usuário;
     - 2 Identity Server: o Identity Server é uma solução de código aberto para autenticação e autorização baseada em OAuth 2.0 e OpenID Connect. Ele é frequentemente usado 
         como um provedor de identidade (IdP) para aplicações web e APIs. O Identity Server emite tokens JWT para representar as informações de autenticação do usuário, que 
         podem ser validados por outras aplicações.
     - Agora, em relação ao uso no contexto de uma aplicação React ou Angular:
       - Validação JWT no React ou  Angular: Quando você tem um token JWT emitido pelo Identity Server (ou qualquer outro provedor de identidade), você pode usá-lo em uma 
          aplicação React para autenticar o usuário e permitir que ele acesse recursos protegidos no servidor. O React, como uma aplicação frontend, pode armazenar o token 
          no armazenamento local (por exemplo, localStorage ou sessionStorage) e enviá-lo no cabeçalho das requisições para autenticar as requisições ao servidor.
       - Identity Server com React: Você pode ter uma aplicação React que interage com o Identity Server para realizar o fluxo de autenticação. O usuário pode ser 
         redirecionado para o Identity Server para fazer login e, após a autenticação bem-sucedida, ele receberá um token JWT que será usado para autenticar as chamadas à 
         API da sua aplicação React ou Angular.
      - Aqui estão algumas etapas gerais de como isso pode ser implementado:
        - 1 Desenvolva um servidor backend (por exemplo, ASP.NET Core) que inclua o Identity Server para autenticação e emissão de tokens JWT;
        - 2 Desenvolva sua aplicação React ou Angular que interage com o servidor backend para autenticação;
        - 3 Use uma biblioteca ou abordagem adequada para armazenar o token JWT no lado do cliente (React ou Angular) após o login;
        - 4 Envie o token JWT no cabeçalho das solicitações para a API do servidor backend, para que ele possa verificar a autenticação em recursos protegidos.
      - O Identity Server pode ser uma solução robusta se você precisar de um provedor de identidade completo e desejar delegar a lógica de autenticação e autorização para 
         um serviço dedicado. Por outro lado, se você estiver trabalhando com um provedor de identidade externo ou simplesmente quiser uma validação básica do JWT, pode 
         optar por implementar apenas a validação do token JWT no seu servidor backend sem o uso do Identity Server.
      - Lembre-se de que a escolha entre essas abordagens dependerá dos requisitos específicos do seu projeto, da escala, da segurança e das políticas de autenticação que 
       você deseja implementar.


      
