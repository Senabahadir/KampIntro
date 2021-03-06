﻿using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int, decimal, float, enum, boolean.. value types
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 10;

            //Console.WriteLine("sayi1 : " + sayi1);  //20

            ////arrays,class,interface... reference types 

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayılar1[0]: "+ sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";

            //Console.WriteLine(person2.FirstName);



            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditKardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "veli";


            //customer = employee;  //customer'a employee atayamayız farklı tipte oldukları için. (int ve stringi birbirine atayamayacağımız gibi.)
            
            Person person3 = customer;   //Yukarıda customer' ı emplooyee 'e atayamadık ama burada atama yapabildik çünkü Customer bir Persondır.
            //Yani miras aldığımız sınıf türünde bir şeye, mirası alan classı atayabiliriz. --base class:Person
            //Base sınıfa onu interite eden sınıfların referansını(adresini) atayabiliriz. 
            customer.FirstName = "Ahmet";
            
            
            //Console.WriteLine(((Customer)person3).CreditKardNumber);

            PersonManager personManeger = new PersonManager();
            personManeger.Add(employee);
        }
    }       //Bu bize yazılımda aynı kodu farklı nesneler için çalıştırmamızı sağlıyor.
    
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastanme { get; set; }
    }

    //base class : Person
    class Customer : Person
    {
        public string CreditKardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
