using Microsoft.AspNetCore.Mvc;
using Reddit.Models;
using Reddit.Services;

namespace Reddit.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private IPostService postService;
        public HomeController(IPostService postService)
        {
            this.postService = postService;
        }

        [HttpGet("")]
        public IActionResult Index(int page = 0, string sortBy = "date", int postsPerPage = 5, string author = "-")
        {
            return View(postService.CreateViewModel(page, sortBy, postsPerPage, author));
        }

        [HttpGet("SubmitNew")]
        public IActionResult SubmitNew()
        {
            return View(postService.CreateSubmitViewModel());
        }

        [HttpPost("SubmitNew")]
        public IActionResult SubmitNew([FromForm] Post post, string name)
        {
            postService.SubmitNewPost(post, name);
            return RedirectToAction("Index");
        }

        [HttpGet("{id}/UpVote")]
        public IActionResult UpVote([FromRoute] int id, int page, string sortBy, int postsPerPage = 5, string author = "-")
        {
            postService.UpVote(id);
            return RedirectToAction("Index", new { page, sortBy, postsPerPage, author });
        }

        [HttpGet("{id}/DownVote")]
        public IActionResult DownVote([FromRoute] int id, int page, string sortBy, int postsPerPage = 5, string author = "-")
        {
            postService.DownVote(id);
            return RedirectToAction("Index", new { page, sortBy, postsPerPage, author });
        }

        [HttpPost("FilterByUser")]
        public IActionResult FilterByUser(int page, string sortBy, int postsPerPage = 5, string author = "-")
        {
            return RedirectToAction("Index", new { page, sortBy, postsPerPage, author });
        }
    }
}