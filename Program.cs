//Preprocessor with defined 
//#define TRIAL_VERSION
using SchoolManagement;
using ModuleA;
using ModuleB;
using ECommerce;
using CSharpLearning;
using Bank;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading;
using System.Threading.Tasks;
Console.WriteLine("Hello, cohort!");

//preprocessor 
#if TRIAL_VERSION
System.Console.WriteLine("TRIAL VERSION");

#else
System.Console.WriteLine("LICENSED VERSION");

#endif



//struct and class
//experiment 1 

int a = 10;
int b = a;
b = 20;
System.Console.WriteLine(a);
System.Console.WriteLine(b);
//experiment 2 
int[] arr1 = { 1, 2, 3 };
int[] arr2 = arr1;
arr2[0] = 100;

System.Console.WriteLine(arr1[0]);
System.Console.WriteLine(arr2[0]);


//experiment 3
//Struct is a value type. Assigning one struct to another copies all of its values, creating an independent copy. Therefore, changing c2 does not affect c1."
CoordinateStruct s1 = new CoordinateStruct();
s1.x = 100;
s1.y = 150;
CoordinateStruct s2 = s1;
s2.x = 200;
System.Console.WriteLine(s1.x);
System.Console.WriteLine(s2.x);


//experiment 4
//Class is a reference type. Assigning one object to another copies only the reference, so both variables refer to the same object. Therefore, changing c2 also changes what c1 sees.
CoordinateClass c1 = new CoordinateClass();
c1.x = 100;
c1.y = 150;
CoordinateClass c2 = c1;
c2.x = 200;
System.Console.WriteLine(c1.x);
System.Console.WriteLine(c2.x);



//enum 
System.Console.WriteLine("Enter the number");
int value = (Convert.ToInt32(Console.ReadLine()));
DaysOfWeek day = (DaysOfWeek)value;
System.Console.WriteLine(day);


//Flags

var permission = FilePermission.Read | FilePermission.Write;
System.Console.WriteLine(permission);


if(((permission & FilePermission.Write)==FilePermission.Write))
{
    System.Console.WriteLine("User has write permission");
}
else
{
    System.Console.WriteLine("User has not write permission");
}

if ((permission & FilePermission.Execute) == FilePermission.Execute)
{
    System.Console.WriteLine("User has execute permission");
}
else
{
    System.Console.WriteLine("User has not execute permission");
}


//implicit conversion
int number1 = 10;
long number2 = number1;
float number3 = number2;
double number4 = number3;
System.Console.WriteLine($"number1={number1}, number2={number2}, number3={number3}, number4={number4}");

//explicit conversion 
double temp = 98.78;
int value1 = (int)temp;
System.Console.WriteLine(value1);

//Convert.TOInt32
string s = "180";
int p = Convert.ToInt32(s);
System.Console.WriteLine(p);

//TryParse 
System.Console.WriteLine("Enter the age :");
string age = Console.ReadLine();
bool result = int.TryParse(age, out int number);
if(result)
{
    System.Console.WriteLine(number);
}
else
{
    System.Console.WriteLine("Enter the valid age ");
}

//is
object value2 = 20;
System.Console.WriteLine(value2 is int);
value2 = "hello";
System.Console.WriteLine(value2 is int);
System.Console.WriteLine(value2 is string);

//as 
string text = value2 as string;
if(text==null)
{
    System.Console.WriteLine("conversion failed");
}
else
{
    System.Console.WriteLine(text);
}

//var
    var j = 10;
    System.Console.WriteLine(j.GetType());
    var name = "Ranjith";
    Console.WriteLine(name.GetType());
    //j = "Hello";
    System.Console.WriteLine(j.GetType());

//dynamic 
    dynamic l= 10;
    Console.WriteLine(l.GetType());

    l = "Hello";
    Console.WriteLine(l.GetType());

    l = true;

    Console.WriteLine(l.GetType());

Dynamic.add(10, 20);
Dynamic.add("Hello", "World");
Dynamic.add(10, "20");

//tuple
int[] numbers = { 10, 25, 3, 80, 15 };

var re = Tuple.GetMinMax(numbers);

