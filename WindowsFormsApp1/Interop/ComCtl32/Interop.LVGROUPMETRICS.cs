// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

internal static partial class Interop
{
    internal static partial class ComCtl32
    {
        public unsafe struct LVGROUPMETRICS
        {
            public uint cbSize;
            public LVGMF mask;
            public uint Left;
            public uint Top;
            public uint Right;
            public uint Bottom;
            public uint crLeft;
            public uint crTop;
            public uint crRight;
            public uint crBottom;
            public uint crHeader;
            public uint crFooter;
        }
    }
}
