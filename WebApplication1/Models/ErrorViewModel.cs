namespace WebApplication1.Models
{
    public class ErrorViewModel
    {
        //a model
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
