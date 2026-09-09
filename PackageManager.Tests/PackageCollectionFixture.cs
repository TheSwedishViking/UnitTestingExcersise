using Xunit;

namespace PackageManager.Tests
{
    [CollectionDefinition("Package collection")]
    public class PackageCollectionFixture : ICollectionFixture<PackageFixture>
    {

    }
}
