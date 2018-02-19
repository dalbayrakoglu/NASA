using System;
using Pluto.Interfaces;
using Pluto.Helpers;

namespace Pluto
{
    public class Compass : ICompass
    {
        private int _directionIndex { get; set; }
        private char[] _cardinalDirections = { 'N', 'E', 'S', 'W' };

        public Compass(char direction)
        {
            _directionIndex = Array.IndexOf(_cardinalDirections, direction);
        }
        public char GetDirection()
        {
            return _cardinalDirections[_directionIndex];
        }

        public void Turn(char steer)
        {
            if (steer == 'R')
            {
                _directionIndex = MathHelper.Modulo(_directionIndex + 1, _cardinalDirections.Length);
            }
            else if (steer == 'L')
            {
                _directionIndex = MathHelper.Modulo(_directionIndex - 1, _cardinalDirections.Length);
            }
        }
    }
}
