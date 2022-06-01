using EMagazine.UserData;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SqlFacade;

namespace EMagazine.Pages
{
    public class DataChangeModel : PageModel
    {
        private ConsoleInteractor _console;

        public DataChangeModel(ConsoleInteractor console)
        {
            _console = console;
        }

        public void OnGet()
        {
            DetermineSourceData();
        }

        private void DetermineSourceData()
        {
            var uri = HttpContext.Request.GetDisplayUrl();
            string action = uri.Split('/')[1];  
            
        }
    }
}
