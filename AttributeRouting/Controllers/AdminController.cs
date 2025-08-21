using Microsoft.AspNetCore.Mvc;

namespace AttributeRouting.Controllers
{
    [Route("News/[controller]/USA/[Action]/{id:int}")]
    public class AdminController : Controller
    {
        
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
