using Welcome.Others;
using WelcomeExtended.Others;
using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

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
    var log = new WelcomeExtended.Others.Delegates.ActionOnError(Log);
    log(e.Message);
}
finally
{
    Console.WriteLine("Executed in any case!");
}