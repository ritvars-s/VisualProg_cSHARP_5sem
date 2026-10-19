using DatuAttelosana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatuAttelosana.Clases
{
    internal class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string BankAddress { get; set; }

        public Client() { }
        public Client(string name, string phoneNumber, string bankAdddress) {

            if (bankAdddress.Length == 11 && IsDigitsOnly(bankAdddress))
            {
                Name = name;
                PhoneNumber = phoneNumber;
                BankAddress = bankAdddress;
               
            }
            else {
                
                Name = name;
                PhoneNumber = phoneNumber;
                BankAddress = "00000000000"; 
            }

                
          
            
        
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
