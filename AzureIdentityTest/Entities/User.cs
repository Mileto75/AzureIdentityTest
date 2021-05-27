using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureIdentityTest.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserEmail { get; set; }
    }
}
