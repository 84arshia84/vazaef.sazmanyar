﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vazaef.sazmanyar.Domain.Modles.RequestingUnit;

namespace vazaef.sazmanyar.Infrastructure.Persistance.Sql.Repositoies
{
    public class RequestingDepartmenRepository : IRequestingDepartmenRepository
    {
        private readonly AppDbContext _context;

        public RequestingDepartmenRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RequestingDepartmen>> GetAllAsync()
        {
            return await _context.RequestingDepartments.ToListAsync();
        }

        public async Task<RequestingDepartmen> GetByIdAsync(long id)
        {
            return await _context.RequestingDepartments.FindAsync(id);
        }

        public async Task AddAsync(RequestingDepartmen requestingDepartment)
        {
            await _context.RequestingDepartments.AddAsync(requestingDepartment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(RequestingDepartmen requestingDepartment)
        {
            _context.RequestingDepartments.Update(requestingDepartment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var requestingDepartment = await _context.RequestingDepartments.FindAsync(id);
            if (requestingDepartment != null)
            {
                _context.RequestingDepartments.Remove(requestingDepartment);
                await _context.SaveChangesAsync();
            }
        }
    }
}
