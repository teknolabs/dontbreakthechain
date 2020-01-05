using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeknoLabs.DontBreakTheChain.WebUI.ViewComponents
{
    public class RightMenuViewComponent : ViewComponent
    {
        public RightMenuViewComponent()
        {

        }

        public ViewViewComponentResult Invoke()
        {
            return View();
        }
    }
}
