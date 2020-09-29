using System;
using System.Collections.Generic;
using System.Linq;

namespace NoLSP
{
    class BadPractice
    {
        public void Run()
        {
            PostDatabase db = new PostDatabase();
            List<string> newPosts = new List<string>();
            newPosts.Add("original post");
            newPosts.Add("#tag post");
            newPosts.Add("@mention post");

            Post postObj;
            foreach (string post in newPosts)
            {
                if (post.StartsWith("#"))
                {
                    postObj = new TagPost();
                }
                else if (post.StartsWith("@"))
                {
                    postObj = new MentionPost();
                }
                else 
                {
                    postObj = new Post();
                }
                
                // The issue here is that the create post will implement the code on Post but not other!
                string result = postObj.CreatePost(db, post);
                Console.WriteLine(result);
            }
        }
    }
}