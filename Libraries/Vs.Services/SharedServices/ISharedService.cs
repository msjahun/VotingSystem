using System;
using System.Collections.Generic;
using System.Text;

namespace Vs.Services.SharedServices
{
   public interface ISharedService
    {
        string ResolveCurrentStateById(int Id);
    }
}
