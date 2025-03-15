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
      
