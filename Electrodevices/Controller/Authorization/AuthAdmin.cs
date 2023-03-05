using Electrodevices.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrodevices.Controller.Authorization
{
    public class AuthAdmin : IAuth
    {
        private readonly AppDBContext _context;
        private readonly IEncrypt _encrypt = new Encrypt();
        private AuthAdmin()
        {
            _context = new AppDBContext();
        }
        public static AuthAdmin Instance { get => AuthCreate.instance; }
        private class AuthCreate
        {
            static AuthCreate() { }
            internal static readonly AuthAdmin instance = new AuthAdmin();
        }
        public async Task<bool> AddObject(IUser administrator)
        {
            Administrator newAdministrator = (Administrator)administrator;
            newAdministrator.Salt = Guid.NewGuid().ToString();
            newAdministrator.Password = await _encrypt.HashPassword(newAdministrator.Password, newAdministrator.Salt);

            _context.Administrators.Add(newAdministrator);
            var res = await _context.SaveChangesAsync();
            if (res == 0) return false;
            else return true;
        }

        public async Task<IUser> LoginObject(string login, string password)
        {
            var admin = await _context.Administrators.FirstOrDefaultAsync(u => u.Login == login);
            if (admin == null)
            {
                MessageBox.Show("Неверный лoгин!");
                return null;
            }
            if (admin.Password == await _encrypt.HashPassword(password, admin.Salt))
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Неверный пароль!");
            }
            return admin;
        }
    }
}
