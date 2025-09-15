using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;
            int step = 1;
            // code here
            for (int i; i < n; i++)
            {
                answer += step;
                
                step = 1/x;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here

            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}