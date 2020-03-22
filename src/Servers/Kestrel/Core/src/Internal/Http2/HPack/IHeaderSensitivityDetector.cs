// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.HPack
{
    internal interface IHeaderSensitivityDetector
    {
        bool IsSensitive(string name, string value);
    }
}
