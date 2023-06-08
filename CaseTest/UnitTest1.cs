using NexumCase;

namespace CaseTest
{
    public class UnitTest1
    {

        [Fact]
        public void TurnLeft()
        {
            Returning returning = new Returning("1 2 N");

            returning.TurnLeft();
            Console.WriteLine(returning.position);
            Assert.Equal("W", returning.position);
        }

        [Fact]
        public void TurnRight()
        {
            Returning returning = new Returning("1 2 N");

            returning.TurnRight();
            Console.WriteLine(returning.position);
            Assert.Equal("E", returning.position);
        }

        [Fact]
        public void Forward()
        {
            Returning returning = new Returning("1 2 N");

            returning.Forward();
            Assert.Equal(3,returning.y);
        }

        [Fact]
        public void Progress()
        {
            Returning returning = new Returning("3 3 E");
            returning.Progress("MMRMMRMRRM");
            Assert.Equal("5 1 E", returning.x + " " + returning.y + " " + returning.position);
            
        }
    }
}