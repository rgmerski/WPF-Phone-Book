using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SQLite;

namespace WPF_Phone_Book.Data
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public Uri Email { get; set; }
        public string Other { get; set; }
        public int UserID { get; set; }

        static int ContactId = 1;

        public Contact(string Name, string Address, string Number, Uri Email, string Other)
        {
            this.Id = ContactId;
            ContactId++;
            this.Name = Name;
            this.Address = Address;
            this.Number = Number;
            this.Email = Email;
            this.Other = Other;
            this.UserID = 1;
        }
    }

    public class User
    {
        public int Id { get; set; }
        private string Password { get; set; }
    }
}
