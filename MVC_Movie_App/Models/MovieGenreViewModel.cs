using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;


namespace MVC_Movie_App.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> movies;
        public SelectList genres;
        public string movieGenre { get; set; }
    }
}