using RocketTeamTeleporter.Maps;

namespace RocketTeamTeleporter.Models;

public class Player
{
    private readonly List<Teleporter> _alreadyUsedTeleporters = new();
    private readonly TeleporterMap _teleporterMap;
    private Teleporter _currentTeleporter;
    private bool _isOnLastTeleporter;

    public Player(TeleporterMap teleporterMap)
    {
        var firstTeleporterLink = teleporterMap.GetMap().First();

        _currentTeleporter = firstTeleporterLink.Current;
        if (!firstTeleporterLink.IsLinkedToAnotherTeleporter)
            _isOnLastTeleporter = true;

        _alreadyUsedTeleporters.Add(_currentTeleporter);
        _teleporterMap = teleporterMap;
    }

    public Teleporter FindLatestTeleporter()
    {
        do
        {
            Move();
        } while (!_isOnLastTeleporter);

        return _currentTeleporter;
    }

    private void Move()
    {
        var teleporterLink = GetTeleporterLinkOf(_currentTeleporter);

        if (!teleporterLink.IsLinkedToAnotherTeleporter)
        {
            _isOnLastTeleporter = true;
            return;
        }

        var nextTeleporter = teleporterLink.Next!;
        if (IsTransportAlreadyUsed(nextTeleporter))
        {
            _isOnLastTeleporter = true;
            return;
        }

        _currentTeleporter = nextTeleporter;
        _alreadyUsedTeleporters.Add(_currentTeleporter);
    }

    private TeleporterLink GetTeleporterLinkOf(Teleporter teleporter)
    {
        var teleporterLink = _teleporterMap
            .GetMap()
            .Find(tl => tl.Current == teleporter);

        if (teleporterLink is null)
            throw new Exception($"Unable to find teleporter {_currentTeleporter}");

        return teleporterLink;
    }

    private bool IsTransportAlreadyUsed(Teleporter teleporter) =>
        _alreadyUsedTeleporters.Contains(teleporter);
}