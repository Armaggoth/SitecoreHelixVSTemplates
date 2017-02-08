using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using $ext_safeprojectname$.Providers;
using $ext_safeprojectname$.Providers.Interfaces;
//TODO: add the correct reference to the Repository namespace
//using  $ext_safeprojectname$.Foundation.SitecoreData.Providers.Interfaces;

namespace $safeprojectname$.Controllers
{
    public class FeatureController : Controller
    {
        private IFeatureProvider myFeatureProvider;

        public FeatureController(IFeatureProvider provider)
        {
            //TODO: Setup IoC
            this.myFeatureProvider = provider;
        }

        public ActionResult Feature()
        {
            var model = this.myFeatureProvider.LoadFeature(Sitecore.Context.Item.ID.ToGuid());

            return View("~/Views/Feature.cshtml", model);
        }
    }
}