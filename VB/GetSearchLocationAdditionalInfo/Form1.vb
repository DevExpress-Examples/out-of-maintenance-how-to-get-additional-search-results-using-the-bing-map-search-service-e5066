Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace GetSearchLocationAdditionalInfo
	Partial Public Class Form1
		Inherits Form

		Private Const yourBingKey As String = "INSERT_YOUR_BING_KEY_HERE"
		Private map As MapControl
		Private searchProvider As BingSearchDataProvider

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			PrepareMap()
			AddHandler searchProvider.SearchCompleted, AddressOf searchDataProvider_SearchCompleted
		End Sub

		Private Sub search_Click(ByVal sender As Object, ByVal e As EventArgs) Handles search.Click
			' Call the Search method.         
			searchProvider.Search(tbKeywords.Text, tbLocation.Text)
		End Sub

		Private Sub searchDataProvider_SearchCompleted(ByVal sender As Object, ByVal e As BingSearchCompletedEventArgs)
			Dim result As SearchRequestResult = e.RequestResult
			If result.ResultCode = RequestResultCode.Success Then
				Dim region As LocationInformation = result.SearchRegion

				If region IsNot Nothing Then
					NavigateTo(region.Location)
				Else
					If result.SearchResults.Count > 0 Then
						NavigateTo(result.SearchResults(0).Location)
					End If
				End If
				DisplayResults(e.RequestResult)
			End If

			If result.ResultCode = RequestResultCode.BadRequest Then
				tbResults.Text = "The Bing Search service does not work for this location."
			End If
		End Sub

		Private Sub NavigateTo(ByVal geoPoint As GeoPoint)
			map.CenterPoint = geoPoint
			map.ZoomLevel = 11
		End Sub

		Private Sub DisplayResults(ByVal requestResult As SearchRequestResult)
			Dim resultList As New StringBuilder("")

			If requestResult.ResultCode = RequestResultCode.Success Then
				Dim resCounter As Integer = 1
				For Each resultInfo As LocationInformation In requestResult.SearchResults
					resultList.Append(String.Format(Constants.vbLf & " Result {0}:  " & Constants.vbLf, resCounter))
					resultList.Append(String.Format(resultInfo.DisplayName + Constants.vbLf))
                    resultList.Append(String.Format(resultInfo.Address + Constants.vbLf))
					resultList.Append(String.Format("Geographical coordinates:  {0}", resultInfo.Location))
					resultList.Append(String.Format(Constants.vbLf & "______________________________" & Constants.vbLf))
					resCounter += 1
				Next resultInfo

				If requestResult.SearchRegion IsNot Nothing Then
					resultList.Append(String.Format(Constants.vbLf & "===================================" & Constants.vbLf))
					resultList.Append(String.Format("Search region:" & Constants.vbLf))
					resultList.Append(String.Format(requestResult.SearchRegion.DisplayName + Constants.vbLf))
                    resultList.Append(String.Format(requestResult.SearchRegion.Address + Constants.vbLf))
					resultList.Append(String.Format("Geographical coordinates:  {0}" & Constants.vbLf, requestResult.SearchRegion.Location))
				End If

				For Each locationInfo As LocationInformation In requestResult.AlternateSearchRegions
					resultList.Append(String.Format(Constants.vbLf & "===================================" & Constants.vbLf))
					resultList.Append(String.Format("Alternate search regions:" & Constants.vbLf + Constants.vbLf))
					resultList.Append(String.Format(locationInfo.DisplayName + Constants.vbLf))
                    resultList.Append(String.Format(locationInfo.Address + Constants.vbLf))
					resultList.Append(String.Format("Geographical coordinates: {0}" & Constants.vbLf, locationInfo.Location))
					resultList.Append(String.Format("______________________________" & Constants.vbLf))
					resCounter += 1
				Next locationInfo
			End If
			tbResults.Text = resultList.ToString()
		End Sub

		Private Sub PrepareMap()
			' Create a map control.
			map = New MapControl()

			' Specify the map position on the form.           
			map.Dock = DockStyle.Fill

			' Add the map control to the window.
			Me.Controls.Add(map)

			' Bring the map to the front.
			map.BringToFront()

			' Create an image tiles layer and add it to the map.
			Dim tilesLayer As New ImageTilesLayer()
			map.Layers.Add(tilesLayer)

			' Create an information layer and add it to the map.
			Dim infoLayer As New InformationLayer()
			map.Layers.Add(infoLayer)

			' Create a Bing data provider and specify the Bing key.
			Dim bingProvider As New BingMapDataProvider()
			tilesLayer.DataProvider = bingProvider
			bingProvider.BingKey = yourBingKey

			' Create a Bing search data provider and specify the Bing key.
			searchProvider = New BingSearchDataProvider()
			infoLayer.DataProvider = searchProvider
			searchProvider.BingKey = yourBingKey
			searchProvider.ShowSearchPanel = False
		End Sub
	End Class
End Namespace