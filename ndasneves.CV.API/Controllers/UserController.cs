using ndasneves.CV.API.Models;
using System;
using System.Web.Http;

namespace ndasneves.CV.API.Controllers
{
    public class UserController : ApiController
    {
        public UserInfo Get()
        {
            return new UserInfo() { FirstName = "Nicolas", LastName = "das Neves", BirthDate = new DateTime(1988, 10, 01) };
        }
    }
}
