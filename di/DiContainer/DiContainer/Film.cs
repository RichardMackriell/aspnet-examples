using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiContainer
{
    internal class Film
    {
        public string Title { get; set; }
        public int RunningTime { get; set; }

        public override string ToString()
        {
            return $"{Title} runs for {RunningTime}";
        }
    }
}
