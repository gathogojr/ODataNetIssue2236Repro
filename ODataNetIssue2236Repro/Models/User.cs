using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ODataNetIssue2236Repro.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> Groups { get; set; }
    }
}
