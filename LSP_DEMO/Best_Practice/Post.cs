using System;
using System.Collections.Generic;
using System.Linq;

namespace LSP
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
        public override string CreatePost(PostDatabase db, string post)
        {
            return db.AddTag(post);
        }
    }

    public class MentionPost: Post
    {
        public override string CreatePost(PostDatabase db, string post)
        {
            return db.AddMention(post);
        }
    }

    public class LinkPost: Post
    {
        public override string CreatePost(PostDatabase db, string post)
        {
            return db.AddLink(post);
        }
    }
}