using System;
using System.Collections.Generic;
using System.Linq;

namespace NoLSP
{
    public class PostDatabase
    {
        public string Add(string post)
        {
            return "Original post: " + post;
        }

        public string AddTagPost(string post)
        {
            return "Tag post: " + post;
        }

        public string AddMentionPost(string post)
        {
            return "Mention post: " + post;
        }
    }   
}