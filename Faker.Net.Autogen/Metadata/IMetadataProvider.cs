using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker.Net.Autogen.Metadata
{
    public interface IMetadataProvider
    {
        ObjectMetadata CreateObjectMetadata(Type objectType);
        ObjectMetadata CreatePropertyMetadata(Type objectType);
    }
}
