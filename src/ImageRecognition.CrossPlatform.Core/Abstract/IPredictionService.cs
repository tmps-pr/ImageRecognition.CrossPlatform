using Plugin.FilePicker.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ImageRecognition.CrossPlatform.Core.Abstract
{
    public interface IPredictionService
    {
        Task<Dictionary<string, float>> Predict(FileData fileData);
    }
}
