using System;
namespace GeoApi.Domain.Entities
{
    public class Survey
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CreatedByUserId { get; set; }
        public List<Question> Questions { get; set; }
        public List<SurveyResponse>? SurveyResponses { get; set; }
    }
}

