using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using PropertyRenting.Application.Interfaces;
using PropertyRenting.Application.Users.Commands;
using PropertyRenting.Domain.Entities;

namespace PropertyRenting.Application.Users.Handlers
{
    public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, Guid>
    {
        private readonly IUserRepository _repo;
        private readonly IPasswordService _password;
        public RegisterUserHandler(IUserRepository repo, IPasswordService password)
        {
            _repo = repo;
            _password = password;
        }
        public async Task<Guid> Handle(RegisterUserCommand request, CancellationToken ct)
        {
            if(await _repo.EmailExistsAsync(request.Dto.Email, ct))
            throw new Exception("Email already exists");

            var user = new User
            {
              Email = request.Dto.Email,
              FullName = request.Dto.FullName,
              PasswordHash = _password.Hash(request.Dto.Password)  
            };

            await _repo.AddUserAsync(user, ct);
            return user.Id;
        }
    }
}