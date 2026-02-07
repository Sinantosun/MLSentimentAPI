using Microsoft.ML.Data;

namespace MLSentimentAPI.Models;

public class SentimentPrediction
{
    [ColumnName("PredictedLabel")]
    public string Prediction { get; set; }

}
