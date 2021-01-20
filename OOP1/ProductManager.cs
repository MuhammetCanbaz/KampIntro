using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

               
        }
    }
}
//void olayı şöyle düşünülebilir. Emir kipi ile çağırıyoruz ve işlemi yapıyor. 
//return'de ise elde edilecek sonuç tekrar kullanılacak ise return komutu kullanılır.