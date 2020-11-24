using Reddit.Models;
using Reddit.ViewModels;
using System.Collections.Generic;

namespace Reddit.Services
{
    public interface IPostService
    {
        SubmitViewModel CreateSubmitViewModel();
        IndexViewModel CreateViewModel(int page, string sortBy, int postsPerPage, string author = "-");
        void DownVote(int id);
        List<Post> GetNextPosts(ref int page, out int pageCount, string sortBy, int postsPerPage, string author);
        void SubmitNewPost(Post post, string name);
        void UpVote(int id);
    }
}