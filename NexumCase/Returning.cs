using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexumCase
{
    public class Returning
    {
        //Kordinat için gerek yön tanımlamaları
        public int x;
        public int y;
        public string position;
        public Returning(string location)
        {
            Int32.TryParse(location.Split(" ")[0], out x); 
            Int32.TryParse(location.Split(" ")[1], out y);
            position = location.Split(" ")[2];           

        }

        public void TurnLeft()
        {
            switch (position)
            {
                case "N": 
                    position = "W";
                    break;
                case "E":
                    position = "N";
                    break;
                case "S":
                    position = "E";
                    break;
                case "W":
                    position = "S";
                    break;
                default:
                    break;
            }
        }

        public void TurnRight()
        {
            switch (position)
            {
                case "N":
                    position = "E";
                    break;
                case "E":
                    position = "S";
                    break;
                case "S":
                    position = "W";
                    break;
                case "W":
                    position = "N";
                    break;
                default:
                    break;
            }
        }

        public void Forward()
        {
            switch (position)
            {
                case "N":
                    y++;
                    break;
                case "E":
                    x++;
                    break;
                case "S":
                    y--;
                    break;
                case "W":
                    x--;
                    break;
                default:
                    break;
            }
        }

        public void Progress(string progressC)
        {
            char[] progressCommand = progressC.ToCharArray();
            for (int i = 0; i < progressCommand.Length; i++)
            {
                switch (progressCommand[i])
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        Forward();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
