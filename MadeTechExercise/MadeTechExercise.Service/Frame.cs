namespace MadeTechExercise.Service
{
    public class Frame
    {
        public int Score { get; init; }

        public Frame(int ballOne, int? ballTwo, int? bonusOne, int? bonusTwo)
        {
            Score = ballOne + 
                ballTwo.GetValueOrDefault(0) + 
                bonusOne.GetValueOrDefault(0) + 
                bonusTwo.GetValueOrDefault(0);
        }
    }
}