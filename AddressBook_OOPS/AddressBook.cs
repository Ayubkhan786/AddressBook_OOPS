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
        //Dictionary<string, List<Contacts>> oldDictionary = new Dictionary<string, List<Contacts>>();
        //Dictionary<string, List<Contacts>> newDictionary = new Dictionary<string, List<Contacts>>();
       
     
            public void Contact()
            {
            Contacts FirstCon = new Contacts()
            //contactList.Add(new Contacts
            {
                Name = "Ayub",
                Address = "India",
                city = "Chennai",
                State = "TN",
                email = "Ayub@gmail.com",
                Zip = 894515,
                phone = 21161458
            };

            Contacts SecondCon = new Contacts()
            //contactList.Add(new Contacts
            {
                Name = "Vijay",
                Address = "India",
                city = "Bihar",
                State = "BH",
                email = "Vijay@gmail.com",
                Zip = 897815,
                phone = 2115461458
            };

            Contacts ThirdCon = new Contacts()
            //contactList.Add(new Contacts
            {
                Name = "Nithish",
                Address = "India",
                city = "Bengaluru",
                State = "KA",
                email = "Nithish@gmail.com",
                Zip = 8989955,
                phone = 2116187458
            };

            Contacts FourthCon = new Contacts()
            //contactList.Add(new Contacts
            {
                Name = "Sri",
                Address = "India",
                city = "Mumbai",
                State = "MH",
                email = "Sri@gmail.com",
                Zip = 8956515,
                phone = 21161568
            };
            contactList.Add(FirstCon);
            contactList.Add(SecondCon);
            contactList.Add(ThirdCon);
            contactList.Add(FourthCon);
            }
            public void Display()
            {
                foreach (var contacts in contactList)
                {
                    Console.WriteLine(contacts.Name
                        + " "
                        + contacts.Address
                        + " "
                        + contacts.city
                        + " "
                        + contacts.State
                        + " "
                        + contacts.email
                        + " "
                        + contacts.Zip
                        + " "
                        + contacts.phone);
                }
            Console.WriteLine("***********************************************************************");
            }
           
        public  void Add()
        {
            Contacts createcontact = new Contacts();
            Console.WriteLine("Enter the Details Of New Contact to Add");
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
                                  
        }

        public void Edit()
        {
            Console.WriteLine("Enter The Name to Edit The Contact");
            string Name = Console.ReadLine();
            foreach (var conts in contactList)
            {
                if (conts.Name == Name)
                {
                    // Taking Input by User Which Field want to Edit 
                    Console.WriteLine("1. Name");
                    Console.WriteLine("2. Address");
                    Console.WriteLine("3. City");
                    Console.WriteLine("4. state");
                    Console.WriteLine("5. Email Address");
                    Console.WriteLine("6. Zip Code ");
                    Console.WriteLine("7. Phone Number ");
                    
                    Console.WriteLine("Enter the Field number you Want to Edit ");
                    int Choice = Convert.ToInt32(Console.ReadLine());

                    // using Switch to Edit The Field Choose By User
                    switch (Choice)
                    {
                        case 1:
                            Console.Write("New First Name : ");
                            string New_Name = Console.ReadLine();
                            conts.Name = New_Name;
                            break;

                        case 2:
                            Console.Write("New Address : ");
                            string New_Address = Console.ReadLine();
                            conts.Address = New_Address;
                            break;
                        case 3:
                            Console.Write("New City : ");
                            string New_City = Console.ReadLine();
                            conts.city = New_City;
                            break;
                        case 4:
                            Console.Write("New State : ");
                            string New_State = Console.ReadLine();
                            conts.State = New_State;
                            break;
                        case 5:
                            Console.Write("New Email Address : ");
                            string New_Email_Address = Console.ReadLine();
                            conts.email = New_Email_Address;
                            break;
                        case 6:
                            Console.Write("New Zip Code : ");
                            int New_Zip_Code = Convert.ToInt32(Console.ReadLine());
                            conts.Zip = New_Zip_Code;
                            break;
                        case 7:
                            Console.Write("New Phone Number : ");
                            int New_Phone_Number = Convert.ToInt32(Console.ReadLine());
                            conts.phone = New_Phone_Number;
                            break;
                       
                        default:
                            Console.WriteLine(" Please Enter Correct Choice");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine(" Your Input Didn't Match the List of Contacts");
                }
               
            }
        }
            public void Delete()
            {
            Console.WriteLine("Enter The Name of Contact to Delete The Contact");
           
            Contacts con = new Contacts();
            string name = Console.ReadLine();
            foreach (var contact in contactList)
            {
                if (contact.Name.Equals(name))
                {
                    con = contact;
                }
            }
            contactList.Remove(con);
        
        }



    }
}



