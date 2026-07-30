//Preprocessor with defined 
//#define TRIAL_VERSION
using SchoolManagement;
using ModuleA;
using ModuleB;
using ECommerce;
using CSharpLearning;
// See https://aka.ms/new-console-template for more information
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
