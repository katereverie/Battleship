namespace Battleship.BLL
{
    public class AircraftCarrier : Ship
    {
        public AircraftCarrier() : base("Aircraft Carrier", 5) { }
    }

    public class Cruiser : Ship
    {
        public Cruiser() : base("Cruiser", 3) { }
    }

    public class BattleShip : Ship
    {
        public BattleShip() : base("Battleship", 4) { }
    }

    public class Destroyer : Ship
    {
        public Destroyer() : base("Destroyer", 2) { }
    }

    public class Submarine : Ship
    {
        public Submarine() : base("Submarine", 3) { }
    }
}
