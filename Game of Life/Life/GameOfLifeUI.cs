using System;
using System.Drawing;
using System.Windows.Forms;


namespace GameOfLife
{
    public partial class formUI : Form
    {
        private const int BUTTON_DIMEN_CONST = 35;
        private const int GRID_DIM_CONST = 520;
        private const int GRID_DIMEN_CONST = GRID_DIM_CONST / BUTTON_DIMEN_CONST;
        private static readonly Color CELL_COLOR_ALIVE_CONST = Color.White;
        private static readonly Color CELL_COLOR_DEAD_CONST = Color.Black;
        private Cell fsmControl = null;

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            goButton.Enabled = false;
            pauseButton.Enabled = true;
        }


        private void pauseButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            pauseButton.Enabled = false;
            goButton.Enabled = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            pauseButton.Enabled = false;
            goButton.Enabled = true;

            fsmControl = new Cell(fsmControl.H, fsmControl.W);
            nextStep.Text = fsmControl.T.ToString();

            updateColors();
        }


        public formUI(){
            InitializeComponent();
            fsmControl = new Cell(GRID_DIMEN_CONST, GRID_DIMEN_CONST);
        }

        
        private void timer_Tick(object sender, EventArgs e)
        {
            fsmControl.eachCycle();
            nextStep.Text = fsmControl.T.ToString();
            updateColors();
        }


        private void ClickCell(object sender, EventArgs e)
        {

            if (timer.Enabled)
                return;

            int buttonLinearIndex = pictureBox.Controls.IndexOf(sender as Control);
            int y = buttonLinearIndex / fsmControl.W;
            int x = buttonLinearIndex % fsmControl.W;
            
            fsmControl[y, x] = !fsmControl[y, x];
            ((Button)sender).BackColor =  fsmControl[y, x] ? CELL_COLOR_ALIVE_CONST : CELL_COLOR_DEAD_CONST;
        }


        private void updateColors(){
            for (int linearIndex = 0; linearIndex < pictureBox.Controls.Count; ++linearIndex)
                pictureBox.Controls[linearIndex].BackColor =
                    fsmControl[linearIndex / fsmControl.W, linearIndex % fsmControl.W] ? CELL_COLOR_ALIVE_CONST : CELL_COLOR_DEAD_CONST;
        }

        private void Game_Of_LifeUI_Load(object sender, EventArgs e)
        {
            for (int y = 0; y + BUTTON_DIMEN_CONST <= GRID_DIM_CONST; y += BUTTON_DIMEN_CONST)
                for (int x = 0; x + BUTTON_DIMEN_CONST <= GRID_DIM_CONST; x += BUTTON_DIMEN_CONST)
                {
                    Button addButton = new Button();
                    addButton.Size = new Size(BUTTON_DIMEN_CONST, BUTTON_DIMEN_CONST);
                    addButton.Location = new Point(x, y);
                    addButton.Click += new EventHandler(ClickCell);
                    pictureBox.Controls.Add(addButton);
                }

            updateColors();
        }
    }
}