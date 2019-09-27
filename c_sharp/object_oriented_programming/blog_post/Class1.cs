using System;
using System.Collections.Generic;
using System.Text;

namespace blog_post
{
	class BlogPost
	{
		public string Author { get; set; }
		public string Title { get; set; }
		public string BlogText { get; set; }
		public string PubDate { get; set; }

		public BlogPost(String author, String title, string blogText, string pubDate)
		{
			this.Author = author;
			this.Title = title;
			this.BlogText = blogText;
			this.PubDate = pubDate;
		}
	}
}
