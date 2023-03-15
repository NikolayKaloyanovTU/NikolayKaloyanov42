using WelcomeExtended.Others;

using Welcome.Others;
using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

// namespace WelcomeExtended
// {
//     public static class Program
//     {
//         public static void holo()
//         {
//             Console.WriteLine("holo");
//         }
//         public static void Main(string[] args)
//         {
            try
            {
                //Example 2
                var user = new User
                {
                    Names = "Nikolay Kaloyanov",
                    Password = "StingPassword",
                    Role = UserRolesEnum.STUDENT
                };

                var viewModel = new UserViewModel(user);

                var view = new UserView(viewModel);

                view.Display();

                view.DisplayError();
            }
            catch (Exception e)
            {
                var log = new Delegates.ActionOnError(Delegates.Log);
                log(e.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
//         }
//     }
//
// }
