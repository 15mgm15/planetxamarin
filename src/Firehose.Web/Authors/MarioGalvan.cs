using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
    public class MarioGalvan : IAmACommunityMember, IFilterMyBlogPosts
	{
		public string FirstName => "Mario";

		public string LastName => "Galvan";

		public string ShortBioOrTagLine => "Mexican mobile developer and speaker";

		public string StateOrRegion => "Colima, Mexico";

		public string EmailAddress => "15mgm15@gmail.com";

		public Uri WebSite => new Uri("http://15mgm15.blog");

		public string TwitterHandle => "MayitoGalvan";

		public string GravatarHash => "048b59cb93b83e0d2a48f1e36b788932";
		public string GitHubHandle => "15mgm15";

		public GeoPosition Position => new GeoPosition(19.2452340, -103.7240870);

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("http://15mgm15.blog/feed"); }
		}

        public string FeedLanguageCode => "en";

        public bool Filter(SyndicationItem item) =>
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin")) &&
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin.forms"));
    }
}
