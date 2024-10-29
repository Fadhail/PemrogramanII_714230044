using System;

namespace P4_1_714230044
{
    internal class ProductTest_714230044
    {
        static void Main(String[] args)
        {
            Book_714230044 product1 = new Book_714230044("Book", "C# Object Oriented Solution", "300");
            DVD_714230044 product2 = new DVD_714230044("Ethernal Sunshine of The Spotless Mind", "145");
            
            product1.DisplayInfo();
            product2.DisplayInfo();
        }
    }
}

