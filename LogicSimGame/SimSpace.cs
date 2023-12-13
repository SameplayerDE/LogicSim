using Microsoft.Xna.Framework;
using System;

public static class SimSpace
{
    public static double TickRate = 60; // Ticks pro Sekunde
    private static double _nextTickTime;
    private static int _ticksThisSecond = 0;
    private static double _lastSecondUpdateTime;

    public static void Initialize()
    {
        _nextTickTime = DateTime.UtcNow.TimeOfDay.TotalSeconds;
        _lastSecondUpdateTime = _nextTickTime;
    }

    public static void Update(GameTime gameTime)
    {
        double currentTime = DateTime.UtcNow.TimeOfDay.TotalSeconds;

        while (currentTime >= _nextTickTime)
        {
            Tick();
            _nextTickTime += 1.0 / TickRate;
            _ticksThisSecond++;
        }

        if (currentTime - _lastSecondUpdateTime >= 1.0)
        {
            Console.WriteLine($"TPS: {_ticksThisSecond}");
            _ticksThisSecond = 0;
            _lastSecondUpdateTime = currentTime;
        }
    }

    private static void Tick()
    {
        // Implementiere hier die Logik für jeden Tick
    }
}
