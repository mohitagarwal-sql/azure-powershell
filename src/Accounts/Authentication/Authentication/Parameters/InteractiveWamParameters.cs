// ----------------------------------------------------------------------------------
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

using System;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;

namespace Microsoft.Azure.Commands.Common.Authentication
{
    public class InteractiveWamParameters : DeviceCodeParameters
    {
        public Action<string> PromptAction { get; set; }

        public InteractiveWamParameters(
            PowerShellTokenCacheProvider tokenCacheProvider,
            IAzureEnvironment environment,
            IAzureTokenCache tokenCache,
            string tenantId,
            string resourceId,
            string userId,
            string homeAccountId,
            Action<string> promptAction,
            string claimsChallenge) : base(tokenCacheProvider, environment, tokenCache, tenantId, resourceId, userId, homeAccountId, claimsChallenge)
        {
            PromptAction = promptAction;
        }
    }
}
