using static Main.Program;

namespace Test
{
    public class Tests
    {
        [Test]
        public void posTest()
        {

            Assert.That(CheckTriangle(3, 4, 5, 0), Is.True);
            Assert.That(CheckTriangle(3, 4, 5, 1), Is.True);
            Assert.That(CheckTriangle(5, 4, 3, 1), Is.True);
        }

        [Test]
        public void negTest()
        {
            Assert.That(CheckTriangle(2, 3, 4, 1), Is.False);
            Assert.That(CheckTriangle(5, 5, 3, 3), Is.False);
            Assert.That(CheckTriangle(0, 4, 5, 0), Is.False);
        }

        [Test]
        public void negTest2()
        {
            Assert.That(CheckTriangle(0, 0, 0, 0), Is.False);
        }
    }
}