using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace AzureIdentityTest.Helpers
{
    public class IsTeacherHandler : AuthorizationHandler<IsTeacherRequirement>
    {
        protected override Task HandleRequirementAsync
            (AuthorizationHandlerContext context, IsTeacherRequirement requirement)
        {
            if(context.User.Identity.Name.Contains(requirement.Teacher))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
