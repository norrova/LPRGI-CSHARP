using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Nutget_Exo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // GET
            Task<Post> getPost =
                ApiHelper<Post>.GetRequestAsync(new Uri("https://jsonplaceholder.typicode.com/posts/58"));
            Task<List<Comment>> getComments =
                ApiHelper<List<Comment>>.GetRequestAsync(
                    new Uri("https://jsonplaceholder.typicode.com/posts/58/comments"));

            await Task.WhenAll(getPost, getComments);
            Console.WriteLine(JsonConvert.SerializeObject(getPost.Result, Formatting.Indented));
            Console.WriteLine(JsonConvert.SerializeObject(getComments.Result, Formatting.Indented));

            // POST
            Task<Post> postPost = ApiHelper<Post>.PostRequestAsync(
                new Uri("https://jsonplaceholder.typicode.com/posts"), new Post
                {
                    UserId = 1,
                    Title = "Mon post",
                    Body = "Test"
                });
            Task<Comment> postComments = ApiHelper<Comment>.PostRequestAsync(
                new Uri("https://jsonplaceholder.typicode.com/comments"), new Comment
                {
                    PostId = 999,
                    Name = "Ttest",
                    Email = "test@gmail.com",
                    Body = "Mon commentaire"
                });

            await Task.WhenAll(postPost, postComments);
            Console.WriteLine(JsonConvert.SerializeObject(postPost.Result, Formatting.Indented));
            Console.WriteLine(JsonConvert.SerializeObject(postComments.Result, Formatting.Indented));
        }
    }
}