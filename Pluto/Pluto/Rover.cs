using Pluto.Interfaces;

namespace Pluto
{
    public class Rover
    {
        private int _x;
        private int _y;
        private ICompass _compass;

        public Rover(int x, int y, ICompass compass)
        {
            _x = x;
            _y = y;
            _compass = compass;
        }

        public void ExecuteOrder(string message)
        {
            foreach (char command in message)
            {
                if (command == 'F')
                {
                    Move(1);
                }
                else if (command == 'B')
                {
                    Move(-1);
                }
                else if (command == 'R' || command == 'L')
                {
                    _compass.Turn(command);
                }
            }
        }

        private void Move(int speed)
        {
            switch (_compass.GetDirection())
            {
                case 'N':
                    _y = _y + speed;
                    break;
                case 'S':
                    _y = _y - speed;
                    break;

                case 'E':
                    _x = _x + speed;
                    break;

                case 'W':
                    _x = _x - speed;
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
