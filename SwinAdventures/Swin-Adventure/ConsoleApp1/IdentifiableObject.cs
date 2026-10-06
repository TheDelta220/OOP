using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swin_Adventure
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
            return _Identifiers.Contains(id);
        }
        public string FirstId
        {
            get
            {
                return _Identifiers[0];
            }
        }
        public string AddIdentifier(string _Identifiers)
        {
            _Identifiers.ToLower();
            return _Identifiers;
        }
        public void PrivilegeEscalation(string pin)
        {
            if(pin.Length == 4)
            {
                
                pin = "1234"; //I don't know what a tutorial ID is
            }
        }
        public void ReplaceFirstId(string newId)
        {
            if (_Identifiers.Count > 0)
            {
                _Identifiers[0] = newId;
            }
        }
    }
}

