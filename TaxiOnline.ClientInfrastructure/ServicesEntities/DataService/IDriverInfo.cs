﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxiOnline.ClientInfrastructure.ServicesEntities.DataService
{
    public interface IDriverInfo : IPersonInfo
    {
        string CarColor { get; }
    }
}
