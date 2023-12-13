using LogicSimLib;
using LogicSimLib.Gates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSimGame
{
    public class GateRenderer
    {

        public static Texture2D PortTexture;
        public static Texture2D AndGateTexture;
        public static Texture2D OrGateTexture;
        public static Texture2D NotGateTexture;

        public static void Render(SpriteBatch spriteBatch, Gate gate, Vector2 position)
        {
            if (gate == null)
            {
                return;
            }

            if (gate is AndGate specifiedGate)
            {
                RenderAndGate(spriteBatch, specifiedGate, position);
            }

        }

        private static void RenderPort(SpriteBatch spriteBatch, Port port, Vector2 position)
        {
            spriteBatch.Draw(PortTexture, position, port.State ? Color.Red : Color.White);
        }

        private static void RenderAndGate(SpriteBatch spriteBatch, AndGate gate, Vector2 position)
        {
            spriteBatch.Draw(AndGateTexture, position, Color.White);
            RenderPort(spriteBatch, gate.InA, position);
            RenderPort(spriteBatch, gate.InB, position);
            RenderPort(spriteBatch, gate.OutA, position);
        }
    }
}
