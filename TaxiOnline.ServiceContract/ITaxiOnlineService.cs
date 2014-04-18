﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using TaxiOnline.ServiceContract.DataContracts;

namespace TaxiOnline.ServiceContract
{
    [System.ServiceModel.ServiceContract()]//CallbackContract = typeof(ITaxiOnlineCallback))]
    public interface ITaxiOnlineService
    {
        [OperationContract]
        IEnumerable<CityDataContract> EnumerateCities(string userCultureName);

        [OperationContract]
        IEnumerable<PedestrianDataContract> EnumeratePedestrians();

        [OperationContract]
        IEnumerable<PedestrianRequestDataContract> EnumeratePedestrianRequests();

        [OperationContract]
        void PushPedestrianRequest(PedestrianRequestDataContract request);
    }
}
