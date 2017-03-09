using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        //models can contain attributes (defined by properties) and behaviors
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        //will contain HTML formatted content
        public string DescriptionHtml { get; set; }
        //artist data moved into Artist model. Separates presentation of data from the data itself
        public Artist[] Artists { get; set; }
        public bool Favorites { get; set; }
        }
    }