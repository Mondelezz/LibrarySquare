using Xunit;

namespace LibrarySquare.Tests
{
    public class SquareTest
    {
        [Fact]
        public void SquareTringle_3and4and5_6returned()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            //act
            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.GetSquare();

            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SquareTringle_328and428and528_6returned()
        {
            //arrange
            double a = 3.28;
            double b = 4.28;
            double c = 5.28;
            double expected = 7.012803182750816;

            //act
            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.GetSquare();

            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SquareTringle_5and5and20_ErrorReturned()
        {
            //arrange
            double a = 5;
            double b = 5;
            double c = 20;

            //act

            //assert
            Assert.Throws<Exception>(() => Validator.ValidateTriangle(a, b, c));
        }
        [Fact]
        public void SquareTriangle_minus3and4and5_ErrorReturned()
        {
            // arrange
            double a = -3;
            double b = 4;
            double c = 5;

            // act

            // assert
            Assert.Throws<Exception>(() => Validator.ValidateNonNegative(a, nameof(a)));

        }
        [Fact]
        public void SquareCircle_10_314returned()
        {
            // arrange
            double r = 10;
            double expected = 314.1592653589793;

            //act
            Circle circle = new Circle(r);
            double actual = circle.GetSquare();

            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SquareCircle_1028_314returned()
        {
            // arrange
            double r = 10.28;
            double expected = 331.9984850831235;

            //act
            Circle circle = new Circle(r);
            double actual = circle.GetSquare();

            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SquareCircle_minus10_ErrorReturned()
        {
            // arrange
            double r = -10;

            //act

            //assert
            Assert.Throws<Exception>(() => Validator.ValidateNonNegative(r, nameof(r)));
        }

    }
}