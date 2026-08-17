# Design Patterns — Week 3

This document maps the design patterns learned in Week 3 to where they will be used in future weeks.

| Pattern | Week 3 Implementation | Future Usage |
|---|---|---|
| Repository | `IRepository<T>`, `StudentRepository`, `CourseRepository` | **Week 7 — Data Layer:** Repository pattern will provide a clean abstraction over database operations such as Get, Add, Update and Delete. |
| Unit of Work | `IUnitOfWork`, `UnitOfWork` | **Week 7 — Data Layer:** Coordinates multiple repositories and provides a common `Save()` operation for database changes. |
| Strategy | `IPaymentStrategy`, `CreditCardPayment`, `UpiPayment`, `NetBankingPayment` | **Future service/business logic:** Used when behavior needs to change at runtime, such as selecting different payment, calculation, or processing strategies. |
| Observer | `IStockObserver`, `StockTickerObserver` and C# events | **Future event-driven features:** Used when multiple components need to react to an event or state change. |
| Factory | `VehicleFactory`, `CarFactory`, `BikeFactory`, `TruckFactory` | **Future service creation:** Used to create different implementations without requiring the caller to directly instantiate concrete classes. |
| Adapter | `XmlReportAdapter` | **Future integrations:** Used when our application's interface differs from a third-party API or service interface. |
| Facade | `OrderFacade` | **Future service/business layer:** Provides a simple entry point to multiple underlying services or subsystems. |
| Builder | Builder pattern notes from Task 3.9 | **Future object construction:** Useful when creating complex objects with many optional properties or configuration values. |
| Prototype | Prototype pattern notes from Task 3.9 | **Future object creation:** Useful when objects need to be created by copying an existing configured object. |
| Decorator | Decorator pattern notes from Task 3.9 | **Future cross-cutting functionality:** Useful for adding logging, caching, authorization, or other behavior without modifying the original class. |
| Command | Command pattern notes from Task 3.9 | **Future application operations:** Useful for encapsulating actions that may need to be queued, logged, or undone. |
| Template Method | Template Method notes from Task 3.9 | **Future processing workflows:** Useful when multiple processes share the same overall workflow but have different individual steps. |
| Mediator | Mediator pattern notes from Task 3.9 | **Future component communication:** Useful for reducing direct dependencies between multiple components that need to communicate. |
| Chain of Responsibility | Chain of Responsibility notes from Task 3.9 | **Future approval/validation workflows:** Useful when a request can pass through multiple handlers until one handles it. |
| State | State pattern notes from Task 3.9 | **Future state-based business logic:** Useful when an object's behavior changes based on its current state, such as Pending, Approved, Shipped, or Completed. |

## Key Future Connections

### Repository → Week 7 Data Layer
The repository abstraction separates business logic from database access. Different database implementations can be plugged behind the same repository interface.

### Strategy → Runtime Choices
Strategy allows the application to change an algorithm or behavior at runtime without modifying the class that uses it.

### Observer → Events
Observer allows multiple subscribers to react when something happens. C# events provide a built-in way to implement this pattern.

### Factory → Service Creation
Factory centralizes object creation so that callers depend on abstractions rather than concrete implementations.

### Unit of Work → Week 7 Data Layer
Unit of Work coordinates multiple repositories and provides a single place to commit related changes.

### Adapter → External Integrations
Adapter allows our application to work with a third-party component even when its interface does not match ours.

### Facade → Service Layer
Facade hides the complexity of multiple underlying services and exposes a simple operation to the caller.

## Week 3 → Future Architecture

Week 3 patterns are intended to prepare for later application development:

- **Factory** → object/service creation
- **Strategy** → interchangeable business behavior
- **Observer** → events and notifications
- **Repository** → database/data access
- **Unit of Work** → coordinated data operations
- **Adapter** → third-party integrations
- **Facade** → simplified service orchestration
- **Other patterns** → reusable solutions for object creation, behavior, communication, and workflow management