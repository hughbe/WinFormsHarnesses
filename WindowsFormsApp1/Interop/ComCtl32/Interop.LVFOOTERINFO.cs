// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

internal static partial class Interop
{
    internal static partial class ComCtl32
    {
        public unsafe struct LVFOOTERINFO
        {
            public LVFF mask;
            public char* pszText;
            public int cchTextMax;
            public uint cItems;
        }
    }
}
