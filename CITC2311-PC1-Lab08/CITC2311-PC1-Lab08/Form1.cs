namespace CITC2311_PC1_Lab08
{
    public partial class Form1 : Form
    {
        private Robot robot = new Robot();

        private const char UP_ARROW = (char)233;
        private const char DOWN_ARROW = (char)234;
        private const char LEFT_ARROW = (char)231;
        private const char RIGHT_ARROW = (char)232;

        public Form1()
        {
            InitializeComponent();
            robot.OutOfRange += Robot_OutOfRange;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateArrowChar();
            UpdateDisplay();
        }

        private void Robot_OutOfRange(object? sender, EventArgs e)
        {
            MessageBox.Show("The robot can't move more than 100 units from the center.", "Out of Range");
        }

        private void UpdateArrowChar()
        {
            if (robot.Direction == Direction.North)
            {
                ArrowLbl.Text = UP_ARROW.ToString();
            }
            else if (robot.Direction == Direction.South)
            {
                ArrowLbl.Text = DOWN_ARROW.ToString();
            }
            else if (robot.Direction == Direction.East)
            {
                ArrowLbl.Text = RIGHT_ARROW.ToString();
            }
            else if (robot.Direction == Direction.West)
            {
                ArrowLbl.Text = LEFT_ARROW.ToString();
            }
        }

        private void UpdateDisplay()
        {
            PositionLbl.Text = robot.Position.ToString();

            int centerX = RobotPnl.ClientSize.Width / 2;
            int centerY = RobotPnl.ClientSize.Height / 2;
            double scale = (centerX - ArrowLbl.Width / 2.0) / 100.0;

            int arrowX = centerX + (int)(robot.Position.X * scale) - (ArrowLbl.Width / 2);
            int arrowY = centerY - (int)(robot.Position.Y * scale) - (ArrowLbl.Height / 2);

            ArrowLbl.Location = new Point(arrowX, arrowY);
        }

        private void NBtn_Click(object sender, EventArgs e)
        {
            robot.Direction = Direction.North;
            UpdateArrowChar();
        }

        private void SBtn_Click(object sender, EventArgs e)
        {
            robot.Direction = Direction.South;
            UpdateArrowChar();
        }

        private void EBtn_Click(object sender, EventArgs e)
        {
            robot.Direction = Direction.East;
            UpdateArrowChar();
        }

        private void WBtn_Click(object sender, EventArgs e)
        {
            robot.Direction = Direction.West;
            UpdateArrowChar();
        }

        private void Go1Btn_Click(object sender, EventArgs e)
        {
            robot.Move(1);
            UpdateDisplay();
        }

        private void Go10Btn_Click(object sender, EventArgs e)
        {
            robot.Move(10);
            UpdateDisplay();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
