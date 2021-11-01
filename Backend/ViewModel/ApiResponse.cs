namespace Backend.ViewModel
{
    public class ApiResponse
    {
        public string Message { get; set; }
        public string ResponseCode { get; set; }
        public bool Status { get; set; }
    }

    public class ApiResponseObj<T>
    {
        public T data { get; set; } = default(T);
        public string Message { get; set; }
        public string ResponseCode { get; set; }
        public bool Status { get; set; }
    }
}