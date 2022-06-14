﻿using System.Collections.Generic;
using System.Linq;
using System.Net;
using eShopOnContainers.Core.Models.MyBasket;
using eShopOnContainers.Core.Services.MyRestService;
using Newtonsoft.Json;

namespace eShopOnContainers.Core.Services.MyBasket
{
    public class MyBasketManager
    {
        private readonly RestServiceManager<List<MyBasketItem>> _restServiceMyBasketItemManager;

        public MyBasketManager()
        {
            _restServiceMyBasketItemManager = new RestServiceManager<List<MyBasketItem>>();
        }


        #region CRUD
        public int Insert(MyBasketItem s)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                string data = JsonConvert.SerializeObject(s);
                var response = webClient.UploadString(ServiceUrlConst.AddMyBasket, data);
                var result = JsonConvert.DeserializeObject<int>(response);
                return result;
            }
        }

        public bool Delete(int id)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                string data = JsonConvert.SerializeObject(id);
                webClient.UploadString(ServiceUrlConst.DeleteItem, data);
                return true;

                //$"{ServiceUrlConst.DeleteItem}/{id}"
            }
        }
        public bool DeleteAll()
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                webClient.UploadString(ServiceUrlConst.DeleteAll, string.Empty);
                return true;
            }
        }

        public IEnumerable<MyBasketItem> GetAll()
        {
            return _restServiceMyBasketItemManager.GetServiceResponse(ServiceUrlConst.GetAllBasketItem);
        }

        public int GetAllCount()
        {
            return _restServiceMyBasketItemManager.GetServiceResponse(ServiceUrlConst.GetAllBasketItem).Count;
        }

        public MyBasketItem Get(int Id)
        {
            var data = _restServiceMyBasketItemManager.GetServiceResponse(ServiceUrlConst.GetAllBasketItem);
            return data.Where(x => x.Id == Id).FirstOrDefault();
        }

        #endregion
    }
}
