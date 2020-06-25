using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WG_Data_Library.DataAccess;
using WG_Data_Library.Models;

namespace WGDataManager.Controllers
{
    [Authorize]
    [RoutePrefix("api/User")]
    public class UsersController : ApiController
    {

        UserData userData = new UserData();
        public UserModel GetUsers()
        {
          
            string userId = RequestContext.Principal.Identity.GetUserId();

            var models = userData.GetUserById(userId).First();

            return models;
        }
           

        public UserModel GetUsers(string id)
        {

            var model = userData.GetUserById(id).First();

            return model;

        }


    }
}
