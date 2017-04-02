using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Business.Configuration
{
    public class AutomapperMappingConfig : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "BusinessMappingConfig";
            }
        }
        public AutomapperMappingConfig()
        {
            CreateMap<Business.Entities.Contact, Data.Entities.Contact>().ReverseMap();
        }
    }
}
