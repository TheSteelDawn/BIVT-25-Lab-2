namespace Lab2test
{
    [TestClass]
    public sealed class GreenTest
    {
        Lab2.Green _main = new Lab2.Green();
        const double E = 1e-4;

        [TestMethod]
        public void Test1()
        {
            // Arrange
            var input = new int[] { 0, 2, 4, 6, 8, 10, 20, 100 };
            var answer = new double[] { 0.000000, 0.666667, 1.466667, 2.323810, 3.212698, 4.121789, 8.819125, 48.052324 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task1(input[i]);
                System.Console.WriteLine(test[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
        [TestMethod]
        public void Test2()
        {
            // Arrange
            var input = new int[] { 0, 1, 1, 2, 3, 1, 10, 10, 10, 11, 12 };
            var input2 = new double[] { 0.01, 0.1, 0.2, 0.3, -0.1, -0.2, 0.78, -0.95, 1.5, 2.87, -1.42 };
            var answer = new double[] {
                1.000000,
                11.000000,
                6.000000,
                15.444444,
                -909.000000,
                -4.000000,
                50.984017,
                1.343683,
                2.965317,
                1.534754,
                0.592925
            };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task2(input[i], input2[i]);
                System.Console.WriteLine(test[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
        [TestMethod]
        public void Test3()
        {
            // Arrange
            var input = new int[] { 0, 1, 2, 3, 10, 11, 12, 25 };
            var answer = new long[] { 1, 2, 4, 10, 4037914, 43954714, 522956314, 4389017640157182490 };
            var test = new long[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task3(input[i]);
                System.Console.WriteLine(test[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test4()
        {
            // Arrange
            var input = new double[] { 0, 0.1, 0.2, 0.3, -0.1, -0.2, 0.78, -0.95, 0.5, 0.87, -0.42 };
            var answer = new double[] {
                0.000000,
                0.123232,
                0.310966,
                0.606612,
                -0.082435,
                -0.137568,
                13.134983,
                -0.272058,
                1.946577,
                26.300102 
            };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task4(input[i]);
                System.Console.WriteLine(test[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
        [TestMethod]
        public void Test5()
        {
            // Arrange
            var input = new double[] { 1.01, 1.1, 2.2, 3.3, -1.1, -2.2, 2.78, -2.95 };
            var answer = new int[] { 463, 73, 12, 9, 105, 14, 10, 10 };
            var test = new int[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task5(input[i]);
                System.Console.WriteLine(test[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test6()
        {
            // Arrange
            var input = new int[] { 0, 1, 2, 3, 10, 11, 12, 25 };
            var answer = new int[] { 0, 0, 2, 6, 30, 30, 30, 62 };
            var test = new int[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task6(input[i]);
                System.Console.WriteLine(test[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test7()
        {
            // Arrange
            var input = new double[] { 0, 1.01, 1.1, 2.2, 33, 278, 2.95, 0.1, 0.0001, 0.123 };
            var answer = new int[] { 0, 34, 34, 35, 39, 42, 35, 30, 20, 31 };
            var test = new int[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task7(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test8()
        {
            // Arrange
            var input = new double[,] {
                { 0,    0.1, 0.2, 0.01, 0.001, 0.05,  0.1, 0.09, 0.1 },
                { 0.1,  0.2,   1,  0.1,   0.1,  0.5, 0.99,  0.5, 0.99 },
                { 0.1,  0.2, 0.3, 0.01, 0.001, 0.05,  0.9, 0.05, 1.1 }
            };
            var answer = new (double, double)[] {
                (0.099669, 0.099669),
                (0.099669, 0.099669),
                (1.335745, 1.335784),
                (0.548996, 0.548996),
                (5.041531, 5.041533),
                (2.636030, 2.636031),
                (0.099669, 0.099669),
                (2.504135, 2.504136),
                (0.099669, 0.099669)
            };
            var test = new (double, double)[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task8(input[0, i], input[1, i], input[2, i]);
                System.Console.WriteLine(test[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].Item1, test[i].Item1, E * 10);
                Assert.AreEqual(answer[i].Item2, test[i].Item2, E * 10);
            }
        }
    }
}
