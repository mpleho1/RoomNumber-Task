using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomNumber
{
    public class RoomNumbers
    {
        public RoomNumbers()
        {

        }

		public int[] numberArray(int roomNumber)
		{
			int[] numArray = new int[10];
			while (roomNumber != 0)
			{
				numArray[roomNumber % 10]++;
				roomNumber /= 10;
			}

			return numArray;
		}

		public int numberOfSets(int roomNumber)
		{
			if (roomNumber <= 0 || roomNumber > 1000000)
			{
				Console.WriteLine("Invalid number. Try again.");
				return -1;
			}

			int[] numArray = numberArray(roomNumber);

			int set = (int)System.Math.Ceiling((numArray[6] + numArray[9]) / 2.0);

			for (int i = 0; i < numArray.Length; i++)
			{
				if (i == 6 || i == 9)
				{
					continue;
				}
				set = System.Math.Max(set, numArray[i]);
			}
			return set;
		}
	}
}
