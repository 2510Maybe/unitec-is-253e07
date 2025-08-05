using Xunit;

using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;

namespace WebUI.IntegrationTest
{
    public class IntegrationTestPages : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public IntegrationTestPages(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Theory]
        [InlineData("Index")]
        [InlineData("privacity3")]
        [InlineData("Privacity2")]
        [InlineData("Privacity4")]
        [InlineData("Privacity 5")]
        public async Task TestGetPages(string url)
        {
            // Arrange

            // Act
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
