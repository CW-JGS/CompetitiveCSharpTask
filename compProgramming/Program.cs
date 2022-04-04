using System;

namespace Comp {
    class Program {
        static void Main(string[] args)
        {
            int[] points = new int[6];
            for(int i = 0; i < 6; i++) {
                bool isValid = int.TryParse(Console.ReadLine(), out points[i]);
                if (!isValid) {
                    i--;
                }
            }
            bool StraightLine = isOnStraightLine(points[0],points[1],points[2],points[3],points[4],points[5]);
            if (StraightLine) {
                System.Console.WriteLine("({0}, {1}), ({2}, {3}), ({4}, {5}) are all on a straight line", points[0],points[1],points[2],points[3],points[4],points[5]);
            }else {
                System.Console.WriteLine("({0}, {1}), ({2}, {3}), ({4}, {5}) are not on a straight line", points[0],points[1],points[2],points[3],points[4],points[5]);

            }
        }
        void solution1() {
            int bucket = 0;
            for(int i =0; i <1000; i++) {
                if(i % 3 == 0 || i % 5 == 0) {
                    bucket += i;
                } 
            }
            Console.WriteLine(bucket);

        }

        int sum(int num1, int num2) {
            return num1 + num2;
        }
        static bool isOnStraightLine(int x1, int y1, int x2, int y2, int x3, int y3) {
            int m = (y2 - y1)/(x2 - x1);
            int n = (y3 - y2)/(x3 - x2);
            if(m == n ) {
                return true;
            } else {
                return false;
            }

        }
    }
}