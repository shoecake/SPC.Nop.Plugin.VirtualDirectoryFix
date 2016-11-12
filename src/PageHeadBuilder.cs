using System.Web.Optimization;
using Autofac;
using Nop.Core.Configuration;
using Nop.Core.Domain.Seo;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Web.Framework.UI;


// added to fix relative image path issue in css bundling - virtual directory

namespace SPC.Nop.Plugin.VirtualDirectoryFix
{
    public class SPCPageHeadBuilder : PageHeadBuilder
    {


        public SPCPageHeadBuilder(SeoSettings seoSettings) : base(seoSettings)
        {
        }

        protected override IItemTransform GetCssTranform()
        {
            return new CssRewriteUrlTransformFixed();

        }


    }


    public class DependencyRegistrar : IDependencyRegistrar
    {

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            builder.RegisterType<SPCPageHeadBuilder>().As<IPageHeadBuilder>().InstancePerLifetimeScope();
        }

        private int IDependencyRegistrar_Order
        {
            get { return 10; }
        }
        int IDependencyRegistrar.Order
        {
            get { return IDependencyRegistrar_Order; }
        }
    }

}
