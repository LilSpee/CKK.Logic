using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    class Store
    {
        private int _id;
        private string _name;
        private Product _product1;
        private Product _product2;
        private Product _product3;

        public int GetId()
        {
            return _id;
        }
        public void SetId(int id)
        {
            _id = id;
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public void AddStoreItem(Product prod)
        {
            if (_product1 == null)
            {
                prod = _product1;
            }
        }
        public void RemoveStoreItem(int productNum)
        {
            if (_product1 != null)
            {
                _product1 = null;
            }
        }
        public Product GetStoreItem(int productNum)
        {
            return productNum;
        }
        public Product FindStoreItemById(int id)
        {
            id = _id;
            if(id = _product1)
            {

            }
            return _product1;
        }
    }
}
