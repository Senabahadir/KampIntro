using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id + " Id'sine sahip müşreti eklendi.");
        }

        public void List(Customer customer)
        {
            Console.WriteLine(customer.Id + " Id'li müsterinin" +customer.Name + " ismi listeye eklendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + " Id'li müsterinin" + customer.TcNo + " nuamralı Tc Kimlik Numarası silindi.");
        }
    }
}
