namespace autoFacDemo_DI.Models
{
    public class Products
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }

        static List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Pepis", pCategory="Cold-Drinks", pIsInStock=true, pPrice=50},
            new Products(){ pId=102, pName="Pepis", pCategory="Cold-Drinks", pIsInStock=true, pPrice=50},
            new Products(){ pId=103, pName="Pepis", pCategory="Cold-Drinks", pIsInStock=true, pPrice=50},
            new Products(){ pId=104, pName="Pepis", pCategory="Cold-Drinks", pIsInStock=true, pPrice=50},
            new Products(){ pId=105, pName="Pepis", pCategory="Cold-Drinks", pIsInStock=true, pPrice=50}
        };

        public List<Products> GetAllProducts()
        {
            return pList;
        }
    }
}
