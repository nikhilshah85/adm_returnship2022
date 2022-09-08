namespace productsMS.Models
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
            new Products(){ pId=101, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new Products(){ pId=102, pName="Coke", pCategory="Cold-Drink", pIsInStock=false, pPrice=50},
            new Products(){ pId=103, pName="Maggie", pCategory="Junk-Food", pIsInStock=true, pPrice=75},
            new Products(){ pId=104, pName="IPhone", pCategory="Electronics", pIsInStock=false, pPrice=1850},
            new Products(){ pId=105, pName="Pasta", pCategory="Junk-Food", pIsInStock=true, pPrice=75},
        };

        public List<Products> GetAllProducts()
        {
            return pList;
        }

        public Products GetProductById(int id)
        {
            var p = pList.Find(pr => pr.pId == id);
            if (p!=null)
            {
                return p;
            }
            throw new Exception("Product Not found");
        }

        public string AddnewProduct(Products newProduct)
        {
            pList.Add(newProduct);
            return "Product Added Successfully";
        }
    }
}






