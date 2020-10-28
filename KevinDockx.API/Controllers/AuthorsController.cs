using System;
using System.Collections.Generic;
using KevinDockx.API.Helpers;
using KevinDockx.API.Models;
using KevinDockx.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace KevinDockx.API.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorsController : ControllerBase
    {
        private readonly ICourseLibraryRepository _courseLibraryRepository;

        public AuthorsController(ICourseLibraryRepository courseLibraryRepository)
        {
            _courseLibraryRepository = courseLibraryRepository ??
                                       throw new ArgumentNullException(nameof(CourseLibraryRepository));
        }

        [HttpGet]
        public ActionResult<IEnumerable<AuthorDto>> GetAuthors()
        {
            var authorsFromRepo = _courseLibraryRepository.GetAuthors();
            var authors = new List<AuthorDto>();

            foreach (var author in authorsFromRepo)
            {
                authors.Add(new AuthorDto
                {
                    Id = author.Id,
                    MainCategory = author.MainCategory,
                    Name = $"{author.FirstName} {author.LastName}",
                    Age = author.DateOfBirth.GetCurrentAge()
                });
            }

            return Ok(authors);
        }

        [HttpGet("{authorId:guid}")]
        public IActionResult GetAuthor(Guid authorId)
        {
            var authorFromRepo = _courseLibraryRepository.GetAuthor(authorId);

            if (authorFromRepo == null)
            {
                return NotFound();
            }

            return Ok(authorFromRepo);
        }
    }
}