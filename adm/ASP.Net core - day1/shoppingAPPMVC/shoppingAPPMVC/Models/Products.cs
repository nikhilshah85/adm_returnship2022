namespace shoppingAPPMVC.Models
{
    public class Products
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }

        //this is hard coded data, this will ideally come from database or a file
        static List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new Products(){ pId=102, pName="Coke", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new Products(){ pId=103, pName="Fossil", pCategory="Watch", pIsInStock=false, pPrice=50},
            new Products(){ pId=104, pName="Maggie", pCategory="Fast-Food", pIsInStock=true, pPrice=50},
            new Products(){ pId=105, pName="Sandwitch", pCategory="Fast-Food", pIsInStock=false, pPrice=50},
            new Products(){ pId=106, pName="Coffee", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
        };

        public List<Products> GetAllProduts()
        {
            return pList;
        }


    }
}
