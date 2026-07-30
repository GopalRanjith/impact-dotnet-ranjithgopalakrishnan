
using Xunit; using CSharpLearning; using System.Collections.Generic; using System; using System.IO;
public class ProductCatalogTests{
[Fact] public void DisplayProducts_PrintsItems(){
var list=new List<Product>{new Product("Laptop",1000,Category.Electronics)};
var sw=new StringWriter(); Console.SetOut(sw);
ProductCatalog.DisplayProducts(list);
Assert.Contains("Laptop",sw.ToString());
}}
