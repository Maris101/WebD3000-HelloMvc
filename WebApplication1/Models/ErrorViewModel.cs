namespace WebApplication1.Models
{
    public class ErrorViewModel
    {
        //a modelsss!
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
