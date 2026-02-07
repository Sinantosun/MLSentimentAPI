using Microsoft.AspNetCore.Mvc;
using MLSentimentAPI.Services;

[ApiController]
[Route("api/[controller]")]
public class SentimentController : ControllerBase
{
    private readonly SentimentService _sentimentService;

    public SentimentController(SentimentService sentimentService)
    {
        _sentimentService = sentimentService;
    }

    [HttpPost("predict")]
    public IActionResult Predict([FromBody] SentimentRequest request)
    {
        var prediction = _sentimentService.Predict(request.Text);

        return Ok(new
        {
            sonuc = prediction
        });
    }
}

public class SentimentRequest
{
    public string Text { get; set; }
}
