using DR.FeedReader.RssFeedRepository;
using DR.FeedReader.RssFeedRepository.Contract;
using StructureMap;

namespace DR.FeedReader.Web.DependencyResolution
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            ObjectFactory.Initialize(a =>
                                         {
                                             a.For<IRssFeedArticleRepository>().Use<RssFeedArticleRepository>();
                                         });

            return ObjectFactory.Container;
        }
    }
}