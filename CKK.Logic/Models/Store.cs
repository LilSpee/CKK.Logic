﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
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
            prod = _product1;
            if (prod != null)
            {
                prod = _product2;
            }
            if (prod != null)
            {
                prod = _product3;
            }
        }
        public void RemoveStoreItem(int productNum)
        {
            if(productNum == _product1.GetId())
            {
                _product1 = null;
            }
        }
        public Product GetStoreItem(int productNum)
        {
            return _product1;

        }
        public Product FindStoreItemById(int id)
        {
            if (id == _product1.GetId())
            {
                return _product1;
            }
            else
            {
                return null;
            }
        }
    }
}
