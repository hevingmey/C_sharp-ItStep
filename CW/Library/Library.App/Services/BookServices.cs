using Library.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.App.data;
using Library.App.Repositories;

namespace Library.App.Services;

public class BookServices
{
    private readonly BookRepository _repository;
    public BookServices(BookRepository repository)
    {
        _repository = repository;
    }

    public void DeleteBook()
    {
        Console.WriteLine("enter id to delete");
        int id = int.Parse(Console.ReadLine());
        _repository.DeleteBook(id);
        
    }

    public void editBook()
    {
        Console.WriteLine("enter choice to edit");
        Console.WriteLine("1. edit name");
        Console.WriteLine("2. edit total pages");
        Console.WriteLine("3. edit cost price");
        Console.WriteLine("4. edit sales price");
        Console.WriteLine("5. edit isSeries");
        Console.WriteLine("6. edit author ");
        Console.WriteLine("7. edit publisher ");
        Console.WriteLine("8. edit date relise");
        
       int choice = int.Parse(Console.ReadLine());
       Console.WriteLine("enter id book");
       int id = int.Parse(Console.ReadLine());

       switch (choice)
       {
           case 1:
               Console.WriteLine("enter name");
               string name = Console.ReadLine();
               _repository.updateBookName(name, id);
               break;
           case 2:
               Console.WriteLine("enter total pages");
               int pages = int.Parse(Console.ReadLine());
               _repository.updateBookTotalPages(pages, id);
               break;
           case 3:
               Console.WriteLine("enter cost price");
               decimal cost = decimal.Parse(Console.ReadLine());
               _repository.updateBookCostPrice(cost, id);
               break;
           case 4:
               Console.WriteLine("enter sales price");
               decimal sales = decimal.Parse(Console.ReadLine());
               _repository.updateBookSalesPrice(sales, id);
               break;
           case 5:
               Console.WriteLine("enter isSeries");
               bool isseries = bool.Parse(Console.ReadLine());
               _repository.updateBookIsbn(isseries, id);
               break;
           case 6:
               Console.WriteLine("enter author id");
               int aId = int.Parse(Console.ReadLine());
               _repository.updateBookAuthor(aId, id);
               break;
           case 7:
               Console.WriteLine("enter publisher id");
               int pId = int.Parse(Console.ReadLine());
               _repository.updateBookPublisher(pId, id);
               break;
           case 8:
               Console.WriteLine("enter date relise");
               DateTime date = DateTime.Parse(Console.ReadLine());
               _repository.updateBookDate(date, id);
               break;
               
               
           
       }
       
    }
    

    public void AddBook()
    {
        Console.WriteLine("you are adding book");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        
        Console.WriteLine("enter total pages");
        int pages = int.Parse(Console.ReadLine());
        
        Console.WriteLine("enter cost price");
        decimal cost = decimal.Parse(Console.ReadLine());
        
        Console.WriteLine("enter sales price");
        decimal sales = decimal.Parse(Console.ReadLine());
        
        Console.WriteLine("Does book have series? ");
        bool series = bool.Parse(Console.ReadLine());
        
        Console.WriteLine("enter series id");
        int serId = int.Parse(Console.ReadLine());
        
        Console.WriteLine("enter author id");
        int aId = int.Parse(Console.ReadLine());
        
        Console.WriteLine("enter publisher id");
        int pId = int.Parse(Console.ReadLine());
        
        Console.WriteLine("date created");
        DateTime date = DateTime.Parse(Console.ReadLine());
        
        
        var book = new Book
        {
            Name = name,
            TotalPages = pages,
            IsSeries = series,
            SeriesId = serId,
            AuthorId = aId,
            PublisherId = pId,
            dataRelise = date,
            CostPrice =  cost,
            SalesPrice = sales
            
        };
        _repository.addBook(book);
        
    }

}