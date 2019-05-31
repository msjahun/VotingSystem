using System;
using System.Collections.Generic;
using System.Text;

namespace Vs.Services.SharedServices
{
   public class SharedService:ISharedService
    {

       public string ResolveCurrentStateById(int Id)
        {
            switch (Id)
            {
                case 0: return "";
                case 1: return "In progress";
                case 2: return "Completed";
                default: return "Error state could not be resolved";
            }
        }


    }
}
