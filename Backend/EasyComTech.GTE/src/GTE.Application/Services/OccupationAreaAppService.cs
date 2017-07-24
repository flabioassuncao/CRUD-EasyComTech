using GTE.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GTE.Application.ViewModels;
using AutoMapper;
using GTE.Domain.Interfaces;

namespace GTE.Application.Services
{
    public class OccupationAreaAppService : IOccupationAreaAppService
    {
        private readonly IMapper _mapper;
        private readonly IOccupationAreaRepository _occupationRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OccupationAreaAppService(IMapper mapper, IOccupationAreaRepository occupationRepository,
                                        IUnitOfWork unitOfWork)
        {
            _occupationRepository = occupationRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        
        public OccupationAreaViewModel GetByIdProgrammer(Guid id)
        {
            return _mapper.Map<OccupationAreaViewModel>(_occupationRepository.GetByIdProgrammer(id));
        }

        public void Dispose()
        {
            _occupationRepository.Dispose();
        }
    }
}
