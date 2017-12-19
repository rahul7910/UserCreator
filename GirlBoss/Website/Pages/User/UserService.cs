namespace Website.Pages.User
{
    public class UserService
    {
        public UserService()
        {
            
        }

        public UserViewModel FindUser()
        {
            UserViewModel userViewModel = new UserViewModel
            {
                FirstName = "Thivy",
                LastName = "Ruthra",
                Email = "Thivy@gmail.com"
            };

            return userViewModel;
        }

    }
}