Console.WriteLine($"Minimum Value : {re.Min}");
Console.WriteLine($"Maximum Value : {re.Max}");

// Pattern Matching
// ----------------------

Console.WriteLine("----- Type Pattern Matching -----");

PatternMatchingDemo.Display(10);
PatternMatchingDemo.Display("Hello");
PatternMatchingDemo.Display(98.5);
PatternMatchingDemo.Display(null);

Console.WriteLine();

Console.WriteLine("----- Switch Expression -----");

Console.WriteLine($"95 -> {PatternMatchingDemo.GetGrade(95)}");
Console.WriteLine($"82 -> {PatternMatchingDemo.GetGrade(82)}");
Console.WriteLine($"74 -> {PatternMatchingDemo.GetGrade(74)}");
Console.WriteLine($"61 -> {PatternMatchingDemo.GetGrade(61)}");
Console.WriteLine($"45 -> {PatternMatchingDemo.GetGrade(45)}");

Console.WriteLine();

Console.WriteLine("----- Property Pattern -----");

Order order1 = new Order
{
    Status = "Completed",
    Amount = 1200
};

Order order2 = new Order
{
    Status = "Completed",
    Amount = 650
};

Order order3 = new Order
{
    Status = "Pending",
    Amount = 300
};

Order order4 = new Order
{
    Status = "Cancelled",
    Amount = 800
};

Console.WriteLine($"Discount : {PatternMatchingDemo.GetDiscount(order1)}%");
Console.WriteLine($"Discount : {PatternMatchingDemo.GetDiscount(order2)}%");
Console.WriteLine($"Discount : {PatternMatchingDemo.GetDiscount(order3)}%");
Console.WriteLine($"Discount : {PatternMatchingDemo.GetDiscount(order4)}%");

//constructors 
Console.WriteLine("\n------ Task 1.16 ------");

Students student1 = new Students("Ranjith", 24);

Console.WriteLine(student1.Name);
Console.WriteLine(student1.Age);

Students student2 = new Students("Rahul", 120);

Console.WriteLine(student2.Name);
Console.WriteLine(student2.Age);

Students student3 = new Students("Arun", 20, new DateTime(2024, 6, 15));

Console.WriteLine(student3.Name);
Console.WriteLine(student3.AdmissionDate);

Console.WriteLine(student1.CalculateGrade(45));

Console.WriteLine(student1.CalculateGrade(430, 500));

Console.WriteLine(Students.SchoolName);

Console.WriteLine(student1.AdmissionDate);

Employee emp = new Employee();

emp.Id = 101;
emp.Name = "Ranjith";

emp.Display();

AccessModifierDemo access = new AccessModifierDemo();

access.ShowValues();

Console.WriteLine(access.PublicValue);

// Console.WriteLine(access.PrivateValue); // Compile Error
Address address1 =
    new Address("MG Road", "Chennai", "600001");

Address address2 =
    new Address("MG Road", "Chennai", "600001");

Console.WriteLine(address1 == address2);

Address address3 =
    address1 with { City = "Bangalore" };

Console.WriteLine(address3);

Playlist playlist =
    new Playlist();

Console.WriteLine(playlist[0]);

playlist[1] = "Believer";

Console.WriteLine(playlist[1]);

Console.WriteLine(playlist["believer"]);

Console.WriteLine(playlist[20]);

//MP 1
Console.WriteLine("\n------ Product Catalog ------");

List<Product> products = new List<Product>
{
    new Product("Laptop", 75000, Category.Electronics),
    new Product("Mobile", 25000, Category.Electronics),
    new Product("Rice", 1200, Category.Grocery),
    new Product("Shirt", 1500, Category.Clothing),
    new Product("Sugar", 250, Category.Grocery)
};

ProductCatalog.DisplayProducts(products);

Console.WriteLine("\n------ Temperature Converter ------");

// Celsius
TemperatureConverter.Convert(25);

// Fahrenheit
TemperatureConverter.Convert(98.6, true);

// Kelvin
TemperatureConverter.Convert(300, 'K');

//MP 3
Console.WriteLine("\n------ Contact Card ------");

