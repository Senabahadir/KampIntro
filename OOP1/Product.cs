using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet - hazır kodlar demek (prop -tab tab)
    class Product  //Entity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }   // birim fiyatı

        public int UnitsInStock { get; set; }  //Ürün Stok Adedi

        //CRUID Operasyonları -creat -read -update -delete 

    }
}
