﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOnline.ClientServicesAdapter.Data.DataObjects
{
    public class DriverDTO
    {
        public string Id { get; set; }

        public string PhoneNumber { get; set; }

        public string SkypeNumber { get; set; }

        public string PersonName { get; set; }

        public string CarColor { get; set; }

        public string CarBrand { get; set; }

        public string CarNumber { get; set; }

        public Guid CityId { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public double? Altitude { get; set; }
    }
}