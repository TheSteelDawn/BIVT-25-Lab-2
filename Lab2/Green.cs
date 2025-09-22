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
            // for (int i; i < n; i++)
            // {
            //     answer += step;
                
            //     step = 1/x;
            // }
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
            double currentx = x;
            double currentsin = Math.Sin(x);
            int i = 1;
            while (Math.Abs(currentsin) >= E)
            {
                answer += currentsin;
                i++;
                currentx *= x;
                currentsin = Math.Sin(i * currentx);
            }

            // end

                return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double currentx = 1 / x;
            int i = 1;
            while (Math.Abs(currentx - currentx / x) > E)
            {
                answer = i;
                i++;
                currentx /= x;
            }
            answer += 2;


            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;
            int i = 0;
            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i++;
            }

            // end

                return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            while (L > Da)
            {
                L /= 2;
                answer += 1;
            }

            // end

                return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            int i = 0;
            double x = a;
            double vremx = 1;
            
            while (x >= a && x <= b)
            {
                if (Math.Abs(vremx) < E)
                {
                    break;
                }
                vremx = Math.Pow(-1, i)*(double)(Math.Pow(x, 2 * i + 1)) / (2 * i + 1);
                SS += vremx;
                i++;
                x += h;

            }
            x = a;
            while (x >= a && x <= b)
            {
                x += h;
                SY += Math.Round(Math.Atan(x), 6);
            }
            SY = Math.Round(SY, 6);
                // end

            return (SS, SY);
        }
    }
}