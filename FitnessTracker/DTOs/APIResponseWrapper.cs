using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.DTOs
{
    public class APIResponseWrapper<T>
    {
        public T SuccessReponse { get; set; }
        public ErrorResponseDTO ErrorResponse { get; set; }
        public bool Success { get; set; }
    }
}
