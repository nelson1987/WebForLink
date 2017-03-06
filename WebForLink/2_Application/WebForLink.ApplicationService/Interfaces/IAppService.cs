using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebForLink.ApplicationService.Interfaces
{
    public interface IAppService
    {
        void Commit();
        void Rollback();
    }
}
