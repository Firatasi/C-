namespace Project4.DataAccess
{
    public class ProductDal : IProductDal
    {
        List<Product> products;
        public ProductDal()
        {
            products = new List<Product>()
            {
                new Product{ProductId = 1, ProductName = "asd", QuantityPerUnit = "32gb", UnitStock=2}
                new Product{ProductId = 2, ProductName = "asd", QuantityPerUnit = "32gb", UnitStock=2}
                new Product{ProductId = 3, ProductName = "asd", QuantityPerUnit = "32gb", UnitStock=2}
                new Product{ProductId = 4, ProductName = "asd", QuantityPerUnit = "32gb", UnitStock=2}

            };

        }

        public void Add(IProductDal product)
        {
            Console.WriteLine(product);
        }

        public List<Product> GetAll()
        {

        }

        List<IProductDal> IProductDal.GetAll()
        {
            Console.WriteLine(); return products;
        }
    }
}
