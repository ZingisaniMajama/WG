using System.Net.Http;

namespace Wolfgang.Helpers
{
    public interface IAPIHelper
    {
        HttpClient APIClient { get; set; }
    }
}