using System.Web.Optimization;

namespace Mvc.Spa.AngularJS
{
	public class BundleConfig
	{
		// 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
						"~/Scripts/angularJS/angular.js",
						"~/Scripts/angularJS/angular-*",
						"~/Scripts/angularJS/i18n/angular-*"));

			bundles.Add(new ScriptBundle("~/bundles/angularui").Include(
						"~/Scripts/angular-ui/angular-ui-*",
						"~/Scripts/angular-ui/ui-*"));

			bundles.Add(new ScriptBundle("~/bundles/app")
					.Include("~/app/app.js")
					.IncludeDirectory("~/app/controllers", "*.js"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css",
					  "~/Content/Site.css"));
		}
	}
}