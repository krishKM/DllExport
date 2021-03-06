﻿
//# Author of original code ([Decompiled] MIT-License): Copyright (c) 2009-2015  Robert Giesecke
//# Use Readme & LICENSE files for details.

//# Modifications: Copyright (c) 2016-2020  Denis Kuzmin < x-3F@outlook.com > GitHub/3F
//$ Distributed under the MIT License (MIT)

namespace RGiesecke.DllExport
{
    public enum PatchesType: long
    {
        None,

        /// <summary>
        /// Affects ldc.r8; ldc.r4; .field;
        /// 
        /// inf/-inf to 0x7F800000/0xFF800000 
        ///             0x7FF0000000000000/0xFFF0000000000000
        /// 
        /// https://github.com/3F/DllExport/issues/128
        /// </summary>
        InfToken = 0x01,

        /// <summary>
        /// Affects ldc.r8; ldc.r4; .field;
        /// 
        /// -nan(ind) to 00 00 C0 FF
        ///              00 00 00 00 00 00 F8 FF
        ///              
        /// https://github.com/3F/DllExport/issues/158
        /// </summary>
        NaNToken = 0x02,
    }
}
