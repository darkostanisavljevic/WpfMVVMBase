using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVVMBase.Models
{
    public class Guestbook
    {

        public string Name { get; }

        private readonly List<Guest> _entries;

        public Guestbook(string name, List<Guest> entries)
        {
            Name = name;
            _entries = entries;
        }

        public List<Guest> GetGuests()
        {
            return _entries;
        }

        public void AddGuest(Guest guest)
        {
            _entries.Add(guest);
        }
    }
}
