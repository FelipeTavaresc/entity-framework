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

            var user = new User
            {
                Name = "Felipe",
                Slug = "felipe",
                Email = "felipe@felipe.com",
                Bio = "github/123",
                Image = "https://felipe.io",
                PasswordHash = "!@#$%456"
            };

            var category = new Category { Name = "Backend", Slug = "backend" };

            var post = new Post
            {
                Author = user,
                Category = category,
                Body = "<p>Hello world</p>",
                Slug = "comecando-com-ef-core",
                Summary = "Neste artigo vamos aprender EF core",
                Title = "Começando com EF Core",
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };

            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
