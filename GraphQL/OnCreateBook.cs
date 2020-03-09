using HotChocolate.Language;
using HotChocolate.Subscriptions;
using Models;

namespace GraphQL
{
    public class OnCreateBook
        : EventMessage
    {
        public OnCreateBook(Book book)
            : base(CreateEventDescription(book))
        {
        }

        private static EventDescription CreateEventDescription(Book book)
        {
            return new EventDescription("onCreateBook",
                new ArgumentNode("book",
                    new StringValueNode(
                        book.BookName)));
        }
    }
}