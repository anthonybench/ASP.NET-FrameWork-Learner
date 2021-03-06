﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int ID { get; set;  }
        public Series Series { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            get
            {
                return Series.Title + " #" + IssueNumber;
            }
        }

        // series-title-issuenumber.jpg
        public string CoverImageFileName
        {
            get
            {
                return Series.Title.Replace(" ", "-").ToLower()
                    + "-" + IssueNumber + ".jpg";
            }
        }
    }
}