ContactCard[] contacts =
{
    new ContactCard("Ranjith","9876543210","ranjith@gmail.com"),
    new ContactCard("Arun","9123456789","arun@gmail.com"),
    new ContactCard("Rahul","9988776655","rahul@gmail.com"),
    new ContactCard("Kumar","9090909090","kumar@gmail.com"),
    new ContactCard("Priya","9012345678","priya@gmail.com")
};

ContactManager.SearchContact(contacts, "ranjith");

Console.WriteLine();

ContactManager.SearchContact(contacts, "ARUN");

Console.WriteLine();

ContactManager.SearchContact(contacts, "Suresh");
//nullable
Shopping shop = new Shopping();
shop.Offer(null);
shop.Offer(20);

//calling through using directive 
Student.display();

//calling wihtout "using" directive
SchoolManagement.Student.display();


//ambuguity error 
//Helper.Greet();

//resolved ambuguity error 

//encapsulation
BankAccount account = new BankAccount();

account.Deposit(1000m);
account.Withdraw(300m);
account.Withdraw(1000m);
account.Deposit(-200m);

Console.WriteLine($"Current Balance: {account.GetBalance()}");

account.PrintHistory();

//inheritance 
Console.WriteLine("----- Car -----");
Car car = new Car("Toyota", "Corolla", 2024, 4);
car.DisplayInfo();

Console.WriteLine();

Console.WriteLine("----- Bike -----");
Bike bike = new Bike("Royal Enfield", "Classic 350", 2023, false);
bike.DisplayInfo();

Console.WriteLine();

Console.WriteLine("----- Electric Car -----");
ElectricCar tesla = new ElectricCar(
    "Tesla",
    "Model 3",
    2025,
    4,
    75
);
tesla.DisplayInfo();

//sealed override 
//Notification email = new EmailNotification();
//Notification sms = new SmsNotification();
////Notification push = new PushNotification();

//email.Send();
//sms.Send();
////push.Send();

//abstraction 
Circle circle = new Circle(5);
Rectangle rectangle = new Rectangle(10, 4);

circle.DisplayArea();
rectangle.DisplayArea();

// Uncomment to observe the compile error
//Shape shape = new Shape();

//Interfaces 
RectangleInterface rect = new RectangleInterface(10, 5);

Console.WriteLine($"Area: {rect.CalculateArea()}");
Console.WriteLine($"Perimeter: {rect.CalculatePerimeter()}");

rect.Draw();

//overloading and hiding method 
Console.WriteLine("----- Method Overloading -----");

Calculator calculator = new Calculator();

Console.WriteLine(calculator.Add(10, 20));
Console.WriteLine(calculator.Add(10.5, 20.5));
Console.WriteLine(calculator.Add(1, 2, 3));
Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));

Console.WriteLine();

Console.WriteLine("----- Runtime Polymorphism -----");

List<Shape> shapes = new List<Shape>
{
    new Circle(5),
    new Rectangle(10, 4)
};

foreach (Shape z in shapes)
{
    z.DisplayArea();
}

Console.WriteLine();

Console.WriteLine("----- Method Hiding (new) -----");

Logger logger = new Logger();
logger.Log();

FileLogger fileLogger = new FileLogger();
fileLogger.Log();

Logger baseReference = new FileLogger();
baseReference.Log();

//operator overloading 
Money usd1 = new Money(100, "USD");
Money usd2 = new Money(200, "USD");
Money usd3 = new Money(100, "USD");
Money inr = new Money(5000, "INR");

// + operator
Money total = usd1 + usd2;
Console.WriteLine(total);

// == and !=
Console.WriteLine(usd1 == usd3);
Console.WriteLine(usd1 != usd2);

// > and <
Console.WriteLine(usd2 > usd1);
Console.WriteLine(usd1 < usd2);

