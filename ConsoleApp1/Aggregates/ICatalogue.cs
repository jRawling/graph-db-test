using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Aggregates
{
    public interface ICatalogue
    {
        void CreateBrand(string name);
        void DeleteAllBrands();
        void CreateCategory(string name);
        void CreateAppStore(string name);

        void CreateApp(Guid appStoreId, string name);
        void CreateProduct(Guid brandId, Guid categoryId, Guid appId, string name);
    }
}
