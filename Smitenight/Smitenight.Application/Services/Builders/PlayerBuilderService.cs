﻿using Smitenight.Abstractions.Application.Services.Builders;
using Smitenight.Domain.Clients.SmiteClient.Responses.MatchResponses;
using Smitenight.Domain.Enums.SmiteClient;
using Smitenight.Domain.Models.Players;

namespace Smitenight.Application.Services.Builders
{
    public class PlayerBuilderService : IPlayerBuilderService
    {
        public Player Build(MatchDetailsResponse matchDetails, CancellationToken cancellationToken = default)
        {
            var player = new Player
            {
                HirezGamerTag = matchDetails.HzGamerTag,
                HirezPlayerName = matchDetails.HzPlayerName,
                LastSynchronizedMatchId = matchDetails.Match,
                Level = matchDetails.AccountLevel,
                MasteryLevel = matchDetails.MasteryLevel,
                PlayerName = matchDetails.PlayerName,
                PrivacyEnabled = false,
            };

            if (!string.IsNullOrWhiteSpace(matchDetails.PlayerPortalId) && int.TryParse(matchDetails.PlayerPortalId, out var parsedPlayerPortalId))
            {
                player.PortalType = (PortalTypeEnum)parsedPlayerPortalId;
            }

            if (!string.IsNullOrWhiteSpace(matchDetails.PlayerId) && int.TryParse(matchDetails.PlayerId, out var parsedPlayerId))
            {
                player.SmiteId = parsedPlayerId;
            }

            if (!string.IsNullOrWhiteSpace(matchDetails.PlayerPortalUserId) && long.TryParse(matchDetails.PlayerPortalUserId, out var parsedPlayerPortalUserId))
            {
                player.SmitePortalUserId = parsedPlayerPortalUserId;
            }
            
            return player;
        }

        public Player BuildAnonymous(MatchDetailsResponse matchDetails, CancellationToken cancellationToken = default)
        {
            return new Player
            {
                Level = matchDetails.AccountLevel,
                MasteryLevel = matchDetails.MasteryLevel,
                PrivacyEnabled = true,
            };
        }
    }
}
