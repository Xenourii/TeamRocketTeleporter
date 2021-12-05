using RocketTeamTeleporter.Models;

namespace RocketTeamTeleporter.Maps;

public class SecondTeleporterMap : TeleporterMap
{ 
/*
 *
 * 1 -> 2 -> 3
 *      |    | 
 *      5 <- 4
 *
 * Answer is 5
 */

    public override List<TeleporterLink> GetMap()
    {
        var teleporter1 = new Teleporter(1);
        var teleporter2 = new Teleporter(2);
        var teleporter3 = new Teleporter(3);
        var teleporter4 = new Teleporter(4);
        var teleporter5 = new Teleporter(5);

        var transportLinks = new List<TeleporterLink>
        {
            new(teleporter1)
            {
                Next = teleporter2
            },
            new(teleporter2)
            {
                Next = teleporter3
            },
            new(teleporter3)
            {
                Next = teleporter4
            },
            new(teleporter4)
            {
                Next = teleporter5
            },
            new(teleporter5)
            {
                Next = teleporter2
            }
        };

        return transportLinks;
    }
}