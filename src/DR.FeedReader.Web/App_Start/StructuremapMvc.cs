using System.Web.Mvc;
using DR.FeedReader.Web.App_Start;
using DR.FeedReader.Web.DependencyResolution;
using StructureMap;
using WebActivator;

[assembly: PreApplicationStartMethod(typeof (StructuremapMvc), "Start")]

namespace DR.FeedReader.Web.App_Start
{
    public static class StructuremapMvc
    {
        public static void Start()
        {
            var container = IoC.Initialize();
            DependencyResolver.SetResolver(new SmDependencyResolver(container));
        }
    }
}