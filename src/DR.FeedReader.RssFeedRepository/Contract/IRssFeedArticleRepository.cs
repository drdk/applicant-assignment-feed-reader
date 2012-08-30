using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.FeedReader.RssFeedRepository.Model;

namespace DR.FeedReader.RssFeedRepository.Contract
{
    public interface IRssFeedArticleRepository
    {
        IEnumerable<RssArticle> GetLatest();
    }
}
