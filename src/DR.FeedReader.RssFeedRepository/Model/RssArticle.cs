using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DR.FeedReader.RssFeedRepository.Model
{
    public class RssArticle
    {
        public string Headline { get; set; }
        public string Teaser { get; set; }
        public Uri ArticleUrl { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
