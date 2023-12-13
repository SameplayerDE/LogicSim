using Microsoft.Xna.Framework;

namespace LogicSimLib.Gates;

public class OrGate : Gate
{
    public Input InA;
    public Input InB;
    public Output OutA;

    public override void Calculate()
    {
        OutA.State = InA.State || InB.State;
    }

    public override void Update(GameTime gameTime)
    {

    }
}
