using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagement.Configuration
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
            CreateMap<Business.Entities.Contact, Models.ContactViewModel>().ReverseMap();
        }
    }
}