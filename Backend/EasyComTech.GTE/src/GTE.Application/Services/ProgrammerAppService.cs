using GTE.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GTE.Application.ViewModels;
using AutoMapper;
using GTE.Domain.Interfaces;
using GTE.Domain.Entities;

namespace GTE.Application.Services
{
    public class ProgrammerAppService : IProgrammerAppService
    {
        private readonly IMapper _mapper;
        private readonly IProgrammerRepository _programmerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProgrammerAppService(IMapper mapper, IProgrammerRepository programmerRepository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _programmerRepository = programmerRepository;
            _unitOfWork = unitOfWork;
        }

        public ProgrammerViewModel AddProgrammer(ProgrammerViewModel programmer)
        {
            var occupationAreaObj = _mapper.Map<OccupationArea>(programmer.OccupationArea);
            occupationAreaObj.ProgrammerId = programmer.Id;
            _programmerRepository.AddOccupationArea(occupationAreaObj);
            programmer.OccupationAreaId = occupationAreaObj.Id;

            var bankInformationObj = _mapper.Map<BankInformation>(programmer.BankInformation);
            bankInformationObj.ProgrammerId = programmer.Id;
            _programmerRepository.AddBankInformation(bankInformationObj);
            programmer.BankInformationId = bankInformationObj.Id;

            var knowledgeObj = _mapper.Map<Knowledge>(programmer.Knowledge);
            knowledgeObj.ProgrammerId = programmer.Id;
            _programmerRepository.AddKnowledge(knowledgeObj);
            programmer.KnowledgeId = knowledgeObj.Id;


            var programmerObj = _mapper.Map<Programmer>(programmer);
            _programmerRepository.Add(programmerObj);

            _unitOfWork.Commit();

            return programmer;
        }
        
        public List<ProgrammerViewModel> GetAllProgrammers()
        {
            return _mapper.Map<List<ProgrammerViewModel>>(_programmerRepository.GetAll());
        }
        
        public void UpdateProgramer(ProgrammerViewModel programmer)
        {
            var occupationAreaObj = _mapper.Map<OccupationArea>(programmer.OccupationArea);
            occupationAreaObj.ProgrammerId = programmer.Id;
            _programmerRepository.UpdateOccupationArea(occupationAreaObj);
            programmer.OccupationAreaId = occupationAreaObj.Id;

            var bankInformationObj = _mapper.Map<BankInformation>(programmer.BankInformation);
            bankInformationObj.ProgrammerId = programmer.Id;
            _programmerRepository.UpdateBankInformation(bankInformationObj);
            programmer.BankInformationId = bankInformationObj.Id;

            var knowledgeObj = _mapper.Map<Knowledge>(programmer.Knowledge);
            knowledgeObj.ProgrammerId = programmer.Id;
            _programmerRepository.UpdateKnowledge(knowledgeObj);
            programmer.KnowledgeId = knowledgeObj.Id;


            var programmerObj = _mapper.Map<Programmer>(programmer);
            _programmerRepository.Update(programmerObj);

            _unitOfWork.Commit();
        }

        public ProgrammerViewModel GetById(Guid id)
        {
            return _mapper.Map<ProgrammerViewModel>(_programmerRepository.GetById(id));
        }

        public void Remove(Guid id)
        {
            _programmerRepository.Remove(id);

            _unitOfWork.Commit();
        }

        public void Dispose()
        {
            _programmerRepository.Dispose();
        }
    }
}
