using System;
using System.Drawing;

namespace WebApiClient
{
    public class Case
    {
        public TimeInterval TimeInterval { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public GoalType Type { get; private set; }

        public Case(string title, string description = "", GoalType type = default, TimeInterval timeInterval= default)
        {
            this.Title = title;
            this.Description = description;
            this.Type = type;
            this.TimeInterval = timeInterval;
        }

        public void ChangeTitle(string title)
        {
            this.Title = title;
        }
        
        public void ChangeDescription(string description)
        {
            this.Description = description;
        }
        
        public void ResetTime(DateTime startTime, DateTime endTime)
        {
            this.TimeInterval = new TimeInterval(startTime, endTime);
        }
        
        public void ChangeType(GoalType type)
        {
            this.Type = type;
        }
    }
}