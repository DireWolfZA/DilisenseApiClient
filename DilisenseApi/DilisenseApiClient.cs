using System;
using DilisenseApi.Actions;
using RestSharp;

namespace DilisenseApi {
    public interface IDilisenseApiClient {
        ICheckActions Check { get; }
        IReportActions GenerateReport { get; }
    }

    public class DilisenseApiClient : IDilisenseApiClient {
        private readonly RestClient client;

        public DilisenseApiClient(string apikey) {
            if (apikey == null)
                throw new ArgumentNullException(nameof(apikey));

            client = new RestClient("https://api.dilisense.com/v1");
            client.AddDefaultHeader("Accept", "application/json");
            client.AddDefaultHeader("X-API-Key", apikey);
        }

        public ICheckActions Check => new CheckActions(client);
        public IReportActions GenerateReport => new ReportActions(client);
    }
}
