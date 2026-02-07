using Microsoft.ML;
using MLSentimentAPI.Models;

namespace MLSentimentAPI.Services
{
    public class SentimentService
    {
        private readonly MLContext _mlContext;
        private readonly PredictionEngine<SentimentData, SentimentPrediction> _predictionEngine;
        public SentimentService()
        {
            _mlContext = new MLContext();

            var data = _mlContext.Data.LoadFromTextFile<SentimentData>(path: "Datas/sentiment_data.csv", hasHeader: true, separatorChar: ',');
            var pipeline = _mlContext.Transforms.Conversion.MapValueToKey(
                outputColumnName: "Label",
                inputColumnName: nameof(SentimentData.Label))

            .Append(_mlContext.Transforms.Text.FeaturizeText(
                outputColumnName: "Features",
                inputColumnName: nameof(SentimentData.Text)))

            .Append(_mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy(
                labelColumnName: "Label",
                featureColumnName: "Features"))

            .Append(_mlContext.Transforms.Conversion.MapKeyToValue(
                outputColumnName: "PredictedLabel",
                inputColumnName: "PredictedLabel"));



            var model = pipeline.Fit(data);

            _predictionEngine = _mlContext.Model.CreatePredictionEngine<SentimentData, SentimentPrediction>(model);
        }

        public string Predict(string text)
        {
            var input = new SentimentData { Text = text };
            var result = _predictionEngine.Predict(input);
            return result.Prediction;
        }

    }
}
