﻿namespace SmitenightApp.Domain.Clients.SystemClient
{
    public record class HirezServerStatusResponse(
        string EntryDatetime, 
        string Environment, 
        bool LimitedAccess,
        string Platform, 
        object RetMsg, 
        string Status, 
        string Version);
}