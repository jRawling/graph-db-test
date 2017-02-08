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
        
        void CreateApp(Guid appStoreId, string name);
        void CreateProduct(Guid brandId, Guid categoryId, Guid appId, string name);

        void DeleteAllBrands();
        void DeleteAllProducts();
        void DeleteAllCategories();
        void DeleteAllApps();
        void DeleteAllAppStores();
        App CreateApp(AppStore appstore, Brand brand, string name);
    }
}