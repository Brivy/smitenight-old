﻿using SmitenightApp.Domain.Constants.SmiteClient;

namespace SmitenightApp.Domain.Clients.SmiteClient.Requests.OtherRequests
{
    public record class EsportProLeagueRequest() : SmiteClientRequest(MethodNameConstants.EsportProLeagueMethod);
}
