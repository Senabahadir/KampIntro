using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Sena";
            customer1.Surname = "Bahadıroğlu";
            customer1.TcNo = "45678912356";
            customer1.PhoneNumber = "65356566";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Engin";
            customer2.Surname = "Demiroğ";
            customer2.TcNo = "65464654654";
            customer2.PhoneNumber = "5454456";


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.List(customer2);
            customerManager.Delete(customer2);
        }
    }
}
