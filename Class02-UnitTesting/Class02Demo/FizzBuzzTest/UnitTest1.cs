using System;
using Xunit;
using Class02Demo;
using static Class02Demo.Program;

namespace FizzBuzzTest
{
	public class UnitTest1
	{
		[Fact]
		public void CanReturn1()
		{
			// 3 parts of a unit test:
			// arrange
			// act
			// assert
			Assert.Equal("1", Convert(1));
		}

		[Fact]
		public void CanReturn2()
		{
			Assert.Equal("2", Convert(2));
		}

		[Fact]
		public void CanReturnFizzFor3()
		{
			Assert.Equal("Fizz", Convert(3));
		}

		[Fact]
		public void CanReturnBuzzFor5()
		{
			Assert.Equal("Buzz", Convert(5));
		}

		[Fact]
		public void CanReturnFizzFor6()
		{
			Assert.Equal("Fizz", Convert(6));
		}

		[Theory]
		[InlineData(3)]
		[InlineData(6)]
		public void CanReturnFizz(int number)
		{
			Assert.Equal("Fizz", Convert(number));
		}

		[Theory]
		[InlineData(5)]
		[InlineData(10)]
		public void CanReturnBuzz(int number)
		{
			Assert.Equal("Buzz", Convert(number));
		}

		[Theory]
		[InlineData(15)]
		public void CanReturnFizzBuzz(int number)
		{
			Assert.Equal("FizzBuzz", Convert(number));
		}

		[Theory]
		[InlineData(30)]
		public void CanFailToReturnBuzz(int number)
		{
			Assert.NotEqual("Buzz", Convert(number));
		}

		[Theory]
		[InlineData(1,"1")]
		[InlineData(3, "Fizz")]
		[InlineData(5, "Buzz")]
		[InlineData(15, "FizzBuzz")]
		public void CanPlayFizzBuzz(int actual, string expected)
		{
			Assert.Equal(expected, Convert(actual));
		}
	}


}
