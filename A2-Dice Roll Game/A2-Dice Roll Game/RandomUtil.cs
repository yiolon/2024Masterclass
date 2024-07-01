namespace bodyPart
{
    partial class _main 
    {
        public class RandomUtil
        {
            private Random random = new Random();
            public int RandomNumGenerater()
            {
                int randomNum = random.Next(1, 7);
                return randomNum;
            }
        }
    }

}