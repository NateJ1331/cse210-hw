namespace Develop05
{
    class Eternal:Quest
    {
        public override int Record()
        {
            int points = 50;
            int total = 50;

            this.SetTotal(total + 1);
            this.SetCompletions(1);

            return points* this.GetCompletions();
        }
        
    }
}