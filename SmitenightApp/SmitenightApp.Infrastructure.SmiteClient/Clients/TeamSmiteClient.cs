﻿using AutoMapper;
using Microsoft.Extensions.Options;
using SmitenightApp.Abstractions.Infrastructure.SmiteClient;
using SmitenightApp.Domain.Clients.SmiteClient;
using SmitenightApp.Domain.Clients.TeamClient;
using SmitenightApp.Domain.Constants.SmiteClient;
using SmitenightApp.Infrastructure.SmiteClient.Contracts.TeamResponses;
using SmitenightApp.Infrastructure.SmiteClient.Models;
using SmitenightApp.Infrastructure.SmiteClient.Secrets;
using SmitenightApp.Infrastructure.SmiteClient.Settings;

namespace SmitenightApp.Infrastructure.SmiteClient.Clients
{
    public class TeamSmiteClient : SmiteClient, ITeamSmiteClient
    {
        public TeamSmiteClient(HttpClient httpClient,
            IOptions<SmiteClientSettings> smiteClientSettings,
            IOptions<SmiteClientSecrets> smiteClientSecrets,
            IMapper mapper) : base(httpClient, smiteClientSettings, smiteClientSecrets, mapper)
        {
        }

        public async Task<SmiteClientListResponse<TeamDetailsResponse>?> GetTeamDetailsAsync(
            string sessionId, int clanId, CancellationToken cancellationToken = default)
        {
            var urlPath = ConstructUrlPath(clanId);
            var request = new SmiteClientRequest(MethodNameConstants.TeamDetailsMethod, sessionId, urlPath);
            var result = await GetListAsync<TeamDetailsResponseDto>(request, cancellationToken);
            return Mapper.Map<SmiteClientListResponse<TeamDetailsResponse>>(result);
        }

        public async Task<SmiteClientListResponse<TeamPlayersResponse>?> GetTeamPlayersAsync(
            string sessionId, int clanId, CancellationToken cancellationToken = default)
        {
            var urlPath = ConstructUrlPath(clanId);
            var request = new SmiteClientRequest(MethodNameConstants.TeamPlayersMethod, sessionId, urlPath);
            var result = await GetListAsync<TeamPlayersResponseDto>(request, cancellationToken);
            return Mapper.Map<SmiteClientListResponse<TeamPlayersResponse>>(result);
        }

        public async Task<SmiteClientListResponse<SearchTeamsResponse>?> SearchTeamsAsync(
            string sessionId, string teamName, CancellationToken cancellationToken = default)
        {
            var urlPath = ConstructUrlPath(teamName);
            var request = new SmiteClientRequest(MethodNameConstants.SearchTeamsMethod, sessionId, urlPath);
            var result = await GetListAsync<SearchTeamsResponseDto>(request, cancellationToken);
            return Mapper.Map<SmiteClientListResponse<SearchTeamsResponse>>(result);
        }
    }
}
