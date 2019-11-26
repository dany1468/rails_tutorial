using System;
using Microsoft.AspNetCore.Mvc;
using SampleApp.Controllers;
using Xunit;

namespace SampleApp.Tests
{
    public class StaticPagesControllerTest
    {
        [Fact]
        public void ShouldGetHome()
        {
            var controller = new StaticPagesController();
            var result = controller.Home();
            Assert.IsType<ViewResult>(result);
        }
        
        [Fact]
        public void ShouldGetHelp()
        {
            var controller = new StaticPagesController();
            var result = controller.Help();
            Assert.IsType<ViewResult>(result);
        }
        
        [Fact]
        public void ShouldGetAbout()
        {
            var controller = new StaticPagesController();
            var result = controller.About();
            Assert.IsType<ViewResult>(result);
        }
    }
}
