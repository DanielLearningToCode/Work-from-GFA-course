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
        public IActionResult Index(int page)
        {
            return View(postService.CreateViewModel(page));
        }
        
        [HttpGet("SubmitNew")]
        public IActionResult SubmitNew()
        {
            return View();
        }

        [HttpPost("SubmitNew")]
        public IActionResult SubmitNew(Post post)
        {
            postService.SubmitNewPost(post);
            return RedirectToAction("Index");
        }

        [HttpGet("{id}/UpVote")]
        public IActionResult UpVote([FromRoute]int id, int currentPage)
        {
            postService.UpVote(id);
            return RedirectToAction("Index", new { page = currentPage });
        }

        [HttpGet("{id}/DownVote")]
        public IActionResult DownVote([FromRoute]int id, int currentPage)
        {
            postService.DownVote(id);
            return RedirectToAction("Index", new { page = currentPage });
        }
    }
}