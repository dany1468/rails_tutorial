using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using LtGt;
using LtGt.Models;

namespace SampleApp.Tests
{
    public class StaticPagesControllerTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private readonly string _baseTitle; 

        public StaticPagesControllerTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
            _baseTitle = "Ruby on Rails Tutorial Sample App";
        }

        [Theory]
        [InlineData("Home")]
        [InlineData("Help")]
        [InlineData("About")]
        public async Task ShouldGetHome(string page)
        {
            // Arrange
            using var client = _factory.CreateClient();

            // Act
            using var response = await client.GetAsync($"/StaticPages/{page}");

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            
            var content = await response.Content.ReadAsHtmlDocumentAsync();
            Assert.Equal($"{page} | {_baseTitle}", content.GetTitle());
        }
    }
}
