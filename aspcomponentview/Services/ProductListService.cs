namespace XTLAB{
    public class ProductListService{
       public List<Product> products {set; get;}= new List<Product>()
        {
            new Product(){Name = "SP 1", Description = "Mo ta cho SP 1", Price = 44},
            new Product(){Name = "SP 2", Description = "Mo ta cho SP 2", Price = 988},
            new Product(){Name = "SP 3", Description = "Mo ta cho SP 3", Price = 50},
            new Product(){Name = "SP 4", Description = "Mo ta cho SP 4", Price = 671},
        };
    }

}