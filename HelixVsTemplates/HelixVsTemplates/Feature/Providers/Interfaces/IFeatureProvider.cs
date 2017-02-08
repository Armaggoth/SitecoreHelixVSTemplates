using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using $ext_safeprojectname$.Models;

namespace $ext_safeprojectname$.Providers.Interfaces
{
    public interface IFeatureProvider
    {
        FeatureContent LoadFeature(Guid id);
    }
}