namespace Academy.Entitys;
using System;
public class Student
{
    public int id { get; set; }
    public string name { get; set; }= string.Empty;
    public string surname { get; set; } = string.Empty;
    public DateTime createdAdd { get; set; }
    public int? age{get;set;}
    public int? email {get;set;}
    public int dateOfBirth{get;set;}
    public int? groupId{get;set;}
    public Group group{get;set;}=null!;
    
}