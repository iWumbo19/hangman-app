namespace hangman_app
{
    partial class HangmanUI
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
            this.OutputWindow = new System.Windows.Forms.RichTextBox();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.A_select = new System.Windows.Forms.Label();
            this.B_select = new System.Windows.Forms.Label();
            this.C_select = new System.Windows.Forms.Label();
            this.D_select = new System.Windows.Forms.Label();
            this.E_select = new System.Windows.Forms.Label();
            this.F_select = new System.Windows.Forms.Label();
            this.G_select = new System.Windows.Forms.Label();
            this.H_select = new System.Windows.Forms.Label();
            this.I_select = new System.Windows.Forms.Label();
            this.J_select = new System.Windows.Forms.Label();
            this.K_select = new System.Windows.Forms.Label();
            this.L_select = new System.Windows.Forms.Label();
            this.M_select = new System.Windows.Forms.Label();
            this.N_select = new System.Windows.Forms.Label();
            this.O_select = new System.Windows.Forms.Label();
            this.P_select = new System.Windows.Forms.Label();
            this.Q_select = new System.Windows.Forms.Label();
            this.R_select = new System.Windows.Forms.Label();
            this.S_select = new System.Windows.Forms.Label();
            this.T_select = new System.Windows.Forms.Label();
            this.U_select = new System.Windows.Forms.Label();
            this.V_select = new System.Windows.Forms.Label();
            this.W_select = new System.Windows.Forms.Label();
            this.X_select = new System.Windows.Forms.Label();
            this.Y_select = new System.Windows.Forms.Label();
            this.Z_select = new System.Windows.Forms.Label();
            this.WordDisplay = new System.Windows.Forms.Label();
            this.MissesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputWindow
            // 
            this.OutputWindow.Location = new System.Drawing.Point(12, 12);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.ReadOnly = true;
            this.OutputWindow.Size = new System.Drawing.Size(676, 41);
            this.OutputWindow.TabIndex = 0;
            this.OutputWindow.Text = "";
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(269, 59);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(140, 29);
            this.NewGameButton.TabIndex = 1;
            this.NewGameButton.Text = "Start New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // A_select
            // 
            this.A_select.AutoSize = true;
            this.A_select.BackColor = System.Drawing.SystemColors.Control;
            this.A_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A_select.Location = new System.Drawing.Point(37, 297);
            this.A_select.Name = "A_select";
            this.A_select.Size = new System.Drawing.Size(49, 54);
            this.A_select.TabIndex = 2;
            this.A_select.Text = "A";
            this.A_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.A_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.A_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // B_select
            // 
            this.B_select.AutoSize = true;
            this.B_select.BackColor = System.Drawing.SystemColors.Control;
            this.B_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_select.Location = new System.Drawing.Point(86, 297);
            this.B_select.Name = "B_select";
            this.B_select.Size = new System.Drawing.Size(46, 54);
            this.B_select.TabIndex = 3;
            this.B_select.Text = "B";
            this.B_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.B_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.B_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // C_select
            // 
            this.C_select.AutoSize = true;
            this.C_select.BackColor = System.Drawing.SystemColors.Control;
            this.C_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C_select.Location = new System.Drawing.Point(132, 297);
            this.C_select.Name = "C_select";
            this.C_select.Size = new System.Drawing.Size(48, 54);
            this.C_select.TabIndex = 4;
            this.C_select.Text = "C";
            this.C_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.C_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.C_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // D_select
            // 
            this.D_select.AutoSize = true;
            this.D_select.BackColor = System.Drawing.SystemColors.Control;
            this.D_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.D_select.Location = new System.Drawing.Point(180, 297);
            this.D_select.Name = "D_select";
            this.D_select.Size = new System.Drawing.Size(51, 54);
            this.D_select.TabIndex = 5;
            this.D_select.Text = "D";
            this.D_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.D_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.D_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // E_select
            // 
            this.E_select.AutoSize = true;
            this.E_select.BackColor = System.Drawing.SystemColors.Control;
            this.E_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.E_select.Location = new System.Drawing.Point(231, 297);
            this.E_select.Name = "E_select";
            this.E_select.Size = new System.Drawing.Size(43, 54);
            this.E_select.TabIndex = 6;
            this.E_select.Text = "E";
            this.E_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.E_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.E_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // F_select
            // 
            this.F_select.AutoSize = true;
            this.F_select.BackColor = System.Drawing.SystemColors.Control;
            this.F_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.F_select.Location = new System.Drawing.Point(274, 297);
            this.F_select.Name = "F_select";
            this.F_select.Size = new System.Drawing.Size(43, 54);
            this.F_select.TabIndex = 7;
            this.F_select.Text = "F";
            this.F_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.F_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.F_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // G_select
            // 
            this.G_select.AutoSize = true;
            this.G_select.BackColor = System.Drawing.SystemColors.Control;
            this.G_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.G_select.Location = new System.Drawing.Point(317, 297);
            this.G_select.Name = "G_select";
            this.G_select.Size = new System.Drawing.Size(50, 54);
            this.G_select.TabIndex = 8;
            this.G_select.Text = "G";
            this.G_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.G_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.G_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // H_select
            // 
            this.H_select.AutoSize = true;
            this.H_select.BackColor = System.Drawing.SystemColors.Control;
            this.H_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.H_select.Location = new System.Drawing.Point(367, 297);
            this.H_select.Name = "H_select";
            this.H_select.Size = new System.Drawing.Size(51, 54);
            this.H_select.TabIndex = 9;
            this.H_select.Text = "H";
            this.H_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.H_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.H_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // I_select
            // 
            this.I_select.AutoSize = true;
            this.I_select.BackColor = System.Drawing.SystemColors.Control;
            this.I_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.I_select.Location = new System.Drawing.Point(418, 297);
            this.I_select.Name = "I_select";
            this.I_select.Size = new System.Drawing.Size(34, 54);
            this.I_select.TabIndex = 10;
            this.I_select.Text = "I";
            this.I_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.I_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.I_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // J_select
            // 
            this.J_select.AutoSize = true;
            this.J_select.BackColor = System.Drawing.SystemColors.Control;
            this.J_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.J_select.Location = new System.Drawing.Point(452, 297);
            this.J_select.Name = "J_select";
            this.J_select.Size = new System.Drawing.Size(37, 54);
            this.J_select.TabIndex = 11;
            this.J_select.Text = "J";
            this.J_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.J_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.J_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // K_select
            // 
            this.K_select.AutoSize = true;
            this.K_select.BackColor = System.Drawing.SystemColors.Control;
            this.K_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.K_select.Location = new System.Drawing.Point(489, 297);
            this.K_select.Name = "K_select";
            this.K_select.Size = new System.Drawing.Size(46, 54);
            this.K_select.TabIndex = 12;
            this.K_select.Text = "K";
            this.K_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.K_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.K_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // L_select
            // 
            this.L_select.AutoSize = true;
            this.L_select.BackColor = System.Drawing.SystemColors.Control;
            this.L_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_select.Location = new System.Drawing.Point(535, 297);
            this.L_select.Name = "L_select";
            this.L_select.Size = new System.Drawing.Size(42, 54);
            this.L_select.TabIndex = 13;
            this.L_select.Text = "L";
            this.L_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.L_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.L_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // M_select
            // 
            this.M_select.AutoSize = true;
            this.M_select.BackColor = System.Drawing.SystemColors.Control;
            this.M_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.M_select.Location = new System.Drawing.Point(577, 297);
            this.M_select.Name = "M_select";
            this.M_select.Size = new System.Drawing.Size(59, 54);
            this.M_select.TabIndex = 14;
            this.M_select.Text = "M";
            this.M_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.M_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.M_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // N_select
            // 
            this.N_select.AutoSize = true;
            this.N_select.BackColor = System.Drawing.SystemColors.Control;
            this.N_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.N_select.Location = new System.Drawing.Point(20, 351);
            this.N_select.Name = "N_select";
            this.N_select.Size = new System.Drawing.Size(53, 54);
            this.N_select.TabIndex = 15;
            this.N_select.Text = "N";
            this.N_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.N_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.N_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // O_select
            // 
            this.O_select.AutoSize = true;
            this.O_select.BackColor = System.Drawing.SystemColors.Control;
            this.O_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.O_select.Location = new System.Drawing.Point(73, 351);
            this.O_select.Name = "O_select";
            this.O_select.Size = new System.Drawing.Size(53, 54);
            this.O_select.TabIndex = 16;
            this.O_select.Text = "O";
            this.O_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.O_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.O_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // P_select
            // 
            this.P_select.AutoSize = true;
            this.P_select.BackColor = System.Drawing.SystemColors.Control;
            this.P_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P_select.Location = new System.Drawing.Point(126, 351);
            this.P_select.Name = "P_select";
            this.P_select.Size = new System.Drawing.Size(45, 54);
            this.P_select.TabIndex = 17;
            this.P_select.Text = "P";
            this.P_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.P_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.P_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // Q_select
            // 
            this.Q_select.AutoSize = true;
            this.Q_select.BackColor = System.Drawing.SystemColors.Control;
            this.Q_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Q_select.Location = new System.Drawing.Point(171, 351);
            this.Q_select.Name = "Q_select";
            this.Q_select.Size = new System.Drawing.Size(53, 54);
            this.Q_select.TabIndex = 18;
            this.Q_select.Text = "Q";
            this.Q_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.Q_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.Q_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // R_select
            // 
            this.R_select.AutoSize = true;
            this.R_select.BackColor = System.Drawing.SystemColors.Control;
            this.R_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.R_select.Location = new System.Drawing.Point(224, 351);
            this.R_select.Name = "R_select";
            this.R_select.Size = new System.Drawing.Size(47, 54);
            this.R_select.TabIndex = 19;
            this.R_select.Text = "R";
            this.R_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.R_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.R_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // S_select
            // 
            this.S_select.AutoSize = true;
            this.S_select.BackColor = System.Drawing.SystemColors.Control;
            this.S_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_select.Location = new System.Drawing.Point(271, 351);
            this.S_select.Name = "S_select";
            this.S_select.Size = new System.Drawing.Size(44, 54);
            this.S_select.TabIndex = 20;
            this.S_select.Text = "S";
            this.S_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.S_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.S_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // T_select
            // 
            this.T_select.AutoSize = true;
            this.T_select.BackColor = System.Drawing.SystemColors.Control;
            this.T_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.T_select.Location = new System.Drawing.Point(315, 351);
            this.T_select.Name = "T_select";
            this.T_select.Size = new System.Drawing.Size(44, 54);
            this.T_select.TabIndex = 21;
            this.T_select.Text = "T";
            this.T_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.T_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.T_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // U_select
            // 
            this.U_select.AutoSize = true;
            this.U_select.BackColor = System.Drawing.SystemColors.Control;
            this.U_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.U_select.Location = new System.Drawing.Point(359, 351);
            this.U_select.Name = "U_select";
            this.U_select.Size = new System.Drawing.Size(50, 54);
            this.U_select.TabIndex = 22;
            this.U_select.Text = "U";
            this.U_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.U_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.U_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // V_select
            // 
            this.V_select.AutoSize = true;
            this.V_select.BackColor = System.Drawing.SystemColors.Control;
            this.V_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.V_select.Location = new System.Drawing.Point(409, 351);
            this.V_select.Name = "V_select";
            this.V_select.Size = new System.Drawing.Size(48, 54);
            this.V_select.TabIndex = 23;
            this.V_select.Text = "V";
            this.V_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.V_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.V_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // W_select
            // 
            this.W_select.AutoSize = true;
            this.W_select.BackColor = System.Drawing.SystemColors.Control;
            this.W_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.W_select.Location = new System.Drawing.Point(457, 351);
            this.W_select.Name = "W_select";
            this.W_select.Size = new System.Drawing.Size(60, 54);
            this.W_select.TabIndex = 24;
            this.W_select.Text = "W";
            this.W_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.W_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.W_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // X_select
            // 
            this.X_select.AutoSize = true;
            this.X_select.BackColor = System.Drawing.SystemColors.Control;
            this.X_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.X_select.Location = new System.Drawing.Point(517, 351);
            this.X_select.Name = "X_select";
            this.X_select.Size = new System.Drawing.Size(47, 54);
            this.X_select.TabIndex = 25;
            this.X_select.Text = "X";
            this.X_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.X_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.X_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // Y_select
            // 
            this.Y_select.AutoSize = true;
            this.Y_select.BackColor = System.Drawing.SystemColors.Control;
            this.Y_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Y_select.Location = new System.Drawing.Point(564, 351);
            this.Y_select.Name = "Y_select";
            this.Y_select.Size = new System.Drawing.Size(45, 54);
            this.Y_select.TabIndex = 26;
            this.Y_select.Text = "Y";
            this.Y_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.Y_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.Y_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // Z_select
            // 
            this.Z_select.AutoSize = true;
            this.Z_select.BackColor = System.Drawing.SystemColors.Control;
            this.Z_select.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Z_select.Location = new System.Drawing.Point(609, 351);
            this.Z_select.Name = "Z_select";
            this.Z_select.Size = new System.Drawing.Size(46, 54);
            this.Z_select.TabIndex = 27;
            this.Z_select.Text = "Z";
            this.Z_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Letter);
            this.Z_select.MouseEnter += new System.EventHandler(this.Mouse_Enter_Letter);
            this.Z_select.MouseLeave += new System.EventHandler(this.Mouse_Leave_Letter);
            // 
            // WordDisplay
            // 
            this.WordDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WordDisplay.AutoSize = true;
            this.WordDisplay.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordDisplay.Location = new System.Drawing.Point(20, 148);
            this.WordDisplay.Name = "WordDisplay";
            this.WordDisplay.Size = new System.Drawing.Size(236, 106);
            this.WordDisplay.TabIndex = 28;
            this.WordDisplay.Text = "NULL";
            // 
            // MissesLabel
            // 
            this.MissesLabel.AutoSize = true;
            this.MissesLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MissesLabel.Location = new System.Drawing.Point(409, 59);
            this.MissesLabel.Name = "MissesLabel";
            this.MissesLabel.Size = new System.Drawing.Size(241, 37);
            this.MissesLabel.TabIndex = 29;
            this.MissesLabel.Text = "Misses Remaining: ";
            // 
            // HangmanUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.MissesLabel);
            this.Controls.Add(this.WordDisplay);
            this.Controls.Add(this.Z_select);
            this.Controls.Add(this.Y_select);
            this.Controls.Add(this.X_select);
            this.Controls.Add(this.W_select);
            this.Controls.Add(this.V_select);
            this.Controls.Add(this.U_select);
            this.Controls.Add(this.T_select);
            this.Controls.Add(this.S_select);
            this.Controls.Add(this.R_select);
            this.Controls.Add(this.Q_select);
            this.Controls.Add(this.P_select);
            this.Controls.Add(this.O_select);
            this.Controls.Add(this.N_select);
            this.Controls.Add(this.M_select);
            this.Controls.Add(this.L_select);
            this.Controls.Add(this.K_select);
            this.Controls.Add(this.J_select);
            this.Controls.Add(this.I_select);
            this.Controls.Add(this.H_select);
            this.Controls.Add(this.G_select);
            this.Controls.Add(this.F_select);
            this.Controls.Add(this.E_select);
            this.Controls.Add(this.D_select);
            this.Controls.Add(this.C_select);
            this.Controls.Add(this.B_select);
            this.Controls.Add(this.A_select);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.OutputWindow);
            this.Name = "HangmanUI";
            this.Text = "Hangman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputWindow;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Label A_select;
        private System.Windows.Forms.Label B_select;
        private System.Windows.Forms.Label C_select;
        private System.Windows.Forms.Label D_select;
        private System.Windows.Forms.Label E_select;
        private System.Windows.Forms.Label F_select;
        private System.Windows.Forms.Label G_select;
        private System.Windows.Forms.Label H_select;
        private System.Windows.Forms.Label I_select;
        private System.Windows.Forms.Label J_select;
        private System.Windows.Forms.Label K_select;
        private System.Windows.Forms.Label L_select;
        private System.Windows.Forms.Label M_select;
        private System.Windows.Forms.Label N_select;
        private System.Windows.Forms.Label O_select;
        private System.Windows.Forms.Label P_select;
        private System.Windows.Forms.Label Q_select;
        private System.Windows.Forms.Label R_select;
        private System.Windows.Forms.Label S_select;
        private System.Windows.Forms.Label T_select;
        private System.Windows.Forms.Label U_select;
        private System.Windows.Forms.Label V_select;
        private System.Windows.Forms.Label W_select;
        private System.Windows.Forms.Label X_select;
        private System.Windows.Forms.Label Y_select;
        private System.Windows.Forms.Label Z_select;
        private System.Windows.Forms.Label WordDisplay;
        private System.Windows.Forms.Label MissesLabel;
    }
}
