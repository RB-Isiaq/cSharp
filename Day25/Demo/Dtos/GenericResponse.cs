
namespace Demo.Dtos
{
    public class GenericResponse<T>
    {
        public string? Code { get; set; }
        public string? Message { get; set; }
        public T? Result { get; set; }
    }
}