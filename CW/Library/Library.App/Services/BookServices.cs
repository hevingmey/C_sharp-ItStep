using Library.Domain;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.App.data;
using Library.App.Repositories;
using Library.Domain.Entitys;
using Microsoft.IdentityModel.Tokens;

namespace Library.App.Services;


public class BookServices
{
    private readonly BookRepository _repository;
    private readonly LibraryDbContext _context;

    public BookServices(BookRepository repository, LibraryDbContext context)
    {
        _repository = repository;
        _context = context;
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
            Console.WriteLine("9. edit total amount of book");
            Console.WriteLine("10. add book to order");
            Console.WriteLine("11. add book to discount");
            

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
                case 9:
                    Console.WriteLine("enter total amount of book");
                    int totalamount = int.Parse(Console.ReadLine());
                    _repository.UpdateBookTotalAmount(totalamount, id);
                    break;
                case 10:
                    Console.WriteLine("enter book Id");
                    int bookId = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter order id");
                    int orderId = int.Parse(Console.ReadLine());
                    trBookToOrder(bookId, orderId);
                    break;
                case 11:
                    Console.WriteLine("enter book Id");
                    int bookDiscountId = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter discount amount");
                    decimal discount = decimal.Parse(Console.ReadLine());
                    _repository.AddBookToDiscount(bookDiscountId, discount);
                    
                        
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

            Console.WriteLine("enter total amount of book");
            int totalamount = int.Parse(Console.ReadLine());

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
                CostPrice = cost,
                SalesPrice = sales,
                TotalAmount = totalamount

            };
            _repository.addBook(book);

        }
        // транзакція 
        public void trBookToOrder(int bookId,int  orderId)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                var book = _context.Books.Find(bookId);
                var order = _context.Orders.Find(orderId);
                if (book.TotalAmount <=0)
                    throw new Exception("No book found");
                book.TotalAmount--;
                order.books.Add(book);
                _context.SaveChanges();
                transaction.Commit();
            }
            catch 
            {
               transaction.Rollback();
                throw;
            }

        }
    

    }
