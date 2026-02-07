using Microsoft.ML.Data;

namespace MLSentimentAPI.Models;

public class SentimentData
{
    [LoadColumn(0)]
    public string Text { get; set; }

    [LoadColumn(1)]
    public string Label { get; set; }
}
