using AutoMapper;
using GTE.Application.ViewModels;
using GTE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AccountType, AccountTypeViewModel>().ReverseMap();
            CreateMap<BankInformation, BankInformationViewModel>().ReverseMap();
            CreateMap<BestTimeToWork, BestTimeToWorkViewModel>().ReverseMap();
            CreateMap<Knowledge, KnowledgeViewModel>().ReverseMap();
            CreateMap<OccupationArea, OccupationAreaViewModel>().ReverseMap();
            CreateMap<Programmer, ProgrammerViewModel>().ReverseMap();
            CreateMap<WillingnessToWork, WillingnessToWorkViewModel>().ReverseMap();
        }
    }
}
