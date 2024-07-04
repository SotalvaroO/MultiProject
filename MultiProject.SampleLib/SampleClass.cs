
namespace MultiProject.SampleLib
{
    public class SampleClass
    {
        public int Random { get; set; }

        public SampleClass(int random)
        {
            Random = random;
        }

        public int GetRandomNumber()
        {
            return Random;
        }
    }
}
