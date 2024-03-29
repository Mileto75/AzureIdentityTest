﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace AzureIdentityTest.Helpers
{
    public class IsTeacherRequirement : IAuthorizationRequirement
    {
        public string Teacher { get; }

        public IsTeacherRequirement(string teacher)
        {
            Teacher = teacher;
        }
    }
}
