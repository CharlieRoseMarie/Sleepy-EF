using System.Web.Http;
using Microsoft.AspNet.OData.Builder;

namespace SleepyEF.EntityFrameworkCore.Dynamics.Config
{
    public class WebApiConfig
    {
        public void Register(HttpConfiguration config)
        {
            var builder = new ODataConventionModelBuilder();
        }
    }
}
