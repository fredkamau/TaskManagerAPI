using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Data.Models;

namespace TaskManager.Services.Definitions
{
    public interface IProjectRepository  
    {
        Task<List<Project>> GetProjects(int take);
    }
}
