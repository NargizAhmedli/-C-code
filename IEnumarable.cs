using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    internal class User
    {
        List<Status> statuses = new List<Status>();
        public string Username { get; set; }
        public void ShareStatus(Status status)
        {
            statuses.Add(status);   
        }
        public string GetStatusByTitle(string title)
        {
            foreach (var item in statuses)
            {
                if (item.Title == title)
                {
                    return $"Ttile:{item.Title}";
                  
                }
                else
                {
                    throw new NotFoundException("Bele user yoxdu!");
                }

            }
            return null;
        }
    }
}
