using System;
using System.Collections.Generic;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents) {
            return contents.ToArray();
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            if (contents.Count != length1 * length2 * length3)
            {
                throw new ArgumentException(String.Format("Number of elements in list must match array size"));
            }
            else { 
                string[,,] matrix = new string[length1, length2, length3];
                
                int contentSelector = 0;

            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length2; j++)
                {
                    for (int k = 0; k < length3; k++)
                    {
                        matrix[i, j, k] = contents[contentSelector];
                        contentSelector++;
                    }
                }
            }
            return matrix;
        }
    }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            if (contents.Count != countRow1 + countRow2)
            {
                throw new ArgumentException(String.Format("Number of elements in list must match array size"));
            }
            else
            {
                string[] row1Data = new string[countRow1];
                string[] row2Data = new string[countRow2];

                for (int i = 0; i < countRow1; i++)
                {
                    row1Data[i] = contents[i];
                }

                for (int i = 0; i < countRow2; i++)
                {
                    row2Data[i] = contents[i + countRow1];
                }


                string[][] matrix = new string[2][];
                matrix[0] = row1Data;
                matrix[1] = row2Data;

                return matrix;
            }
        }
        
    }
}
