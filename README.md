# 💻 Stocks Management Project
This is a web application through you can manage your stocks in different domains, for example if you have a shop with some products, you can keep track the whole workflow from supplier to clients.
The main purpose of this application is to dive deeper inside the Clean Architecture and Pages Architecture. 

## 🛠️ Architecture
Clean Architecture is a software design approach that emphasizes maintainability, testability, and separation of concerns. It provides a structured way to organize code within an application, ensuring that business logic remains independent of technical details. This architectural style was introduced by Robert C. Martin, and it's especially popular in modern software development.

<p align="center">
 <img src="https://github.com/Piciorus-Ovidiu-Mihai/Photos/blob/master/clean-architecture-onion-ring.png">
</p>

* Domain 
Enterprise logic is contained in the domain layer. This will contain all entities, enums, exceptions, interfaces, types and logic specific to this layer.
All dependencies flow inwards in a Clean Architecture, and Domain has no reliance on any other layer. The Domain or Core layer is also responsible for the Infrastructure and Presentation layers.

* Application
All application logic is included in this layer. It is dependent on the domain layer. This contains the interfaces of the services, that are used in the API layer, the services implementation, all the helpers classes, custom exceptions, guard clauses, domain events, handlers, basically all the business of the application. All above, represent the core of the application. The other two layers are: API layer and infrastructure layer.

* Infrastructure
Classes for communicating with external resources like file systems, web services, and SMTP, for example, can be found in this layer. 
These classes should be built on top of the interfaces declared in the application layer. This layer is also divided into two components: data and persistence. A generic repository is used in the data layer, and it follows the repository design pattern's rules. Because we don't want to implement simple CRUD methods for each entity, we've chosen to adopt the repository design pattern. Also, we have a repository for each entity that inherits from the base repository.
The second part of this layer is persistence, where we built the ApplicationDBContext and the migrations. There we define the database structure and there we can see all the migrations history that represents all the modifications made.

<p align="center">
 <img src="https://github.com/Piciorus-Ovidiu-Mihai/Photos/blob/master/clean-architecture-project.png">
</p>

* Presentation Layer
Here is defined communication with the outside. This contains controllers, middlewares, Startup file, that represents all the configurations for the application to run. For example if we want to make some requests for getting or posting data from the client side, we have to make that through this layer.

## 🛡️ Key Features
* Layered Structure: Clean Architecture divides an application into distinct layers, each with a specific responsibility. These layers often include the outermost "Frameworks and Drivers" layer, the "Interface Adapters" layer, the "Application Business Rules" layer, and the innermost "Entities" layer. These layers are organized in a concentric fashion, with the inner layers having no direct dependencies on the outer ones.
* Dependency Rule: The core principle of Clean Architecture is the Dependency Rule, which states that dependencies should always point inwards. This means that inner layers contain high-level business rules and are not affected by changes in outer layers like frameworks or databases. This decoupling allows for easier maintenance and flexibility.
* Testability: Clean Architecture encourages extensive testing by isolating business rules from external concerns. This isolation allows for unit testing of critical application logic without the need for external dependencies. As a result, it improves the reliability and maintainability of the application.
* Adaptability: Clean Architecture supports adaptability to changing technologies. Outer layers can be swapped or upgraded without affecting the core business logic. This adaptability is especially valuable as technology evolves over time.
* Business Logic Centralization: The "Application Business Rules" layer is at the core of Clean Architecture, where all business rules are implemented. This centralization ensures that the core application logic remains consistent, making it easier to understand and maintain.
* Decoupled Frameworks: Frameworks and external libraries are positioned in the outermost layer. This allows developers to swap out or upgrade frameworks with minimal impact on the core application.
* SOLID Principles: Clean Architecture promotes the SOLID principles of software design, particularly the Single Responsibility Principle (SRP) and the Dependency Inversion Principle (DIP), to create modular and maintainable code.
* Technology-Agnostic: Clean Architecture is technology-agnostic, making it applicable to a wide range of programming languages and platforms.

## 💽 Prerequisites
* ⚙️ Visual Studio 
* ⚙️ Basic knowledge about layered Architecture
* ⚙️ SQL server 
* ⚙️ Azure Data Studio or SQL Server Management Studio(SSMS)

## 🚀 Getting Started
* ⭐ Clone this repository
* ⭐ Build & Run the project

## 🖥️ Technologies
* 💽 .NET Core
* 💽 SQL
* 💽 Entity Frameworks
* 💽 Linq
