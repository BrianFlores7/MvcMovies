using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class SeriesGenreViewModel
    {
        public List<Series>? Series { get; set; }
        public SelectList? Genres { get; set; }
        public string? SeriesGenre { get; set; }
        public string? SearchString { get; set; }
    }
}