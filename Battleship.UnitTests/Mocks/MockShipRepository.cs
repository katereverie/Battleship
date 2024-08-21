using Battleship.BLL;

namespace Battleship.UnitTests.Mocks
{
    public class MockShipRepository
    {
        public List<Ship> Ships { get; private set; } = new List<Ship>(5);

        public MockShipRepository()
        {
            Ships.Add(new MockAircraftCarrier());
            Ships.Add(new MockBattleShip());
            Ships.Add(new MockCruiser());
            Ships.Add(new MockSubmarine());
            Ships.Add(new MockDestroyer());
        }
    }
}
