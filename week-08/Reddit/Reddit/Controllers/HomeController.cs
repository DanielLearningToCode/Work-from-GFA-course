using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Models;
using Reddit.Services;

namespace Reddit.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private PostService postService;
        public HomeController(PostService postService)
        {
            this.postService = postService;
        }

        [HttpGet("")]
        public IActionResult Index(int page, bool sortByDate, int postsPerPage = 5)
        {
            return View(postService.CreateViewModel(page, sortByDate, postsPerPage));
        }

        [HttpGet("SubmitNew")]
        public IActionResult SubmitNew()
        {
            return View(postService.CreateSubmitViewModel());
        }

        [HttpPost("SubmitNew")]
        public IActionResult SubmitNew(Post post, string name)
        {
            postService.SubmitNewPost(post, name);
            return RedirectToAction("Index");
        }

        [HttpGet("{id}/UpVote")]
        public IActionResult UpVote([FromRoute]int id, int page, bool sortByDate, int postsPerPage = 5)
        {
            postService.UpVote(id);
            return RedirectToAction("Index", new { page = page, sortByDate = sortByDate, postsPerPage = postsPerPage });
        }

        [HttpGet("{id}/DownVote")]
        public IActionResult DownVote([FromRoute]int id, int page, bool sortByDate, int postsPerPage = 5)
        {
            postService.DownVote(id);
            return RedirectToAction("Index", new { page = page, sortByDate = sortByDate, postsPerPage = postsPerPage });
        }
        /*[HttpGet("SortByDate")]
        public IActionResult SortByDate(int page, bool sortByDate)
        {
            return RedirectToAction("Index", new { page = page, sortByDate = sortByDate });
        }
*/
        [HttpGet("FilterByUser")]
        public IActionResult FilterByUser(int page, bool sortByDate, int postsPerPage = 5, string author = "")
        {

            return RedirectToAction("Index", new { page = page, sortByDate = sortByDate, postsPerPage = postsPerPage, author = author });
        }

    }
}