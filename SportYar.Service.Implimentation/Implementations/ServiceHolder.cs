using AutoMapper;
using SportYar.Repository;
using SportYar.Service.Interfaces;

namespace SportYar.Service.Implimentation.Implementations;

public class ServiceHolder : IServiceHolder
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private StateService _stateService;
    private AnnouncementsService _announcementsService;

    public ServiceHolder(IUnitOfWork unitOfWork , IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public IStateService StateService => _stateService = _stateService ?? new StateService(_unitOfWork);

    public IAnnouncementsService AnnouncementsService => _announcementsService = _announcementsService ?? new AnnouncementsService(_unitOfWork,_mapper);
}
