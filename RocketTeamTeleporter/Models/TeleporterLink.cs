namespace RocketTeamTeleporter.Models;

public class TeleporterLink
{
    public Teleporter Current { get; }
    public Teleporter? Next { get; set; }

    public TeleporterLink(Teleporter current)
    {
        Current = current;
    }

    public bool IsLinkedToAnotherTeleporter => Next is not null;
}