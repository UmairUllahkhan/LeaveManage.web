using AutoMapper;
using LeaveManage.web.Data;
using LeaveManage.web.Models;

namespace LeaveManage.web.Application_Configrations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }


    }
}
