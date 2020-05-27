using System.Net.Http;
using System.Threading.Tasks;

namespace ImageRecognition.CrossPlatform.Core.Services
{
    public class GenderPredictionService : PredictionService
    {
        protected override async Task<HttpResponseMessage> SendContent(HttpClient httpClient, MultipartFormDataContent content)
        {
            return await httpClient.PostAsync("api/image-recognition/gender-recognition", content);
        }
    }
}
