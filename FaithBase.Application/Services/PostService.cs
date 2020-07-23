using System;
using FaithBase.Application.Helpers;
using FaithBase.Application.Interfaces;
using FaithBase.Application.Models.Post;
using FaithBase.Domain.Entities;
using Microsoft.AspNetCore.Hosting;

namespace FaithBase.Application.Services
{
    public class PostService : IPostService
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public PostService(IWebHostEnvironment hostEnvironment)
        {
            webHostEnvironment = hostEnvironment;
        }

        public void AddPost(PostInputModel model)
        {
            string uniqueFileName = FileUploadHelper.ImageUploader(model.PostImage, webHostEnvironment);
  
                Post post = new Post
                {  
                    Title = model.Title,
                    Summary = model.Summary,
                    Content = model.Content,
                    IsPublished = model.IsPublished,
                    PostImage = uniqueFileName,
                    Slug = FriendlyUrlHelper.GetFriendlyTitle(model.Title)
                };

                // add PostRepository here
                // dbContext.Add(employee);
                // await dbContext.SaveChangesAsync();
        }
    }
}