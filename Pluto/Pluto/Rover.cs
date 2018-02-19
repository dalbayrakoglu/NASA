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
                    Move(1);
                }
                else if (command == 'B')
                {
                    Move(-1);
                }
                else if (command == 'R')
                {
                    TurnRight();
                }
            }
        }

        private void TurnRight()
        {
            switch (_direction)
            {
                case 'N':
                    _direction = 'E';
                    break;
                case 'E':
                    _direction = 'S';
                    break;
                case 'S':
                    _direction = 'W';
                    break;
                case 'W':
                    _direction = 'N';
                    break;
            }
        }

        private void Move(int speed)
        {
            switch (_direction)
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
            return _direction;
        }
    }
}
