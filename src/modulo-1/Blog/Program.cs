using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

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
                // var tags = context
                //             .Tags
                //             .Where(x => x.Name.Contains(".NET"))
                //             .ToList();
                            
                // var tags = context
                //             .Tags
                //             .ToList();

                // foreach (var tag in tags)
                // {
                //     Console.WriteLine(tag.Name);
                // }


                //Exemplo incorreto, não utilizar AsNoTracking em update ou delete
                // var tag = context
                //             .Tags
                //             .AsNoTracking()
                //             .FirstOrDefault(x => x.Id == 4);
                // tag.Name = "Ponto NET1";
                // tag.Slug = "dotnet";

                //Exemplo correto
                // var tag = context
                //             .Tags
                //             .FirstOrDefault(x => x.Id == 4);
                // tag.Name = "Ponto NET1";
                // tag.Slug = "dotnet";

                //Para select, ok usar AsNoTracking

                // context.Update(tag);
                // context.SaveChanges();

                // Retorna o primeiro tem ou null
                // var tag = context
                //             .Tags
                //             .AsNoTracking()
                //             .FirstOrDefault(x => x.Id == 1);

                //Caso tenha mais de um item para o filtro, retorna erro.
                var tag = context
                            .Tags
                            .AsNoTracking()
                            .Single(x => x.Id == 3 || x.Id == 4);

                Console.WriteLine(tag?.Name);
            }
        }
    }
}
