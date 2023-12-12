namespace LogicSimLib.Gates;

public class AndGate : Gate
{
    public bool InA;
    public bool InB;
    private bool _outA;

    public bool OutA
    {
        get { return _outA; }
    }

    public override bool Calculate()
    {
        _outA = InA && InB;
        return _outA;
    }
}
