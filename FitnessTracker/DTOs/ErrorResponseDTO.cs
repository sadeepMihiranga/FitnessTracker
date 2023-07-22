namespace FitnessTracker.DTOs
{
    public class ErrorResponseDTO
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public string TraceId { get; set; }
    }
}
