using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
namespace ADUM.Controllers
{
    public class ApplyPolicyOrAuthorizeFilter : AuthorizeFilter
    {
        public ApplyPolicyOrAuthorizeFilter(AuthorizationPolicy policy) : base(policy) { }

        public ApplyPolicyOrAuthorizeFilter(IAuthorizationPolicyProvider policyProvider, IEnumerable<IAuthorizeData> authorizeData)
            : base(policyProvider, authorizeData) { }

        public override Task OnAuthorizationAsync(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext context)
        {
            if (context.Filters.Any(f =>
            {
                var filter = f as AuthorizeFilter;
                //There's 2 default Authorize filter in the context for some reason...so we need to filter out the empty ones
                return filter?.AuthorizeData != null && filter.AuthorizeData.Any() && f != this;
            }))
            {
                return TaskCache.CompletedTask;
            }
            return base.OnAuthorizationAsync(context);
        }
    }
 }
*/