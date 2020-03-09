using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Subscriptions;
using Models;
using Services;

namespace GraphQL
{
public class MutationType{
    private BookService respository;
    public MutationType(BookService service)
    {
        respository=service;
    }
    public async Task<Book> CreateReview(
                Book book,
                [Service]IEventSender eventSender)
            {
                book = respository.Create(book);
                //await eventSender.SendAsync(new OnCreateBook(book));
                return book;
            }
    }   
}