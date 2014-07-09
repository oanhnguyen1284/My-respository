using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoursquareAngularJS.Web.Controllers
{
    public class UsersController : BaseApiController
    {
        public bool Get(string username) {
            return TheRepository.UserNameExists(username);
        }
    }
}
