using DICREP.EcommerceSubastas.Application.DTOs.Responses;

namespace Mantenedor_oficial_salaventasOLD.Application
{
    public class ResponseDTO<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public ErrorResponseDto Error { get; set; }
    }
}