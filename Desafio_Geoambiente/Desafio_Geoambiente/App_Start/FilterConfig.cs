using System.Web;
using System.Web.Mvc;

namespace Desafio_Geoambiente
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}