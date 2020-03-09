using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using GreenDonut;
using HotChocolate.Types;
using Models;
using Services;

namespace GraphQL{
    public class SimpleQueryType : ObjectType<Book> {
        protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
        {
            descriptor.Field("books").Type<ObjectType<Book>>().
            Resolver(ctx =>{
                var service = ctx.Service<BookService>();
                return service.GetFirst();
            });
            descriptor.Field("test").Type<NonNullType<StringType>>().Resolver(ContextData=>{return "dasd";});
        }
    }

    public class SimpleQuery :ObjectType<Book>{
        public Book Hello(){
            var service = new Services.BookService();
            Debug.WriteLine(service.Get().First().BookName);
            return service.Get().First();
        }
    }
}