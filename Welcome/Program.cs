using System;
using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;
using Welcome.Others;

namespace Welcome
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            User user = new User { Names = "Nikolay", Password = "MaskedPassword1234§~~~", Role = UserRolesEnum.Admin };

            UserViewModel uvm = new UserViewModel(user);
            UserView userView = new UserView(uvm);
            userView.Display();
        }
    }
}