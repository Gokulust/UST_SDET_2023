﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal interface IAppointment
    {
        void BookAppointment(int doctorId,string patientName);

        void DeleteAppointment(string patientName);

    }
}
