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
                int speed = 0;

                if (command == 'F')
                {
                    speed = 1;
                }
                else if (command == 'B')
                {
                    speed = -1;
                }

                if (_direction == 'N')
                {
                    _y = _y + speed;
                }

                if (_direction == 'S')
                {
                    _y = _y - speed;
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

        public char GetDirection()
        {
            return _direction;
        }
    }
}
