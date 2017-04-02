using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BusinessLayer = Business.Configuration;

namespace ContactManagement.App_Start
{
    public class AutoMapperConfig : Profile
    {
        public static void Configure()
        {
            // Load automapper maps
            Mapper.Initialize(x=>
            {
                x.AddProfile<BusinessLayer.AutomapperMappingConfig>();
                x.AddProfile<Configuration.AutomapperMappingConfig>();
            });
            Mapper.AssertConfigurationIsValid();
        }
    }
}