namespace ConsoleApp1.Repositories
{
    public interface IBrandRepository
    {
        void CreateBrand(string brandName);
        void DeleteAll();
    }
}