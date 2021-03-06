// <copyright file="OwinOpaque.Spec-Opaque.cs" company="Microsoft Open Technologies, Inc.">
// Copyright 2013 Microsoft Open Technologies, Inc. All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System.IO;
using System.Threading;

namespace Owin.Types.Opaque
{
    public partial struct OwinOpaque
    {
        public string Version
        {
            get { return Get<string>(OwinConstants.OpaqueConstants.Version); }
            set { Set(OwinConstants.OpaqueConstants.Version, value); }
        }

        public CancellationToken CallCancelled
        {
            get { return Get<CancellationToken>(OwinConstants.OpaqueConstants.CallCancelled); }
            set { Set(OwinConstants.OpaqueConstants.CallCancelled, value); }
        }

        public Stream Stream
        {
            get { return Get<Stream>(OwinConstants.OpaqueConstants.Stream); }
            set { Set(OwinConstants.OpaqueConstants.Stream, value); }
        }
    }
}
