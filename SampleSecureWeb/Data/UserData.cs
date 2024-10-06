using System;
using SampleSecureWeb.Models;

namespace SampleSecureWeb.Data;

public class UserData : IUser
{
    private readonly ApplicationDbContext _db;

    public UserData(ApplicationDbContext db)
    {
        _db = db;
    }

    public User Login(User user)
    {
        var _user = _db.Users.FirstOrDefault(u => u.Username == user.Username);
        if (_user == null)
        {
            throw new Exception("Pengguna Tidak Ditemukan");
        }
        if (!BCrypt.Net.BCrypt.Verify(user.Password, _user.Password))
        {
            throw new Exception("Kata Sandi Salah");
        }
        return _user;
    }

    public User Registration(User user)
    {
        user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
        _db.Users.Add(user);
        _db.SaveChanges();
        return user;
    }

    public User GetUserByUsername(string username)
    {
        return _db.Users.FirstOrDefault(u => u.Username == username);
    }

    public void UpdateUser(User user)
    {
        _db.Users.Update(user);
        _db.SaveChanges();
    }
}
