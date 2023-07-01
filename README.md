# CustomSwitchLinkManager-Sitecore91
A Custom Switch Link Provider for Multisite setup in Sitecore 9.1

## PreRequisites
1. Sitecore 9.1 with multisite setup in local
2. Developer workstation to validate the solution
3. Link Provider for each site. Example: (name="mySite1LinkProvider" type="MySite1.Foundation.Multisite.Links.MySite1LinkProvider, MySite1.Foundation.Multisite"). Where, MySite1.Foundation.Multisite.Links.MySite1LinkProvider contains the defination for link provider created for Site 1.

## Setup
1. Take backup of webroot\bin and webroot\App_Config
2. Clone the repository CustomSwitchLinkManager-Sitecore91 (https://github.com/ravindra-mishra/CustomSwitchLinkManager-Sitecore91)
3. Build the solution
4. Copy the DailySitecore.SwitchLinkManager.dll to your webroot\bin
#### Step 1: Update your Site Definition Config -
5. Add **linkProvider** attribute and assign respective value in the Site Config file of every site. Example: linkProvider="mySite1LinkProvider" ([MySite1.Project.PublicSite.Site.config](https://github.com/ravindra-mishra/CustomSwitchLinkManager-Sitecore91/blob/master/DailySitecore.SwitchLinkManager/App_Config/Include/MySite1/PublicSite/MySite1.Project.PublicSite.Site.config))
#### Step 2: Changes in LinkManager config ([DailySitecore.SwitchLinkManager.config](https://github.com/ravindra-mishra/CustomSwitchLinkManager-Sitecore91/blob/master/DailySitecore.SwitchLinkManager/App_Config/Include/SwitchLinkManager/DailySitecore.SwitchLinkManager.config))-
6. Update the name and type values in place of site1LinkProvider and site2LinkProvider according to your sites and link provider type. You can add more link provider if needed.
7. Keep **switcherLinkProvider** at last and as a default provider. Example: <patch:attribute name="defaultProvider">switcherLinkProvider</patch:attribute>
8. Set fallback provider. Example: <patch:attribute name="fallbackProvider">sitecore</patch:attribute>
9. Copy the DailySitecore.SwitchLinkManager.config to your webroot\App_Config\Include\SwitchLinkManager folder
10. Verify it by browsing your sites. Now, you will notice that switcherLinkProvider resolves the link provider based on context site.

# Exploring More Sitecore Insights
## Perficient Blog Post 
https://blogs.perficient.com/author/rmishra/
1. Add PowerShell Script to the Context Menu in Sitecore SXA - https://blogs.perficient.com/2022/09/30/add-powershell-script-to-the-context-menu-in-sitecore-sxa/
2. Submit Action to Save Contacts in List Manager – Basic Implementation - https://blogs.perficient.com/2023/05/13/submit-action-to-save-contacts-in-list-manager-basic-implementation/
3. Submit Action to Save Contacts in List Manager with Fields Mapping - https://blogs.perficient.com/2023/06/01/submit-action-to-save-contacts-in-list-manager-with-fields-mapping-part-1/

## Personal Sitecore Blog
https://dailysitecore.blogspot.com/

1. A Custom Switch Link Provider for Multisite setup in Sitecore 9.1 -
  https://dailysitecore.blogspot.com/2022/06/a-custom-switch-link-provider-for.html
2. Rewrite rule to convert URLs to small letters and removing spaces -
  https://dailysitecore.blogspot.com/2022/06/rewrite-rule-to-convert-urls-to-small.html
3. Get droplink value of rendering parameter using scriban in Sitecore - 
  https://dailysitecore.blogspot.com/2022/08/get-droplink-value-of-rendering-parameter-using-scriban.html
