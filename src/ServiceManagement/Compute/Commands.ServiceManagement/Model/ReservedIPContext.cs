﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------


using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.WindowsAzure.Management.Network.Models;
using System.Collections.Generic;

namespace Microsoft.WindowsAzure.Commands.ServiceManagement.Model
{
    public class ReservedIPContext : ManagementOperationContext
    {
        public string ReservedIPName { get; set; }

        public string Address { get; set; }

        public string Id { get; set; }

        public string Label { get; set; }

        public string Location { get; set; }

        public string State { get; set; }

        public bool InUse { get; set; }

        public string ServiceName { get; set; }

        public string DeploymentName { get; set; }

        public string VirtualIPName { get; set; }

        public List<IPTag> IPTags { get; set; }
    }
}
