using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_5
{
    internal class ChessPiece
    {
        public string Name;
        public string Position;

        public ChessPiece(string name, string position)
        {
            if (position.Length != 2 || position[0] < 'A' || position[0] > 'H' || position[1] < '1' || position[1] > '8')
            {
                throw new ArgumentException("Invlaid Input creating chess");

            }
            else
            {
                Name = name;
                Position = position;
            }
        }

        public void Move(string newPosition)
        {
            if (newPosition.Length != 2 || newPosition[0] < 'A' || newPosition[0] > 'H' || newPosition[1] < '1' || newPosition[1] > '8')
            {
                throw new ArgumentException("Invalid input for moving ");
            }

            //Я не придумал :(
        }
    }
}
