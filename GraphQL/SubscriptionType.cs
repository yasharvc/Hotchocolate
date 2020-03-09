using System;
using HotChocolate.Subscriptions;
using Models;
using Services;

namespace GraphQL
{
public class Subscription
    {
        private readonly BookService _repository;

        public Subscription(BookService repository)
        {
            _repository = repository
                ?? throw new ArgumentNullException(nameof(repository));
        }

        public Book OnCreateBook(IEventMessage message)
        {
            return (Book)message.Payload;
        }
    }

}