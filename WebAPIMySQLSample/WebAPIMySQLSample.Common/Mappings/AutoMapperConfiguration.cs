using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIMySQLSample.Common.Mappings
{
    public class AutoMapperConfiguration
    {
        //public static void Configure()
        //{
        //    Mapper.Initialize(x =>
        //    {
        //        x.AddProfile<DomainToViewModelMappingProfile>();
        //    });
        //}

        //public static IMapper Mapper;
        //public static void Configure()
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.AddProfile(new DomainToViewModelMappingProfile());
        //    });
        //    //MapperFacade.MapperConfiguration = config.CreateMapper();

        //    Mapper = config.CreateMapper();
        //    config.AssertConfigurationIsValid();

        //}

        public static void Configure()
        {
            Mapper.Initialize(x =>
                {
                    x.AddProfile<DomainToViewModelMappingProfile>();
                });

        }

    }
}