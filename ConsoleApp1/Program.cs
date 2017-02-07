using System;
using Neo4j.Driver.V1;
using System.Collections.Generic;
using ConsoleApp1.Aggregates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Test();
    }

    private static void Test()
    {
        ICatalogue catalogue = new Catalogue();
        catalogue.DeleteAllBrands();
        catalogue.CreateBrand("Philips");
    }
}