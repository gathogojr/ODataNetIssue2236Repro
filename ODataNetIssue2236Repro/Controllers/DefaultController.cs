using System.Collections.Generic;
using ODataNetIssue2236Repro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace ODataNetIssue2236Repro.Controllers
{
    [Route("odata")]
    public class DefaultController : ODataController
    {
        [HttpGet("WhoAmI()")]
        public User WhoAmI()
        {
            return new User
            {
                UserName = "john.doe@temp.com",
                FirstName = "John",
                LastName = "Doe",
                Groups = new List<string> { "Group 1", "Group 2" }
            };
        }
    }
}
