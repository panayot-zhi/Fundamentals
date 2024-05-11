// Copyright (c) Cratis. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Aksio.Concepts;

namespace Aksio.Json.for_ConceptAsJsonConverter;

public record DecimalConcept(decimal Value) : ConceptAs<decimal>(Value);
