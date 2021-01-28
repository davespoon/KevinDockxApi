using System;
using System.Collections.Generic;
using KevinDockx.API.Entities;
using KevinDockx.API.Helpers;
using KevinDockx.API.ResourceParameters;

namespace KevinDockx.API.Services
{
    public interface ICourseLibraryRepository
    {
        IEnumerable<Course> GetCourses(Guid authorId);
        Course GetCourse(Guid authorId, Guid courseId);
        void AddCourse(Guid authorId, Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(Course course);
        IEnumerable<Author> GetAuthors();
        PagedList<Author> GetAuthors(AuthorsResourceParameters authorsResourceParameters);
        Author GetAuthor(Guid authorId);
        IEnumerable<Author> GetAuthors(IEnumerable<Guid> authorIds);
        void AddAuthor(Author author);
        void DeleteAuthor(Author author);
        void UpdateAuthor(Author author);
        bool AuthorExists(Guid authorId);
        bool Save();
    }
}