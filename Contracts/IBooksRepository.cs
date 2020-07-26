using ASPNETCoreDISample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreDISample.Contracts
{
    public interface IBooksRepository
    {
        List<Book> GetAll();
    }
}
