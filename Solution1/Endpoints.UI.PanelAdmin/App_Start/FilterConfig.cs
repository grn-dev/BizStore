using System.Web;
using System.Web.Mvc;

namespace Endpoints.UI.PanelAdmin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
