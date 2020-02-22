using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patent
{
    class dataBd
    {
        public dataBd() {}
        public List<int> datebasevalueStart = new List<int>();
        public List<int> datebasevalueEnd = new List<int>();
        public void setParam(string str) 
        {
            string[] parse = str.Split('-');
            if (parse.Length>1)
            {
                datebasevalueEnd.Add(int.Parse(parse[1]));
            }
            datebasevalueStart.Add(int.Parse(parse[0]));
        }
    }
}
