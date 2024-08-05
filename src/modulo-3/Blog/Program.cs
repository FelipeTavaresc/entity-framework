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
            using var context = new BlogDataContext();
            
            // context.Users.Add(new User{
            //     Bio = "...",
            //     Email = "email@email",
            //     Image = "https://image",
            //     Name = "User",
            //     PasswordHash = "!#454",
            //     Slug = "user"
            // });

            // context.SaveChanges();

            // var user = context.Users.FirstOrDefault();
            // var post = new Post{
            //     Author = user,
            //     Body = "Meu artigo",
            //     Category = new Category{
            //         Name = "Backend",
            //         Slug = "backend"
            //     },
            //     CreateDate = DateTime.Now,
            //     Slug = "meu-artigo",
            //     Summary = "Resumo artigo",
            //     Title = "Meu Artigo"
            // };

            // context.Posts.Add(post);
            // context.SaveChanges();

            var posts = context.PostWithTagsCounts.ToList();

            foreach (var item in posts)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
