using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swin_Adventure._2
{
    public class IdentifiableObject
    {
        private List<string> _Identifiers;

        public IdentifiableObject(string[] idents)
        {
            _Identifiers = new List<string>(idents);
        }
        public bool AreYou(string id)
        {
            return _Identifiers.Contains(id.ToLower());
        }
        public string FirstId
        {
            get
            {
                if (_Identifiers.Count == 0)
                {
                    return "";
                }
                else
                {
                    return _Identifiers[0];
                }
            }
        }
        public void AddIdentifier(string id)
        {
            _Identifiers.Add(id.ToLower());
            
        }
        public void PrivilegeEscalation(string pin)
        {
            string studentid = "103995219";
            if (studentid.Substring(studentid.Length - 4) == pin)
            {

                _Identifiers[0] = "8";
            }
        }
        
    }
}

