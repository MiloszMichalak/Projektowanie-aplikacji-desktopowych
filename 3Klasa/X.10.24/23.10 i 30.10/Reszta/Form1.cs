using System.Drawing.Printing;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace Reszta
{
    public partial class Form1 : Form
    {
        private FlowLayoutPanel flowLayoutPanel;
        public Form1()
        {
            InitializeComponent();
            flowLayoutPanel = new FlowLayoutPanel
            {
                Size = new Size(1000, 500),
                Location = new Point(10, 150)
            };
            this.Controls.Add(flowLayoutPanel);
        }

        private string[] imagePath =
        {
            "200.jpg",
            "100.jpg",
            "50.jpg",
            "20.jpg",
            "10.jpg",
            "5.png",
            "2.png",
            "1.png"
        };

        private int[] nominaly = 
        {
            200,
            100,
            50,
            20,
            10,
            5,
            2,
            1
        };

        private List<int> wydane = new List<int>();

        private void Zaplac_Click(object sender, EventArgs e)
        {
         
            flowLayoutPanel.Controls.Clear();
                wydane.Clear();

                int doWydania = Convert.ToInt32(zaplacone.Text);
                int i = 0;


                while (doWydania > 0)
                {
                    int ile = doWydania / nominaly[i];

                    for (int j = 0; j < ile; j++)
                    {

                        Image image = Image.FromFile(imagePath[i]);

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = image;
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                        flowLayoutPanel.Controls.Add(pictureBox);
                        wydane.Add(nominaly[i]);
                    }

                    doWydania -= nominaly[i] * ile;
                    i++;
                }
                reszta.Text = String.Join(" ", wydane);
        }
    }
}
