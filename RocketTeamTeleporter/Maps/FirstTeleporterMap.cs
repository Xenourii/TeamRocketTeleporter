using RocketTeamTeleporter.Models;

namespace RocketTeamTeleporter.Maps;

public class FirstTeleporterMap : TeleporterMap
{ 
    /*       5
 *           |
 * 1 -> 2 -> 3 -> 4
 *           |
 *           6
 *
 * Answer is 4
 */

    public override List<TeleporterLink> GetMap()
    {
        var teleporter1 = new Teleporter(1);
        var teleporter2 = new Teleporter(2);
        var teleporter3 = new Teleporter(3);
        var teleporter4 = new Teleporter(4);
        var teleporter5 = new Teleporter(5);
        var teleporter6 = new Teleporter(6);

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
            new(teleporter4),
            new(teleporter5)
            {
                Next = teleporter3
            },
            new(teleporter6)
            {
                Next = teleporter3
            }
        };

        return transportLinks;
    }
}