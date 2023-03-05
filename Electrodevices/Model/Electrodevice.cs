using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Electrodevices.Controller;

namespace Electrodevices.Model
{
    public class Electrodevice
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public decimal Wight { get; set; }
        public int Amount_Stock { get; set; }
        public int Amount_Defect { get; set; }
        public int Amount_Sale { get; set; }
        public string Path_Picture { get; set; }
        public Category Category { get; set; }
        public Country Country { get; set; }
        public Date Date { get; set; }
        public override string ToString()
        {
            return $"{Category} {Model} Цена: {Price} Вес:{Wight} Страна: {Country} Год: {Date} " +
                $"Кол-во на складе: {Amount_Stock} Кол-во дефекта: {Amount_Defect} Кол-во продаж: {Amount_Sale}";
        }
    }

}
