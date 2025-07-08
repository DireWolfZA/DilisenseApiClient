using System.Threading.Tasks;
using DilisenseApi.Models;
using DilisenseApi.Utils;
using RestSharp;

// https://developers.dilisense.com/
namespace DilisenseApi.Actions {
    public interface ICheckActions {
        Task<CollectionResponse<Individual>> Individual(string query, bool searchAll = false, int? fuzzySearch = null, string? dob = null, string? gender = null, string? includes = null);
        Task<CollectionResponse<Entity>> Entity(string query, bool searchAll = false, int? fuzzySearch = null, string? includes = null);
    }

    public class CheckActions : ICheckActions {
        private readonly RestClient client;
        public CheckActions(RestClient client) {
            this.client = client;
        }

        // https://developers.dilisense.com/#2-checkindividual-get
        public async Task<CollectionResponse<Individual>> Individual(string query, bool searchAll = false, int? fuzzySearch = null, string? dob = null, string? gender = null, string? includes = null) {
            Utils.Utils.RequireArgument(nameof(query), query);
            var request = new RestRequest("checkIndividual", Method.Get)
                .AddParameter(searchAll ? "search_all" : "names", query);

            if (fuzzySearch != null)
                request.AddParameter("fuzzy_search", (int)fuzzySearch);
            if (dob != null)
                request.AddParameter("dob", dob);
            if (gender != null)
                request.AddParameter("gender", gender);
            if (includes != null)
                request.AddParameter("includes", includes);

            return RestResponseHandler.Handle(await client.ExecuteAsync<CollectionResponse<Individual>>(request, Method.Get));
        }

        // https://developers.dilisense.com/#4-checkentity-get
        public async Task<CollectionResponse<Entity>> Entity(string query, bool searchAll = false, int? fuzzySearch = null, string? includes = null) {
            Utils.Utils.RequireArgument(nameof(query), query);
            var request = new RestRequest("checkEntity", Method.Get)
                .AddParameter(searchAll ? "search_all" : "names", query);

            if (fuzzySearch != null)
                request = request.AddParameter("fuzzy_search", (int)fuzzySearch);
            if (includes != null)
                request.AddParameter("includes", includes);

            return RestResponseHandler.Handle(await client.ExecuteAsync<CollectionResponse<Entity>>(request, Method.Get));
        }
    }
}
