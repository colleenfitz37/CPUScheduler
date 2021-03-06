﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// AUTHOR: COLEEN FITZSIMONS

namespace COM310JobScheduler
{
    /// <summary>
    /// FIRST COME FIRST SERVED CLASS
    /// </summary>
    public class FCFS : Scheduler, Algorithm
    {
        /// <summary>
        /// CALCULATES GANTT CHART FOR THIS ALGORITHM
        /// INHERITED FROM BASE CLASS AND INTERFACE
        /// </summary>
        /// <param name="activeProcesses">LIST OF ALL PROCESSES THAT ARE ACTIVE</param>
        /// <returns>RETURNS THE STRING REPRESENTATION OF A GANTT CHART BUILT BY A STRINGBUILDER</returns>
        public override string calculateGantt(List<Process> activeProcesses)
        {
            return "WORKS!";
        }
    }
}
