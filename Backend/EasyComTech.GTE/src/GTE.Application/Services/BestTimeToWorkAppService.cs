using AutoMapper;
using GTE.Application.Interfaces;
using GTE.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GTE.Application.ViewModels;

namespace GTE.Application.Services
{
    public class BestTimeToWorkAppService : IBestTimeToWorkAppService
    {
        private readonly IMapper _mapper;
        private readonly IBestTimeToWorkRepository _bestTimeToWorkRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BestTimeToWorkAppService(IMapper mapper, IBestTimeToWorkRepository bestTimeToWorkRepository)
        {
            _bestTimeToWorkRepository = bestTimeToWorkRepository;
            _mapper = mapper;
        }
        
        public List<BestTimeToWorkViewModel> GetAll()
        {
            return _mapper.Map<List<BestTimeToWorkViewModel>>(_bestTimeToWorkRepository.GetAll());
        }

        public void Dispose()
        {
            _bestTimeToWorkRepository.Dispose();
        }
    }
}
