using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Token {
    public class ThingsBoardCredentials {

        public string username { get; set; }

        public string password { get; set; }

        public ThingsBoardCredentials(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
}
