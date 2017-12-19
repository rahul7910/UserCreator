using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.User
{
    public class IndexModel : PageModel
    {
        private readonly UserService _userService;

        public UserViewModel ViewModel { get; private set; }

        public IndexModel(UserService userService)
        {
            _userService = userService;
        }


        public void OnGet()
        {
            ViewModel = _userService.FindUser();
        }
    }
}