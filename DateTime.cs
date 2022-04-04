using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    internal class MeetingSchedule
    {
        List<Meeting> meetingList;
        private object meeting;

        public string SetMeeting(string name, DateTime fromdate, DateTime todate, DateTime inputdate)
        {
            if(inputdate>fromdate && inputdate < todate)
            {
                throw new Exception("bu tarix intervalinda meeting var");
            }
            else
            {
                string Names = meeting.Add(name);
            }
        }
        public int FindMeetingsCount(DateTime date, DateTime fromdate)
        {
            if (date == null)
            {
                int count = 0;
                if(date < fromdate)
                {
                    count++;
                }
                return count;
            }
        }
        public bool IsExistsMeetingByName(string value, string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                if (name == meeting.Name)
                {
                    return true;
                }

                return false;
            }   
            return true;
        }
        public List<string> GetExistMeetings(string name)
        {
            List<string> findname = new List<string>();
            if (!string.IsNullOrEmpty(name))
            {
                if(name == meeting.Name)
                {
                    findname.Add(name);
                }
                return null;
            }
        }
    }
}
