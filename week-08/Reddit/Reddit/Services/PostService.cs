﻿using Microsoft.EntityFrameworkCore;
using Reddit.Context;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reddit.Services
{
    public class PostService
    {
        private ApplicationDBContext db;
     
        public delegate List<Post> SortingDelegate();
       // public SortingDelegate GetSortedPosts;
        public PostService(ApplicationDBContext db)
        {
            this.db = db;
        }

        public SortingDelegate SelectSorting(bool sortByDate)
        {
            /*    if (sortByDate)
                {
                    return GetSortedPosts = SortByDate;
                }
                 return GetSortedPosts = SortByVotes;
            */
            return sortByDate ? new SortingDelegate(SortByDate) : new SortingDelegate(SortByVotes);
                
        }

        public List<Post> SortByDate()
        {
            var sortedPosts = GetPosts().OrderByDescending(p => p.CreatedDate).ToList();
            return sortedPosts;
        }
        public List<Post> SortByVotes()
        {
            var sortedPosts = GetPosts().OrderByDescending(p => p.Votes).ToList();
            return sortedPosts;
        }

        public List<Post> GetPosts()
        {
            List<Post> result = db.Posts.Include(p => p.User).ToList();
            return result;
        }
/*        public List<Post> GetSortedPosts()
        {
            var sortedPosts = GetPosts().OrderByDescending(p => p.Votes).ToList();
            return sortedPosts;
        }*/

        public List<Post> GetNextPosts(int page, out int pageCount, bool sortByDate, int postsPerPage)
        {
            List<Post> result = new List<Post>();
            //GetSortedPosts = SelectSorting(sortByDate);
            List<Post> posts = SelectSorting(sortByDate)();
            int postCount = posts.Count;
            
            int remainingPosts = postCount - page * postsPerPage;
            pageCount = postCount % postsPerPage > 0 ? ((postCount / postsPerPage) + 1) : (postCount / postsPerPage);
            int skip = page * postsPerPage;
            int take = remainingPosts < postsPerPage ? remainingPosts : postsPerPage;
            result = posts.Skip(skip).Take(take).ToList();
            return result;
        }

        internal void FilterByUser(string author)
        {
            throw new NotImplementedException();
        }

        public IndexViewModel CreateViewModel(int page, bool sortByDate, int postsPerPage)
        {
            List<Post> posts = GetNextPosts(page, out int pageCount, sortByDate, postsPerPage);
            List<string> names = db.Users.Select(u => u.Name).ToList();
            IndexViewModel model = new IndexViewModel() { Posts = posts, PageCount = pageCount, CurrentPage = page, SortByDate = sortByDate, Names = names, PostsPerPage = postsPerPage};
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
