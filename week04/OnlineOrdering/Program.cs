using System;

class Program
{
    static void Main(string[] args)
    {
        Customer oli = new Customer("Oliver");
        oli.SetAddress("123N 456E", "London", "England","UK");
        Customer joe = new Customer("Joe Mama");
        joe.SetAddress("67W 321S", "Columbus", "Ohio","USA");

        Order oliOrder = new Order(oli);
        Order joeOrder = new Order(joe);

        oliOrder.AddProduct("banana","1B67", 2.50 , 2);
        oliOrder.AddProduct("apple","A7F9", 1.67 , 1);
        oliOrder.AddProduct("chicken nuggets","C85B", 1.00 , 10);

        joeOrder.AddProduct("soap","8F6D", 7.50, 2);
        joeOrder.AddProduct("spoon","37CA", 3.00, 1);
        joeOrder.AddProduct("T.V","DC23", 100.25 , 1);

        Console.WriteLine();
        Console.WriteLine(oliOrder.PackingLabel());
        Console.WriteLine(oliOrder.ShippingLabel());
        Console.WriteLine($"{oliOrder.TotalCost()}$");
        Console.WriteLine();
        Console.WriteLine(joeOrder.PackingLabel());
        Console.WriteLine(joeOrder.ShippingLabel());
        Console.WriteLine($"{joeOrder.TotalCost()}$");
        Console.WriteLine();
    }
}