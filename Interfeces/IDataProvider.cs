using HW2_module6.Entityes;

namespace HW2_module6.Interfeces
{
    public interface IDataProvider
    {
        public Product[] GetAllProducts();
        public Product GetProduct(int id);
        public void CreateProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int id);
    }
}