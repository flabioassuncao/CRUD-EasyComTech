using GTE.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GTE.Application.ViewModels;
using GTE.Domain.Interfaces;
using AutoMapper;

namespace GTE.Application.Services
{
    public class BankInformationAppService : IBankInformationAppService
    {
        private readonly IMapper _mapper;
        private readonly IBankInformationRepository _bankRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BankInformationAppService(IMapper mapper, IBankInformationRepository bankRepository,
                                        IUnitOfWork unitOfWork)
        {
            _bankRepository = bankRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        
        public BankInformationViewModel GetByIdProgrammer(Guid id)
        {
            return _mapper.Map<BankInformationViewModel>(_bankRepository.GetByIdProgrammer(id));
        }

        public void Dispose()
        {
            _bankRepository.Dispose();
        }
    }
}
