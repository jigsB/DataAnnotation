using System.Web;
using System.Web.Mvc;

namespace MVCPracticeDataAnnotations
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
