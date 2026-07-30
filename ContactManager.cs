using System;

namespace CSharpLearning
{
    public class ContactManager
    {
        public static void SearchContact(ContactCard[] contacts, string searchName)
        {
            bool found = false;

            foreach (ContactCard contact in contacts)
            {
                if (contact.Name.Equals(searchName,
                    StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Contact Found");
                    Console.WriteLine($"Name : {contact.Name}");
                    Console.WriteLine($"Phone : {contact.PhoneNumber}");
                    Console.WriteLine($"Email : {contact.Email}");

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Contact Not Found");
            }
        }
    }
}