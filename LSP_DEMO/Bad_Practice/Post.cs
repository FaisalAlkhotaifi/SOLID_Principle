using System;
using System.Collections.Generic;
using System.Linq;

namespace NoLSP
{
    public class Post
    {
        public virtual string CreatePost(PostDatabase db, string post)
        {
            return db.Add(post);
        }
    }

    public class TagPost: Post
    {
        public string CreateTagPost(PostDatabase db, string post)
        {
            return db.AddTagPost(post);
        }
    }

    public class MentionPost: Post
    {
        public string CreateMentionPost(PostDatabase db, string post)
        {
            return db.AddMentionPost(post);
        }
    }
}