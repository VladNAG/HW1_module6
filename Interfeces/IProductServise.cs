using HW2_module6.Entityes;

namespace HW2_module6.Interfeces
{
    public interface IProductServise
    {
        public Product[] GetAll();
        public Product Get(int id);
        public void Create(Product product);
        public void Update(Product product);
        public void Delete(int id);
    }
}
