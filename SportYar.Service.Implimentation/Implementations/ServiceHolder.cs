using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using SportYar.Domain.Entites;
using SportYar.Repository;
using SportYar.Service.Interfaces;

namespace SportYar.Service.Implimentation.Implementations;

public class ServiceHolder : IServiceHolder
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<User> _userManager;
    private readonly IConfiguration _configuration;
    private readonly IRedisService _redisService;
    private readonly IMapper _mapper;
    private StateService _stateService;
    private AnnouncementsService _announcementsService;
    private UserFunctionsService _userFunctionsService;

    public ServiceHolder(IUnitOfWork unitOfWork , IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public IStateService StateService => _stateService = _stateService ?? new StateService(_unitOfWork);

    public IAnnouncementsService AnnouncementsService => _announcementsService = _announcementsService ?? new AnnouncementsService(_unitOfWork,_mapper);
    public IUserFunctionsService UserFunctionsService => _userFunctionsService = _userFunctionsService ?? new UserFunctionsService(_userManager, _configuration, _unitOfWork, _redisService);
}
