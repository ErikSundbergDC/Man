namespace man
{
    public partial class Form1 : Form
    {
        int manX = 1;
        int manY = 1;
        int score = 0;
        int[,] level1 = {{1,1,1,1,1,1,1,1,1,1,1},
                         {1,2,3,3,3,3,3,3,3,3,1},
                         {1,3,1,1,1,3,1,1,1,3,1},
                         {1,3,1,3,3,3,3,3,1,3,1},
                         {1,3,3,3,1,1,1,3,3,3,1},
                         {1,3,1,3,3,3,3,3,1,3,1},
                         {1,3,1,1,1,3,1,1,1,3,1},
                         {1,3,3,3,3,3,3,3,3,3,1},
                         {1,1,1,1,1,1,1,1,1,1,1}};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (level1[j, i] == 1)
                    {
                        SolidBrush brush = new SolidBrush(Color.Blue);
                        g.FillRectangle(brush, i * 32, j * 32, 32, 32);

                    }
                    else if (level1[j, i] == 2)
                    {
                        SolidBrush brush = new SolidBrush(Color.Yellow);
                        g.FillEllipse(brush, i * 32, j * 32, 32, 32);

                    }
                    else if (level1[j, i] == 3)
                    {
                        SolidBrush brush = new SolidBrush(Color.White);
                        g.FillEllipse(brush, i * 32 + 8, j * 32 + 8, 16, 16);

                    }
                }
            }

            Text = "Score: " + score;

            base.OnPaint(e);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            level1[manY, manX] = 0;
            if (e.KeyCode == Keys.Right)
            {
                if (level1[manY, manX + 1] != 1)
                {
                    manX++;
                }
                
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (level1[manY, manX - 1] != 1)
                {
                    manX--;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (level1[manY-1, manX] != 1)
                {
                    manY--;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (level1[manY + 1, manX] != 1)
                {
                    manY++;
                }
            }
            if (level1[manY, manX] == 3)
            {
                score++;
            }
            level1[manY, manX] = 2;

            Refresh();
        }
    }
}
