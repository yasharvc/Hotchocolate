using System.Linq;
using HotChocolate.Types;
using Services;

namespace Models
{
    public class BookType : ObjectType<Book>{
        protected override void Configure(IObjectTypeDescriptor<Book> descriptor){
            //descriptor.Field(t => t.BookName);
            // descriptor.Field("test").Type<NonNullType<Book>>().Resolver(ctx=>{
            //     var app = ctx.Service<BookService>();
            //     return app.Get().First();
            // });
            descriptor.Field(t => t.BookName).Resolver(ctx =>{return "ASD";});
        }
    }
}