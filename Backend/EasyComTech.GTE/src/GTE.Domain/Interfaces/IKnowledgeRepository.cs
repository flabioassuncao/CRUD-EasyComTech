using GTE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTE.Domain.Interfaces
{
    public interface IKnowledgeRepository : IRepository<Knowledge>
    {
        Knowledge GetByIdProgrammer(Guid id);
    }
}
