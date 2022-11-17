using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh.Modell
{
    public class Game
    {
        public string turn { get; set; }
        public bool isPlayer1turn{ get; set; }


        public void gameturnLoop(int i)
        {
            while (i < 4)
            {
                switch (i)
                {
                    case 1: turn = "1"; break;
                    case 2: turn = "2"; break;
                    case 3: turn = "3"; break;
                    case 4: turn = "4"; break;
                    default: i = 0; break;
            }

            }

        }
    



    }









}
