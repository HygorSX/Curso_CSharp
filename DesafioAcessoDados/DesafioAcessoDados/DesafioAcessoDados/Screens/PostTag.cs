using Blog;
using DesafioAcessoDados.Models;
using DesafioAcessoDados.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAcessoDados.Screens
{
    public class PostTag
    {
        public static void connectPostTag()
        {
            var postRepository = new PostRepository(Database.Connection);

            // Chame o método GetPostsWithTags
            List<Post> posts = postRepository.GetPostsWithTags();

            // Processe os resultados conforme necessário
            foreach (var post in posts)
            {
                Console.Write($"Id {post.Id}) Post: {post.Title}");
                if (post.Tags.Count() == 0)
                {
                    Console.WriteLine(" - Não há tags para este post");
                }
                else
                {
                    foreach (var tag in post.Tags)
                    {
                        Console.WriteLine($" - Tag: {tag.Name}");
                    }
                }
            }
        }
    }
}
