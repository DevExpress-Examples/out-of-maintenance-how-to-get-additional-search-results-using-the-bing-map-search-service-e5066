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

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18408
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My


    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")> _
    Friend NotInheritable Partial Class Settings
        Inherits System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

        Public Shared ReadOnly Property [Default]() As Settings
            Get
                Return defaultInstance
            End Get
        End Property
    End Class
End Namespace
