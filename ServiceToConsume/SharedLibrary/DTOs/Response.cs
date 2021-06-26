using System.Text.Json.Serialization;

namespace SharedLibrary.DTOs
{
    public class Response<T> where T:class
    {
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public ErrorDto ErrorDto { get; set; }
        
        [JsonIgnore]
        public bool IsSuccessful { get; set; }

        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T>{Data = data, StatusCode = statusCode, IsSuccessful = true};
        }

        public static Response<T> Success(int statusCode)
        {
            return new Response<T>{Data = default, StatusCode = statusCode, IsSuccessful = true};
        }

        public static Response<T> Fail(ErrorDto errorDto, int statusCode)
        {
            return new Response<T>()
            {
                ErrorDto = errorDto,
                StatusCode = statusCode,
                IsSuccessful = false
            };
        }

        public static Response<T> Fail(string errorMessage, int statusCode, bool isShow)
        {
            var errorDto = new ErrorDto(errorMessage,isShow);
            return new Response<T>()
            {
                ErrorDto = errorDto,
                StatusCode = statusCode,
                IsSuccessful = false
            };
        }
    }
}