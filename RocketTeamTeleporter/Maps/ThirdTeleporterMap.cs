using RocketTeamTeleporter.Models;

namespace RocketTeamTeleporter.Maps;

public class ThirdTeleporterMap : TeleporterMap
{
    public override List<TeleporterLink> GetMap() => new() {new TeleporterLink(new Teleporter(0))};
}