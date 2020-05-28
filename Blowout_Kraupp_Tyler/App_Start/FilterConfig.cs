using System.Web;
using System.Web.Mvc;

namespace Blowout_Kraupp_Tyler
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
