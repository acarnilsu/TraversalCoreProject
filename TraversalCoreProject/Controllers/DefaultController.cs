using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class DefaultController : Controller
    {
        FeatureManager _featureManager = new FeatureManager(new EfFeatureDal());

        public IActionResult Index()
        {
            var values = _featureManager.TGetList();
            return View(values);
        }
    }
}
