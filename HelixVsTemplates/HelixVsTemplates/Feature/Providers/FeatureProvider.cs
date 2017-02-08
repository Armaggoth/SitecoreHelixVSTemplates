using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using $ext_safeprojectname$.Models;
using $ext_safeprojectname$.Providers.Interfaces;
//TODO: add the correct reference to the Repository namespace
//using  $safeprojectname$.Foundation.SitecoreData.Providers.Interfaces;

namespace $safeprojectname$.Providers
{
    public class FeatureProvider : IFeatureProvider
    {
        //TODO: Set up the repo instance and the constructor

        //private ISitecoreRepository myRepo;
        //
        //public FeatureProvider(ISitecoreRepository repository)
        //{
        //    this.myRepo = repository;
        //}

        public FeatureContent LoadFeature(Guid id)
        {
            //TODO: Set the call to the repo to get the data
            //return this.myRepo.FindById<FeatureContent>(id);
            return new FeatureContent();
        }
    }
}