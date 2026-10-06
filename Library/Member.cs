using Library;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace Library
{
    public class Member
    {
        //Private field
        private int memberId;
        private string name;
        private string address;
        private int phone; // Changed to string to keep the leading zeros

        // Public properties
        public int MemberId
        {
            get { return memberId; }
            private set {memberId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { name = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        // Constructor for new member
        public Member(int memberId, string name, string address, int phone)
        {
            this.MemberId = memberId;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        // Method to display information about a member
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Member name: {Name}");
            Console.WriteLine($"Member address: {Address}");
            Console.WriteLine($"Member phone no: {Phone}");
            Console.WriteLine();
        }
    }
}