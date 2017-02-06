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

        App CreateApp(Guid appStoreId, string name);
        Product CreateProduct(Guid brandId, Guid categoryId, Guid appId, string name);
    }
}
