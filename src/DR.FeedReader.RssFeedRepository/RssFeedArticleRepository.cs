using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml;
using AutoMapper;
using DR.FeedReader.RssFeedRepository.Contract;
using DR.FeedReader.RssFeedRepository.Model;

namespace DR.FeedReader.RssFeedRepository
{
    public class RssFeedArticleRepository : IRssFeedArticleRepository
    {
        static RssFeedArticleRepository()
        {
            Mapper.CreateMap<SyndicationItem, RssArticle>()
                .ForMember(a => a.Headline, b => b.MapFrom(c => c.Title.Text))
                .ForMember(a => a.Teaser, b => b.MapFrom(c => c.Summary.Text))
                .ForMember(a => a.ArticleUrl, b => b.MapFrom(c => c.Links.Any() ? c.Links.FirstOrDefault().Uri : null))
                .ForMember(a => a.PublicationDate, b => b.MapFrom(c => c.PublishDate.DateTime));
        }
        public IEnumerable<RssArticle> GetLatest()
        {
            var settings = new XmlReaderSettings()
            {
                DtdProcessing = DtdProcessing.Parse
            };

            using (var reader = XmlReader.Create("http://www.dr.dk/nyheder/service/feeds/allenyheder", settings))
            {
                var rssFeed = SyndicationFeed.Load(reader);
                return rssFeed.Items.Select(Mapper.Map<RssArticle>).ToList(); /* Force enumeration */
            }
        }
    }
}
