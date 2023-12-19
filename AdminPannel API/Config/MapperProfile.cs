using AutoMapper;

using AdminPannel_API.Models;
using AdminPannel_API.Models.DTO;

namespace AdminPannel_API.Config
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AccountDetailstbl, AccountDetailsDTO>();
            CreateMap<CustomerSupporttbl, CustomerSupportDTO>();
            CreateMap<Notificationstbl, NotificationDTO>();
            CreateMap<ProfileInformationtbl, ProfileInformationDTO>();
            CreateMap<PvAggregatorstbl, PV_AggregatorDTO>().ReverseMap();
            CreateMap<PvNewCarDealerstbl, PV_NewCarDealerDTO>().ReverseMap();
            CreateMap<PvOpenMarketstbl, PV_OpenMarketDTO>().ReverseMap();
            CreateMap<PvaMaketbl, PVA_MakeDTO>();
            CreateMap<PvaModeltbl, PVA_ModelDTO>();
            CreateMap<PvaVarianttbl, PVA_VariantDTO>();
            CreateMap<PvaYearOfRegtbl, PVA_YearOfRegDTO>();
            CreateMap<Statetbl, StateDTO>();
            CreateMap<OrderStockAuditstbl, Order_StockAuditDTO>().ReverseMap();
            CreateMap<StockAuditPurposestbl, StockAudit_PurposeDTO>();
            CreateMap<Userstbl, UserPhoneDTO>().ReverseMap();
            CreateMap<Userstbl, UserInfoDTO>().ReverseMap();
            CreateMap<AccountDetailstbl, UserAccountDTO>().ReverseMap();
            CreateMap<StockAudit, UploadPic_StockAuditDTO>().ReverseMap();
            CreateMap<Payment, PaymentProofImgDTO>().ReverseMap();
        }

    }
}
