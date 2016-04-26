﻿using Microsoft.Legal.MatterCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Legal.MatterCenter
{
    public interface IValidationFunctions
    {
        GenericResponseVM IsMatterValid(MatterInformationVM matterInformation, int methodNumber, MatterConfigurations matterConfigurations);
        GenericResponseVM MatterDetailsValidation(Matter matter, Client client, int methodNumber,
            MatterConfigurations matterConfigurations);
        GenericResponseVM MatterMetadataValidation(Matter matter, Client client,
            int methodNumber, MatterConfigurations matterConfigurations);
    }
}