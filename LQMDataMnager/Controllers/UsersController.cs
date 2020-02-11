using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LQMDataManager.Models;
using Microsoft.AspNet.Identity;

namespace LQMDataManager.Controllers
{
    [Authorize]
    public class UsersController : ApiController
    {
        UserModel user = new UserModel();
        List<UserModel> Users = new List<UserModel>(); 
        public UsersController()
        {
            Users.Add(new UserModel { Id = 1, Username = "admin", Password = "admin123" });
            Users.Add(new UserModel { Id = 2, Username = "mbuzi", Password = "mbuzi123" });
            Users.Add(new UserModel { Id = 3, Username = "mbazo", Password = "mbazo123" });
            Users.Add(new UserModel { Id = 4, Username = "muntu", Password = "muntu123" });
        }
        // GET: api/Users
        public List<UserModel> Get()
        {
            return Users;
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
