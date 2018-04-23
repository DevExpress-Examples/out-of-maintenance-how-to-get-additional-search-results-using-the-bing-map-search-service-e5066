using DevExpress.XtraMap;
using System;
using System.Text;
using System.Windows.Forms;

namespace GetSearchLocationAdditionalInfo {
    public partial class Form1 : Form {

        const string yourBingKey = "INSERT_YOUR_BING_KEY_HERE";
        MapControl map;
        BingSearchDataProvider searchProvider;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            PrepareMap();
            searchProvider.SearchCompleted +=
                new BingSearchCompletedEventHandler(searchDataProvider_SearchCompleted);
        }

        private void search_Click(object sender, EventArgs e) {
            // Call the Search method.         
            searchProvider.Search(tbKeywords.Text, tbLocation.Text);
        }

        private void searchDataProvider_SearchCompleted(object sender, BingSearchCompletedEventArgs e) {
            SearchRequestResult result = e.RequestResult;
            if (result.ResultCode == RequestResultCode.Success) {
                LocationInformation region = result.SearchRegion;

                if (region != null) {
                    NavigateTo(region.Location);
                }
                else {
                    if (result.SearchResults.Count > 0)
                        NavigateTo(result.SearchResults[0].Location);
                }
                DisplayResults(e.RequestResult);
            }

            if (result.ResultCode == RequestResultCode.BadRequest)
                tbResults.Text = "The Bing Search service does not work for this location.";
        }

        void NavigateTo(GeoPoint geoPoint) {
            map.CenterPoint = geoPoint;
            map.ZoomLevel = 11;
        }

        private void DisplayResults(SearchRequestResult requestResult) {
            StringBuilder resultList = new StringBuilder("");

            if (requestResult.ResultCode == RequestResultCode.Success) {
                int resCounter = 1;
                foreach (LocationInformation resultInfo in requestResult.SearchResults) {
                    resultList.Append(String.Format("\n Result {0}:  \n", resCounter));
                    resultList.Append(String.Format(resultInfo.DisplayName + "\n"));
                    resultList.Append(String.Format(resultInfo.Address.FormattedAddress + "\n"));
                    resultList.Append(String.Format("Geographical coordinates:  {0}", resultInfo.Location));
                    resultList.Append(String.Format("\n______________________________\n"));
                    resCounter++;
                }

                if (requestResult.SearchRegion != null) {
                    resultList.Append(String.Format("\n===================================\n"));
                    resultList.Append(String.Format("Search region:\n"));
                    resultList.Append(String.Format(requestResult.SearchRegion.DisplayName + "\n"));
                    resultList.Append(String.Format(requestResult.SearchRegion.Address.FormattedAddress + "\n"));
                    resultList.Append(String.Format("Geographical coordinates:  {0}\n", requestResult.SearchRegion.Location));
                }

                foreach (LocationInformation locationInfo in requestResult.AlternateSearchRegions) {
                    resultList.Append(String.Format("\n===================================\n"));
                    resultList.Append(String.Format("Alternate search regions:\n\n"));
                    resultList.Append(String.Format(locationInfo.DisplayName + "\n"));
                    resultList.Append(String.Format(locationInfo.Address.FormattedAddress + "\n"));
                    resultList.Append(String.Format("Geographical coordinates: {0}\n", locationInfo.Location));
                    resultList.Append(String.Format("______________________________\n"));
                    resCounter++;
                }
            }
            tbResults.Text = resultList.ToString();
        }

        private void PrepareMap() {
            // Create a map control.
            map = new MapControl();

            // Specify the map position on the form.           
            map.Dock = DockStyle.Fill;

            // Add the map control to the window.
            this.Controls.Add(map);

            // Bring the map to the front.
            map.BringToFront();

            // Create an image tiles layer and add it to the map.
            ImageTilesLayer tilesLayer = new ImageTilesLayer();
            map.Layers.Add(tilesLayer);

            // Create an information layer and add it to the map.
            InformationLayer infoLayer = new InformationLayer();
            map.Layers.Add(infoLayer);

            // Create a Bing data provider and specify the Bing key.
            BingMapDataProvider bingProvider = new BingMapDataProvider();
            tilesLayer.DataProvider = bingProvider;
            bingProvider.BingKey = yourBingKey;

            // Create a Bing search data provider and specify the Bing key.
            searchProvider = new BingSearchDataProvider();
            infoLayer.DataProvider = searchProvider;
            searchProvider.BingKey = yourBingKey;
            searchProvider.ShowSearchPanel = false;
        }
    }
}