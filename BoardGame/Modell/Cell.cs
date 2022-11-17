using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh.Modell
{
    public class Cell
    {
        public Cell(int rows, int colums)
        {
            Rows = rows;
            Colums = colums;
        }

        public int Rows { get; set; }
        public int Colums { get; set; }
        public bool isOcupiedbyP1 { get; set; }
        public bool isOcupiedbyP2 { get; set; }
        public bool isLegal { get; set; }
        
        public string Character { get; set; }



    }

    




}
