
namespace Academy.Services.Contracts.Institutions
{
    public interface InstitutionResponses<T>
    {
        public string? Code { get; set; }
        public string? Message { get; set; }
        public T? Result { get; set; }
    }
}