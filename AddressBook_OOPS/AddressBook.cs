using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_OOPS
{
    public class Contacts
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string city { get; set; }
        public string State { get; set; }
        public string email { get; set; }
        public int Zip { get; set; }
        public int phone { get; set; }

    }
    public class AddressBook
    {
        public void Contact()
        {
            List<Contacts> contactList = new List<Contacts>();
            contactList.Add(new Contacts
            {
                Name = "Ayub",
                Address = "India",
                city = "Chennai",
                State = "TN",
                email = "Ayub@gmail.com",
                Zip = 894515,
                phone = 21161458
            });

            contactList.Add(new Contacts
            {
                Name = "Vijay",
                Address = "India",
                city = "Bihar",
                State = "BH",
                email = "Vijay@gmail.com",
                Zip = 897815,
                phone = 2115461458
            });

            contactList.Add(new Contacts
            {
                Name = "Nithish",
                Address = "India",
                city = "Bengaluru",
                State = "KA",
                email = "Nithish@gmail.com",
                Zip = 8989955,
                phone = 2116187458
            });

            contactList.Add(new Contacts
            {
                Name = "Sri",
                Address = "India",
                city = "Mumbai",
                State = "MH",
                email = "Sri@gmail.com",
                Zip = 8956515,
                phone = 21161568
            });


            foreach (var contacts in contactList)
            {
                Console.WriteLine(contacts.Name);
                Console.WriteLine(contacts.Address);
                Console.WriteLine(contacts.city);
                Console.WriteLine(contacts.State);
                Console.WriteLine(contacts.email);
                Console.WriteLine(contacts.Zip);
                Console.WriteLine(contacts.phone);
                Console.WriteLine("*******************************************************************");
            }
        }
    }
}


