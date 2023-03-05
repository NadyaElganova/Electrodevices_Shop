using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pbkdf2;

namespace Electrodevices.Model
{

    public class Encrypt : IEncrypt
    {
        public async Task<string> HashPassword(string password, string salt)
        {
            string result = "";
            await Task.Run(() =>
            {
                result = Convert.ToBase64String(Pbkdf2.Pbkdf2.HashData("SHA512", Encoding.ASCII.GetBytes(password), Encoding.ASCII.GetBytes(salt), 350000, 64));
            });
            return result;
        }
    }
}
