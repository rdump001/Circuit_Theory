using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class AUDIOVISUALSDataSource : DataSourceBase<YouTubeSchema>
    {
        private const string _url = @"https://gdata.youtube.com/feeds/api/videos?q=circuits+and+networks+&orderby=published&start-index=1&max-results=20&safeSearch=strict&format=5&v=2";

        protected override string CacheKey
        {
            get { return "AUDIOVISUALSDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return false; }
        }

        public async override Task<IEnumerable<YouTubeSchema>> LoadDataAsync()
        {
            try
            {
                var youTubeDataProvider = new YouTubeDataProvider(_url);
                return await youTubeDataProvider.Load();
            }
            catch (Exception ex)
            {
                AppLogs.WriteError("AUDIOVISUALSDataSourceDataSource.LoadData", ex.ToString());
                return new YouTubeSchema[0];
            }
        }
    }
}
