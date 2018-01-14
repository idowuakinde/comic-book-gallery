using System;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ContentResult Detail()
        {
            return new ContentResult() 
            { 
                Content = "Hello World, from the Comic Books controller!" 
            };
        }
    }
}