// Currency mismatch
try
{
    Money invalid = usd1 + inr;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//delegate 
Console.WriteLine("----- Delegate -----");

// Single delegate
MathOperation operation = MathOperations.Add;
operation(10, 5);

operation = MathOperations.Subtract;
operation(10, 5);

operation = MathOperations.Multiply;
operation(10, 5);

operation = MathOperations.Divide;
operation(10, 5);

Console.WriteLine();

Console.WriteLine("----- Multicast Delegate -----");

MathOperation multi = MathOperations.Add;
multi += MathOperations.Multiply;

multi(10, 5);

Console.WriteLine();

Console.WriteLine("----- Func Delegate -----");

Func<double, double, double> funcOperation = MathOperations.Add;
funcOperation(10, 5);

funcOperation = MathOperations.Multiply;
funcOperation(10, 5);

//event
Console.WriteLine("----- Events -----");

AlarmClock clock = new AlarmClock();
Person person = new Person();
CoffeeMachine coffeeMachine = new CoffeeMachine();

clock.OnAlarmRing += person.WakeUp;
clock.OnAlarmRing += coffeeMachine.StartBrewing;

clock.RingAlarm();

//task 2.1
Console.WriteLine("----- Action -----");

Action<string> action = DelegateProcessor.PrintUpperCase;
action("hello world");

Console.WriteLine();

Console.WriteLine("----- Func -----");

Func<int, int, int> multiply = DelegateProcessor.Multiply;
Console.WriteLine(multiply(5, 6));

Console.WriteLine();

Console.WriteLine("----- Predicate -----");

Predicate<int> isEven = DelegateProcessor.IsEven;
Console.WriteLine(isEven(10));
Console.WriteLine(isEven(7));

Console.WriteLine();

Console.WriteLine("----- ProcessList -----");

List<int> numb = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

DelegateProcessor.ProcessList(
    numb,
    isEven,
    x => x * x,
    x => Console.WriteLine(x)
);
//2.11
Console.WriteLine("----- Generic Repository: Student -----");

Repository<StudentGeneric> studentRepo = new Repository<StudentGeneric>();

studentRepo.Add(new StudentGeneric("Ranjith", 23));
studentRepo.Add(new StudentGeneric("Arun", 24));

foreach (var student in studentRepo.GetAll())
{
    Console.WriteLine(student);
}

studentRepo.Update(0, new StudentGeneric("Ranjith Kumar", 24));

Console.WriteLine();
Console.WriteLine("After Update:");

foreach (var student in studentRepo.GetAll())
{
    Console.WriteLine(student);
}

Console.WriteLine();
Console.WriteLine("----- Generic Repository: Product -----");

Repository<ProductGeneric> productRepo = new Repository<ProductGeneric>();

productRepo.Add(new ProductGeneric("Laptop", 65000));
productRepo.Add(new ProductGeneric("Mouse", 800));

foreach (var product in productRepo.GetAll())
{
    Console.WriteLine(product);
}

productRepo.Delete(productRepo.GetAll()[1]);

Console.WriteLine();
Console.WriteLine("After Delete:");

foreach (var product in productRepo.GetAll())
{
    Console.WriteLine(product);
}

//2.12
Console.WriteLine("----- Even Numbers -----");

foreach (int numbe in NumberGenerator.GetEvenNumbers(10))
{
    Console.WriteLine(numbe);
}

Console.WriteLine();

Console.WriteLine("----- Books (Alphabetical) -----");

BookCollection library = new BookCollection();

library.Add(new Book("C# in Depth", "Jon Skeet"));
library.Add(new Book("Clean Code", "Robert C. Martin"));
library.Add(new Book("Algorithms", "Robert Sedgewick"));

foreach (Book book in library)
{
    Console.WriteLine(book);
}
List<EmployeeLinq> employees = new List<EmployeeLinq>
{
    new EmployeeLinq("Ranjith", "IT", 60000, new DateTime(2022, 1, 10)),
    new EmployeeLinq("Arun", "IT", 55000, new DateTime(2021, 5, 15)),
    new EmployeeLinq("Priya", "HR", 45000, new DateTime(2020, 3, 20)),
    new EmployeeLinq("Meena", "Finance", 70000, new DateTime(2019, 7, 1)),
    new EmployeeLinq("Karthik", "Finance", 52000, new DateTime(2023, 2, 11)),
    new EmployeeLinq("Vijay", "Sales", 48000, new DateTime(2021, 9, 18)),
    new EmployeeLinq("Suresh", "Sales", 65000, new DateTime(2018, 11, 30)),
    new EmployeeLinq("Anita", "HR", 53000, new DateTime(2022, 6, 5)),
    new EmployeeLinq("Divya", "IT", 80000, new DateTime(2017, 4, 25)),
    new EmployeeLinq("Rahul", "Marketing", 51000, new DateTime(2023, 1, 12))
};

Console.WriteLine("----- Salary > 50000 (Query Syntax) -----");
var highSalaryQuery =
    from e in employees
    where e.Salary > 50000
    select e;

foreach (var e in highSalaryQuery)
{
    Console.WriteLine($"{e.Name} - {e.Salary}");
}

Console.WriteLine();

Console.WriteLine("----- Salary > 50000 (Method Syntax) -----");
var highSalaryMethod = employees.Where(e => e.Salary > 50000);

foreach (var e in highSalaryMethod)
{
    Console.WriteLine($"{e.Name} - {e.Salary}");
}

Console.WriteLine();

Console.WriteLine("----- Order By Salary Desc (Query Syntax) -----");
var orderQuery =
    from e in employees
    orderby e.Salary descending
    select e;

foreach (var e in orderQuery)
{
    Console.WriteLine($"{e.Name} - {e.Salary}");
}

Console.WriteLine();

Console.WriteLine("----- Order By Salary Desc (Method Syntax) -----");
var orderMethod = employees.OrderByDescending(e => e.Salary);

foreach (var e in orderMethod)
{
    Console.WriteLine($"{e.Name} - {e.Salary}");
}

Console.WriteLine();

Console.WriteLine("----- Group By Department (Query Syntax) -----");
var groupQuery =
    from e in employees
    group e by e.Department into dept
    select new
    {
        Department = dept.Key,
        Count = dept.Count(),
        AverageSalary = dept.Average(x => x.Salary)
    };

foreach (var d in groupQuery)
{
    Console.WriteLine($"{d.Department} - Count: {d.Count}, Avg Salary: {d.AverageSalary}");
}

Console.WriteLine();

Console.WriteLine("----- Group By Department (Method Syntax) -----");
var groupMethod = employees
    .GroupBy(e => e.Department)
    .Select(dept => new
    {
        Department = dept.Key,
        Count = dept.Count(),
        AverageSalary = dept.Average(x => x.Salary)
    });

foreach (var d in groupMethod)
{
    Console.WriteLine($"{d.Department} - Count: {d.Count}, Avg Salary: {d.AverageSalary}");
}

Console.WriteLine();

Console.WriteLine("----- Anonymous Type Projection (Query Syntax) -----");
var projectionQuery =
    from e in employees
    select new
    {
        e.Name,
        Experience = DateTime.Now.Year - e.JoiningDate.Year
    };

foreach (var p1 in projectionQuery)
{
    Console.WriteLine($"{p1.Name} - {p1.Experience} years");
}

Console.WriteLine();

Console.WriteLine("----- Anonymous Type Projection (Method Syntax) -----");
var projectionMethod = employees.Select(e => new
{
    e.Name,
    Experience = DateTime.Now.Year - e.JoiningDate.Year
});

foreach (var p1 in projectionMethod)
{
    Console.WriteLine($"{p1.Name} - {p1.Experience} years");
}

//2.14
Console.WriteLine("----- Extension Methods -----");

// ToTitleCase
string sampleText = "hello world from c sharp";
Console.WriteLine(sampleText.ToTitleCase());

// IsNullOrEmpty
List<int> listNumbers = new List<int>();
Console.WriteLine(listNumbers.IsNullOrEmpty());

listNumbers.Add(10);
Console.WriteLine(listNumbers.IsNullOrEmpty());

// ToWords
Console.WriteLine(0.ToWords());
Console.WriteLine(25.ToWords());
Console.WriteLine(105.ToWords());
Console.WriteLine(999.ToWords());

Console.WriteLine();

Console.WriteLine("----- Anonymous Types -----");

List<EmployeeSimple> employeeList = new List<EmployeeSimple>
{
    new EmployeeSimple("Ranjith", 60000),
    new EmployeeSimple("Arun", 55000),
    new EmployeeSimple("Meena", 70000)
};

var employeeSummary = employeeList.Select(e => new
{
    e.Name,
    AnnualSalary = e.Salary * 12
});

foreach (var empl in employeeSummary)
{
    Console.WriteLine($"{empl.Name} - {empl.AnnualSalary}");
}

//Q4
List<EmployeeBase> payrollEmployees = new List<EmployeeBase>
{
    new FullTimeEmployee("Ranjith", "IT", 60000),
    new FullTimeEmployee("Arun", "IT", 55000),
    new PartTimeEmployee("Meena", "HR", 80, 500),
    new PartTimeEmployee("Priya", "HR", 60, 450),
    new ContractEmployee("Vijay", "Finance", 70000),
    new ContractEmployee("Suresh", "Finance", 65000)
};

Console.WriteLine("----- Employee Salaries -----");

foreach (var emp2 in payrollEmployees)
{
    Console.WriteLine($"{emp2.Name} ({emp2.Department}) - Salary: {emp2.CalculateSalary()}");

    if (emp2 is ITaxable taxable)
    {
        Console.WriteLine($"Tax: {taxable.CalculateTax()}");
    }
}

Console.WriteLine();

decimal totalPayroll = payrollEmployees.Sum(e => e.CalculateSalary());
Console.WriteLine($"Total Payroll: {totalPayroll}");

Console.WriteLine();

Console.WriteLine("----- Payroll by Department -----");

var payrollByDepartment = payrollEmployees
    .GroupBy(e => e.Department)
    .Select(g => new
    {
        Department = g.Key,
        TotalSalary = g.Sum(x => x.CalculateSalary())
    });

foreach (var dept in payrollByDepartment)
{
    Console.WriteLine($"{dept.Department} - {dept.TotalSalary}");
}

//Q5
Console.WriteLine("----- Notification Engine -----");

NotificationService notificationService = new NotificationService();
NotificationLogger notificationLogger = new NotificationLogger();

notificationService.OnNotificationSent += notificationLogger.LogNotification;

notificationService.Send("Welcome to C#", NotificationSenders.SendEmail);
notificationService.Send("OTP: 123456", NotificationSenders.SendSms);
notificationService.Send("Your report is ready", NotificationSenders.SendPush);

List<BookLibrary> libraryBooks = new List<BookLibrary>
{
    new BookLibrary("Clean Code", "Robert C. Martin", "Programming", 2008, true),
    new BookLibrary("The Pragmatic Programmer", "Andrew Hunt", "Programming", 1999, true),
    new BookLibrary("C# in Depth", "Jon Skeet", "Programming", 2019, true),
    new BookLibrary("Head First C#", "Andrew Stellman", "Programming", 2021, false),
    new BookLibrary("Algorithms", "Robert Sedgewick", "Computer Science", 2011, true),
    new BookLibrary("Design Patterns", "Erich Gamma", "Programming", 1994, false),
    new BookLibrary("Refactoring", "Martin Fowler", "Programming", 2018, true),
    new BookLibrary("The Hobbit", "J.R.R. Tolkien", "Fantasy", 1937, true),
    new BookLibrary("The Lord of the Rings", "J.R.R. Tolkien", "Fantasy", 1954, false),
    new BookLibrary("Harry Potter", "J.K. Rowling", "Fantasy", 1997, true),
    new BookLibrary("The Alchemist", "Paulo Coelho", "Fiction", 1988, true),
    new BookLibrary("Atomic Habits", "James Clear", "Self Help", 2018, true),
    new BookLibrary("Deep Work", "Cal Newport", "Self Help", 2016, false),
    new BookLibrary("Sapiens", "Yuval Noah Harari", "History", 2014, true),
    new BookLibrary("Educated", "Tara Westover", "Biography", 2018, true)
};

Console.WriteLine("----- Available Books by J.R.R. Tolkien -----");

var availableByAuthor = libraryBooks
    .Where(b => b.Author == "J.R.R. Tolkien" && b.IsAvailable);

foreach (var book in availableByAuthor)
{
    Console.WriteLine(book.Title);
}

Console.WriteLine();

Console.WriteLine("----- Books Grouped by Genre -----");

var booksByGenre = libraryBooks
    .GroupBy(b => b.Genre)
    .Select(g => new
    {
        Genre = g.Key,
        Count = g.Count()
    });

foreach (var genre in booksByGenre)
{
    Console.WriteLine($"{genre.Genre} - {genre.Count}");
}

Console.WriteLine();

Console.WriteLine("----- Oldest Book -----");

var oldestBook = libraryBooks.OrderBy(b => b.Year).First();

Console.WriteLine($"{oldestBook.Title} ({oldestBook.Year})");

Console.WriteLine();

Console.WriteLine("----- Books After 2010 (Sorted by Title) -----");

var recentBooks = libraryBooks
    .Where(b => b.Year > 2010)
    .OrderBy(b => b.Title);

foreach (var book in recentBooks)
{
    Console.WriteLine($"{book.Title} ({book.Year})");
}
// week 3 day 1 
Banks  b1 = new Banks(1000);
try 
{
 b1.AmountWithdrawl(1400);
 }
 catch (InsufficientFundsException ex)
 {
  Console.WriteLine(ex.Message);
  Console.WriteLine($"The balance need extra to withdraw  is {ex.deficitamount}");
 }
 finally 
 {
 Console.WriteLine ( "Process Completed");
 }

Exceptionhandling E = new Exceptionhandling();
E.OrderOfExecution("3223");
E.OrderOfExecution("8432943284898");

//week 3 day 2 
string path;
using (TempFileManager te = new TempFileManager("hello , here is your content"))
{
    path = te.GetFilePath();
    Console.WriteLine($"File exists inside using: {File.Exists(path)}");
}
Console.WriteLine($"File exists after using: {File.Exists(path)}");
Console.WriteLine("After using block");

await AsyncDemo.RunDemoAsync();
List<Thread> threads = new List<Thread>();
List<Task> tasks = new List<Task>();

// 5 Threads
for (int i = 1; i <= 5; i++)
{
    int threadNumber = i;

    Thread thread = new Thread(() =>
    {
        ThreadSafeLogger.Instance.Log($"Thread {threadNumber}");
    });

    threads.Add(thread);
    thread.Start();
}

// Wait for all threads
foreach (Thread thread in threads)
{
    thread.Join();
}

// 5 Tasks
for (int i = 1; i <= 5; i++)
{
    int taskNumber = i;

    tasks.Add(Task.Run(() =>
    {
        ThreadSafeLogger.Instance.Log($"Task {taskNumber}");
    }));
}

await Task.WhenAll(tasks);

Console.WriteLine("Completed.");

IFactoryVehicle factoryCar =
    SimpleVehicleFactory.CreateVehicle("car");

factoryCar.Drive();

IFactoryVehicle factoryBike =
    SimpleVehicleFactory.CreateVehicle("bike");

factoryBike.Drive();

IFactoryVehicle factoryTruck =
    SimpleVehicleFactory.CreateVehicle("truck");

factoryTruck.Drive();

Console.WriteLine("\nFactory Method:");

VehicleFactoryMethod carFactory =
    new FactoryCarFactory();

carFactory.StartVehicle();

VehicleFactoryMethod bikeFactory =
    new FactoryBikeFactory();

bikeFactory.StartVehicle();

VehicleFactoryMethod truckFactory =
    new FactoryTruckFactory();

truckFactory.StartVehicle();

// ==========================================
// Task 3.6 - Custom Observer
// ==========================================

StockTickerObserver observerTicker =
    new StockTickerObserver();

StockInvestor investor1 =
    new StockInvestor("Investor 1");

StockInvestor investor2 =
    new StockInvestor("Investor 2");

StockInvestor investor3 =
    new StockInvestor("Investor 3");

observerTicker.Subscribe(investor1);
observerTicker.Subscribe(investor2);
observerTicker.Subscribe(investor3);

observerTicker.SetPrice("ABC", 150.50m);


// ==========================================
// Task 3.6 - C# Events
// ==========================================

StockTickerEvent eventTicker =
    new StockTickerEvent();

EventInvestor eventInvestor1 =
    new EventInvestor("Investor 1");

EventInvestor eventInvestor2 =
    new EventInvestor("Investor 2");

EventInvestor eventInvestor3 =
    new EventInvestor("Investor 3");

eventTicker.PriceChanged += eventInvestor1.OnPriceChanged;
eventTicker.PriceChanged += eventInvestor2.OnPriceChanged;
eventTicker.PriceChanged += eventInvestor3.OnPriceChanged;

eventTicker.SetPrice("ABC", 155.75m);

// ==========================================
// Task 3.7 - Strategy Pattern
// ==========================================

ShoppingCart cart =
    new ShoppingCart(new CreditCardPayment());

cart.Checkout(1000m);

// Change strategy at runtime
cart.SetPaymentStrategy(new UpiPayment());

cart.Checkout(1000m);

// Change strategy again
cart.SetPaymentStrategy(new NetBankingPayment());

cart.Checkout(1000m);

// ==========================================
// Task 3.8 - Repository + Unit of Work
// ==========================================

IUnitOfWork unitOfWork = new UnitOfWork();

unitOfWork.Students.Add(
    new RepositoryStudent
    {
        Id = 1,
        Name = "Ranjith"
    });

unitOfWork.Courses.Add(
    new RepositoryCourse
    {
        Id = 1,
        Name = "C#"
    });

Console.WriteLine(
    $"Student: {unitOfWork.Students.GetById(1)?.Name}");

Console.WriteLine(
    $"Course: {unitOfWork.Courses.GetById(1)?.Name}");

unitOfWork.Save();
// =====================================================
// Task 3.9 - Adapter
// =====================================================

string json = """
{
    "Id": 101,
    "Product": "Laptop",
    "Amount": 75000
}
""";

IXmlReportGenerator xmlGenerator =
    new ThirdPartyXmlReportGenerator();

XmlReportAdapter adapter =
    new XmlReportAdapter(xmlGenerator);

adapter.GenerateFromJson(json);


// =====================================================
// Task 3.9 - Facade
// =====================================================

OrderFacade orderFacade =
    new OrderFacade();

orderFacade.PlaceOrder();

await PerformanceComparison.Run();

ReflectionDemo.Run();

// ==========================================
// Task 3.12 - Custom Attribute
// ==========================================

AttributeUser user = new AttributeUser
{
    Name = "RanjithGopalakrishnan",
    Email = "ranjith@example.com"
};

AttributeValidator.Validate(user);

// ==========================================
// Task 3.13 - Interface vs Abstract
// ==========================================

IPrintable invoice = new PrintableInvoice();
invoice.Print();

IPrintable report = new PrintableReport();
report.Print();

OrderBase order = new OnlineOrder(5000m);
order.DisplayAmount();
order.ProcessOrder();


// ==========================================
// MathHelper - Static methods
// ==========================================

Console.WriteLine(
    $"Factorial: {MathHelper.Factorial(5)}");

Console.WriteLine(
    $"Is 17 prime? {MathHelper.IsPrime(17)}");

Console.WriteLine(
    $"GCD of 48 and 18: {MathHelper.GCD(48, 18)}");


// ==========================================
// OrderProcessor - Instance methods
// ==========================================

OrderProcessor processor =
    new OrderProcessor("Order Service");

processor.ProcessOrder("ORD-101");
processor.CancelOrder("ORD-102");

EmployeeComparisonDemo.Run();

ModuleA.Helper.Greet();
ModuleB.Helper.Greet();

SchoolDetails show = new SchoolDetails();
show.Show();
//identifiers 
public class SchoolDetails
{
    public void Show()
    {

        string studentName = "Ranjith";
        string teacherName = "Arun";
        int totalMarks = 95;
        decimal tuitionFees = 25000;
        bool isPresent = true;

        //using class 
        //string class = "10A";
        //using @class
        string @class = "10A";


        System.Console.WriteLine(@class);
    }
}




