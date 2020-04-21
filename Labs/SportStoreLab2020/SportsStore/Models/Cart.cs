using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>(); // builds a new list that 
        public virtual void AddItem(Product product, int quantity)
        {
            CartLine line = lineCollection
            .Where(p => p.Product.ProductID == product.ProductID) // predictor matches product class to productID
            .FirstOrDefault(); // means its the first item in there
            if (line == null)
            {
                lineCollection.Add(new CartLine // add new cartline object
                {
                    Product = product,
                    Quantity = quantity
                }); // syntax
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        // CRUD Delete (delete) 
        public virtual void RemoveLine(Product product) =>
        lineCollection.RemoveAll(l => l.Product.ProductID == product.ProductID);
       // CRUD - NA 
        
        public virtual decimal ComputeTotalValue() => 
        lineCollection.Sum(e => e.Product.Price * e.Quantity);

        // empties cart 
        public virtual void Clear() => lineCollection.Clear();
        public virtual IEnumerable<CartLine> Lines => lineCollection;
    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}