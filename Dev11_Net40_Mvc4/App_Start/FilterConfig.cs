using System.Web;
using System.Web.Mvc;

namespace Dev11_Net40_Mvc4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}