using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace $safeprojectname$.Models
{
    public class FeatureContent
    {
        public virtual string Title { get; set; }
        public virtual string Introduction { get; set; }
        public virtual IEnumerable<Tag> Tags { get; set; }
        public virtual string Author { get; set; }
        public virtual DateTime PublishDate { get; set; }
        public virtual bool DisplayByline { get; set; }
        public virtual Image Thumbnail { get; set; }

        [SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get; set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        public virtual string Name { get; set; }

        [SitecoreInfo(SitecoreInfoType.ContentPath)]
        public virtual string ContentPath { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; set; }

        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        public virtual string DisplayName { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        public virtual string TemplateName { get; set; }

        [SitecoreField(FieldName = "__Renderers")]
        public virtual string RendererId { get; set; }
    }
}