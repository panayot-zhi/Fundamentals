// Copyright (c) Cratis. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Aksio.Types;

namespace Aksio.Serialization.for_DerivedTypes.given;

public class derived_types : Specification
{
    protected Mock<ITypes> types;

    protected virtual IEnumerable<Type> ProvideDerivedTypes() => Enumerable.Empty<Type>();

    void Establish()
    {
        types = new();
        types.SetupGet(_ => _.All).Returns(ProvideDerivedTypes());
    }
}
