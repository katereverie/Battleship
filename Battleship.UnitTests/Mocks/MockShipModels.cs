using Battleship.BLL;

namespace Battleship.UnitTests.Mocks
{
    public class MockAircraftCarrier : AircraftCarrier
    {
        public MockAircraftCarrier()
        {
            Coordinate startCoord = new Coordinate(1, 1); // A1
            SetCoordinates(startCoord, 'V');
        }
    }

    public class MockBattleShip : BattleShip
    {
        public MockBattleShip()
        {
            Coordinate startCoord = new Coordinate(2, 1); // B1
            SetCoordinates(startCoord, 'V');
        }
    }

    public class MockCruiser : Cruiser
    {
        public MockCruiser()
        {
            Coordinate startCoord = new Coordinate(3, 1); // D1
            SetCoordinates(startCoord, 'V');
        }
    }

    public class MockDestroyer : Destroyer
    {
        public MockDestroyer()
        {
            Coordinate startCoord = new Coordinate(5, 1); // E1
            SetCoordinates(startCoord, 'V');
        }
    }

    public class MockSubmarine : Submarine
    {
        public MockSubmarine()
        {
            Coordinate startCoord = new Coordinate(4, 1); // D1
            SetCoordinates(startCoord, 'V');
        }
    }
}
