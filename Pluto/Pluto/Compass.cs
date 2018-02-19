using System;
using Pluto.Interfaces;

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
            throw new NotImplementedException();
        }
    }
}
