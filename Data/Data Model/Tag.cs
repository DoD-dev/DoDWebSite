using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Data_Model
{
    public class Tag
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string UrlSlug { get; set; }
		public bool IsHidden { get; set; }
		public int QueuePriority { get; set; }
		public int TotalPostCount { get; set; }
		public bool OnTop { get; set; }
		public DateTime? CreatedOrModifiedOn { get; set; }
	}
}
