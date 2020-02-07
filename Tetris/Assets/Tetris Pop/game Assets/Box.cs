using UnityEngine;
using System.Collections;
using System; //This allows the IComparable Interface

//This is the class you will be storing
//in the different collections. In order to use
//a collection's Sort() method, this class needs to
//implement the IComparable interface.
public class Box : IComparable<Box>
{
		public GameObject box;
		public int color;
		public int count;
		public int col;
		public int row;


		public Box(GameObject newBox, int newcolor, int newCount, int newCol, int newRow)
		{
				box = newBox;
				color = newcolor;
				count = newCount;
				col = newCol;
				row = newRow;
		}

		//This method is required by the IComparable
		//interface. 
		public int CompareTo(Box other)
		{
				if(other == null)
						return 0;

					//Return same color.
				if(other.color == color)
					return 1;
				return 0;
		}
}