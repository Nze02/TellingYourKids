using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TellingYourKids.Contracts;
using TellingYourKids.Models;
using TellingYourKids.Models.PostDtos;

namespace TellingYourKids.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;


        //private readonly ILogger<HomeController> _logger;

        public HomeController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }


        //Runs and populates the index screen
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var posts = await _repository.Post.GetAllApprovedPostsAsync(trackChanges: false);
            var postsDto = _mapper.Map<IEnumerable<PostOutputDto>>(posts);

            return View(postsDto);
        }





        [HttpGet("{id}", Name = "PostById")]
        public async Task<IActionResult> GetById(int id)
        {

            var post = await _repository.Post.GetPostAsync(id, trackChanges: false);
            if (post == null)
            {
                _logger.LogInfo($"Post with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var postDto = _mapper.Map<PostOutputDto>(post);
                return Ok(postDto);
            }

        }

        [HttpGet]
        public IActionResult add_story()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> add_story([FromBody] PostInputDto post)
        {
            if (post == null)
                return BadRequest();

            var postEntity = _mapper.Map<Post>(post);
            _repository.Post.CreatePost(postEntity);
            await _repository.SaveAsync();

            return View();
        }



        public async Task<IActionResult> admin_dashboard()
        {
            var posts = await _repository.Post.GetAllApprovedPostsAsync(trackChanges: false);
            var postsDto = _mapper.Map<IEnumerable<PostOutputDto>>(posts);

            return View(postsDto);
        }

        public async Task<IActionResult> admin_dashboard_newentry()
        {
            var posts = await _repository.Post.GetAllUnApprovedPostsAsync(trackChanges: false);
            var postsDto = _mapper.Map<IEnumerable<PostOutputDto>>(posts);

            return View(postsDto);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        
        public IActionResult About()
        {
            return View();
        }
        
           public IActionResult login()
        {
            return View();
        }

        public IActionResult admin_signup()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
