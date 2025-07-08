using RestSharp;

namespace DilisenseApi.Utils {
    internal static class RestResponseHandler {
        public static T Handle<T>(RestResponse<T> response) {
            if (response.ErrorException != null)
                throw response.ErrorException.WithContent(response.Content);
            if (response.Data == null)
                throw new System.ApplicationException("Empty Data!").WithContent(response.Content);
            return response.Data;
        }

        public static byte[] HandleBase64(RestResponse response) {
            if (response.ErrorException != null)
                throw response.ErrorException.WithContent(response.Content);
            if (!response.IsSuccessStatusCode)
                throw new System.ApplicationException("Error Response! Code: " + response.StatusCode).WithContent(response.Content);
            return System.Convert.FromBase64String(response.Content);
        }
    }
}
