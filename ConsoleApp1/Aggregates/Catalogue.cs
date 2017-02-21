using ConsoleApp1.Entities;
using ConsoleApp1.Repositories;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Aggregates
{
    public class Catalogue : ICatalogue
    {
        private AppRepository AppRepository { get; } = new AppRepository();
        private AppStoreRepository AppStoreRepository { get; } = new AppStoreRepository();
        private BrandRepository BrandRepository { get; } = new BrandRepository();
        private CategoryRepository CategoryRepository { get; } = new CategoryRepository();
        private ProductRepository ProductRepository { get; } = new ProductRepository();

        public App CreateApp(IEnumerable<AppStore> appStores, Brand brand, string name)
        {
            return AppRepository.CreateApp(appStores, brand, name);
        }

        public AppStore CreateAppStore(string name)
        {
            return AppStoreRepository.CreateAppStore(name);
        }

        public Brand CreateBrand(string name)
        {
            return BrandRepository.CreateBrand(name);
        }

        public Category CreateCategory(string name)
        {
            return CategoryRepository.CreateCategory(name);
        }

        public Product CreateProduct(Brand brand, App nativeApp, IEnumerable<App> thirdPartyApps, string name)
        {
            return ProductRepository.CreateProduct(brand, nativeApp, thirdPartyApps, name);
        }

        public void DeleteAllApps()
        {
            AppRepository.DeleteAll();
        }

        public void DeleteAllAppStores()
        {
            AppStoreRepository.DeleteAll();
        }

        public void DeleteAllBrands()
        {
            BrandRepository.DeleteAll();
        }

        public void DeleteAllCategories()
        {
            CategoryRepository.DeleteAll();
        }

        public void DeleteAllProducts()
        {
            ProductRepository.DeleteAll();
        }
    }
}
