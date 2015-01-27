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
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Azure Common Authentication")]
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyProduct("Microsoft Azure Libraries")]
[assembly: AssemblyCopyright("Copyright � Microsoft")]

[assembly: ComVisible(false)]
[assembly: CLSCompliant(false)]
[assembly: Guid("4f3ab2e4-cc7a-43ac-bb15-f481fcf94d58")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

#if CODESIGN
[assembly: InternalsVisibleTo("Common.Authentication.Test, PublicKey=00240000048000009400000006020000002400005253413100040000010001002592552baf0c4819857c12145baeaea2e7191d00874d9df03d9b3deec1efcca0ae56fbcba8e8aea60c29c84e7679269e020c32c7efd5cd93a821caa0d0e9a7247623396cc1c280133caefcc8d585901f709ba3fbd96628e6554678b7b1dcc446748433b00599efdb447cb8fd35ef318be24fe5728fe14fcfb67b85197c049fdb")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484cf7045cc7")]
#else
[assembly: InternalsVisibleTo("Common.Authentication.Test")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
#endif