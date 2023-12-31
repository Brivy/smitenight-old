﻿using System.Net;

namespace SmitenightApp.Infrastructure.SmiteClient.Contracts
{
    public record class SmiteClientResponseDto(HttpStatusCode StatusCode, string? ReasonPhrase);

    public record class SmiteClientResponseDto<TResponse>(HttpStatusCode StatusCode, string? ReasonPhrase, TResponse? Response)
        : SmiteClientResponseDto(StatusCode, ReasonPhrase) where TResponse : class;

    public record class SmiteClientListResponseDto<TResponse>(HttpStatusCode StatusCode, string? ReasonPhrase, List<TResponse>? Response)
        : SmiteClientResponseDto(StatusCode, ReasonPhrase) where TResponse : class;
}
