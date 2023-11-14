using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Life_Game
{
    public partial class LifeGame : Form
    {
        public int CellCount;
        public int CellSize;
        public bool Play = false;

        public bool[,] Cells_Condition;
        public Button[,] Cells;

        public int LivingCellsCount;
        public int GenerationsCount;
        public int PercentOfLivingCells;

        public LifeGame()
        {
            InitializeComponent();

            LivingCellsCount = 0;
            GenerationsCount = 0;
            PercentOfLivingCells = 20;
            CellCount = (int)numUDSetCountCellsOnField.Value;
            CellSize = PnlGameField.Width / CellCount;
            numUDPercentLivingCells.Value = PercentOfLivingCells;
            CreateGeneration();
            CreateField();
        }

        private bool Is_living()
        {
            return LivingCellsCount > 0;
        }

        private void CreateField()
        {
            Cells = new Button[CellCount, CellCount];
            for (int i = 0; i < CellCount; i++)
                for (int j = 0; j < CellCount; j++)
                {
                    Button b = new()
                    {
                        Size = new Size(CellSize, CellSize),
                        Location = new Point(i * CellSize, j * CellSize)
                    };
                    if (Cells_Condition[i, j])
                    {
                        b.BackColor = PnlColorLivingCell.BackColor;
                        LivingCellsCount++;
                    }
                    else
                        b.BackColor = PnlColorDeadCell.BackColor;
                    b.Click += new EventHandler(Set_cell);
                    Cells[i, j] = b;
                    PnlGameField.Controls.Add(b);
                }
        }

        private void CreateGeneration()
        {
            Cells_Condition = new bool[CellCount, CellCount];
            Random random = new();

            for (int i = 0; i < CellCount; i++)
                for (int j = 0; j < CellCount; j++)
                {
                    Cells_Condition[i, j] = random.Next(99) % 100 < PercentOfLivingCells;
                }
        }

        private bool Condition(int x, int y)
        {
            int xx = x + CellCount - 1;
            int yy = y + CellCount - 1;
            int r = 0;
            int c = 0;

            for (int i = xx; i < (xx + 3); i++)
                for (int j = yy; j < (yy + 3); j++)
                {
                    if (Cells_Condition[i % CellCount, j % CellCount])
                        c = 1;
                    else
                        c = 0;
                    r += c;
                }
            if (Cells_Condition[x, y])
                c = 1;
            else
                c = 0;
            r -= c;

            return ((r == 3) || ((r == 2) && (Cells_Condition[x, y])));
        }

        private void Generation()
        {
            GenerationsCount++;
            LivingCellsCount = 0;
            bool[,] tmp = new bool[CellCount, CellCount];
            for (int i = 0; i < CellCount; i++)
                for (int j = 0; j < CellCount; j++)
                {
                    if (Condition(i, j))
                        tmp[i, j] = true;
                    else
                        tmp[i, j] = false;
                }
            Cells_Condition = tmp;
            SetCellsColor();
        }

        private void Set_cell(object sender, EventArgs e)
        {
            var presB = sender as Button;
            if (!Play)
            {
                var i = presB.Location.X / CellSize;
                var j = presB.Location.Y / CellSize;
                if (Cells_Condition[i, j])
                {
                    Cells_Condition[i, j] = false;
                    Cells[i, j].BackColor = PnlColorDeadCell.BackColor;
                    LivingCellsCount--;
                    PercentOfLivingCells = (LivingCellsCount * 100 / (CellCount * CellCount));
                    numUDPercentLivingCells.Value = PercentOfLivingCells;
                }
                else
                {
                    Cells_Condition[i, j] = true;
                    Cells[i, j].BackColor = PnlColorLivingCell.BackColor;
                    LivingCellsCount++;
                    PercentOfLivingCells = (LivingCellsCount * 100 / (CellCount * CellCount));
                    numUDPercentLivingCells.Value = PercentOfLivingCells;
                }
            }
        }

        private void SetCellsColor()
        {
            for (int i = 0; i < CellCount; i++)
                for (int j = 0; j < CellCount; j++)
                {
                    if (Cells_Condition[i, j])
                    {
                        Cells[i, j].BackColor = PnlColorLivingCell.BackColor;
                        LivingCellsCount++;
                    }
                    else
                        Cells[i, j].BackColor = PnlColorDeadCell.BackColor;
                }
        }

        private void Field_Refresh()
        {
            for (int i = 0; i < CellCount; i++)
                for (int j = 0; j < CellCount; j++)
                {
                    PnlGameField.Controls.Remove(Cells[i, j]);
                    Cells_Condition[i, j] = false;
                }
            CellCount = (int)numUDSetCountCellsOnField.Value;
            CellSize = PnlGameField.Width / CellCount;
            CreateGeneration();
            CreateField();
        }

        private void Field_Clear()
        {
            PercentOfLivingCells = 0;
            numUDPercentLivingCells.Value = PercentOfLivingCells;
            LivingCellsCount = 0;
            GenerationsCount = 0;
            Field_Refresh();
        }

        private void PnlColorLivingCell_Click(object sender, EventArgs e)
        {
            if (ColDialog.ShowDialog() == DialogResult.OK)
                PnlColorLivingCell.BackColor = ColDialog.Color;
        }
        private void PnlColorDeadCell_Click(object sender, EventArgs e)
        {
            if (ColDialog.ShowDialog() == DialogResult.OK)
                PnlColorDeadCell.BackColor = ColDialog.Color;
        }

        private void BtStart_Click(object sender, EventArgs e)
        {

            if (!Play)
            {
                Play = true;
                Timer.Start();
            }
        }

        private void BtStop_Click(object sender, EventArgs e)
        {
            Play = false;
            Timer.Stop();
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            Play = false;
            Timer.Stop();
            Field_Clear();
        }

        private void BtRefresh_Click(object sender, EventArgs e)
        {
            Play = false;
            Timer.Stop();
            PercentOfLivingCells = 20;
            numUDPercentLivingCells.Value = PercentOfLivingCells;
            Field_Refresh();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            if (Is_living())
            {
                Generation();
            }
            else
            {
                Timer.Stop();
                MessageBox.Show("All Cells is dead!!!");
            }
        }

        private void LifeGame_Resize(object sender, EventArgs e)
        {
            // PnlGameField.Controls.Clear();
            // CreateField();
            //PnlGameField.Size = new Size(ClientSize.Width - (PnlSettings.Width), ClientSize.Height - 10);
        }
    }
}