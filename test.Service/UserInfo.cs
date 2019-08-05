using System.Collections.Generic;

namespace test.Service
{
    public class UserInfo
    {
        public int Id;
        public string Name;
        public string DefaultName;
        public string Groupid;
        public string email;
        public string Phone;
        public string Rights;
        public override string ToString()
        {
            return Id+"\t"+Name+"\t"+DefaultName + "\t"+Groupid;
        }
    }
    public enum Right{
        Read=0,Write=1
    }
}