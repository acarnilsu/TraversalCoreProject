using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _PopularDestinations:ViewComponent
    {

        public IViewComponentResult Invoke()
        {    
            return View();
        }
    }
}
