namespace man
{
    public partial class Form1 : Form
    {
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
                for (int j = 0; j < 9; j ++)
                {
                    if (level1[j, i] == 1)
                    {
                        SolidBrush brush = new SolidBrush(Color.Blue);
                        g.FillRectangle(brush, i * 32, j * 32, 32, 32);
                    }
                }
            }

            base.OnPaint(e);
        }
    }
}
