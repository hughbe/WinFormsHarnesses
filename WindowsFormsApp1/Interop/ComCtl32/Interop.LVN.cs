// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

internal static partial class Interop
{
    internal static partial class ComCtl32
    {
        public enum LVN : int
        {
            FIRST = 0 - 100,
            ITEMCHANGING = FIRST - 0,
            ITEMCHANGED = FIRST - 1,
            INSERTITEM = FIRST - 2,
            DELETEITEM = FIRST - 3,
            DELETEALLITEMS = FIRST - 4,
            BEGINLABELEDITA = FIRST - 5,
            ENDLABELEDITA = FIRST - 6,
            COLUMNCLICK = FIRST - 8,
            BEGINDRAG = FIRST - 9,
            BEGINRDRAG = FIRST - 11,
            ODCACHEHINT = FIRST - 13,
            ITEMACTIVATE = FIRST - 14,
            ODSTATECHANGED = FIRST - 15,
            HOTTRACK = FIRST - 21,
            GETDISPINFOA = FIRST - 50,
            SETDISPINFOA = FIRST - 51,
            ODFINDITEMA = FIRST - 52,
            KEYDOWN = FIRST - 55,
            MARQUEEBEGIN = FIRST - 56,
            GETINFOTIPA = FIRST - 57,
            GETINFOTIPW = FIRST - 58,
            INCREMENTALSEARCHA = FIRST - 62,
            INCREMENTALSEARCHW = FIRST - 63,
            COLUMNDROPDOWN = FIRST - 64,
            COLUMNOVERFLOWCLICK = FIRST - 66,
            BEGINLABELEDITW = FIRST - 75,
            ENDLABELEDITW = FIRST - 76,
            GETDISPINFOW = FIRST - 77,
            SETDISPINFOW = FIRST - 78,
            ODFINDITEMW = FIRST - 79,
            BEGINSCROLL = FIRST - 80,
            ENDSCROLL = FIRST - 81,
            LINKCLICK = FIRST - 84,
            GETEMPTYMARKUP = FIRST - 87,
        }
    }
}
