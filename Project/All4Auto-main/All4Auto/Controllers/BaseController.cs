namespace All4Auto.Controllers
{
    using All4Auto.Core.Constants;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.AspNetCore.Authorization;

    [Authorize]
    public class BaseController : Controller
    {
        public string UserFirstName
        {
            get
            {
                string firstName = string.Empty;

                if (User?.Identity?.IsAuthenticated ?? false
                    && User.HasClaim(c => c.Type == ClaimTypeConst.FirsName))
                {
                    firstName = User.Claims.FirstOrDefault(c => 
                    c.Type == ClaimTypeConst.FirsName) ?.Value ?? firstName;
                }
                return firstName;
            }
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                ViewBag.UserFirstName = UserFirstName;
            }

            base.OnActionExecuted(context);
        }
    }
}
