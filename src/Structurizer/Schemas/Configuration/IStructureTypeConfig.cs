﻿using System;
using System.Collections.Generic;

namespace Structurizer.Schemas.Configuration
{
    public interface IStructureTypeConfig
    {
        Type Type { get; }
        bool IndexConfigIsEmpty { get; }
        bool IncludeContainedStructureMembers { get; set; }
        ISet<string> MemberPathsBeingIndexed { get; }
        ISet<string> MemberPathsNotBeingIndexed { get; }
    }
}