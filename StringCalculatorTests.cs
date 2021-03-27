using System;
using Xunit;

namespace kata_prueba8
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Can_Add_Emty_String()
        {
            //Arrange
            var calculator = new StringCalculator();

            //Act
            int result = calculator.Add("");

            //Assert
            Assert.Equal(0, result);


        }
        [Fact]
        public void Can_Add_Single_String()
        {
            //Arrange
            var calculator = new StringCalculator();

            //Act
            int result = calculator.Add("9");

            //Assert
            Assert.Equal(9, result);
            

        }
        [Fact]
        public void Can_Add_two_String()
        {
            //Arrange
            var calculator = new StringCalculator();

            //Act
            int result = calculator.Add("9,9");

            //Assert
            Assert.Equal(18, result);
            

        }

         [Fact]
        public void Can_Add_Unknown_String()
        {
            //Arrange
            var calculator = new StringCalculator();

            //Act
            int result = calculator.Add("999");

            //Assert
            Assert.Equal(999, result);
            

        }
        [Fact]
        public void Can_Add_Comma_String()
        {
            //Arrange
            var calculator = new StringCalculator();

            //Act
            int result = calculator.Add("1\n2,3");

            //Assert
            Assert.Equal(6, result);
            

        }

         [Fact]
        public void Can_Add_Container_String()
        {
            //Arrange
            var calculator = new StringCalculator();

            //Act
            int result = calculator.Add("//;\n1;2");

            //Assert
            Assert.Equal(3, result);
            
        }

        
        [Fact]
        public void Cant_Add_NegativeString()

        {
            //Arrange
            var calculator = new StringCalculator();

            //Act

            var exception = Assert.Throws<InvalidOperationException>(
                () => calculator.Add("-1"));

            //The thrown exception can be used for even more detailed assertions.
            Assert.Equal("negative not allowed: -1", exception.Message);
        }
      
  

        [Fact]
        public void Cant_Add_MultipleNegativeString()

        {
            //Arrange
            var calculator = new StringCalculator();

            //Act

            var exception = Assert.Throws<InvalidOperationException>(
                () => calculator.Add("-1, -2"));
                
            //The thrown exception can be used for even more detailed assertions.
            Assert.Equal("negative not allowed: -1,-2", exception.Message);
        }

        [Fact]
        public void Can_Add_Ignored_String()
        {
            //Arrange
            var calculator = new StringCalculator();

            //Act
            int result = calculator.Add("//+\n2+1002");

            //Assert
            Assert.Equal(2, result);
            
        }

        [Fact]
        public void Can_Add_IgnoredInt_String()
        {
            //Arrange
            var calculator = new StringCalculator();

            //Act
            int result = calculator.Add("3+1001");

            //Assert
            Assert.Equal(3, result);
            
        }
        // [Fact]
        // public void Can_Add_MultipleDelimiters_String()
        // {
        //     //Arrange
        //     var calculator = new StringCalculator();

        //     //Act
        //     int result = calculator.Add("//[***]\n1***2***3");

        //     //Assert
        //     Assert.Equal(3, result);
            
        // }
    }
}
