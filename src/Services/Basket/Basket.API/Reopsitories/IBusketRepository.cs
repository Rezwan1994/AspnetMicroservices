using Basket.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Reopsitories
{
    public interface IBusketRepository
    {
        Task<ShoppingCart>  GetBasket(string userName);
        Task<ShoppingCart> UpdateBasket(ShoppingCart userName);
        Task DeleteBasket(string userName);
    }
}
