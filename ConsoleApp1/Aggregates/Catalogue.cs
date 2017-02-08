using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Entities;
using ConsoleApp1.Repositories;

namespace ConsoleApp1.Aggregates
{
    public class Catalogue : ICatalogue
    { 
        public App CreateApp(AppStore appstore, Brand brand, string name)
        {
            return new AppRepository().CreateApp(appstore, brand, name);
        }

        public void CreateApp(Guid appStoreId, string name)
        {
            throw new NotImplementedException();
        }

        public AppStore CreateAppStore(string name)
        {
            return new AppStoreRepository().CreateAppStore(name);
        }

        public Brand CreateBrand(string name)
        {
            return new BrandRepository().CreateBrand(name);
        }

        public Category CreateCategory(string name)
        {
            return new CategoryRepository().CreateCategory(name);
        }

        public void CreateProduct(Guid brandId, Guid categoryId, Guid appId, string name)
        {
            throw new NotImplementedException();
        }

        public void DeleteAllApps()
        {
            new AppRepository().DeleteAll();
        }

        public void DeleteAllAppStores()
        {
            new AppStoreRepository().DeleteAll();
        }

        public void DeleteAllBrands()
        {
            new BrandRepository().DeleteAll();
        }

        public void DeleteAllCategories()
        {
            new CategoryRepository().DeleteAll();
        }

        public void DeleteAllProducts()
        {
            new ProductRepository().DeleteAll();
        }
    }
}
