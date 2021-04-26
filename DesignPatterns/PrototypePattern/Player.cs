using System.Collections.Generic;

namespace PrototypePattern
{
    internal class Player: PlayerPrototype
    {
        private readonly string _number;
        private readonly Position _position;
        private readonly Skin _skin;
        private readonly decimal _height;
        private readonly decimal Weight;
        public Skill Skill { get; private set; }
        

        public Player(string name, string number, Position position, Skin skin, Skill skill, decimal height, decimal weight)
        {
            Name = name;
            _number = number;
            _position = position;
            _skin = skin;
            _height = height;
            Weight = weight;
            Skill = new Skill(skill.Speed, skill.Acceleration, skill.Power);
        }

        public string Name { get; set; }

        internal override PlayerPrototype Clone()
        {
            return (Player) this.MemberwiseClone();
        }

    }

    internal class PlayerMenu
    {
        private readonly Dictionary<string, PlayerPrototype> _players = new Dictionary<string, PlayerPrototype>();

        public PlayerPrototype this[string name]
        {
            get => _players[name];
            set => _players.Add(name,value);
        }
    }
    
    internal class Skill
    {
        internal int Speed { get; }
        internal int Acceleration { get; }
        internal int Power { get; }

        public Skill(int speed, int acceleration, int power)
        {
            Speed = speed;
            Acceleration = acceleration;
            Power = power;
        }
    }

    internal enum Position
    { 
        LB, DL, CB, FS, QB, OL, RB, WR
    }

    internal enum Skin
    {
        White, Black, Brown
    }
}
