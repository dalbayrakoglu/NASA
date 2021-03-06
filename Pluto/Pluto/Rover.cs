﻿using Pluto.Helpers;
using Pluto.Interfaces;

namespace Pluto
{
    public class Rover
    {
        private int _x;
        private int _y;
        private ICompass _compass;
        private const int _mapXSize = 100;
        private const int _mapYSize = 100;

        public Rover(int x, int y, ICompass compass)
        {
            _x = x;
            _y = y;
            _compass = compass;
        }

        //66
        public void ExecuteOrder(string message)
        {
            foreach (char command in message)
            {
                if (command == 'F' || command == 'B')
                {
                    Move(command);
                }
                else if (command == 'R' || command == 'L')
                {
                    _compass.Turn(command);
                }
                else
                {
                    //Exit if any command is invalid, do not want to get lost
                    break;
                }
            }
        }

        private void Move(char command)
        {
            int speed = command == 'F' ? 1 : -1;

            switch (_compass.GetDirection())
            {
                case 'N':
                    _y = MathHelper.Modulo(_y + speed, _mapYSize);
                    break;

                case 'S':
                    _y = MathHelper.Modulo(_y - speed, _mapYSize);
                    break;

                case 'E':
                    _x = MathHelper.Modulo(_x + speed, _mapXSize);
                    break;

                case 'W':
                    _x = MathHelper.Modulo(_x - speed, _mapXSize);
                    break;
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

        public char GetDirection()
        {
            return _compass.GetDirection();
        }
    }
}
