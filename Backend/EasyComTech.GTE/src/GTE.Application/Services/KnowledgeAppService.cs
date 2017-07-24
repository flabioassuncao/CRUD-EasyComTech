using GTE.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GTE.Application.ViewModels;
using AutoMapper;
using GTE.Domain.Interfaces;

namespace GTE.Application.Services
{
    public class KnowledgeAppService : IKnowledgeAppService
    {
        private readonly IMapper _mapper;
        private readonly IKnowledgeRepository _knowledgeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public KnowledgeAppService(IMapper mapper, IKnowledgeRepository knowledgeRepository,
                                        IUnitOfWork unitOfWork)
        {
            _knowledgeRepository = knowledgeRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public KnowledgeViewModel GetByIdProgrammer(Guid id)
        {
            return _mapper.Map<KnowledgeViewModel>(_knowledgeRepository.GetByIdProgrammer(id));
        }

        public void Dispose()
        {
            _knowledgeRepository.Dispose();
        }
    }
}
