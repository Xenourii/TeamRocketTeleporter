namespace RocketTeamTeleporter.Models;

public record Teleporter(int Id)
{
    public virtual bool Equals(Teleporter? other)
    {
        if (other is null)
            return false;

        return other.Id == Id;
    }

    public override int GetHashCode() => Id.GetHashCode();
}