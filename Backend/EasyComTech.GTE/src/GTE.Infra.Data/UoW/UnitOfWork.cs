using GTE.Domain.Interfaces;
using GTE.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using GTE.Domain.Commands;

namespace GTE.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GTEContext _context;

        public UnitOfWork(GTEContext context)
        {
            _context = context;
        }

        public CommandResponse Commit()
        {
            var rowsAffected = _context.SaveChanges();
            return new CommandResponse(rowsAffected > 0);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
        
    }
}
