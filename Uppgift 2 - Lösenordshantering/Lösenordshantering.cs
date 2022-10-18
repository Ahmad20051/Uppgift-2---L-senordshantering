using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_2___Lösenordshantering
{
    public class info
    {
        public class lösenordinfo
        {
            private string lösenord = ",";

            public string visalösenord()
            {
                return this.lösenord;
            }


            public void setlösenord(string lösenord)
            {
                this.lösenord = lösenord;
            }

            public void getlösenord(string lösenord)
            {
                _ = this.lösenord != lösenord;
            }
        }
    }
}
