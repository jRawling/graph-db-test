using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Entities;
using ConsoleApp1.Repositories;

namespace ConsoleApp1.Aggregates
{
    public class Catalogue : ICatalogue
    {
        public void CreateApp(Guid appStoreId, string name)
        {
            throw new NotImplementedException();
        }

        public void CreateAppStore(string name)
        {
            throw new NotImplementedException();
        }

        public void CreateBrand(string name)
        {
            IBrandRepository brands = new BrandRepository();
            brands.CreateBrand(name);
        }

        public void CreateCategory(string name)
        {
            throw new NotImplementedException();
        }

        public void CreateProduct(Guid brandId, Guid categoryId, Guid appId, string name)
        {
            throw new NotImplementedException();
        }

        public void DeleteAllBrands()
        {
            IBrandRepository brands = new BrandRepository();
            brands.DeleteAll();
        }
    }
}
