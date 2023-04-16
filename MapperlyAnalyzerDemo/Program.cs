// See https://aka.ms/new-console-template for more information

using Riok.Mapperly.Abstractions;

var user = new User { Id = 123, Name = "John Doe", Address = "Mulholland drive 91" };
var info = user.ToInfo();
Console.WriteLine($"Hello, {info.Name}!");

class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}

class UserInfo
{
    public int Id { get; set; }
    public string Name { get; set; }
}

[Mapper]
static partial class UserMapper
{
    public static partial UserInfo ToInfo(this User user);
}