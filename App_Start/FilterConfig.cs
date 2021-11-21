using System.Web;
using System.Web.Mvc;

namespace DA_Nro11_SesionExternoGoogle
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
