using System;
using System.Collections.Generic;
using WFA.Models;

namespace WFA.Services
{
    class UsersService
    {
        public static User loggedInUser;
        public static List<User> users = new List<User>();

        public static void Register(string name, string username, string password, string email)
        {
            User foundUser = users.Find((currentUser) => currentUser.username == username);
            if (foundUser != null) throw new Exception("Username already exists");
            User user = new User(name, username, password, email);
            users.Add(user);
        }

        public static void Login(string username, string password)
        {
            User foundUser = users.Find((currentUser) => currentUser.username == username);
            if (foundUser == null || foundUser.password != password) throw new Exception("Invalid credentials");
            loggedInUser = foundUser;
        }
    }
}
