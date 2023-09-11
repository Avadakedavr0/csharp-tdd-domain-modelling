﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {

    }
    public class Basket
    {
        public Dictionary<string, int> products = new Dictionary<string, int>();
        public void addProduct(string productName, int price)
        {
            if (!products.ContainsKey(productName))
            {
                products.Add(productName, price);
            }
        }
        public int totalCost()
        {
          return products.Values.Sum();
        }

        public Receipt makeReceipt()
        {
            Receipt receipt = new Receipt();
            receipt.purchasedProducts = this.products;
            return receipt;
        }
    }
    public class Receipt
    {
        public Dictionary<string, int> purchasedProducts = new Dictionary<string, int>();
        public string viewTheReceipt()
        {
            List<string> itemList = new List<string>();
            foreach (var item in purchasedProducts)
            {
                itemList.Add($"{ item.Key} : { item.Value}");
            }
            return string.Join(",", itemList);
        }
    }
}
