using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
