﻿namespace sh_lab_2;
public class User
{
    public string Login { get; set; }
    public string Password { get; set; }

    public User(string login, string password)
    {
        Login = login;
        Password = password;
    }
}