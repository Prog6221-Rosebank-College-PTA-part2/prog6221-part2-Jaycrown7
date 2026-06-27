using System;
using System.Collections.Generic;

namespace BOTGUI.Services
{
    public class ActivityLogger
    {
        private List<string> activities = new List<string>();

        public void Log(string activity)
        {
            string logEntry = DateTime.Now.ToString("HH:mm:ss")
                              + " - "
                              + activity;

            activities.Add(logEntry);
        }

        public List<string> GetRecentActivities()
        {
            if (activities.Count <= 10)
                return activities;

            return activities.GetRange(
                activities.Count - 10,
                10);
        }
    }
}