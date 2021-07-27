using consimpleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace consimpleApp.Services
{
    public interface IRootobjectService
    {
        Task<Rootobject> GetAllAsync();
    }
}
