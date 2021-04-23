using System.Threading.Tasks;
using TypingDashboard.Models.TokenAuth;
using TypingDashboard.Web.Controllers;
using Shouldly;
using Xunit;

namespace TypingDashboard.Web.Tests.Controllers
{
    public class HomeController_Tests: TypingDashboardWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}