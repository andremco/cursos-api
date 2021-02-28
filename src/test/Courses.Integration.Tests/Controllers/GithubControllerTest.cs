﻿using Courses.API;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Courses.Integration.Tests
{
    public class GithubControllerTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _httpClient;

        public GithubControllerTest(WebApplicationFactory<Startup> factory)
        {
            _httpClient = factory.CreateClient();
        }

        [Fact]
        public async Task GetLinkGithub_TestAsync()
        {
            var link = "https://github.com/user/test";
            Environment.SetEnvironmentVariable("LinkGithub", link);
            var response = await _httpClient.GetAsync("api/v1/github");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(link, await response.Content.ReadAsStringAsync());
        }
    }
}
