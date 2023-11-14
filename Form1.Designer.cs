namespace Life_Game
{
    partial class LifeGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PnlGameField = new Panel();
            BtStart = new Button();
            BtStop = new Button();
            BtClear = new Button();
            numUDPercentLivingCells = new NumericUpDown();
            numUDSetCountCellsOnField = new NumericUpDown();
            PnlColorDeadCell = new Panel();
            PnlColorLivingCell = new Panel();
            PnlSettings = new Panel();
            BtRefresh = new Button();
            ColDialog = new ColorDialog();
            Timer = new System.Windows.Forms.Timer(components);
            lblPercent = new Label();
            lblcountcellsonfield = new Label();
            lbllivingColor = new Label();
            lbldeadcolor = new Label();
            ((System.ComponentModel.ISupportInitialize)numUDPercentLivingCells).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDSetCountCellsOnField).BeginInit();
            PnlSettings.SuspendLayout();
            SuspendLayout();
            // 
            // PnlGameField
            // 
            PnlGameField.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PnlGameField.Location = new Point(253, 0);
            PnlGameField.Name = "PnlGameField";
            PnlGameField.Size = new Size(729, 800);
            PnlGameField.TabIndex = 0;
            // 
            // BtStart
            // 
            BtStart.Location = new Point(14, 19);
            BtStart.Name = "BtStart";
            BtStart.Size = new Size(94, 29);
            BtStart.TabIndex = 1;
            BtStart.Text = "Start";
            BtStart.UseVisualStyleBackColor = true;
            BtStart.Click += BtStart_Click;
            // 
            // BtStop
            // 
            BtStop.Location = new Point(139, 19);
            BtStop.Name = "BtStop";
            BtStop.Size = new Size(94, 29);
            BtStop.TabIndex = 2;
            BtStop.Text = "Stop";
            BtStop.UseVisualStyleBackColor = true;
            BtStop.Click += BtStop_Click;
            // 
            // BtClear
            // 
            BtClear.Location = new Point(14, 66);
            BtClear.Name = "BtClear";
            BtClear.Size = new Size(219, 29);
            BtClear.TabIndex = 3;
            BtClear.Text = "Clear Field";
            BtClear.UseVisualStyleBackColor = true;
            BtClear.Click += BtClear_Click;
            // 
            // numUDPercentLivingCells
            // 
            numUDPercentLivingCells.Location = new Point(0, 205);
            numUDPercentLivingCells.Name = "numUDPercentLivingCells";
            numUDPercentLivingCells.Size = new Size(94, 27);
            numUDPercentLivingCells.TabIndex = 0;
            // 
            // numUDSetCountCellsOnField
            // 
            numUDSetCountCellsOnField.Location = new Point(139, 205);
            numUDSetCountCellsOnField.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            numUDSetCountCellsOnField.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            numUDSetCountCellsOnField.Name = "numUDSetCountCellsOnField";
            numUDSetCountCellsOnField.Size = new Size(94, 27);
            numUDSetCountCellsOnField.TabIndex = 4;
            numUDSetCountCellsOnField.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // PnlColorDeadCell
            // 
            PnlColorDeadCell.BackColor = SystemColors.ActiveCaption;
            PnlColorDeadCell.Location = new Point(139, 289);
            PnlColorDeadCell.Name = "PnlColorDeadCell";
            PnlColorDeadCell.Size = new Size(94, 45);
            PnlColorDeadCell.TabIndex = 0;
            PnlColorDeadCell.Click += PnlColorDeadCell_Click;
            // 
            // PnlColorLivingCell
            // 
            PnlColorLivingCell.BackColor = SystemColors.Desktop;
            PnlColorLivingCell.Location = new Point(12, 289);
            PnlColorLivingCell.Name = "PnlColorLivingCell";
            PnlColorLivingCell.Size = new Size(94, 45);
            PnlColorLivingCell.TabIndex = 5;
            PnlColorLivingCell.Click += PnlColorLivingCell_Click;
            // 
            // PnlSettings
            // 
            PnlSettings.Controls.Add(lbldeadcolor);
            PnlSettings.Controls.Add(lbllivingColor);
            PnlSettings.Controls.Add(lblcountcellsonfield);
            PnlSettings.Controls.Add(lblPercent);
            PnlSettings.Controls.Add(BtRefresh);
            PnlSettings.Controls.Add(BtStart);
            PnlSettings.Controls.Add(PnlColorDeadCell);
            PnlSettings.Controls.Add(PnlColorLivingCell);
            PnlSettings.Controls.Add(BtClear);
            PnlSettings.Controls.Add(BtStop);
            PnlSettings.Controls.Add(numUDSetCountCellsOnField);
            PnlSettings.Controls.Add(numUDPercentLivingCells);
            PnlSettings.Dock = DockStyle.Left;
            PnlSettings.Location = new Point(0, 0);
            PnlSettings.Name = "PnlSettings";
            PnlSettings.Size = new Size(256, 755);
            PnlSettings.TabIndex = 1;
            // 
            // BtRefresh
            // 
            BtRefresh.Location = new Point(14, 118);
            BtRefresh.Name = "BtRefresh";
            BtRefresh.Size = new Size(219, 29);
            BtRefresh.TabIndex = 6;
            BtRefresh.Text = "Refresh Population";
            BtRefresh.UseVisualStyleBackColor = true;
            BtRefresh.Click += BtRefresh_Click;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(3, 165);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(130, 20);
            lblPercent.TabIndex = 0;
            lblPercent.Text = "Percent living cells";
            // 
            // lblcountcellsonfield
            // 
            lblcountcellsonfield.AutoSize = true;
            lblcountcellsonfield.Location = new Point(127, 165);
            lblcountcellsonfield.Name = "lblcountcellsonfield";
            lblcountcellsonfield.Size = new Size(128, 20);
            lblcountcellsonfield.TabIndex = 7;
            lblcountcellsonfield.Text = "Count cells(1 row)";
            // 
            // lbllivingColor
            // 
            lbllivingColor.AutoSize = true;
            lbllivingColor.Location = new Point(3, 258);
            lbllivingColor.Name = "lbllivingColor";
            lbllivingColor.Size = new Size(118, 20);
            lbllivingColor.TabIndex = 8;
            lbllivingColor.Text = "Color living cells";
            // 
            // lbldeadcolor
            // 
            lbldeadcolor.AutoSize = true;
            lbldeadcolor.Location = new Point(127, 258);
            lbldeadcolor.Name = "lbldeadcolor";
            lbldeadcolor.Size = new Size(116, 20);
            lbldeadcolor.TabIndex = 9;
            lbldeadcolor.Text = "Color dead cells";
            // 
            // LifeGame
            // 
            ClientSize = new Size(982, 755);
            Controls.Add(PnlSettings);
            Controls.Add(PnlGameField);
            Name = "LifeGame";
            Text = "Form1";
            Resize += LifeGame_Resize;
            ((System.ComponentModel.ISupportInitialize)numUDPercentLivingCells).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDSetCountCellsOnField).EndInit();
            PnlSettings.ResumeLayout(false);
            PnlSettings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel PnlGameField;
        private Button BtStart;
        private Button BtStop;
        private Button BtClear;
        private NumericUpDown numUDPercentLivingCells;
        private NumericUpDown numUDSetCountCellsOnField;
        public Panel PnlColorDeadCell;
        public Panel PnlColorLivingCell;
        private Panel PnlSettings;
        private Button BtRefresh;
        private ColorDialog ColDialog;
        private System.Windows.Forms.Timer Timer;
        private Label lbldeadcolor;
        private Label lbllivingColor;
        private Label lblcountcellsonfield;
        private Label lblPercent;
    }
}