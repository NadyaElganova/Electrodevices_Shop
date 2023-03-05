using Electrodevices.Controller.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodevices.Model
{
    public interface IAuth
    {
        Task<bool> AddObject(IUser user);
        Task<IUser> LoginObject(string login, string password);
    }
}
