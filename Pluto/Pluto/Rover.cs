using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluto
{
    public class Rover
    {
        private int _x;
        private int _y;
        private char _direction;

        public Rover(int x, int y, char direction)
        {
            _x = x;
            _y = y;
            _direction = direction;
        }

        public void ExecuteOrder(string message)
        {
            foreach (char command in message)
            {
                if (command == 'F')
                {
                    _y++;
                }
                else if (command == 'B')
                {
                    _y--;
                }
            }
        }

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
        }
    }
}
