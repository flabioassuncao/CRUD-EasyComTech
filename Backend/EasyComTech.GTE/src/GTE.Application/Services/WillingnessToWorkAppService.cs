using AutoMapper;
using GTE.Application.Interfaces;
using GTE.Domain.Interfaces;
using System.Collections.Generic;
using GTE.Application.ViewModels;

namespace GTE.Application.Services
{
    public class WillingnessToWorkAppService : IWillingnessToWorkAppService
    {
        private readonly IMapper _mapper;
        private readonly IWillingnessToWorkRepository _willingnessToWorkRepository;
        private readonly IUnitOfWork _unitOfWork;

        public WillingnessToWorkAppService(IWillingnessToWorkRepository willingnessToWorkRepository, IMapper mapper)
        {
            _mapper = mapper;
            _willingnessToWorkRepository = willingnessToWorkRepository;
        }
        

        public List<WillingnessToWorkViewModel> GetAll()
        {
            return _mapper.Map<List<WillingnessToWorkViewModel>>(_willingnessToWorkRepository.GetAll());
        }

        public void Dispose()
        {
            _willingnessToWorkRepository.Dispose();
        }
    }
}
