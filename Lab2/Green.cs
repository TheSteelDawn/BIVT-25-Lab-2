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
            double i;
            int ii = 2;
            while (ii <= n)
            {
                i = (double)ii / (ii + 1);
                answer += i;
                ii += 2;
            }

            // end

                return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;
            // code here
            double vremx = x;
            for (int i = 0; i <= n; i++)
            {
                answer += x / vremx;
                vremx *= x;
            }
            // end

                return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long fac = 1;
            int ii = 2;
            for (int i = 0; i < n; i++)
            {
                answer += fac;
                fac *= ii;
                ii++;
            }
            answer += 1;

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
            const double epsilon = 0.0001;
            const int maxIterations = 10000;
            
            if (h == 0)
            {
                double x = a;
                double s = 0;
                double term = x;
                int i = 0;
                
                while (i < maxIterations && Math.Abs(term) >= epsilon)
                {
                    s += term;
                    i++;
                    term = term * (-x * x) * (2 * i - 1) / (2 * i + 1);
                }
                
                SS = s;
                SY = Math.Atan(x);
            }
            else
            {
                double x = a;
                
                while ((h > 0 && x <= b) || (h < 0 && x >= b))
                {
                    double s = 0;
                    double term = x;
                    int i = 0;
                    
                    while (i < maxIterations && Math.Abs(term) >= epsilon)
                    {
                        s += term;
                        i++;
                        term = term * (-x * x) * (2 * i - 1) / (2 * i + 1);
                    }
                    
                    SS += s;
                    SY += Math.Atan(x);
                    
                    x += h;
                }
            }
            SS = Math.Round(SS, 6);
            SY = Math.Round(SY, 6);
            // end

            return (SS, SY);
        }
    }
}