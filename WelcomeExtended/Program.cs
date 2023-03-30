﻿using Welcome.Others;
using WelcomeExtended.Others;
using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended.Data;

try
{
    //Example 3
    UserData userData = new UserData();
    
    //Example 2
    var user = new User
        {
        Names = "Nikolay Kaloyanov",
        Password = "StingPassword",
        Role = UserRolesEnum.STUDENT
        };
    
    userData.AddUser(user);
    
    var student2 = new User
        {
        Names = "Student2",
        Password = "123",
        Role = UserRolesEnum.STUDENT
        };
    
    userData.AddUser(user);
    
    var teacher = new User
        {
        Names = "Teacher",
        Password = "1234",
        Role = UserRolesEnum.PROFESSOR
        };
    
    userData.AddUser(user);
    
    var admin = new User
        {
        Names = "Admin",
        Password = "12345",
        Role = UserRolesEnum.ADMIN
        };
    
    userData.AddUser(user);

    var viewModel = new UserViewModel(user);

    var view = new UserView(viewModel);

    view.Display();

    view.DisplayError();
}
catch (Exception e)
{
    var log = Delegates.Log2;
    log(e.Message);
}
finally
{
    Console.WriteLine("Executed in any case!");
}