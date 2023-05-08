using System.Text.Json.Serialization;

namespace RickAndMorty.Service.Essential.Service
{
    public interface IGenericResult<T>
    {
        T Data { get; }
    }
}
