using Reddit.Context;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public class PostService
    {
        private ApplicationDBContext db; 
        public PostService(ApplicationDBContext db)
        {
            this.db = db;
        }
        public List<Post> GetPosts()
        {
            List<Post> result = db.Posts.ToList();
            return result;
        }
        public void SubmitNewPost(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
        }
        public void UpVote(int id)
        {
            Post post = db.Posts.Find(id);
            post.Votes++;
            db.SaveChanges();
        }
        public void DownVote(int id)
        {
            Post post = db.Posts.Find(id);
            post.Votes--;
            db.SaveChanges();
        }
    }
}
