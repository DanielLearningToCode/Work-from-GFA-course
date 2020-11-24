using Microsoft.EntityFrameworkCore;
using Reddit.Data;
using Reddit.Models;
using Reddit.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reddit.Services
{
    public class PostService : IPostService
    {
        private ApplicationDBContext db;

        private delegate IQueryable<Post> SortingDelegate(IQueryable<Post> posts);
        public PostService(ApplicationDBContext db)
        {
            this.db = db;
        }

        private SortingDelegate SelectSorting(string sortBy)
        {
            return sortBy == "date" ? new SortingDelegate(SortByDate) : new SortingDelegate(SortByVotes);
        }

        private IOrderedQueryable<Post> SortByDate(IQueryable<Post> posts)
        {
            return posts.OrderByDescending(p => p.CreatedDate);
        }

        private IOrderedQueryable<Post> SortByVotes(IQueryable<Post> posts)
        {
            return posts.OrderByDescending(p => p.Votes);
        }

        private IQueryable<Post> GetPosts(string author)
        {
            return author == "-" ? db.Posts.Include(p => p.User) :
                db.Posts.Include(p => p.User).Where(p => p.User.Name == author);
        }

        public List<Post> GetNextPosts(ref int page, out int pageCount, string sortBy, int postsPerPage, string author)
        {
            var posts = SelectSorting(sortBy)(GetPosts(author));  // selects sorting delegate based on sort type and calls the method referenced by the delegate        
            int postCount = posts.Count();
            //pagination
            page = (postCount / postsPerPage) == 0 ? 0 : page;
            int remainingPosts = postCount - page * postsPerPage;
            pageCount = postCount % postsPerPage > 0 ? ((postCount / postsPerPage) + 1) : (postCount / postsPerPage);
            int skip = page * postsPerPage;
            int take = remainingPosts < postsPerPage ? remainingPosts : postsPerPage;
            return posts.Skip(skip).Take(take).ToList();
        }

        public IndexViewModel CreateViewModel(int page, string sortBy, int postsPerPage, string author = "-")
        {
            List<Post> posts = GetNextPosts(ref page, out int pageCount, sortBy, postsPerPage, author);
            List<string> names = db.Users.Select(u => u.Name).ToList();
            IndexViewModel model = new IndexViewModel()
            {
                Posts = posts,
                PageCount = pageCount,
                CurrentPage = page,
                SortBy = sortBy,
                PostsPerPage = postsPerPage,
                FilteredAuthor = author
            };
            model.Names.AddRange(names);
            return model;
        }

        public void SubmitNewPost(Post post, string name)
        {
            User user = db.Users.FirstOrDefault(u => u.Name == name);
            post.User = user;
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

        public SubmitViewModel CreateSubmitViewModel()
        {
            List<string> users = db.Users.Select(u => u.Name).ToList();
            return new SubmitViewModel() { Users = users };
        }
    }
}
