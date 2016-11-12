using System.Web.Routing;
using Nop.Core.Plugins;
using Nop.Services.Common;

namespace SPC.Nop.Plugin.VirtualDirectoryFix
{
    public class PluginSettings  : BasePlugin, IMiscPlugin
    {

        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "Configuration";
            routeValues = new RouteValueDictionary { { "Namespaces", "SPC.Nop.Plugin.VirtualDirectoryFix.Controllers" }, { "area", null } };
        }
    }
}
