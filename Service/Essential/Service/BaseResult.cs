namespace RickAndMorty.Service.Essential.Service
{
    public class BaseResult<T> : IGenericResult<T>
    {
        public T Data { get; set; }
        public string Raw { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }


}
