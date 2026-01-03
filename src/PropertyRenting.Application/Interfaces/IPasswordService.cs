using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyRenting.Application.Interfaces
{
    public interface IPasswordService
    {
        string Hash(string password);
    }
}