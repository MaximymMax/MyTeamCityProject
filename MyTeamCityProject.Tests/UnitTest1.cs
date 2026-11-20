using MyTeamCityProject;
using Xunit;

namespace MyTeamCityProject.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void GetGreeting_ReturnsExpectedMessage()
        {
            Assert.Equal("Hello, TeamCity!", Program.GetGreeting());
        }

        [Fact]
        public void GetGreeting_IsNotEmpty()
        {
            Assert.False(string.IsNullOrWhiteSpace(Program.GetGreeting()));
        }
    }
}
