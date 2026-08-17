using System;
using System.Text.Json;
using System.Xml.Linq;

// =====================================================
// 1. Adapter Pattern - JSON -> XML
// =====================================================

// Our application expects an XML report generator.
public interface IXmlReportGenerator
{
    void GenerateXml(string xml);
}

// Third-party generator that only accepts XML.
public class ThirdPartyXmlReportGenerator : IXmlReportGenerator
{
    public void GenerateXml(string xml)
    {
        Console.WriteLine("Third-party XML generator received:");
        Console.WriteLine(xml);
    }
}

// JSON model
public class OrderJson
{
    public int Id { get; set; }
    public string Product { get; set; } = "";
    public decimal Amount { get; set; }
}

// Adapter converts JSON data into XML.
public class XmlReportAdapter
{
    private readonly IXmlReportGenerator generator;

    public XmlReportAdapter(IXmlReportGenerator generator)
    {
        this.generator = generator;
    }

    public void GenerateFromJson(string json)
    {
        OrderJson? order =
            JsonSerializer.Deserialize<OrderJson>(json);

        if (order == null)
        {
            throw new ArgumentException("Invalid JSON");
        }

        XElement xml =
            new XElement("Order",
                new XElement("Id", order.Id),
                new XElement("Product", order.Product),
                new XElement("Amount", order.Amount)
            );

        generator.GenerateXml(xml.ToString());
    }
}


// =====================================================
// 2. Facade Pattern
// =====================================================

public class InventoryService
{
    public void CheckInventory()
    {
        Console.WriteLine("Inventory checked.");
    }
}

public class PaymentService
{
    public void ProcessPayment()
    {
        Console.WriteLine("Payment processed.");
    }
}

public class ShippingService
{
    public void ArrangeShipping()
    {
        Console.WriteLine("Shipping arranged.");
    }
}

// Facade hides the complexity of the three services.
public class OrderFacade
{
    private readonly InventoryService inventory;
    private readonly PaymentService payment;
    private readonly ShippingService shipping;

    public OrderFacade()
    {
        inventory = new InventoryService();
        payment = new PaymentService();
        shipping = new ShippingService();
    }

    public void PlaceOrder()
    {
        inventory.CheckInventory();
        payment.ProcessPayment();
        shipping.ArrangeShipping();

        Console.WriteLine("Order placed successfully.");
    }
}


// =====================================================
// 3. Design Pattern Notes
// =====================================================

/*
Builder:
Builds a complex object step-by-step.
Useful when an object has many optional properties.
It separates object construction from the final object.
Use case: Building a complex HTTP request or configuration object.


Prototype:
Creates a new object by copying an existing object.
Useful when creating an object from scratch is expensive.
The existing object acts as a template.
Use case: Cloning a preconfigured game character.


Decorator:
Adds behavior to an existing object without modifying its class.
Multiple decorators can be combined.
It follows composition instead of changing the original class.
Use case: Adding logging or caching to a service.


Command:
Encapsulates an operation as an object.
The caller does not need to know how the operation is performed.
Commands can also be queued, logged, or undone.
Use case: Undo/redo operations in an application.


Template Method:
Defines the overall algorithm in a base class.
Subclasses implement or customize specific steps.
The overall execution order remains controlled by the base class.
Use case: Different report generation processes sharing the same workflow.


Mediator:
Centralizes communication between multiple objects.
Objects communicate through the mediator instead of directly with each other.
This reduces direct dependencies between components.
Use case: Chat room where users communicate through a chat mediator.


Chain of Responsibility:
Passes a request through a sequence of handlers.
Each handler decides whether to process the request or pass it forward.
This avoids tightly coupling the sender to a specific handler.
Use case: Approval workflow with employee → manager → director.


State:
Allows an object to change its behavior when its internal state changes.
Different state objects represent different behaviors.
The main object delegates behavior to its current state.
Use case: Order behavior changing between Pending, Shipped, and Delivered.
*/