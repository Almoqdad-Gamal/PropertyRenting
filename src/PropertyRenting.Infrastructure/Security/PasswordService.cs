using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropertyRenting.Application.Interfaces;

namespace PropertyRenting.Infrastructure.Security
{
    public class PasswordService : IPasswordService
    {
        public string Hash(string password)
            => BCrypt.Net.BCrypt.HashPassword(password);
    }
}