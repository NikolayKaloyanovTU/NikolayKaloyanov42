using Welcome.Model;
using Welcome.Others;

namespace WelcomeExtended.Data;

public class UserData
{
    private List<User> _users;
    private int _nextId;

    public UserData()
    {
        _users = new List<User>();
        _nextId = 0;
    }

    public void AddUser(User user)
    {
        user.Id = _nextId++;
        _users.Add(user);
    }

    public void DeleteUser(User user)
    {
        _users.Remove(user);
    }

    public bool ValidateUser(string name, string password)
    {
        foreach (var user in _users)
        {
            if (user.Names == name && user.Password == password)
            {
                return true;
            }
        }

        return false;
    }

    public bool ValidateUserLambda(string names, string password)
    {
        return _users.Where(x => x.Names == names && x.Password == password)
            .FirstOrDefault() != null ? true : false;
    }

    public bool ValidateUserLinq(string names, string password)
    {
        var ret = from user in _users
            where user.Names == names && user.Password == password
            select user.Id;
        return ret != null ? true : false;
    }

    public User GetUser(string username, string password)
    {
        if (ValidateUser(username, password))
        {
            return _users.Find(x => x.Names == username && x.Password == password);
        }

        return null;
    }

    public void AssignUserRole(string name, UserRolesEnum role)
    {
        _users.Find(x => x.Names != name).Role = role;
    }
    
}