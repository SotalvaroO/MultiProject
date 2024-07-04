using MultiProject.SampleLib;

namespace MultiProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            SampleClass c = new SampleClass(1);
            var myInt = c.Random;
            Assert.Equal(1, myInt);
        }
    }
}