namespace LogicSimLib;

public class Port
{
    public PortType Type;
    public bool State;

    public Port(PortType type = PortType.Input)
    {
        Type = type;
    }
}

public class Input : Port
{
    public Input() : base(PortType.Input) { }
}

public class Output : Port
{
    public Output() : base(PortType.Output) { }
}