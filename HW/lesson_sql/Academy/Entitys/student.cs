namespace Academy.Entitys;
using System;
public class Student
{
    public int id { get; set; }
    public string name { get; set; }= string.Empty;
    public string surname { get; set; } = string.Empty;
    public string? email {get;set;}=string.Empty;
    public int dateOfBirth{get;set;}
    public int? groupId{get;set;}
    public Group group{get;set;}=null!;
    // public ICollection<Subject> courses{get;set;}=new List<Subject>();
    public List<Grade> Grades { get; set; } = new();

}