namespace FitnessTracker.DTOs
{
    public class APIResponseWrapper<T>
    {
        public T SuccessReponse { get; set; }
        public ErrorResponseDTO ErrorResponse { get; set; }
        public bool Success { get; set; }
    }
}


