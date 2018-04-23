' Developer Express Code Central Example:
' How to get additional search results using the Bing Map Search service
' 
' This example demonstrates how to provide search for location and keywords using
' the BingSearchDataProvider.Search
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic)
' method. In this example, the built-in Search panel is disabled (the
' BingSearchDataProvider.ShowSearchPanel
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_ShowSearchPaneltopic)
' property is set to false), because a custom panel is used instead. To start
' search, specify search parameters (location and a keyword) in the custom Search
' panel and click the Search button. All search parameters are passed to the
' Search method and you can see the result in the rich text box element. The
' results contain a display name, and address associated with the search location.
' In addition, the SearchRequestResult.AlternateSearchRegions
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchRequestResult_AlternateSearchRegionstopic)
' property returns results of searching for alternate regions. Note that if you
' run this sample as is, you will get a warning message saying that the specified
' Bing Maps key is invalid. To learn how to register a Bing Maps account and
' create a key for it, refer to the How to: Get a Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5066

' Developer Express Code Central Example:
' How to get additional search results using the Bing Map Search service
' 
' This example demonstrates how to provide search for location and keywords using
' the BingSearchDataProvider.Search
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic)
' method. In this example, the built-in Search panel is disabled (the
' BingSearchDataProvider.ShowSearchPanel
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_ShowSearchPaneltopic)
' property is set to false), because a custom panel is used instead. To start
' search, specify search parameters (location and a keyword) in the custom Search
' panel and click the Search button. All search parameters are passed to the
' Search method and you can see the result in the rich text box element. The
' results contain a display name, and address associated with the search location.
' In addition, the SearchRequestResult.AlternateSearchRegions
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchRequestResult_AlternateSearchRegionstopic)
' property returns results of searching for alternate regions. Note that if you
' run this sample as is, you will get a warning message saying that the specified
' Bing Maps key is invalid. To learn how to register a Bing Maps account and
' create a key for it, refer to the How to: Get a Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5066

' Developer Express Code Central Example:
' How to get additional search results using the Bing Map Search service
' 
' This example demonstrates how to provide search for location and keywords using
' the BingSearchDataProvider.Search
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic)
' method. In this example, the built-in Search panel is disabled (the
' BingSearchDataProvider.ShowSearchPanel
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_ShowSearchPaneltopic)
' property is set to false), because a custom panel is used instead. To start
' search, specify search parameters (location and a keyword) in the custom Search
' panel and click the Search button. All search parameters are passed to the
' Search method and you can see the result in the rich text box element. The
' results contain a display name, and address associated with the search location.
' In addition, the SearchRequestResult.AlternateSearchRegions
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchRequestResult_AlternateSearchRegionstopic)
' property returns results of searching for alternate regions. Note that if you
' run this sample as is, you will get a warning message saying that the specified
' Bing Maps key is invalid. To learn how to register a Bing Maps account and
' create a key for it, refer to the How to: Get a Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5066

' Developer Express Code Central Example:
' How to get additional search results using the Bing Map Search service
' 
' This example demonstrates how to provide search for location and keywords using
' the BingSearchDataProvider.Search
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic)
' method. In this example, the built-in Search panel is disabled (the
' BingSearchDataProvider.ShowSearchPanel
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_ShowSearchPaneltopic)
' property is set to false), because a custom panel is used instead. To start
' search, specify search parameters (location and a keyword) in the custom Search
' panel and click the Search button. This handles the search_Click event and all
' search parameters are passed to the Search method and you can see the result in
' the rich text box element. The results contain a display name, and address
' associated with the search location. In addition, the
' SearchRequestResult.AlternateSearchRegions
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchRequestResult_AlternateSearchRegionstopic)
' property returns results of searching for alternate regions. Note that if you
' run this sample as is, you will get a warning message saying that the specified
' Bing Maps key is invalid. To learn how to register a Bing Maps account and
' create a key for it, refer to the How to: Get a Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5066

' Developer Express Code Central Example:
' How to get additional search results using the Bing Map Search service
' 
' This example demonstrates how to provide search for location, keywords and other
' additional parameters using the BingSearchDataProvider.Search
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic)
' method. In this example, the built-in Search panel is disabled (the
' BingSearchDataProvider.ShowSearchPanel
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_ShowSearchPaneltopic)
' property is set to false), because a custom panel is used instead. To start
' search, specify search parameters (location, a keyword, start search index,
' geographical point coordinates) in the custom Search panel and click the Search
' button. This handles the search_Click event and all search parameters are passed
' to the Search method and you can see the result in the rich text box element.
' The results contain a display name, entity type and address associated with the
' search location. In addition, the SearchRequestResult.AlternateSearchRegions
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchRequestResult_AlternateSearchRegionstopic)
' property returns results of searching for alternate regions. Moreover, you can
' see search request information returned by the RequestResultBase.ResultCode
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapRequestResultBase_ResultCodetopic),
' RequestResultBase.FaultReason
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapRequestResultBase_FaultReasontopic)
' and SearchRequestResult.EstimatedMatches
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchRequestResult_EstimatedMatchestopic)
' properties. Note that if you run this sample as is, you will get a warning
' message saying that the specified Bing Maps key is invalid. To learn how to
' register a Bing Maps account and create a key for it, refer to the How to: Get a
' Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5066

Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("GetSearchLocationAdditionalInfo")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("GetSearchLocationAdditionalInfo")>
<Assembly: AssemblyCopyright("Copyright ©  2014")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("2227b922-a3c4-4e80-ab97-bdd6bf5f0ba5")>

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
' [assembly: AssemblyVersion("1.0.*")]
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
