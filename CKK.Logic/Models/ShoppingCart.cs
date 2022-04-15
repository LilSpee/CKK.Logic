using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer _customer;
        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;

        public ShoppingCart (Customer cust)
        {
            _customer = cust;
        }
        public int GetCustomerId()
        {
            return _customer.GetId();
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {

            return _product1;

        }
        public ShoppingCartItem AddProduct(Product prod)
        {
            return _product1;
        }
        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            if (quantity >= 0)
            {
                return _product1;
            }
            return null;
        }
        public ShoppingCartItem GetProductById(int Id)
        {
            return _product1;
        }
        public decimal GetTotal()
        {
            return _product1.GetTotal();
        }
        public ShoppingCartItem GetProduct(int productNum)
        {
            if (productNum == null)
            {
                return null;
            }
            return _product1;
        }
    }
}
