using System;

class Program
{
    static void Main(string[] args)
    {
        Address cus1Adress = new Address("Tried and True Tech, Level 27, 222 Beacon Road", "Sydney", "New South Wales", "Australia");
        Customer customer1 = new Customer("Lauren Flay", cus1Adress);

        Order cus1Order = new Order(customer1);

        Product cus1Product1 = new Product("Ministry and Mystery", 51432, 44.9, 1);
        cus1Order.AddProduct(cus1Product1);
        Product cus1Product2 = new Product("Clinkerton", 77511, 79.9, 1);
        cus1Order.AddProduct(cus1Product2);
        Console.WriteLine(cus1Order.Display());
        Console.WriteLine();

        Address cus2Adress = new Address("54 E Pear Street", "Oklahoma City", "Oklahoma", "USA");
        Customer customer2 = new Customer("Amelia Vega", cus2Adress);

        Order cus2Order = new Order(customer2);

        Product cus2Product1 = new Product("Trojan Wireless Mouse", 123145, 63.9, 1);
        cus2Order.AddProduct(cus2Product1);
        Product cus2Product2 = new Product("USB-C Cable 6 ft", 99691, 20.9, 2);
        cus2Order.AddProduct(cus2Product2);
        Product cus2Product3 = new Product("Fitness Tracker", 268832, 99.9, 1);
        cus2Order.AddProduct(cus2Product3);
        Console.WriteLine(cus2Order.Display());
    }
}