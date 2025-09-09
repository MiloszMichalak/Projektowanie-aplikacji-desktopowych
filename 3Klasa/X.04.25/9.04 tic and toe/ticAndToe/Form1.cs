namespace ticAndToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var n = 3;
            int[,] matrix = new int[n, n];
            int rozmiar = n * 2 + 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(1, 3);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[] sumy = new int[rozmiar];
            int temp = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sumy[temp] += matrix[i, j];
                }
                temp++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sumy[temp] += matrix[j, i];
                }
                temp++;
            }

            for (int i = 0; i < n; i++)
            {
                sumy[temp] += matrix[i, i];
            }
            temp++;

            for (int i = 0; i < n; i++)
            {
                sumy[temp] += matrix[i, n - 1 - i];
            }
            


            String s2 = new string("");
            for (int i = 0; i < sumy.Length; i++)
            {
                s2 += sumy[i] + " ";
            }

            label2.Text = s2;


            String s = new string("");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    s += matrix[i, j] + " ";
                }

                s += "\n";
            }

            label1.Text = s;
        }
    }
}
