using System;
using Neo4j.Driver.V1;
using System.Collections.Generic;
using ConsoleApp1.Aggregates;
using ConsoleApp1.Entities;

class Program
{
    static void Main(string[] args)
    {
        Test();
    }

    private static void Test()
    {
        ICatalogue catalogue = new Catalogue();

        Console.WriteLine("Resetting database");
        catalogue.DeleteAllBrands();
        catalogue.DeleteAllAppStores();
        catalogue.DeleteAllCategories();
        catalogue.DeleteAllProducts();
        catalogue.DeleteAllApps();

        Console.WriteLine("Creating app stores");
        AppStore appleStore = catalogue.CreateAppStore("Apple");
        AppStore googleStore = catalogue.CreateAppStore("Google");

        Console.WriteLine("Creating catagories");
        Category lighting = catalogue.CreateCategory("Lighting");
        Category heating = catalogue.CreateCategory("Heating");
        Category smartAssistant = catalogue.CreateCategory("Smart Assistant");
        Category hub = catalogue.CreateCategory("Hub");

        Console.WriteLine("Creating brands:");
        Console.WriteLine("- Amazon");
        Brand amazon = catalogue.CreateBrand("Amazon");
        App alexa = catalogue.CreateApp(appleStore, amazon, "Alexa");
      //  Product echo = catalogue.CreateProduct(amazon.Id, smartAssistant.Id, )


        Console.WriteLine("- Philips");
        Brand philips = catalogue.CreateBrand("Philips");
        Console.WriteLine("- British Gas");
        Brand britishGas = catalogue.CreateBrand("British Gas");
    }       
}