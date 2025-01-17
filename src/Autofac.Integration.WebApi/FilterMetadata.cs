﻿// Copyright (c) Autofac Project. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Autofac.Integration.WebApi
{
    /// <summary>
    /// Metadata interface for filter registrations.
    /// </summary>
    internal class FilterMetadata
    {
        /// <summary>
        /// Gets a unique ID for this filter registration.
        /// </summary>
        public Guid Id { get; } = Guid.NewGuid();

        /// <summary>
        /// Gets the registered set of predicates for this filter.
        /// </summary>
        public List<FilterPredicateMetadata> PredicateSet { get; } = new List<FilterPredicateMetadata>();

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is FilterMetadata metadata)
            {
                return metadata.Id == Id;
            }

            return false;
        }
    }
}
