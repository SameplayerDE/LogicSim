using Microsoft.Xna.Framework;

namespace LogicSimLib.Gates;

public class NotGate : Gate
{
    public Input InA;
    public Output OutA;

    public override void Calculate()
    {
        OutA.State = !InA.State;
    }

    public override void Update(GameTime gameTime)
    {

    }
}
