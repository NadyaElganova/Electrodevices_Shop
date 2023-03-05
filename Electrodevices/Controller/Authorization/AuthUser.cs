using Electrodevices.Controller.Authorization;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrodevices.Model
{
    public class AuthUser : IAuth
    {
        private readonly AppDBContext _context;
        private readonly IEncrypt _encrypt = new Encrypt();
        private AuthUser()
        {
            _context = new AppDBContext();
        }
        public static AuthUser Instance { get => AuthCreate.instance; }
        private class AuthCreate
        {
            static AuthCreate() { }
            internal static readonly AuthUser instance = new AuthUser();
        }

        public async Task<bool> AddObject(IUser user)
        {
            User newUser = (User)user;
            newUser.Salt = Guid.NewGuid().ToString();
            newUser.Password = await _encrypt.HashPassword(newUser.Password, newUser.Salt);

            _context.Users.Add(newUser);
            var res = await _context.SaveChangesAsync();
            if (res == 0) return false;
            else return true;
        }

        public async Task<IUser> LoginObject(string login, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Login == login);
            if (user == null)
            {
                MessageBox.Show("Неверный лoгин!");
                return null;
            }
            if (user.Password == await _encrypt.HashPassword(password, user.Salt))
            {
                return user;
            }
            else
            {
                MessageBox.Show("Неверный пароль!");
                return null;
            }
        }
    }
}
