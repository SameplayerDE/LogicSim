namespace LogicSimLib.Gates;

public class NotGate : Gate
{
    public bool InA;
    private bool _outA;

    public bool OutA
    {
        get { return _outA; }
    }

    public override bool Calculate()
    {
        _outA = !InA;
        return _outA;
    }
}
