using Battleship.BLL;

namespace Battleship.UnitTests.Mocks
{
    public class MockShotHistory
    {
        public List<Coordinate> Shots { get; set; } = new List<Coordinate>();

        public MockShotHistory()
        {
            // (A1, B2, C3, D4 ... J10)
            for (int i = 0; i < 10; i++)
            {
                Shots.Add(new Coordinate(1 + i, 1 + i));
            }
        }
    }
}
