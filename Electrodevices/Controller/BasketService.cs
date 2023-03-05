using Electrodevices.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrodevices.Controller
{
    public class BasketService
    {
        public readonly AppDBContext _context;
        public static BasketService Instance { get => BasketServiceCreate.instance; }

        private BasketService()
        {
            _context = new AppDBContext();
        }
        private class BasketServiceCreate
        {
            static BasketServiceCreate() { }
            internal static readonly BasketService instance = new BasketService();
        }
        public async Task<bool> AddProductInBasket(User user, Electrodevice electrodevice)
        {
            Basket productInBasket = new Basket();
            productInBasket.Electrodevice = await _context.Electrodevices.FirstOrDefaultAsync(el => el.Id == electrodevice.Id);
            if (productInBasket.Electrodevice.Amount_Stock == 0)
            {
                MessageBox.Show("Товара нет на складе!");
                return false;
            }
            productInBasket.User = await _context.Users.FirstOrDefaultAsync(u => u.Id == user.Id);
            _context.Baskets.Add(productInBasket);
            var res = await _context.SaveChangesAsync();
            if (res == 0) return false;
            else return true;
        }
        public async Task<List<Electrodevice>> GetElectrodevicesInBasket(int userId)
        {
            var basket = await _context.Baskets.Include("User").Include("Electrodevice").Include("Electrodevice.Category").Include("Electrodevice.Country").Include("Electrodevice.Date").Where(e => e.User.Id == userId).ToListAsync();
            List<Electrodevice> electrodevices = new List<Electrodevice>();
            foreach (var item in basket)
            {
                electrodevices.Add(item.Electrodevice);
            }
            return electrodevices;
        }
        public async Task<bool> RemoveProductBasket(Electrodevice electrodevice)
        {
            var deleteProductBasket = await _context.Baskets.FirstOrDefaultAsync(e => e.Electrodevice.Id == electrodevice.Id);
            _context.Baskets.Remove(deleteProductBasket);
            var res = await _context.SaveChangesAsync();
            if (res == 0)
            {
                return false;
            }
            return true;
        }
        public async Task<bool> BuyElectrodevice(int userId)
        {
            var basket = await _context.Baskets.Include("User").Include("Electrodevice").Where(p => p.User.Id == userId).ToListAsync();
            List<Electrodevice> electrodevices = new List<Electrodevice>();
            int res = 0;
            foreach (var item in basket)
            {
                await DataService.Instance.Amount_Sale_Stock(item.Electrodevice);                
                _context.Baskets.Remove(item);
                res = await _context.SaveChangesAsync();
            }
            if (res == 0) return false;
            else return true;            
        }

    }
}
