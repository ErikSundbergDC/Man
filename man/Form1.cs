namespace man
{
    public partial class Form1 : Form
    {
        int manX = 1;
        int manY = 1;
        int[,] level1 = {{1,1,1,1,1,1,1,1,1,1,1},
                         {1,2,0,0,0,0,0,0,0,0,1},
                         {1,0,1,1,1,0,1,1,1,0,1},
                         {1,0,1,0,0,0,0,0,1,0,1},
                         {1,0,0,0,1,1,1,0,0,0,1},
                         {1,0,1,0,0,0,0,0,1,0,1},
                         {1,0,1,1,1,0,1,1,1,0,1},
                         {1,0,0,0,0,0,0,0,0,0,1},
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
                }
            }

            base.OnPaint(e);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                level1[manY, manX] = 0;
                manX++;
                level1[manY, manX] = 2;
            }
            else if (e.KeyCode == Keys.Left)
            {
                level1[manY, manX] = 0;
                manX--;
                level1[manY, manX] = 2;
            }
            else if (e.KeyCode == Keys.Up)
            {
                level1[manY, manX] = 0;
                manY--;
                level1[manY, manX] = 2;
            }
            else if (e.KeyCode == Keys.Down)
            {
                level1[manY, manX] = 0;
                manY++;
                level1[manY, manX] = 2;
            }
            Refresh();
        }
    }
}
