
using Xunit; using CSharpLearning; using System; using System.IO;
public class ContactManagerTests{
[Fact] public void SearchContact_Found(){
var arr=new[]{new ContactCard("John","123","a@b.com")};
var sw=new StringWriter(); Console.SetOut(sw);
ContactManager.SearchContact(arr,"John");
Assert.Contains("Contact Found",sw.ToString());
}
[Fact] public void SearchContact_NotFound(){
var arr=new[]{new ContactCard("John","123","a@b.com")};
var sw=new StringWriter(); Console.SetOut(sw);
ContactManager.SearchContact(arr,"Jane");
Assert.Contains("Contact Not Found",sw.ToString());
}}
