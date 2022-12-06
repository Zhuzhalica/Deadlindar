using System;
using System.Collections.Generic;

namespace WebApiClient
{
    public class Day
    {
        public List<Case> Cases = new List<Case>();
        private readonly DateTime day;

        public Day(DateTime day)
        {
            this.day = day;
        }
        
        
    }
}