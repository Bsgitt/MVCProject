namespace Introduticon.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class ContactController : Controller
    {

        public IActionResult Index()
        {
            var contact =("Bio@cc.co.th tel 090-000-0000","Myskill : Front end : React.js,svelte.js,Vue.js");
            ViewData["contact"] = contact.Item1+" "+contact.Item2;
            return View();
        }
        public IActionResult Elon()
        {
            return View();
        }

    }
}