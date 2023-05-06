using System.Web;
using System.Xml;
using Sitecore.Configuration;
using Sitecore.Data.Items;
using Sitecore.DependencyInjection;
using Sitecore.Links;
using Sitecore.Web;

namespace DailySitecore.SwitchLinkManager.Links
{
    public class SwitchLinkProvider : LinkProvider
    {
        private string _fallbackProvider;

        public SwitchLinkProvider()
        {
            XmlNode linkManagerNode = Factory.GetConfigNode("linkManager");
            _fallbackProvider = linkManagerNode.Attributes["fallbackProvider"].Value;
        }

        private LinkProvider GetContextProvider()
        {
            var providerHelper = ServiceLocator.GetRequiredResetableService<Sitecore.Configuration.ProviderHelper<LinkProvider, LinkProviderCollection>>();
            var providerName = Sitecore.Context.Site.Properties["linkProvider"];
            return !string.IsNullOrEmpty(providerName) ? providerHelper?.Value?.Providers[providerName] : providerHelper?.Value?.Providers[_fallbackProvider];
        }

        public override bool AddAspxExtension
        {
            get { return GetContextProvider().AddAspxExtension; }
        }

        public override bool AlwaysIncludeServerUrl
        {
            get { return GetContextProvider().AlwaysIncludeServerUrl; }
        }

        public override bool EncodeNames
        {
            get { return GetContextProvider().EncodeNames; }
        }

        public override LanguageEmbedding LanguageEmbedding
        {
            get { return GetContextProvider().LanguageEmbedding; }
        }

        public override LanguageLocation LanguageLocation
        {
            get { return GetContextProvider().LanguageLocation; }
        }

        public override bool LowercaseUrls
        {
            get { return GetContextProvider().LowercaseUrls; }
        }

        public override bool ShortenUrls
        {
            get { return GetContextProvider().ShortenUrls; }
        }

        public override bool UseDisplayName
        {
            get { return GetContextProvider().UseDisplayName; }
        }

        public override string ExpandDynamicLinks(string text, bool resolveSites)
        {
            return GetContextProvider().ExpandDynamicLinks(text, resolveSites);
        }

        public override UrlOptions GetDefaultUrlOptions()
        {
            return GetContextProvider().GetDefaultUrlOptions();
        }

        public override string GetDynamicUrl(Item item, LinkUrlOptions options)
        {
            return GetContextProvider().GetDynamicUrl(item, options);
        }

        public override string GetItemUrl(Item item, UrlOptions options)
        {
            return GetContextProvider().GetItemUrl(item, options);
        }

        public override bool IsDynamicLink(string linkText)
        {
            return GetContextProvider().IsDynamicLink(linkText);
        }

        public override DynamicLink ParseDynamicLink(string linkText)
        {
            return GetContextProvider().ParseDynamicLink(linkText);
        }

        public override RequestUrl ParseRequestUrl(HttpRequest request)
        {
            return GetContextProvider().ParseRequestUrl(request);
        }
    }
}