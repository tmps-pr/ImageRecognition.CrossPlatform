using ImageRecognition.CrossPlatform.Core.Abstract;
using Newtonsoft.Json;
using Plugin.FilePicker.Abstractions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ImageRecognition.CrossPlatform.Core.Services
{
    public abstract class PredictionService : IPredictionService
    {
        private HttpClient _httpClient;
        public PredictionService()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("http://localhost:7001/")
            };
        }

        public async Task<Dictionary<string, float>> Predict(FileData fileData)
        {
            if (fileData != null)
            {
                MultipartFormDataContent content = new MultipartFormDataContent();
                content.Add(new StreamContent(fileData.GetStream()), "file", fileData.FileName);
                var result = await SendContent(_httpClient, content);
                return await GetDictionaryResult(result.Content);
            }
            else
            {
                throw new ArgumentNullException(nameof(fileData));
            }
        }

        protected abstract Task<HttpResponseMessage> SendContent(HttpClient httpClient, MultipartFormDataContent content);

        private async Task<Dictionary<string, float>> GetDictionaryResult(HttpContent content)
        {
            string jsonContent = await content.ReadAsStringAsync();
            var predicitons = JsonConvert.DeserializeObject<Dictionary<string, float>>(jsonContent);
            return predicitons;
        }
    }
}
