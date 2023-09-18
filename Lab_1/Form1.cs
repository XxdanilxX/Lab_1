using System.Drawing;
namespace Lab_1
{
    public partial class Form1 : Form
    {
        CCircle[] circles;
        CEmblem[] emblems;
        int EmblemCount = 0;
        int CurrentEmblemIndex;
        int CircleCount = 0;
        int CurrentCircleIndex;


        public Form1()
        {
            InitializeComponent();
            circles = new CCircle[100];
            emblems = new CEmblem[100];

        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {

            if (CircleCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!"); return;
            }
            Graphics graphics = pnMain.CreateGraphics();
            CurrentCircleIndex = CircleCount;
            circles[CurrentCircleIndex] = new CCircle(graphics, pnMain.Width / 2, pnMain.Height / 2, 50);
            circles[CurrentCircleIndex].Show();
            CircleCount++;
            cbCircles.Items.Add("Коло №" + (CircleCount - 1).ToString()); cbCircles.SelectedIndex = CircleCount - 1;
        }

        private void btnHide_Click_1(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0)) return;
            circles[CurrentCircleIndex].Hide();
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0)) return;
            circles[CurrentCircleIndex].Show();
        }

        private void btnExpand_Click_1(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0)) return;
            circles[CurrentCircleIndex].Expand(5);
        }

        private void btnCollapse_Click_1(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0)) return;
            circles[CurrentCircleIndex].Collapse(5);
        }

        private void btnUp_Click_1(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0)) return;
            circles[CurrentCircleIndex].Move(0, -10);
        }

        private void btnDown_Click_1(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0)) return;
            circles[CurrentCircleIndex].Move(0, 10);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0)) return;
            circles[CurrentCircleIndex].Move(10, 0);
        }

        private void btnLeft_Click_1(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0)) return;
            circles[CurrentCircleIndex].Move(-10, 0);
        }

        private void btnRightFar_Click_1(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0)) return;
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnLeftFar_Click_1(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0)) return;
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnUpFar_Click_1(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0)) return;
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnDownFar_Click_1(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0)) return;
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(0, 1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbFigure.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;
            emblems[CurrentEmblemIndex].Show();
        }

        private void btnCreateNew1_Click(object sender, EventArgs e)
        {
            if (EmblemCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!"); return;
            }
            Graphics graphics = pnMain1.CreateGraphics();
            CurrentEmblemIndex = EmblemCount;
            emblems[CurrentEmblemIndex] = new CEmblem(graphics, pnMain1.Width / 2, pnMain1.Height / 2);
            emblems[CurrentEmblemIndex].Show();
            EmblemCount++;
            cbFigure.Items.Add("Фігура №" + (EmblemCount - 1).ToString()); cbFigure.SelectedIndex = EmblemCount - 1;
        }

        private void btnHide1_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbFigure.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;
            emblems[CurrentEmblemIndex].Hide();
        }

        private void btnExpand1_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbFigure.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;
            emblems[CurrentEmblemIndex].Expand(5);
        }

        private void btnCollapse1_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbFigure.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;
            emblems[CurrentEmblemIndex].Collapse(5);
        }

        private void btnUp1_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbFigure.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;
            emblems[CurrentEmblemIndex].Move(0, -10);
        }

        private void btnUpFar1_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbFigure.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnDown1_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbFigure.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;
            emblems[CurrentEmblemIndex].Move(0, 10);
        }

        private void btnDownFar1_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbFigure.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(0, 1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnRight1_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbFigure.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;
            emblems[CurrentEmblemIndex].Move(10, 0);
        }

        private void btnRightFar1_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbFigure.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnLeft1_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbFigure.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;
            emblems[CurrentEmblemIndex].Move(-10, 0);
        }

        private void btnLeftFar1_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbFigure.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0)) return;
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }
    }
}