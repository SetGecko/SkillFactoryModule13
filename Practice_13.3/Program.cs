// using System.Collections.Generic;

namespace Practice_13._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            phoneBook.Add(new Contact("Жужа", 89000000000, "zhuzha@gmail.com"));
            phoneBook.Add(new Contact("Пуци", 89111111111, "putsi@gmail.com"));

            foreach (var contact in phoneBook) 
            { 
                Console.WriteLine(contact.Name + ": " + contact.PhoneNumber + " email: " + contact.Email);
            }
        }
    }
    public class Contact
    {
        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public string Name { get; }
        public string Email { get; }
        public long PhoneNumber { get; }

    }
}