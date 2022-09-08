using Microsoft.AspNetCore.Mvc;
using apiCallsMS.Models;

namespace apiCallsMS.Controllers
{
    public class SocialmediaController : Controller
    {

        PostDataModel pObj = new PostDataModel();
        public IActionResult GetPostData()
        {           
            return View(pObj.GetPostData());
        }


    }
}
