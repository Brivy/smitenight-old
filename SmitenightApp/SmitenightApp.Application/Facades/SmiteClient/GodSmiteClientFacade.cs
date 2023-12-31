﻿using SmitenightApp.Abstractions.Application.Facades.SmiteClient;
using SmitenightApp.Abstractions.Application.Services.Cache;
using SmitenightApp.Abstractions.Infrastructure.SmiteClient;
using SmitenightApp.Domain.Clients.GodClient;
using SmitenightApp.Domain.Clients.SmiteClient;
using SmitenightApp.Domain.Enums.SmiteClient;

namespace SmitenightApp.Application.Facades.SmiteClient
{
    /// <summary>
    /// Simplified version without sessionId of <see cref="IGodSmiteClient"/>
    /// </summary>
    public class GodSmiteClientFacade : IGodSmiteClientFacade
    {
        private readonly IGodSmiteClient _godSmiteClient;
        private readonly ISmiteSessionCacheService _smiteSessionCacheService;

        public GodSmiteClientFacade(
            IGodSmiteClient godSmiteClient,
            ISmiteSessionCacheService smiteSessionCacheService)
        {
            _godSmiteClient = godSmiteClient;
            _smiteSessionCacheService = smiteSessionCacheService;
        }

        public async Task<SmiteClientListResponse<GodsResponse>?> GetGodsAsync(LanguageCodeEnum languageCode, CancellationToken cancellationToken = default) =>
            await _godSmiteClient.GetGodsAsync(await _smiteSessionCacheService.GetSessionIdAsync(cancellationToken), languageCode, cancellationToken);

        public async Task<SmiteClientListResponse<GodLeaderbordResponse>?> GetGodLeaderbordAsync(int godId, GameModeQueueIdEnum gameModeQueueId, CancellationToken cancellationToken = default) =>
            await _godSmiteClient.GetGodLeaderbordAsync(await _smiteSessionCacheService.GetSessionIdAsync(cancellationToken), godId, gameModeQueueId, cancellationToken);

        public async Task<SmiteClientListResponse<GodAltAbilitiesResponse>?> GetGodAltAbilitiesAsync(CancellationToken cancellationToken = default) =>
            await _godSmiteClient.GetGodAltAbilitiesAsync(await _smiteSessionCacheService.GetSessionIdAsync(cancellationToken), cancellationToken);

        public async Task<SmiteClientListResponse<GodSkinsResponse>?> GetGodSkinsAsync(int godId, LanguageCodeEnum languageCode, CancellationToken cancellationToken = default) =>
            await _godSmiteClient.GetGodSkinsAsync(await _smiteSessionCacheService.GetSessionIdAsync(cancellationToken), godId, languageCode, cancellationToken);
    }
}
