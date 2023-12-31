using QcmBackendApi.Models;

namespace QcmBackendApi.Services
{
    public interface IQcmService
    {
        Qcm CreateQcm(QcmRequest request);
        Qcm GetQcmById(int qcmId);
        IEnumerable<Qcm> GetQcms();
    }
}
