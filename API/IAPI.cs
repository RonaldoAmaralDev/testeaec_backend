using SDKAPI.Responses;
using System.Threading.Tasks;

namespace SDKAPI
{
    public interface IAPI
    {
        Task<CptecCidadeResponse> CptecCidade();
        Task<CptecCidadeResponse> CptecCidade(string cidadeNome);
        Task<CptecClimaResponse> CptecClimaAeroporto(string icaoCodigo);
        Task<CptecClimaResponse> CptecClimaCapital();
        Task<CptecPrevisaoResponse> CptecClimaPrevisao(int cidadeCodigo);
        Task<CptecPrevisaoResponse> CptecClimaPrevisao(int cidadeCodigo, int dias);
        void Dispose();
    }
}