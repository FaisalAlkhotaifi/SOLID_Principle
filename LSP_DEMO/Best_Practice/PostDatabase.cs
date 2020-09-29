using System;
using System.Collections.Generic;
using System.Linq;

namespace LSP
{
    public class PostDatabase
    {
        public string Add(string post)
        {
            return "Original post: " + post;
        }

        public string AddTag(string post)
        {
            return "Tag post: " + post;
        }

        public string AddMention(string post)
        {
            return "Mention post: " + post;
        }

        public string AddLink(string post)
        {
            return "Link post: " + post;
        }
    }   
}