using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bodlogo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = { { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } }, { { 9, 10, 11, 12 }, { 13, 14, 15, 16 } } };

            int[,] res = TwoArray(arr);
            for(int i = 0; i< res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++) {
                    Console.Write(res[i,j] + "," );
                    
                }
            }
            

        }
        static int[,] TwoArray(int[,,] arr)
        {
            
            List<int> r = new List<int>();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {

                        if (arr[i, j, k] % 2 == 0)
                        {
                            r.Add(arr[i, j, k]);                     
                        }
                    }
                }
            }

            int[] rs = r.ToArray();
            int h = 4;
            int[,] res = converTo2dArray(rs, h, rs.Length / h);

            return res;
        }
        public static int[,] converTo2dArray(int[] arr, int h, int w)
        {
            int[,] res = new int[h, w];
            for (int i = 0; i < h; i++) { 
                for(int j = 0; j < w; j++)
                {
                    res[i, j] = arr[i*w +j ];
                }
            }
            return res;
        }
       
    }
}
