using System;
using Xunit;
using apples;

namespace XUnitTestProject1
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			//arrange
			Apple testApple = new Apple();

			//act
			string result = testApple.GetString();

			//assert
			Assert.Equal("apple", result);
		}
	}
}