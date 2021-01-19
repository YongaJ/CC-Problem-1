using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_KeywordSearch
{
    public class Groups
    {
        public List<List<string>> GroupsOfItems()
        {
            //items inside groups added here: 
            var users = new List<string> { "Yonga", "Jacobs", "Jason Bourne", "Mariah Carey", "Eminem", "Tata Nelson Mandela", "Jan van Rebeek", "Oprah", "Ronaldo", "Thabo", "Arnold", "Gerrard", "Yongama", "Zukile" };
            var userGroups = new List<string> { "President", "Actor/(s)", "Singer", "Soccer Player", "Explorer", "Doctor", "Teacher" };
            var userActivityLog = new List<string> { "Users", "Yonga", "Documents", "CC", "Problem1_ KeywordSearch", "Problem1_Keyword Search", "bin", "Debug", "Problem1_ KeywordSearch .exe" };
            var listOfGroups = new List<List<string>>();
            listOfGroups.Add(users);
            listOfGroups.Add(userGroups);
            listOfGroups.Add(userActivityLog);

            return listOfGroups;
        }
        
    }
}
