using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
            {
                ps.AddProfile(new MappingProfile());
            });
        }
    }
}
