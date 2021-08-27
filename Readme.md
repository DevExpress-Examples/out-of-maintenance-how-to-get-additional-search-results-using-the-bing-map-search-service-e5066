<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576452/13.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5066)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/GetSearchLocationAdditionalInfo/Form1.cs) (VB: [Form1.vb](./VB/GetSearchLocationAdditionalInfo/Form1.vb))
<!-- default file list end -->
# How to get additional search results using the Bing Map Search service


<p>This example demonstrates how to provide the capability for end-users to search for location and keywords using the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic"><u>BingSearchDataProvider.Search</u></a> method.</p>
<p>In this example, the built-in Search panel is disabled (the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_ShowSearchPaneltopic"><u>BingSearchDataProvider.ShowSearchPanel</u></a> property is set to <strong>false</strong>), because a custom panel is used instead.</p>
<p>To start search, specify search parameters (location and a keyword) in the custom Search panel and click the Search button. All search parameters are passed to the <strong>Search</strong> method and you can see the result in the rich text box element.</p>
<p>The results contain a display name, and address associated with the search location. In addition, the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchRequestResult_AlternateSearchRegionstopic"><u>SearchRequestResult.AlternateSearchRegions</u></a> property returns results of searching for alternate regions.</p>
<p>Note that if you run this sample as is, you will get a warning message saying that the specified Bing Maps key is invalid. To learn how to register a Bing Maps account and create a key for it, refer to the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument15102"><u>How to: Get a Bing Maps Key</u></a><u> </u>tutorial.</p>

<br/>


