using AddressBook_OOPS;


Console.WriteLine("Welcome to Address Book Program");


AddressBook addressBook = new AddressBook();
addressBook.Contact();
addressBook.Display();
addressBook.Add();
addressBook.Display();
addressBook.Edit();
addressBook.Display();
addressBook.Delete();
addressBook.Display();


//Collection collection = new Collection();
//collection.MultiCon();


MultiAddressBook multi = new MultiAddressBook();
multi.AddBook("AddressBookOne");
multi.AddContact("AddressBookOne");













