using System.Net.Http;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicAssetsApiClient.Core.Test
{
    [TestFixture]
    public class HttpResponseMessageExtensionTest
    {
        [Test]
        public void ContentAs()
        {
            new HttpResponseMessage
            {
                Content = new StringContent("{\"Id\": \"uppercase_id_property\",\"Name\": \"uppercase_name_property\"}")
            }
            .ContentAs<TestObject>()
            .Should()
            .BeEquivalentTo(new TestObject
            {
                Id = "uppercase_id_property",
                Name = "uppercase_name_property"
            });

            new HttpResponseMessage
            {
                Content = new StringContent("{\"id\": \"lowercase_id_property\",\"name\": \"lowercase_name_property\"}")
            }
            .ContentAs<TestObject>()
            .Should()
            .BeEquivalentTo(new TestObject
            {
                Id = "lowercase_id_property",
                Name = "lowercase_name_property"
            });
        }

        public class TestObject
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }
    }
}
