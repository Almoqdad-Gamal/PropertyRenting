using MediatR;
using PropertyRenting.Application.Users.DTOs;

namespace PropertyRenting.Application.Users.Commands
{
    public record RegisterUserCommand (RegisterUserDto Dto) : IRequest<Guid>;
}