using MadeTechExercise.Service;
using Xunit;

namespace MadeTechExercise.Tests
{
    public class FrameScoreTests
    {
        [Theory]
        [InlineData(0, 0, null, 0)]
        //[InlineData(5, 4, null, 9)]
        [InlineData(9, 1, 2, 12)]
        public void FrameScoreCalculatesSumOfBallsIncludingBonus(int firstBall, int secondBall, int? bonusBall, int expectedScore)
        {
            var frame = new Frame(firstBall, secondBall, bonusBall, null);

            var score = frame.Score;

            Assert.Equal(expectedScore, score);
        }

        [Fact]
        public void FrameScoreIsNine_WhenFiveAndFourRolled()
        {
            var frame = new Frame(5, 4, null, null);

            var score = frame.Score;

            Assert.Equal(9, score);
        }

        [Fact]
        public void FrameScoreIsTwelve_WhenSpareIsRolledFollowedByATwo()
        {
            var frame = new Frame(6, 4, 2, null);

            var score = frame.Score;

            Assert.Equal(12, score);
        }

        [Fact]
        public void FrameScoreIsFifteen_WhenStrikeIsRolledFollowedByATwoAndAThree()
        {
            var frame = new Frame(10, null, 2, 3);

            var score = frame.Score;

            Assert.Equal(15, score);
        }
    }
}