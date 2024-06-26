using System;
using System.Linq;
using Blog.Data;
using Blog.Models;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                // var tag = new Tag { Name = ".NET CORE", Slug = "dotnet-core" };
                // context.Tags.Add(tag);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x => x.Id == 4);
                // tag.Name = ".NET";
                // tag.Slug = "dotnet";

                // context.Update(tag);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);

                // context.Remove(tag);
                // context.SaveChanges();

                //Exemplo incorreto, filtrando a lista em memória
                // var tags = context
                //             .Tags
                //             .ToList()
                //             .Where(x => x.Name.Contains(".NET"));

                //Exemplo correto, filtrando a lista e só por último executando a query no banco
                var tags = context
                            .Tags
                            .Where(x => x.Name.Contains(".NET"))
                            .ToList();
                            

                foreach (var tag in tags)
                {
                    Console.WriteLine(tag.Name);
                }
            }
        }
    }
}
