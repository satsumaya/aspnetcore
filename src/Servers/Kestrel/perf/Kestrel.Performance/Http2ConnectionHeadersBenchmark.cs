// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Server.Kestrel.Performance
{
    public class Http2ConnectionHeadersBenchmark : Http2ConnectionBenchmarkBase
    {
        [Params(0, 1, 4, 32)]
        public int CustomHeaders { get; set; }

        private int _headerIndex;

        protected override Task ProcessRequest(HttpContext httpContext)
        {
            for (var i = 0; i < CustomHeaders; i++)
            {
                httpContext.Response.Headers["CustomHeader" + _headerIndex++] = "The quick brown fox jumps over the lazy dog.";
            }
            
            return Task.CompletedTask;
        }
    }
}
