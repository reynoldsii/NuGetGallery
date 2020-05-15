﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetGallery
{
    public class PackageDependent
    {
        public String Id { get; set; }
        public int DownloadCount { get; set; }
        public String Description { get; set; }

        // TODO Add verify checkmark
        // https://github.com/NuGet/NuGetGallery/issues/4718
    }
}
      