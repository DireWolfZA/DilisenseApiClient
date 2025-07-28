using System;
using System.Text.Json;
using DilisenseApi.Actions;
using RestSharp;
using RestSharp.Serializers.Json;

namespace DilisenseApi {
    public interface IDilisenseApiClient {
        ICheckActions Check { get; }
        IReportActions GenerateReport { get; }
    }

    public class DilisenseApiClient : IDilisenseApiClient {
        private readonly RestClient client;

        public DilisenseApiClient(string apikey) {
            Utils.Utils.RequireArgument(nameof(apikey), string.IsNullOrWhiteSpace(apikey) ? null : apikey);

            client = new RestClient("https://api.dilisense.com/v1", configureSerialization: config => config.UseSystemTextJson(new JsonSerializerOptions(JsonSerializerDefaults.Web) {
                Converters = { // deserialize string values as enums - dilisense API sends as uppersnakecase
                    new System.Text.Json.Serialization.JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseUpper),
                },
            }));

            client.AddDefaultHeader("Accept", "application/json");
            client.AddDefaultHeader("X-API-Key", apikey);
        }

        public ICheckActions Check => new CheckActions(client);
        public IReportActions GenerateReport => new ReportActions(client);
    }
}
