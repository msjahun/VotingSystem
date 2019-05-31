using System;
using System.Collections.Generic;
using System.Text;

namespace Vs.Core.ElectionState
{
   public class ElectionStates:BaseEntity
    {
        public string StateName { get; set; }
        public bool IsCurrentState { get; set; }
        public int Status { get; set; }
        //0 not started
        //1 in progress/current state
        //2 is complete
    }

    public class StateEnum
    {
        public static int Complete = 2;
        public static int InProgress = 1;
        public static int Default = 0;
    }
}
