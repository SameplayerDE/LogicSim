using Microsoft.Xna.Framework;

namespace LogicSimLib;

public abstract class Gate : LogicObject
{
    public abstract void Calculate();
    public abstract void Update(GameTime gameTime);
}
