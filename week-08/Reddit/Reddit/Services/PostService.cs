using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public List<Post> GetSortedPosts()
        {
            var sortedPosts = GetPosts().OrderByDescending(p => p.Votes).ToList();
            return sortedPosts;
        }

        /* public KeyValuePair<int, List<Post>> GetNextPosts(int? page)
         {
             var posts = GetSortedPosts();
             int postsPerPage = 5;
             int totalPosts = posts.Count;
             // logika abych necetl dal nez je prvku, staci tlacitko next a zpet
             int skip = (int)page * postsPerPage;
             var selection = posts.Skip(skip * postsPerPage).Take(postsPerPage).ToList();
             KeyValuePair<int, List<Post>> result = new KeyValuePair<int, List<Post>>((int)page, selection);
             return result;
         }*/
        public List<Post> GetNextPosts(int page, out int pageCount)
        {
            List<Post> result = new List<Post>();
            var posts = GetSortedPosts();
            int postCount = posts.Count;
            int postsPerPage = 5;
            int remainingPosts = postCount - page * postsPerPage;
            pageCount = postCount % postsPerPage > 0 ? ((postCount / postsPerPage) + 1) : (postCount / postsPerPage);  
            int skip = page * postsPerPage;
            int take = remainingPosts < postsPerPage ? remainingPosts : postsPerPage;
            result = posts.Skip(skip).Take(take).ToList();
            return result;
        }
        public IndexViewModel CreateViewModel(int page)
        {
            List<Post> posts = GetNextPosts(page, out int pageCount);
            IndexViewModel model = new IndexViewModel() { Posts = posts, PageCount = pageCount, CurrentPage = page };
            return model;
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
