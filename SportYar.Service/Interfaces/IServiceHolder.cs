namespace SportYar.Service.Interfaces
{
    public interface IServiceHolder
    {
        public IStateService StateService { get; }
        public IAnnouncementsService  AnnouncementsService { get; }
    }
}
