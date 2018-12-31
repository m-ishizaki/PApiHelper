using Newtonsoft.Json;
using PApiHelper.Models;
using PApiHelper.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PApiHelper
{
    public class PApiClient
    {
        static string _ContentType { get; } = "application/json";
        static Encoding _Encoding { get; } = Encoding.UTF8;
        public HttpClient HttpClient { get; set; }
        public string ApiKey { get; set; }
        public string BaseUrl { get; set; }
        public string ApiName { get; set; } = "Items";
        public string ApiMethod { get; set; } = "get";

        public async Task<T> PostAsync<T>(string apiKey, string baseUrl, string apiName, long id, string apiMethod, PGetApiRequest requestData)
            where T : PApiResponse
        {
            if (string.IsNullOrEmpty(requestData.ApiKey)) requestData.ApiKey = apiKey;
            var json = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(json, _Encoding, _ContentType);

            var http = HttpClient;
            if (http == null)
            {
                http = new HttpClient();
                HttpClient = http;
            }

            var response = await http.PostAsync($"{baseUrl}/api/{apiName}/{id}/{apiMethod}", content);
            var responseContentString = await response?.Content?.ReadAsStringAsync();
            try
            {
                var responseContent = JsonConvert.DeserializeObject<T>(responseContentString);
                responseContent.StringContent = responseContentString;
                return responseContent;
            }
            catch (Exception ex)
            {
                throw new PApiHelperException(ex.Message, ex, response);
            }
        }

        public async Task<PApiResponse> PostAsync(string apiName, long id, string apiMethod, PGetApiRequest requestData)
            => await PostAsync<PApiResponse>(ApiKey, BaseUrl, apiName, id, apiMethod, requestData);

        public async Task<PApiResponse<T>> PostAsync<T>(string apiName, long id, string apiMethod, PGetApiRequest requestData)
            => await PostAsync<PApiResponse<T>>(ApiKey, BaseUrl, apiName, id, apiMethod, requestData);

        public async Task<PApiResponse<T>> PostAsync<T>(long id, PGetApiRequest requestData)
            => await PostAsync<T>(ApiName, id, ApiMethod, requestData);

        public async Task<PApiResponse<Models.DataModels.PApiItem>> PostGetItemsAsync(long id, PGetApiRequest requestData)
            => await PostAsync<Models.DataModels.PApiItem>("Items", id, "get", requestData);

        public async Task<PApiResponse> PostCreateItemsAsync(long id, PApiItem requestData)
            => await PostAsync<Models.DataModels.PApiItem>("Items", id, "create", requestData);

        public async Task<PApiResponse> PostUpdateItemsAsync(long id, PApiItem requestData)
            => await PostAsync<Models.DataModels.PApiItem>("Items", id, "update", requestData);

        public async Task<PApiResponse> PostDeleteItemsAsync(long id, PApiItem requestData)
            => await PostAsync<Models.DataModels.PApiItem>("Items", id, "delete", requestData);

        public async Task<PApiResponse<Models.DataModels.PApiDept>> PostGetDeptsAsync(PGetApiRequest requestData)
            => await PostAsync<Models.DataModels.PApiDept>("Depts", 0, "get", requestData);

        public async Task<PApiResponse<Models.DataModels.PApiGroup>> PostGetGroupsAsync(PGetApiRequest requestData)
            => await PostAsync<Models.DataModels.PApiGroup>("Groups", 0, "get", requestData);

        public async Task<PApiResponse<Models.DataModels.PApiUser>> PostGetUsersAsync(PGetApiRequest requestData)
            => await PostAsync<Models.DataModels.PApiUser>("Users", 0, "get", requestData);
    }
}
