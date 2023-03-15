using Moq;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using SocialNetwork.PLL.Views;

namespace SocialNetwork.Tests
{
	public class Tests
	{
		[TestFixture]
		public class AssertThrowsTests
		{
			private UserService userService;
			private Mock<IUserRepository> userRepositoryMock;

			[SetUp]
			public void Setup()
			{
				userService = new UserService();
			}

			[Test]
			public void FindByEmail_WithNonExistentUser_ShouldThrowUserNotFoundException()
			{
				var nonExistentEmail = "nonexistentuser@example.com";

				Assert.Throws<UserNotFoundException>(() => this.userService.FindByEmail(nonExistentEmail));
			}
		}
	}
}