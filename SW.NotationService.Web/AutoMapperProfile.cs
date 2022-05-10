namespace SW.NotationService.Web
{
    using AutoMapper;
    using SW.NotationService.Repository.Models;
    using SW.NotationService.Web.RequestModels;

    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<NotationDb, NotationGetRequestResult>().ReverseMap();
        }
    }
}
