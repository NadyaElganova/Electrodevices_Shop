using Electrodevices.Controller;
using Electrodevices.Model;
using MoreLinq.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrodevices.Controller
{
    public class DataService
    {
        public readonly AppDBContext _context;
        public static DataService Instance { get => DataServiceCreate.instance; }

        private DataService()
        {
            _context = new AppDBContext();
        }
        private class DataServiceCreate
        {
            static DataServiceCreate() { }
            internal static readonly DataService instance = new DataService();
        }
        public async Task<Electrodevice> AddElectrodevice(Electrodevice electrodevice, Country country, Date date, Category category)
        {
            if(country != null) _context.Countries.Include("Electrodevices").Include("Electrodevices.Country").FirstOrDefault(c => c.ID == country.ID).Electrodevices.Add(electrodevice);
            if (date != null) _context.Dates.Include("Electrodevices").Include("Electrodevices.Date").FirstOrDefault(d => d.Id == date.Id).Electrodevices.Add(electrodevice);
            if (category != null) _context.Categories.Include("Electrodevices").Include("Electrodevices.Category").FirstOrDefault(c => c.ID == category.ID).Electrodevices.Add(electrodevice);
            if(country == null && date == null && category == null) _context.Electrodevices.Add(electrodevice);
            int res = await _context.SaveChangesAsync();
            if (res == 0)
            {
                throw new Exception();
            }
            return electrodevice;
        }
        public async Task<List<Electrodevice>> GetAllElectrodevices()
        {
            return await _context.Electrodevices.Include("Country").Include("Date").Include("Category").ToListAsync();
        }
        public async Task<bool> RemoveElectodevice(Electrodevice electrodevice)
        {
            var deleteProduct = await _context.Electrodevices.FirstOrDefaultAsync(e => e.Id == electrodevice.Id);
            _context.Electrodevices.Remove(deleteProduct); 
            var res = await _context.SaveChangesAsync();
            if (res == 0)
            {
                return false;
            }
            return true;
        }
        public async Task<bool> ChangeElectrodevice(Electrodevice newProduct)
        {
            _context.Electrodevices.Add(newProduct);
            int res = await _context.SaveChangesAsync();
            if (res == 0)
            {
                return false;
            }
            return true;
        }
        public async Task<List<Electrodevice>> SortElectrodevices(int key)
        {
            switch(key)
            {
                case 0:
                    return await _context.Electrodevices.OrderBy(p => p.Date.Year).ToListAsync();
                case 1:
                    return await _context.Electrodevices.OrderBy(p => p.Model).ToListAsync();
                case 2:
                    return await _context.Electrodevices.OrderBy(p => p.Country.Name).ToListAsync();
                case 3:
                    return await _context.Electrodevices.OrderBy(p => p.Wight).ToListAsync();
                case 4:
                    return await _context.Electrodevices.OrderBy(p => p.Price).ToListAsync();
                default:
                    MessageBox.Show("Возникла ошибка!");
                    break;
            }
            return null;
        }
        public List<Electrodevice> BetterElectrodevice(int key)
        {
            switch (key)
            {
                case 0:
                    return _context.Electrodevices.MaxBy(p => p.Price).ToList();
                    break;
                case 1:
                    return _context.Electrodevices.MinBy(p => p.Price).ToList();
                    break;
                case 2:
                    return _context.Electrodevices.MaxBy(p => p.Amount_Sale).ToList();
                    break;
            }
            return null;
        }
        public async Task<Date> AddDate(Date date)
        {
            _context.Dates.Add(date);
            int res = await _context.SaveChangesAsync();
            if (res == 0)
            {
                throw new Exception();
            }
            return date;
        }
        public async Task<Date> GetDate(int year)
        {
            return await _context.Dates.Include("Electrodevices").Include("Electrodevices.Date").FirstOrDefaultAsync(c => c.Year == year);
        }
        public async Task<Country> AddCountry(Country country)
        {
            _context.Countries.Add(country);
            int res = await _context.SaveChangesAsync();
            if (res == 0)
            {
                throw new Exception();
            }
            return country;
        }
        public async Task<Country> GetCountry(string name)
        {
            return await _context.Countries.Include("Electrodevices").Include("Electrodevices.Country").FirstOrDefaultAsync(c => c.Name == name);
        }
        public async Task<List<Country>> GetAllCountries()
        {
            return await _context.Countries.Include("Electrodevices").Include("Electrodevices.Country").ToListAsync();
        }
        public async Task<Category> AddCategory(Category category)
        {
            _context.Categories.Add(category);
            int res = await _context.SaveChangesAsync();
            if (res == 0)
            {
                throw new Exception();
            }
            return category;
        }
        public async Task<Category> GetCategory(string name)
        {
            return await _context.Categories.Include("Electrodevices").Include("Electrodevices.Category").FirstOrDefaultAsync(c => c.Name == name);
        }
        public async Task<List<Category>> GetAllCategories()
        {
            return await _context.Categories.Include("Electrodevices").Include("Electrodevices.Category").ToListAsync();
        }
        public async Task<bool> Amount_Sale_Stock(Electrodevice electrodevice)
        {
            var res = await _context.Electrodevices.Include("Country").Include("Date").Include("Category").FirstOrDefaultAsync(el => el.Id == electrodevice.Id);
            res.Amount_Sale++;
            res.Amount_Stock--;
            int result= await _context.SaveChangesAsync();
            if (result == 0)
            {
                return false;
            }
            return true;
        }
    }
}
