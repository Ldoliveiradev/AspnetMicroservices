# Projeto 
Projeto e-commerce do curso feito na Udemy chamado Microservices Architecture and Implementation on .NET 5

# Introdução
Módulos de e-commerce sobre microsserviços Catalog, Basket e Ordering com NoSQL (MongoDB, Redis) e 
bancos de dados relacionais (PostgreSQL, Sql Server) com comunicação sobre RabbitMQ Event Driven Communication e 
usando Ocelot API Gateway. Arquitetura de Microsserviços e Implementação .NET

# Comando para rodar o projeto no docker
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d

# Microserviços
Catalog: Desenvolvido com as seguintes descrições.
-	Aplicação ASP.NET Core Web API
-	Princícios REST API e operações CRUD
-	Conexão e conteinerização do banco de dados MongoDB
-	Implementação do padrão de Repository
-   Implementação da API aberta do Swagger

Basket: Desenvolvido com as seguintes descrições.
-	Aplicação ASP.NET Core Web API
-	Princícios REST API e operações CRUD
-	Conexão e conteinerização do banco de dados Redis
-	Consumo do serviço Grpc de desconto para comunicação de sincronização entre serviços para calcular o preço final do produto
-   Publish na fila do BasketCheckout usando MassTransit e RabbitMQ

Discount: Desenvolvido com as seguintes descrições.
-	Aplicação ASP.NET Grpc Server
-	Criação de uma comunicação gRPC entre serviços de alto desempenho com o Basket Microservice
-	Expondo serviços Grpc com a criação de mensagens Protobuf
-	Usando Dapper para implementação de micro-orm para simplificar o acesso a dados e garantir alto desempenho
-   Conexão e conteinerização do banco de dados PostgreSQL

Comunicação dos Microserviços.
-	Sincronizar comunicação gRPC entre serviços
-	Comunicação assíncrona de microsserviços com o serviço de intermediário de mensagens RabbitMQ
-	Usando o modelo de troca de tópicos de Publish/Subscribe do RabbitMQ
-	Usando MassTransit para abstração no sistema RabbitMQ Message-Broker
-   Publicando fila de eventos BasketCheckout de microsserviços Basket e Inscrevendo este evento de microsserviços de pedidos
-   Criação da biblioteca RabbitMQ EventBus.Messages e adição de referências Microservices

Ordering: Desenvolvido com as seguintes descrições.
-	Implementando DDD, CQRS e Arquitetura Limpa com o uso de Melhores Práticas
-	Desenvolvendo CQRS usando pacotes MediatR, FluentValidation e AutoMapper
-	Consumindo a fila de eventos RabbitMQ BasketCheckout usando a configuração MassTransit-RabbitMQ
-	Conexão de banco de dados SqlServer e conteinerização
-   Usando o Entity Framework Core ORM e migrar automaticamente para o SqlServer na inicialização do aplicativo

API Gateway Ocelot: Desenvolvido com as seguintes descrições.
-	Implementação do API gateway com Ocelot
-	Microsserviços/contêineres de amostra para redirecionar por meio dos API Gateways
-	Execução de vários tipos diferentes de contêiner do API Gateway/BFF
-	O padrão de agregação do Gateway no Shopping.Aggregator

WebUI ShoppingApp: Desenvolvido com as seguintes descrições.
-	Aplicação Web ASP.NET Core com Bootstrap 4 e modelo Razor
-	Chamada dao Ocelot API com HttpClientFactory
-	Ferramentas do ASPNET Core Razor — Exibir componentes, exibições parciais, auxiliares de marca, vinculações e validações de modelo, seções do Razor etc.

Contêineres Auxiliares
-	Interface do usuário de gerenciamento leve do Portainer for Container, que permite gerenciar facilmente seus diferentes ambientes do Docker
-	Ferramentas pgAdmin PostgreSQL apresentam uma rica plataforma de administração e desenvolvimento Open Source para PostgreSQL

Docker Compose com todos os microsserviços no docker
-	Conteinerização de microsserviços
-	Conteinerização de bancos de dados
-	Override de variáveis ​​de ambiente