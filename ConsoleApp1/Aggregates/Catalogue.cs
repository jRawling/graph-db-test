using ConsoleApp1.Entities;
using ConsoleApp1.Repositories;
using System;

namespace ConsoleApp1.Aggregates
{
    public class Catalogue : ICatalogue
    {
        private AppRepository AppRepository { get; } = new AppRepository();
        private AppStoreRepository AppStoreRepository { get; } = new AppStoreRepository();
        private BrandRepository BrandRepository { get; } = new BrandRepository();
        private CategoryRepository CategoryRepository { get; } = new CategoryRepository();
        private ProductRepository ProductRepository { get; } = new ProductRepository();

        public App CreateApp(AppStore appstore, Brand brand, string name)
        {
            return AppRepository.CreateApp(appstore, brand, name);
        }

        public void CreateApp(Guid appStoreId, string name)
        {
            throw new NotImplementedException();
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

        public void CreateProduct(Guid brandId, Guid categoryId, Guid appId, string name)
        {
            throw new NotImplementedException();
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
