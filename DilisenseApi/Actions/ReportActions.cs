using System.Threading.Tasks;
using DilisenseApi.Utils;
using RestSharp;

// https://developers.dilisense.com/
namespace DilisenseApi.Actions {
    public interface IReportActions {
        Task<byte[]> Individual(string names, string? dob = null, string? gender = null, string? includes = null);
        Task<byte[]> Entity(string names, string? includes = null);
    }

    public class ReportActions : IReportActions {
        private readonly RestClient client;
        public ReportActions(RestClient client) {
            this.client = client;
        }

        // https://developers.dilisense.com/#3-generateindividualreport-get
        public async Task<byte[]> Individual(string names, string? dob = null, string? gender = null, string? includes = null) {
            Utils.Utils.RequireArgument(nameof(names), names);
            var request = new RestRequest("generateIndividualReport", Method.Get)
                .AddParameter("names", names);

            if (dob != null)
                request.AddParameter("dob", dob);
            if (gender != null)
                request.AddParameter("gender", gender);
            if (includes != null)
                request.AddParameter("includes", includes);

            return RestResponseHandler.HandleBase64(await client.ExecuteAsync(request, Method.Get));
        }

        // https://developers.dilisense.com/#5-generateentityreport-get
        public async Task<byte[]> Entity(string names, string? includes = null) {
            Utils.Utils.RequireArgument(nameof(names), names);
            var request = new RestRequest("generateEntityReport", Method.Get)
                .AddParameter("names", names);

            if (includes != null)
                request.AddParameter("includes", includes);

            return RestResponseHandler.HandleBase64(await client.ExecuteAsync(request, Method.Get));
        }
    }
}
