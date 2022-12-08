﻿using Structurizr;
using Structurizr.Api;

namespace c4_model_microservices
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventario();
            //URL DE DIAGRAMA PÚBLICO EN STRUCTURIZR (workspace: 78136 creado en la web de structurizt) =>
            // https://structurizr.com/share/78136
        }

        static void Inventario()
        {
            const long workspaceId = 78136;
            const string apiKey = "66bb7aaf-2d15-49a3-83fb-dd535af060cf"; 
            const string apiSecret = "839c1914-5137-40cc-95d3-5bb9aaae7bdd";

            StructurizrClient structurizrClient = new StructurizrClient(apiKey, apiSecret);
            Workspace workspace = new Workspace("C4 Model Microservices - InventApp", "Sistema de Gestión de Inventario para Restaurante");
            Model model = workspace.Model;
            ViewSet viewSet = workspace.Views;

            // 1. Diagrama de Contexto (CONFIGURACIÓN)
            /*
            SoftwareSystem monitoringSystem = model.AddSoftwareSystem("Configuración", "Permite realizar el registro de usuarios y asignar roles ");
            //SoftwareSystem googleMaps = model.AddSoftwareSystem("Google Maps", "Plataforma que ofrece una REST API de información geo referencial.");
            //SoftwareSystem aircraftSystem = model.AddSoftwareSystem("Aircraft System", "Permite transmitir información en tiempo real por el avión del vuelo a nuestro sistema");

            Person administrador = model.AddPerson("Administrador", "Administrador del sistema.");
            //Person periodista = model.AddPerson("Periodista", "Periodista de los diferentes medios de prensa.");
            //Person developer = model.AddPerson("Developer", "Developer - Open Data.");

            administrador.Uses(monitoringSystem, "Realiza el registro de los nuevos usuarios que accederán al sistema de inventario");
            //periodista.Uses(monitoringSystem, "Realiza consultas para mantenerse al tanto de la planificación de los vuelos hasta la llegada del lote de vacunas al Perú");
            //developer.Uses(monitoringSystem, "Realiza consultas a la REST API para mantenerse al tanto de la planificación de los vuelos hasta la llegada del lote de vacunas al Perú");
            //monitoringSystem.Uses(aircraftSystem, "Consulta información en tiempo real por el avión del vuelo");
            //monitoringSystem.Uses(googleMaps, "Usa");
            
            SystemContextView contextView = viewSet.CreateSystemContextView(monitoringSystem, "Contexto", "Diagrama de contexto");
            contextView.PaperSize = PaperSize.A4_Landscape;
            contextView.AddAllSoftwareSystems();
            contextView.AddAllPeople();

            // Tags
            //monitoringSystem.AddTags("SistemaMonitoreo");
            //oogleMaps.AddTags("GoogleMaps");
            //aircraftSystem.AddTags("AircraftSystem");
            administrador.AddTags("Administrador");
            //periodista.AddTags("Periodista");
            //developer.AddTags("Developer");
            
            Styles styles = viewSet.Configuration.Styles;
            styles.Add(new ElementStyle("Administrador") { Background = "#0a60ff", Color = "#ffffff", Shape = Shape.Person });
     
            styles.Add(new ElementStyle("Periodista") { Background = "#08427b", Color = "#ffffff", Shape = Shape.Person });
            styles.Add(new ElementStyle("Developer") { Background = "#facc2e", Shape = Shape.Robot });
            styles.Add(new ElementStyle("SistemaMonitoreo") { Background = "#008f39", Color = "#ffffff", Shape = Shape.RoundedBox });
            styles.Add(new ElementStyle("GoogleMaps") { Background = "#90714c", Color = "#ffffff", Shape = Shape.RoundedBox });
            styles.Add(new ElementStyle("AircraftSystem") { Background = "#2f95c7", Color = "#ffffff", Shape = Shape.RoundedBox });
            */
             // 1. Diagrama de Contexto (CONFIGURACIÓN)



            // 2. Diagrama de Contexto (INVENTARIO)
           /*
            SoftwareSystem inventario = model.AddSoftwareSystem("Inventario", "Permite realizar el registro de ingredientes y platos ");
            SoftwareSystem configuracion = model.AddSoftwareSystem("Configuración", "Sistema que gestiona usuarios que pueden acceder al sistema.");
            SoftwareSystem stock = model.AddSoftwareSystem("Stock", "Sistema que almacenar datos de stock por cada ingrediente.");
            SoftwareSystem ventas = model.AddSoftwareSystem("Ventas", "Sistema que gestiona las ventas.");
            

            Person administrador = model.AddPerson("Administrador", "Administrador del sistema.");
            Person cocinero = model.AddPerson("Cocinero", "Cocinero encargado de la preparación de los diferentes platos");
            //Person developer = model.AddPerson("Developer", "Developer - Open Data.");

            administrador.Uses(inventario, "Realizar el monitoreo de los platos e ingredientes registrados");
            cocinero.Uses(inventario, "Realizar el registro de ingredientes y platos, según inventario");
            inventario.Uses(configuracion, "Consulta qué usuarios pueden acceder al sistema");
            inventario.Uses(stock, "Consulta stock de cada ingrediente");
            ventas.Uses(inventario, "Realiza actualización de inventario en base a las ventas realizadas");
            
            SystemContextView contextView = viewSet.CreateSystemContextView(inventario, "Contexto", "Diagrama de contexto");
            contextView.PaperSize = PaperSize.A4_Landscape;
            contextView.AddAllSoftwareSystems();
            contextView.AddAllPeople();

            // Tags
            inventario.AddTags("Inventario");
            configuracion.AddTags("Configuracion");
            stock.AddTags("Stock");
            ventas.AddTags("Ventas");
            administrador.AddTags("Administrador");
            cocinero.AddTags("Cocinero");
            
            Styles styles = viewSet.Configuration.Styles;
            styles.Add(new ElementStyle("Administrador") { Background = "#0a60ff", Color = "#ffffff", Shape = Shape.Person });
            styles.Add(new ElementStyle("Cocinero") { Background = "#08427b", Color = "#ffffff", Shape = Shape.Person });
            styles.Add(new ElementStyle("Stock") { Background = "#facc2e", Shape = Shape.RoundedBox });
            styles.Add(new ElementStyle("Ventas") { Background = "#008f39", Color = "#ffffff", Shape = Shape.RoundedBox });
            styles.Add(new ElementStyle("Inventario") { Background = "#90714c", Color = "#ffffff", Shape = Shape.RoundedBox });
            styles.Add(new ElementStyle("Configuracion") { Background = "#2f95c7", Color = "#ffffff", Shape = Shape.RoundedBox });
            */
            // -- 2. Diagrama de Contexto (INVENTARIO)
            
         


            // 3. Diagrama de Contexto (STOCK)
            /*
            SoftwareSystem stock = model.AddSoftwareSystem("Stock", "Sistema que almacenar datos de stock por cada ingrediente.");
            SoftwareSystem inventario = model.AddSoftwareSystem("Inventario", "Permite realizar el registro de ingredientes y platos ");
            SoftwareSystem configuracion = model.AddSoftwareSystem("Configuración", "Sistema que gestiona usuarios que pueden acceder al sistema.");
            SoftwareSystem ventas = model.AddSoftwareSystem("Ventas", "Sistema que gestiona las ventas.");
            

            Person administrador = model.AddPerson("Administrador", "Administrador del sistema.");
            Person cocinero = model.AddPerson("Cocinero", "Cocinero encargado de la preparación de los diferentes platos");
            //Person developer = model.AddPerson("Developer", "Developer - Open Data.");

            administrador.Uses(stock, "Realizar el monitoreo de los platos e ingredientes registrados");
            cocinero.Uses(stock, "Realizar el registro de ingredientes y platos, según inventario");
            //developer.Uses(monitoringSystem, "Realiza consultas a la REST API para mantenerse al tanto de la planificación de los vuelos hasta la llegada del lote de vacunas al Perú");
            configuracion.Uses(stock, "Brinda información sobre usuario que pueden acceder al sistema para modificar stock");
            inventario.Uses(stock, "Consulta stock de ingrediente actualizado");
            stock.Uses(ventas, "Almacena datos de stock actualizada de cada ingrediente");
            
            SystemContextView contextView = viewSet.CreateSystemContextView(stock, "Contexto", "Diagrama de contexto");
            contextView.PaperSize = PaperSize.A4_Landscape;
            contextView.AddAllSoftwareSystems();
            contextView.AddAllPeople();

            // Tags
            inventario.AddTags("Inventario");
            configuracion.AddTags("Configuracion");
            stock.AddTags("Stock");
            ventas.AddTags("Ventas");
            administrador.AddTags("Administrador");
            cocinero.AddTags("Cocinero");
            
            Styles styles = viewSet.Configuration.Styles;
            styles.Add(new ElementStyle("Administrador") { Background = "#0a60ff", Color = "#ffffff", Shape = Shape.Person });
            styles.Add(new ElementStyle("Cocinero") { Background = "#08427b", Color = "#ffffff", Shape = Shape.Person });
            styles.Add(new ElementStyle("Stock") { Background = "#facc2e", Shape = Shape.RoundedBox });
            styles.Add(new ElementStyle("Ventas") { Background = "#008f39", Color = "#ffffff", Shape = Shape.RoundedBox });
            styles.Add(new ElementStyle("Inventario") { Background = "#90714c", Color = "#ffffff", Shape = Shape.RoundedBox });
            styles.Add(new ElementStyle("Configuracion") { Background = "#2f95c7", Color = "#ffffff", Shape = Shape.RoundedBox });
            */
            // -- 3. Diagrama de Contexto (STOCK)



            // 4. Diagrama de Contexto (VENTAS)
            /*
            SoftwareSystem stock = model.AddSoftwareSystem("Stock", "Sistema que almacenar datos de stock por cada ingrediente.");
            SoftwareSystem inventario = model.AddSoftwareSystem("Inventario", "Permite realizar el registro de ingredientes y platos ");
            SoftwareSystem configuracion = model.AddSoftwareSystem("Configuración", "Sistema que gestiona usuarios que pueden acceder al sistema.");
            SoftwareSystem ventas = model.AddSoftwareSystem("Ventas", "Sistema que gestiona las ventas.");
            

            Person administrador = model.AddPerson("Administrador", "Administrador del sistema.");
            Person cajero = model.AddPerson("Cajero", "Cajero se encarga del registro y cobro de la venta");
            
            administrador.Uses(ventas, "Realizar el monitoreo de las ventas");
            cajero.Uses(ventas, "Realizar el registro y cobro de las ventas");
            ventas.Uses(configuracion, "Brinda información sobre usuario que pueden acceder al sistema para registrar venta");
            stock.Uses(ventas, "Consulta datos y actualiza stock de ingredientes");
            ventas.Uses(inventario, "Actualiza stock de ingrediente de venta realizada");
            
            SystemContextView contextView = viewSet.CreateSystemContextView(ventas, "Contexto", "Diagrama de contexto");
            contextView.PaperSize = PaperSize.A4_Landscape;
            contextView.AddAllSoftwareSystems();
            contextView.AddAllPeople();

            // Tags
            inventario.AddTags("Inventario");
            configuracion.AddTags("Configuracion");
            stock.AddTags("Stock");
            ventas.AddTags("Ventas");
            administrador.AddTags("Administrador");
            cajero.AddTags("Cajero");
            
            Styles styles = viewSet.Configuration.Styles;
            styles.Add(new ElementStyle("Administrador") { Background = "#0a60ff", Color = "#ffffff", Shape = Shape.Person });
            styles.Add(new ElementStyle("Cajero") { Background = "#08427b", Color = "#ffffff", Shape = Shape.Person });
            styles.Add(new ElementStyle("Stock") { Background = "#facc2e", Shape = Shape.RoundedBox });
            styles.Add(new ElementStyle("Ventas") { Background = "#008f39", Color = "#ffffff", Shape = Shape.RoundedBox });
            styles.Add(new ElementStyle("Inventario") { Background = "#90714c", Color = "#ffffff", Shape = Shape.RoundedBox });
            styles.Add(new ElementStyle("Configuracion") { Background = "#2f95c7", Color = "#ffffff", Shape = Shape.RoundedBox });
            */

            // -- 3. Diagrama de Contexto (VENTAS)


            /////////////////////////////
            //DIAGRAMA DE CONTENEDORES
            /////////////////////////////

            // 2. Diagrama de Contenedores
            /*
            SoftwareSystem SistemaGestionInventario = model.AddSoftwareSystem("Gestión Inventario", "Sistema de gestión de inventario.");
            
            //SoftwareSystem stock = model.AddSoftwareSystem("Stock", "Sistema que almacenar datos de stock por cada ingrediente.");
            //SoftwareSystem inventario = model.AddSoftwareSystem("Inventario", "Permite realizar el registro de ingredientes y platos ");
            //SoftwareSystem configuracion = model.AddSoftwareSystem("Configuración", "Sistema que gestiona usuarios que pueden acceder al sistema.");
            //SoftwareSystem ventas = model.AddSoftwareSystem("Ventas", "Sistema que gestiona las ventas.");
            
            //context - microservicios y aplicativos web y/o movil
            Container mobileApplication = SistemaGestionInventario.AddContainer("Mobile App", "Permite a los usuarios realizar las operaciones de gestión de inventario", "Android");
            Container webApplication = SistemaGestionInventario.AddContainer("Web App", "Permite a los usuarios realizar las operaciones de gestión de inventario y venta", "React");
            Container apiGateway = SistemaGestionInventario.AddContainer("API Gateway", "API Gateway", "Spring Boot port 8080");
            
            Container configuracionContext = SistemaGestionInventario.AddContainer("Configuración Context", "Bounded Context del Microservicio de Configuración", "Spring Boot port 8081");
            Container stockContext = SistemaGestionInventario.AddContainer("Stock Context", "Bounded Context del Microservicio de Stock", "Spring Boot port 8082");
            Container inventarioContext = SistemaGestionInventario.AddContainer("Inventario Context", "Bounded Context del Microservicio de Inventario de Ingredientes", "Spring Boot port 8083");
            Container ventasContext = SistemaGestionInventario.AddContainer("Ventas Context", "Bounded Context del Microservicio de Inventario de Ventas", "Spring Boot port 8084");
            
            //context - bd
            Container messageBus = SistemaGestionInventario.AddContainer("Bus de Mensajes", "Transporte de eventos del dominio.", "Event Sorcing");
            
            Container ConfiguracionContextDatabase = SistemaGestionInventario.AddContainer("Configuración Context DB", "", "MySQL");
            Container stockContextDatabase = SistemaGestionInventario.AddContainer("Stock Context DB", "", "MySQL");
            Container inventarioContextDatabase = SistemaGestionInventario.AddContainer("Inventario Context DB", "", "MySQL");
            Container inventarioContextReplicaDatabase = SistemaGestionInventario.AddContainer("Inventario Context DB Replica", "", "MySQL");
            Container ventasContextDatabase = SistemaGestionInventario.AddContainer("Ventas Context DB", "", "MySQL");
            
            //definiendo los usuarios
            Person administrador = model.AddPerson("Administrador", "Administrador del sistema.");
            Person cocinero = model.AddPerson("Cocinero", "Cocinero registra ingredientes");
            Person cajero = model.AddPerson("Cajero", "Cajero registra venta y cobra");
            
            administrador.Uses(webApplication, "Realizar el monitoreo de inventario y ventas");
            cocinero.Uses(webApplication, "Realizar el registro de ingredientes");
            cajero.Uses(webApplication, "Realizar el registro de venta y cobro");

            administrador.Uses(mobileApplication, "Realizar el monitoreo de inventario y ventas");
            cocinero.Uses(mobileApplication, "Realizar el registro de ingredientes");
            cajero.Uses(mobileApplication, "Realizar el registro de venta y cobro");
            
             // Tags
            administrador.AddTags("Administrador");
            cocinero.AddTags("Cocinero");
            cajero.AddTags("Cajero");
            
            Styles styles = viewSet.Configuration.Styles;
            styles.Add(new ElementStyle("Administrador") { Background = "#0a60ff", Color = "#ffffff", Shape = Shape.Person });
            styles.Add(new ElementStyle("Cocinero") { Background = "#08427b", Color = "#ffffff", Shape = Shape.Person });
            styles.Add(new ElementStyle("Cajero") { Background = "#FF33E0", Color = "#ffffff", Shape = Shape.Person });
            styles.Add(new ElementStyle("Stock") { Background = "#facc2e", Shape = Shape.RoundedBox });
            styles.Add(new ElementStyle("Ventas") { Background = "#008f39", Color = "#ffffff", Shape = Shape.RoundedBox });
            styles.Add(new ElementStyle("Inventario") { Background = "#90714c", Color = "#ffffff", Shape = Shape.RoundedBox });
            styles.Add(new ElementStyle("Configuracion") { Background = "#2f95c7", Color = "#ffffff", Shape = Shape.RoundedBox });
            //definiendo los usuarios

            administrador.Uses(webApplication, "Consulta");
            administrador.Uses(mobileApplication, "Consulta");

            cocinero.Uses(webApplication, "Consulta");
            cocinero.Uses(mobileApplication, "Consulta");

            cajero.Uses(webApplication, "Consulta");
            cajero.Uses(mobileApplication, "Consulta");
            
            //cajero.Uses(mobileApplication, "Consulta");
            //cajero.Uses(mobileApplication, "Registro");
            //cajero.Uses(mobileApplication, "Edición");
            
         
            mobileApplication.Uses(apiGateway, "API Request", "JSON/HTTPS");
            webApplication.Uses(apiGateway, "API Request", "JSON/HTTPS");
            
            apiGateway.Uses(configuracionContext, "API Request", "JSON/HTTPS");
            apiGateway.Uses(stockContext, "API Request", "JSON/HTTPS");
            apiGateway.Uses(inventarioContext, "API Request", "JSON/HTTPS");
            apiGateway.Uses(ventasContext, "API Request", "JSON/HTTPS");

            configuracionContext.Uses(messageBus, "Publica y consume eventos del dominio");
            configuracionContext.Uses(ConfiguracionContextDatabase,"", "JDBC");

            stockContext.Uses(messageBus, "Publica y consume eventos del dominio");
            stockContext.Uses(stockContextDatabase, "", "JDBC");
            
            inventarioContext.Uses(messageBus, "Publica y consume eventos del dominio");
            inventarioContext.Uses(inventarioContextDatabase, "JDBC");
            inventarioContextDatabase.Uses(inventarioContextReplicaDatabase, "",  "JDBC");

            ventasContext.Uses(messageBus, "Publica y consume eventos del dominio");
            ventasContext.Uses(ventasContextDatabase, "", "JDBC");
            
           
            // Tags
            mobileApplication.AddTags("MobileApp");
            webApplication.AddTags("WebApp");
            apiGateway.AddTags("APIGateway");

            string contextTag = "Context";
            string databaseTag = "Database";

            configuracionContext.AddTags(contextTag);
            ConfiguracionContextDatabase.AddTags(databaseTag);

            stockContext.AddTags(contextTag);
            stockContextDatabase.AddTags(databaseTag);

            inventarioContext.AddTags(contextTag);
            inventarioContextDatabase.AddTags(databaseTag);
            inventarioContextReplicaDatabase.AddTags(databaseTag);

            ventasContext.AddTags(contextTag);
            ventasContextDatabase.AddTags(databaseTag);

            messageBus.AddTags("MessageBus");
            styles.Add(new ElementStyle("MobileApp") { Background = "#9d33d6", Color = "#ffffff", Shape = Shape.MobileDevicePortrait, Icon = "" });
            styles.Add(new ElementStyle("WebApp") { Background = "#9d33d6", Color = "#ffffff", Shape = Shape.WebBrowser, Icon = "" });
            styles.Add(new ElementStyle("APIGateway") { Shape = Shape.RoundedBox, Background = "#0000ff", Color = "#ffffff", Icon = "" });
            styles.Add(new ElementStyle(contextTag) { Shape = Shape.Hexagon, Background = "#facc2e", Icon = "" });
            styles.Add(new ElementStyle(databaseTag) { Shape = Shape.Cylinder, Background = "#ff0000", Color = "#ffffff", Icon = "" });
            styles.Add(new ElementStyle("MessageBus") { Width = 850, Background = "#fd8208", Color = "#ffffff", Shape = Shape.Pipe, Icon = "" });
            
            ContainerView containerView = viewSet.CreateContainerView(SistemaGestionInventario, "Contenedor", "Diagrama de contenedores");
            containerView.PaperSize = PaperSize.A4_Landscape;
            containerView.AddAllElements();
            */




            /////////////////////////////
            //DIAGRAMA DE COMPONENTES
            /////////////////////////////
            SoftwareSystem SistemaGestionInventario = model.AddSoftwareSystem("Gestión Inventario", "Sistema de gestión de inventario.");
            
            Container inventarioContext = SistemaGestionInventario.AddContainer("Inventario Context", "Bounded Context del Microservicio de Inventario de Ingredientes", "Spring Boot port 8083");
            Container mobileApplication = SistemaGestionInventario.AddContainer("Mobile App", "Permite a los usuarios realizar las operaciones de gestión de inventario", "Android");
            Container webApplication = SistemaGestionInventario.AddContainer("Web App", "Permite a los usuarios realizar las operaciones de gestión de inventario y venta", "React");
            Container apiGateway = SistemaGestionInventario.AddContainer("API Gateway", "API Gateway", "Spring Boot port 8080");
            Container inventarioContextDatabase = SistemaGestionInventario.AddContainer("Inventario Context DB", "", "MySQL");
            Container inventarioContextReplicaDatabase = SistemaGestionInventario.AddContainer("Inventario Context DB Replica", "", "MySQL");
            
            //context - bd
            Container messageBus = SistemaGestionInventario.AddContainer("Bus de Mensajes", "Transporte de eventos del dominio.", "Event Sorcing");
            inventarioContext.Uses(messageBus, "Publica y consume eventos del dominio");
            inventarioContext.Uses(inventarioContextDatabase, "JDBC");
            inventarioContextDatabase.Uses(inventarioContextReplicaDatabase, "",  "JDBC");
            
            //Tags
            string contextTag = "Context";
            string databaseTag = "Database";
            inventarioContextDatabase.AddTags(databaseTag);
            inventarioContextReplicaDatabase.AddTags(databaseTag);

            mobileApplication.Uses(apiGateway, "API Request", "JSON/HTTPS");
            webApplication.Uses(apiGateway, "API Request", "JSON/HTTPS");
             
            
            //Tags
            mobileApplication.AddTags("MobileApp");
            webApplication.AddTags("WebApp");
            apiGateway.AddTags("APIGateway");
            messageBus.AddTags("MessageBus");

            Styles styles = viewSet.Configuration.Styles;
            styles.Add(new ElementStyle("MobileApp") { Background = "#9d33d6", Color = "#ffffff", Shape = Shape.MobileDevicePortrait, Icon = "" });
            styles.Add(new ElementStyle("WebApp") { Background = "#9d33d6", Color = "#ffffff", Shape = Shape.WebBrowser, Icon = "" });
            styles.Add(new ElementStyle("APIGateway") { Shape = Shape.RoundedBox, Background = "#0000ff", Color = "#ffffff", Icon = "" });
            styles.Add(new ElementStyle(contextTag) { Shape = Shape.Hexagon, Background = "#facc2e", Icon = "" });
            styles.Add(new ElementStyle(databaseTag) { Shape = Shape.Cylinder, Background = "#ff0000", Color = "#ffffff", Icon = "" });
            styles.Add(new ElementStyle("MessageBus") { Width = 850, Background = "#fd8208", Color = "#ffffff", Shape = Shape.Pipe, Icon = "" });
            

            // 3. Diagrama de Componentes
            Component domainLayer = inventarioContext.AddComponent("Domain Layer", "", "Spring Boot");
            Component ingredienteController = inventarioContext.AddComponent("Ingrediente Controller", "REST API endpoints de ingrediente.", "Spring Boot REST Controller");
            Component platoController = inventarioContext.AddComponent("Plato Controller", "REST API endpoints de plato.", "Spring Boot REST Controller");
            Component ingredienteApplicationService = inventarioContext.AddComponent("Ingrediente Application Service", "Provee métodos para el registro/edición de ingredientes, pertenece a la capa Application de DDD", "Spring Component");
            Component platosApplicationService = inventarioContext.AddComponent("Plato Application Service", "Provee métodos para el registro/edición de platos, pertenece a la capa Application de DDD", "Spring Component");
            Component ingredienteRepository = inventarioContext.AddComponent("Ingrediente Repository", "Información de platos", "Spring Component");
            Component platoRepository = inventarioContext.AddComponent("Plato Repository", "Información de ingredientes", "Spring Component");
                        
            apiGateway.Uses(platoController, "", "JSON/HTTPS");
            apiGateway.Uses(ingredienteController, "", "JSON/HTTPS");
            
            ingredienteController.Uses(ingredienteApplicationService, "Invoca métodos para registro/edición de ingredientes");
            platoController.Uses(platosApplicationService, "Invoca métodos para registro/edición de platos");
            
            ingredienteApplicationService.Uses(domainLayer, "Usa", "");
            ingredienteApplicationService.Uses(ingredienteRepository, "", "JDBC");
            
            platosApplicationService.Uses(domainLayer, "Usa", "");
            platosApplicationService.Uses(platoRepository, "", "JDBC");
            
            ingredienteRepository.Uses(inventarioContextDatabase, "", "JDBC");
            ingredienteRepository.Uses(inventarioContextReplicaDatabase, "", "JDBC");
            platoRepository.Uses(inventarioContextDatabase, "", "JDBC");
            platoRepository.Uses(inventarioContextReplicaDatabase, "", "JDBC");

            // Tags
            string componentTag = "Component";

            domainLayer.AddTags(componentTag);
            ingredienteController.AddTags(componentTag);
            platoController.AddTags(componentTag);
            ingredienteApplicationService.AddTags(componentTag);
            platosApplicationService.AddTags(componentTag);
            ingredienteRepository.AddTags(componentTag);
            platoRepository.AddTags(componentTag);
            
            styles.Add(new ElementStyle(componentTag) { Shape = Shape.Component, Background = "#facc2e", Icon = "" });
            
            ComponentView componentView = viewSet.CreateComponentView(inventarioContext, "Components", "Component Diagram");
            componentView.PaperSize = PaperSize.A4_Landscape;
            componentView.Add(mobileApplication);
            componentView.Add(webApplication);
            componentView.Add(apiGateway);
            componentView.Add(inventarioContextDatabase);
            componentView.Add(inventarioContextReplicaDatabase);
            componentView.AddAllComponents();

            structurizrClient.UnlockWorkspace(workspaceId);
            structurizrClient.PutWorkspace(workspaceId, workspace);
        }
    }
}