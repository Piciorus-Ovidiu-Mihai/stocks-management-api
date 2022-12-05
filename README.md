# 📀 Stocks Management Project
This is a web application through you can manage your stocks in different domains, for example if you have a shop with some products, you can keep track the whole workflow from supplier to clients.
The main purpose of this application is to dive deeper inside the Clean Architecture and Pages Architecture. 

# 💻 Clean Architecture
### 🗝️ Benefits
* Independent of Database and Frameworks.
* Independent of the presentation layer. Anytime we can change the UI without changing the rest of the system and business logic.
* Highly testable, especially the core domain model and its business rules are extremely testable.

### 📌 Domain 
Enterprise logic is contained in the domain layer. This will contain all entities, enums, exceptions, interfaces, types and logic specific to this layer.
All dependencies flow inwards in a Clean Architecture, and Domain has no reliance on any other layer. The Domain or Core layer is also responsible for the Infrastructure and Presentation layers.

### 📌 Application
All application logic is included in this layer. It is dependent on the domain layer. This contains the interfaces of the services, that are used in the API layer, the services implementation, all the helpers classes, custom exceptions, guard clauses, domain events, handlers, basically all the business of the application. All above, represent the core of the application. The other two layers are: API layer and infrastructure layer.

### 📌 Infrastructure
Classes for communicating with external resources like file systems, web services, and SMTP, for example, can be found in this layer. 
These classes should be built on top of the interfaces declared in the application layer. This layer is also divided into two components: data and persistence. A generic repository is used in the data layer, and it follows the repository design pattern's rules. Because we don't want to implement simple CRUD methods for each entity, we've chosen to adopt the repository design pattern. Also, we have a repository for each entity that inherits from the base repository.
The second part of this layer is persistence, where we built the ApplicationDBContext and the migrations. There we define the database structure and there we can see all the migrations history that represents all the modifications made. 

### 📌 Presentation Layer
Here is defined communication with the outside. This contains controllers, middlewares, Startup file, that represents all the configurations for the application to run. For example if we want to make some requests for getting or posting data from the client side, we have to make that through this layer.

### 📌 Architecture


# 💽 Prerequisites
* ⚙️ Visual Studio 
* ⚙️ Basic knowledge about layered Architecture
* ⚙️ SQL server 
* ⚙️ Azure Data Studio or SQL Server Management Studio(SSMS)

# 🚀 Getting started
* 🏹 Clone this repository
* 🏹 Build & Run the project
    
# What I Used ?
* ⛏️ .NET Core
* ⛏️ SQL
* ⛏️ Entity Frameworks
* ⛏️ Linq

