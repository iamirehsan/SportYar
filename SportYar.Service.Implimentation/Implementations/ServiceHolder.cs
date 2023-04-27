using SportYar.Repository;
using SportYar.Service.Interfaces;

namespace SportYar.Service.Implimentation.Implementations;

public class ServiceHolder : IServiceHolder
{
    private readonly IUnitOfWork _unitOfWork;
    private StateService _stateService;

    public ServiceHolder(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IStateService StateService => _stateService = _stateService ?? new StateService(_unitOfWork);
}
