﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Portal.Domain.ProcessedVideoContext
{
    public class TaskProviderStateEventArgs : EventArgs
    {
        public TaskProviderState State { get; set; }
    }
}