using BeyazEsyaSepeti.Models;
using BeyazEsyaSepeti.Service.Interface;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyazEsyaSepeti.Service
{
    public class UserService : IUserService
    {
        public User GetUserById(string Id)
        {
            MongoHelper context = new MongoHelper();
            var user = context.Users.Find(x => x.Id == Id).FirstOrDefault();
            return user;
        }

        public User GetUserByUsername(string userName)
        {
            MongoHelper context = new MongoHelper();
            var user = context.Users.Find(x => x.userName == userName).FirstOrDefault();
            return user;
        }

        public void Insert(User user)
        {
            MongoHelper context = new MongoHelper();
            context.Users.InsertOne(user);
        }

        public Entity LoginUser(User model)
        {
            var user = GetUserByUsername(model.userName.ToLower());

            if (user == null)
            {
                model.Error = "Kullanıcı bulunamadı!";
                return model;
            }
            if(user.password != model.password)
            {
                model.Error = "Hatalı parola!";
                return model;
            }

            model.Id = user.Id;


            return model;
        }

        public Entity RegisterUser(User model)
        {
           

            if (model.password.Length < 6)
            {
                model.Error = "Şifre en az 6 karakter olmalıdır";
                return model;
            }

            if (model.userName.Length < 4)
            {
                model.Error = "Kullanıcı adı en az 4 karakter olmalıdır";
                return model;
            }


            var user = GetUserByUsername(model.userName.ToLower());
            if (user != null)
            {
                model.Error = "Kullanıcı zaten var";
                return model;
            }

            user = new User();
            user.userName = model.userName;
            user.password = model.password;
            Insert(user);


            return new Entity();
        }

        public void Update(User user)
        {
            MongoHelper context = new MongoHelper();
            context.Users.ReplaceOne<User>(k => k.Id == user.Id, user);
        }
    }
}
