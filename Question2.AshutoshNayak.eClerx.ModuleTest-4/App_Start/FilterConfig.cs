using System.Web;
using System.Web.Mvc;

namespace Question2.AshutoshNayak.eClerx.ModuleTest_4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
