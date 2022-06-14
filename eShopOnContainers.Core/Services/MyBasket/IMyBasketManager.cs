using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyBasket;

namespace eShopOnContainers.Core.Services.MyBasket
{
    public interface IMyBasketManager
    {
        MyBasketItem Get(int Id);
        int GetAllCount();
        IEnumerable<MyBasketItem> GetAll();
        int Insert(MyBasketItem s);
        int Update(MyBasketItem s);
        int Delete(int Id);

        void Dispose();
    }
}
