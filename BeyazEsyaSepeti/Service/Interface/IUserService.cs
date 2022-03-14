using BeyazEsyaSepeti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyazEsyaSepeti.Service.Interface
{
    public interface IUserService
    {
        User GetUserById(string Id);

        User GetUserByUsername(string userName);

        void Insert(User user);

        void Update(User user);

        Entity RegisterUser(User model);

        Entity LoginUser(User model);
    }
}
