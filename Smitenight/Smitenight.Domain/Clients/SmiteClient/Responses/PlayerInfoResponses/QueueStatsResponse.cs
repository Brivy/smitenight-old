﻿namespace Smitenight.Domain.Clients.SmiteClient.Responses.PlayerInfoResponses
{
    public record class QueueStatsResponse
    (
        int Assists,
        int Deaths,
        string God,
        int GodId,
        int Gold,
        int Kills,
        string LastPlayed,
        int Losses,
        int Matches,
        int Minutes,
        string Queue,
        int Wins,
        string PlayerId,
        object RetMsg
    );
}
