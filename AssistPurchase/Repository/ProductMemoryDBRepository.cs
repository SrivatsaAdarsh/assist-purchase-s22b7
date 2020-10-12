﻿using AssistPurchase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace AssistPurchase.Repository
{
    public class ProductMemoryDBRepository : IProductDataRepository
    {
        List<Models.ProductDataModel> _db = new List<ProductDataModel>();


        // ITransactionManager _tranx;
        public ProductMemoryDBRepository()
        {

            _db.Add(new ProductDataModel
            {
                ProductName = "IntelliVue",
                ProductId = "X3",
                ProductPrice = "25000",
                TouchScreen = "Yes",
                DisplaySize = "6",
                DisplayType = "LCD",
                Battery = "Yes",
                BatteryCapacity = "5",
                Portability = "Yes",
                Weight = "1.4",
                Wearable = "No",
            }
            );
            _db.Add(new ProductDataModel
            {
                ProductName = "IntelliVue",
                ProductId = "MX750",
                ProductPrice = "50000",
                TouchScreen = "Yes",
                DisplaySize = "19",
                DisplayType = "LCD",
                Battery = "No",
                BatteryCapacity = "0",
                Portability = "No",
                Weight = "1.8",
                Wearable = "No",
            }
            );
            _db.Add(new ProductDataModel
            {
                ProductName = "IntelliVue",
                ProductId = "MP2",
                ProductPrice = "20000",
                TouchScreen = "No",
                DisplaySize = "3.5",
                DisplayType = "LCD",
                Battery = "Yes",
                BatteryCapacity = "6",
                Portability = "Yes",
                Weight = "1.5",
                Wearable = "Yes",
            }
           );
            _db.Add(new ProductDataModel
            {
                ProductName = "IntelliVue",
                ProductId = "MP5",
                ProductPrice = "35000",
                TouchScreen = "Yes",
                DisplaySize = "6",
                DisplayType = "LCD",
                Battery = "No",
                BatteryCapacity = "0",
                Portability = "No",
                Weight = "3",
                Wearable = "No",
            }
            );
            _db.Add(new ProductDataModel
            {
                ProductName = "IntelliVue",
                ProductId = "MX450",
                ProductPrice = "40000",
                TouchScreen = "Yes",
                DisplaySize = "12",
                DisplayType = "LCD",
                Battery = "No",
                BatteryCapacity = "0",
                Portability = "Yes",
                Weight = "2",
                Wearable = "No",
            }
            );
        }
        //public bool AddNewProduct(ProductDataModel newState)
        //{

        //    _db.Add(newState);
        //    return true;
        //}

        //public IEnumerable<ProductDataModel> GetAllProducts()
        //{
        //    return _db;
        //}

        //public bool Remove(string id)
        //{
        //    for (int i = 0; i < _db.Count; i++)
        //    {
        //        if (_db[i].ProductId == id)
        //        {
        //            _db.Remove(_db[i]);
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public bool UpdateProductInfo(string id, ProductDataModel state)
        //{

        //    for (int i = 0; i < _db.Count; i++)
        //    {
        //        if (_db[i].ProductId == id)
        //        {
        //            _db.Insert(i, state);
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public ProductDataModel AddNewProduct(ProductDataModel newState)
        {
            _db.Add(newState);
            return _db[_db.Count-1];
        }

        public IEnumerable<ProductDataModel> GetAllProducts()
        {
            return _db;
        }

        public ProductDataModel GetProductById(string id)
        {
            for (int i = 0; i < _db.Count; i++)
            {
                if (_db[i].ProductId == id)
                {
                    return _db[i];
                }
            }
            return null;
        }

        public void Remove(string id)
        {
            for (int i = 0; i < _db.Count; i++)
            {
                if (_db[i].ProductId == id)
                {
                    _db.Remove(_db[i]);
                }
            }
        }

        public bool UpdateProductInfo(string id, ProductDataModel state)
        {
            for (int i = 0; i < _db.Count; i++)
            {
                if (_db[i].ProductId == id)
                {
                    _db.Insert(i, state);
                    return true;

                }
            }
            return false;
        }
    }
}
