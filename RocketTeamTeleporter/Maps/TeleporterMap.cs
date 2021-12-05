using RocketTeamTeleporter.Models;

namespace RocketTeamTeleporter.Maps;

public abstract class TeleporterMap
{
    private const int MaxSize = 10_000;

    /// <summary>
    /// Get the links of teleporters.
    /// The first teleporter will be used as starting point.
    /// </summary>
    /// <returns></returns>
    public abstract List<TeleporterLink> GetMap();

    protected TeleporterMap()
    {
        if (GetMap().Count > MaxSize)
            throw new ArgumentException("Too much transports");
    }
}