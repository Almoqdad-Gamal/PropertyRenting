using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropertyRenting.Domain.Entities;

namespace PropertyRenting.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> EmailExistsAsync (string email, CancellationToken ct);

        Task AddUserAsync (User user, CancellationToken ct);
    }
}