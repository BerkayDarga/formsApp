namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category{CategoryId=1, Name="Telefon"});
            _categories.Add(new Category{CategoryId=2, Name="Bilgisayar"});

            _products.Add(new Product { ProductId = 1, Name = "iphone 14", Price = 40000, IsActive = true, Image = "iphone14.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 2, Name = "iphone 15", Price = 50000, IsActive = true, Image = "iphone15.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 3, Name = "iphone 16", Price = 60000, IsActive = true, Image = "iphone16.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 4, Name = "iphone 17", Price = 70000, IsActive = true, Image = "iphone17.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 5, Name = "macbook air", Price = 80000, IsActive = true, Image = "macbookair.jpg", CategoryId = 2 });
            _products.Add(new Product { ProductId = 6, Name = "macbook pro", Price = 90000, IsActive = true, Image = "macbookpro.jpg", CategoryId = 2 });
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
    }
}