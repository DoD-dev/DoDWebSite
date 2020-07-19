using Dapper.Contrib.Extensions;
using Data.Data_Model;
using System;
using System.Collections.Generic;

namespace Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string HeaderImage { get; set; }
        public string PostContent { get; set; }
        public bool IsHidden { get; set; }
        public int QueuePriority { get; set; }
        public bool Ontop { get; set; }
        public string UrlSlug { get; set; }
        public string AuditLog { get; set; }
        public DateTime? CreatedOrModifiedOn { get; set; }
        public DateTime? PublishedOn { get; set; }
    }
}
