using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Aggregates
{
    public interface ICatalogue
    {
        Brand CreateBrand(string name);
        Category CreateCategory(string name);
        AppStore CreateAppStore(string name);
        
        Product CreateProduct(Brand brand, App nativeApp, IEnumerable<App> thirdPartyApps, string name);

        void DeleteAllBrands();
        void DeleteAllProducts();
        void DeleteAllCategories();
        void DeleteAllApps();
        void DeleteAllAppStores();
        App CreateApp(IEnumerable<AppStore> appStores, Brand brand, string name);
    }
}