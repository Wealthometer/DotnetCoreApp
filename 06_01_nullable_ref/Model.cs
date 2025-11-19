using System.Collections.Generic;


namespace _06_01_nullable_ref
{
    // if we build the class we will get an error because we declare the variables
    // as non nullable reference types & we failed to initialize them
    public class BlogPost
    {
        //it now changes from a non-nullable string to a nullable string
        public string Title { get; set; }

        // the comments property is a get-only property
        // we assigned it with a property initializer(which means it cannot be null)
        public List<Comment> Comments { get; } = new List<Comment>();

        // we define our constructors here
        public BlogPost(string title)
        {
            Title = title;
        }
    }

    public class Comment
    {
        public string Body { get; set; }
        public Author PostedBy { get; set; }

        public Comment(string body, Author postedBy)
        {
            Body = body;
            PostedBy = postedBy;
        }
    }

    public class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Author(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}