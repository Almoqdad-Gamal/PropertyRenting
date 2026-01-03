using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PropertyRenting.Application.Interfaces;
using PropertyRenting.Domain.Entities;

namespace PropertyRenting.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _db;
        public UserRepository(AppDbContext db)
        {
            _db = db;
        }
        public async Task AddUserAsync(User user, CancellationToken ct)
        {
            _db.Users.Add(user);
            await _db.SaveChangesAsync(ct);
        }

        public async Task<bool> EmailExistsAsync(string email, CancellationToken ct)
            => await _db.Users.AnyAsync(x => x.Email == email, ct);
    }
}