﻿using SmitenightApp.Domain.Contracts.Gods;
using SmitenightApp.Domain.Contracts.Smitenights;
using SmitenightApp.Domain.Enums.SmiteClient;

namespace SmitenightApp.Domain.Contracts.Matches
{
    public class MatchDto
    {
        public string GameMap { get; set; } = null!;
        public GameModeQueueIdEnum GameModeQueue { get; set; }
        public int MatchDuration { get; set; }
        public int? TeamOneScore { get; set; }
        public int? TeamTwoScore { get; set; }
        public string Name { get; set; } = null!;
        public string Region { get; set; } = null!;
        public DateTime StartDate { get; set; }

        public List<GodBanDto> GodBans { get; set; }
        public List<MatchDetailDto> MatchDetails { get; set; }
        public List<SmitenightMatchDto> SmitenightMatches { get; set; }

        public MatchDto()
        {
            GodBans = new List<GodBanDto>();
            MatchDetails = new List<MatchDetailDto>();
            SmitenightMatches = new List<SmitenightMatchDto>();
        }
    }
}
