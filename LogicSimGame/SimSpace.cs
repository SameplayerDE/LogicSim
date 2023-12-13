using LogicSimLib;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSimGame
{
    public static class SimSpace
    {

        public static double TickRate = 10;
        private static double _lastUpdate;

        public static List<(Gate gate, Vector2 position)> Gates = new();
        public static List<Wire> Wires = new();
        public static List<(Port ports, Vector2 position)> Ports = new();

        public static void Update(GameTime gameTime)
        {
            double rate = 1.0 / TickRate;
            double current = gameTime.TotalGameTime.TotalSeconds;
            if (current - _lastUpdate > rate)
            {
                Tick();
                _lastUpdate = current;
            }
        }

        private static void Tick()
        {
            foreach (var (port, position) in Ports)
            {
                
            }

            foreach (var wire in Wires)
            {
                
            }

            foreach (var (gate, position) in Gates)
            {
                
            }
        }
    }
}
