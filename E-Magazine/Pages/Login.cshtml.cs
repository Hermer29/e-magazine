using EMagazine.UserData;
using EMagazine.Utility;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EMagazine.Pages
{
    public class LoginModel : PageModel
    {
        private UserLoginInteractor _interactor;

        public LoginModel(UserLoginInteractor interactor)
        {
            _interactor = interactor;
        }

        public bool IsWrongPass { get; private set; } = false;
        public bool IsLogged { get; private set; } = false;
        public string WorkPageLink { get; private set; }

        public void OnGet()
        {
            WorkPageLink = _interactor.GetRole(Request.Cookies["session-token"])
                .GetCorrespondingUri();
            IsLogged = Request.Cookies.ContainsKey("session-token");
        }

        public void OnPost()
        {
            var login = Request.Form["login"];
            var password = Request.Form["password"];
            var loginData = _interactor.Login(login, password);
            if (loginData.IsSucceeded)
            {
                Response.Cookies.Append("session-token", loginData.Token);
                Response.Redirect(loginData.Role.GetCorrespondingUri());
                return;
            }
            IsWrongPass = true;
        }
    }
}
