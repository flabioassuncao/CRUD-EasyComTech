using AutoMapper;
using GTE.Application.Interfaces;
using GTE.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GTE.Application.ViewModels;

namespace GTE.Application.Services
{
    public class AccountTypeAppService : IAccountTypeAppService
    {
        private readonly IMapper _mapper;
        private readonly IAccountTypeRepository _accountTypeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AccountTypeAppService(IMapper mapper, IAccountTypeRepository accountTypeRepository)
        {
            _accountTypeRepository = accountTypeRepository;
            _mapper = mapper;
        }

        public List<AccountTypeViewModel> GetAll()
        {
            return _mapper.Map<List<AccountTypeViewModel>>(_accountTypeRepository.GetAll());
        }

        public void Dispose()
        {
            _accountTypeRepository.Dispose();
        }
    }
}
