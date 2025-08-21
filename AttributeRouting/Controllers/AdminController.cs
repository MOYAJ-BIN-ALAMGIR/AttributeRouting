using Microsoft.AspNetCore.Mvc;

namespace AttributeRouting.Controllers
{
    public class AdminController : Controller
    {
        [Route("[controller]/CallMe")]
        public string Index()
        {
            return "'Admin' Controller, 'Index' View";
        }

        public string List()
        {
            return "'Admin' Controller, 'List' View";
        }
    }
}
