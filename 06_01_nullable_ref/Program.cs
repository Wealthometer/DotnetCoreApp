using System.Collections.Generic;
using System;

namespace _06_01_nullable_ref
{
    class Program
    { 
        static void Main(string[] args)
        {
            var post = new BlogPost("Nullable Ref Types Rock!");
            post.Comments.Add(new Comment("Yes they do!", new Author("John", "john@nullrefs.com")));
            post.Comments.Add(new Comment("I love them!", new Author("Leah", "leah@nullrefs.com")));
            //post.Comments.Add(null);

             // PrintPostInfo(null);
             PrintPostInfo(post);
        }

        static void PrintPostInfo(BlogPost post)
        {
            // we use the null forgiving operator to allow nullable reference type
            // it tells the compiler dat were sure the property wont be null
            Console.WriteLine($"{post.Title} ({post.Title.Length})");

            foreach (var comment in post.Comments)
            {
                var commentPreview = comment.Body.Length > 10 ?
                    $"{comment.Body.Substring(0, 10)}..." :
                    comment.Body;

                Console.WriteLine($"{comment.PostedBy.Name} ({comment.PostedBy.Email}): " + $"{commentPreview}");
            }
        }
    }
}
