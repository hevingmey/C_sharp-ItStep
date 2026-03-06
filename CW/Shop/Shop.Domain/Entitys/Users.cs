using System.ComponentModel.DataAnnotations;
using Shop.Domain.Enums;

namespace Shop.Domain.Entitys;


public class Users
{
    [Key]
    public int Id { get; set; }
     public string Name { get; set; }
     public string Surname { get; set; }
     public string HashPassword { get; set; }
     public string? Email { get; set; }
     public UserRole Role { get; set; }= UserRole.User;
     public DateTime CreatedAt { get; set; }
}