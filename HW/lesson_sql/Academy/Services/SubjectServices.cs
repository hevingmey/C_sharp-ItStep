using Academy.Context;
using Academy.Entitys;

namespace Academy.Services;

public class SubjectServices(AcademyDbContext _context)
{
       public void addSubject(string name)
       {
              var subject = new Subject
              {
                     Name = name
              };
              _context.Subjects.Add(subject);
              _context.SaveChanges();
       }

       public void GerAllSubjects()
       {
              var subjects = _context.Subjects.ToList();
              foreach (var subject in subjects)
              {
                     Console.WriteLine($"{subject.Id},{subject.Name}");
              }
       }

       public void GetAllbyIdSubject()
       {
              Console.WriteLine("enter id subject");
              string idsudj = Console.ReadLine();
              var subjects = _context.Subjects.Find(idsudj);
              Console.WriteLine($"{subjects.Id},{subjects.Name}");
                  
       }

       public void UpdateSubject(string id, string name)
       {
              Console.WriteLine("enter id subject");
              string idsudj = Console.ReadLine();
              
              Console.WriteLine("enter New name subject");
              string newname = Console.ReadLine();

              Console.WriteLine("enter new id subject");
              int newid = int.Parse(Console.ReadLine());
              var subject = _context.Subjects.Find(id);
              subject.Name = name;
              subject.Id = newid;
              _context.Subjects.Update(subject);
              _context.SaveChanges();
              
       }

       public void DeleteSubject(string id)
       {
              Console.WriteLine("enter id subject");
              string idsudj = Console.ReadLine();
              var subject = _context.Subjects.Find(id);
              
              if (subject.Grades != null)
              {
                     _context.Subjects.Remove(subject);
                     _context.SaveChanges();
              }
              else
              {
                     Console.WriteLine("Sorry you can't delete this subject!");
              }
       }
       
}