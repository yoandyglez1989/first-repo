using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationsDemo
{
    // This is a comment
    class Program
    {
        static void Main(string[] args)
        {

            Post[] posts = new Post[] { new Post() { BlogId = 1 }, new Post() { BlogId = 2 } };
            var cloned = posts.Clone();
            
            using (var ctx = new BlogContext())
            {
                ctx.Blogs.Add(new Blog
                {
                    Name = "Secound BLog"
                });

                ctx.SaveChanges();

                foreach (var item in ctx.Blogs)
                {
                    Console.WriteLine(item.Name);
                }

                Post p = new Post();
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
