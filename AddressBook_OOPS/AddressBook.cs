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
        List<Contacts> contactList = new List<Contacts>();
        public void Contact()
        {
            //Contacts createcontact=new Contacts();
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
            Console.WriteLine("*******************-----------------------------------------------------------------**************************");
        }
        
        public void Add()
        {
            Contacts createcontact=new Contacts();

            Console.WriteLine("Enter Name");
            createcontact.Name = Console.ReadLine();
            Console.WriteLine("Enter Address");
            createcontact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            createcontact.city = Console.ReadLine();
            Console.WriteLine("Enter State");
            createcontact.State = Console.ReadLine();
            Console.WriteLine("Enter Email");
            createcontact.email = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            createcontact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone");
            createcontact.phone = Convert.ToInt32(Console.ReadLine());
            contactList.Add(createcontact);

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


