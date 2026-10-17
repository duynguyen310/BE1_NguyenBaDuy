using System.Web;
using System.Web.Mvc;

namespace BE1_NguyenBaDuy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
