using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Profilz.Models;

namespace Profilz.Test
{
    [TestClass]
    public class Test_Profilz_Users
    {
        [TestMethod]
        public void Test_Create_Users()
        {


            User user = new User()
            {
                Username="Lol",
                Email="lol@lol.lol",
                Password="looooooooool"
            };
            
            Dal.Db.Users.Add(user);
            Dal.Db.SaveChanges();
        }
    }
}
