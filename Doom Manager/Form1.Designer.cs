namespace Doom_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pk3_list = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wad_list = new System.Windows.Forms.CheckedListBox();
            this.Launch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Wad_up = new System.Windows.Forms.Button();
            this.Wad_down = new System.Windows.Forms.Button();
            this.pk3_down = new System.Windows.Forms.Button();
            this.pk3_up = new System.Windows.Forms.Button();
            this.Demo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.commands = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.config_input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.config_list = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Number_players = new System.Windows.Forms.NumericUpDown();
            this.players_label = new System.Windows.Forms.Label();
            this.Ip_box = new System.Windows.Forms.TextBox();
            this.ip_label = new System.Windows.Forms.Label();
            this.Join = new System.Windows.Forms.CheckBox();
            this.Host = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Number_players)).BeginInit();
            this.SuspendLayout();
            // 
            // pk3_list
            // 
            this.pk3_list.FormattingEnabled = true;
            this.pk3_list.Location = new System.Drawing.Point(213, 32);
            this.pk3_list.Name = "pk3_list";
            this.pk3_list.Size = new System.Drawing.Size(150, 379);
            this.pk3_list.TabIndex = 0;
            this.pk3_list.SelectedIndexChanged += new System.EventHandler(this.pk3_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pk3 Files:";
            // 
            // wad_list
            // 
            this.wad_list.FormattingEnabled = true;
            this.wad_list.Location = new System.Drawing.Point(12, 32);
            this.wad_list.Name = "wad_list";
            this.wad_list.Size = new System.Drawing.Size(150, 379);
            this.wad_list.TabIndex = 2;
            this.wad_list.SelectedIndexChanged += new System.EventHandler(this.wad_list_SelectedIndexChanged);
            // 
            // Launch
            // 
            this.Launch.Location = new System.Drawing.Point(12, 417);
            this.Launch.Name = "Launch";
            this.Launch.Size = new System.Drawing.Size(121, 23);
            this.Launch.TabIndex = 3;
            this.Launch.Text = "Launch Gzdoom";
            this.Launch.UseVisualStyleBackColor = true;
            this.Launch.Click += new System.EventHandler(this.Launch_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wad Files:";
            // 
            // Wad_up
            // 
            this.Wad_up.Enabled = false;
            this.Wad_up.Location = new System.Drawing.Point(169, 32);
            this.Wad_up.Name = "Wad_up";
            this.Wad_up.Size = new System.Drawing.Size(38, 23);
            this.Wad_up.TabIndex = 5;
            this.Wad_up.Text = "↑";
            this.Wad_up.UseVisualStyleBackColor = true;
            this.Wad_up.Click += new System.EventHandler(this.Wad_up_Click);
            // 
            // Wad_down
            // 
            this.Wad_down.Enabled = false;
            this.Wad_down.Location = new System.Drawing.Point(169, 62);
            this.Wad_down.Name = "Wad_down";
            this.Wad_down.Size = new System.Drawing.Size(38, 23);
            this.Wad_down.TabIndex = 6;
            this.Wad_down.Text = "↓";
            this.Wad_down.UseVisualStyleBackColor = true;
            this.Wad_down.Click += new System.EventHandler(this.Wad_down_Click);
            // 
            // pk3_down
            // 
            this.pk3_down.Enabled = false;
            this.pk3_down.Location = new System.Drawing.Point(369, 62);
            this.pk3_down.Name = "pk3_down";
            this.pk3_down.Size = new System.Drawing.Size(38, 23);
            this.pk3_down.TabIndex = 7;
            this.pk3_down.Text = "↓";
            this.pk3_down.UseVisualStyleBackColor = true;
            this.pk3_down.Click += new System.EventHandler(this.pk3_down_Click);
            // 
            // pk3_up
            // 
            this.pk3_up.Enabled = false;
            this.pk3_up.Location = new System.Drawing.Point(369, 33);
            this.pk3_up.Name = "pk3_up";
            this.pk3_up.Size = new System.Drawing.Size(38, 23);
            this.pk3_up.TabIndex = 8;
            this.pk3_up.Text = "↑";
            this.pk3_up.UseVisualStyleBackColor = true;
            this.pk3_up.Click += new System.EventHandler(this.pk3_up_Click);
            // 
            // Demo
            // 
            this.Demo.AutoSize = true;
            this.Demo.Location = new System.Drawing.Point(139, 421);
            this.Demo.Name = "Demo";
            this.Demo.Size = new System.Drawing.Size(92, 17);
            this.Demo.TabIndex = 9;
            this.Demo.Text = "Record Demo";
            this.Demo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Other commands:";
            // 
            // commands
            // 
            this.commands.Location = new System.Drawing.Point(333, 419);
            this.commands.Name = "commands";
            this.commands.Size = new System.Drawing.Size(165, 20);
            this.commands.TabIndex = 11;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(369, 134);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(125, 23);
            this.save.TabIndex = 12;
            this.save.Text = "Save config";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Config name";
            // 
            // config_input
            // 
            this.config_input.Location = new System.Drawing.Point(369, 108);
            this.config_input.Name = "config_input";
            this.config_input.Size = new System.Drawing.Size(125, 20);
            this.config_input.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select config to load";
            // 
            // config_list
            // 
            this.config_list.FormattingEnabled = true;
            this.config_list.Location = new System.Drawing.Point(369, 176);
            this.config_list.Name = "config_list";
            this.config_list.Size = new System.Drawing.Size(125, 95);
            this.config_list.TabIndex = 16;
            this.config_list.SelectedIndexChanged += new System.EventHandler(this.config_list_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Number_players);
            this.groupBox1.Controls.Add(this.players_label);
            this.groupBox1.Controls.Add(this.Ip_box);
            this.groupBox1.Controls.Add(this.ip_label);
            this.groupBox1.Controls.Add(this.Join);
            this.groupBox1.Controls.Add(this.Host);
            this.groupBox1.Location = new System.Drawing.Point(369, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 134);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multiplayer settings";
            // 
            // Number_players
            // 
            this.Number_players.Location = new System.Drawing.Point(9, 85);
            this.Number_players.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Number_players.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Number_players.Name = "Number_players";
            this.Number_players.Size = new System.Drawing.Size(101, 20);
            this.Number_players.TabIndex = 5;
            this.Number_players.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Number_players.Visible = false;
            // 
            // players_label
            // 
            this.players_label.AutoSize = true;
            this.players_label.Location = new System.Drawing.Point(7, 68);
            this.players_label.Name = "players_label";
            this.players_label.Size = new System.Drawing.Size(95, 13);
            this.players_label.TabIndex = 4;
            this.players_label.Text = "Number of players:";
            this.players_label.Visible = false;
            // 
            // Ip_box
            // 
            this.Ip_box.Location = new System.Drawing.Point(10, 84);
            this.Ip_box.Name = "Ip_box";
            this.Ip_box.Size = new System.Drawing.Size(100, 20);
            this.Ip_box.TabIndex = 3;
            this.Ip_box.Visible = false;
            // 
            // ip_label
            // 
            this.ip_label.AutoSize = true;
            this.ip_label.Location = new System.Drawing.Point(7, 68);
            this.ip_label.Name = "ip_label";
            this.ip_label.Size = new System.Drawing.Size(19, 13);
            this.ip_label.TabIndex = 2;
            this.ip_label.Text = "Ip:";
            this.ip_label.Visible = false;
            // 
            // Join
            // 
            this.Join.AutoSize = true;
            this.Join.Location = new System.Drawing.Point(7, 44);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(45, 17);
            this.Join.TabIndex = 1;
            this.Join.Text = "Join";
            this.Join.UseVisualStyleBackColor = true;
            this.Join.CheckedChanged += new System.EventHandler(this.Join_CheckedChanged);
            // 
            // Host
            // 
            this.Host.AutoSize = true;
            this.Host.Location = new System.Drawing.Point(7, 20);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(48, 17);
            this.Host.TabIndex = 0;
            this.Host.Text = "Host";
            this.Host.UseVisualStyleBackColor = true;
            this.Host.CheckedChanged += new System.EventHandler(this.Host_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.config_list);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.config_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.save);
            this.Controls.Add(this.commands);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Demo);
            this.Controls.Add(this.pk3_up);
            this.Controls.Add(this.pk3_down);
            this.Controls.Add(this.Wad_down);
            this.Controls.Add(this.Wad_up);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Launch);
            this.Controls.Add(this.wad_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pk3_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "GzDoom Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Number_players)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox pk3_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox wad_list;
        private System.Windows.Forms.Button Launch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Wad_up;
        private System.Windows.Forms.Button Wad_down;
        private System.Windows.Forms.Button pk3_down;
        private System.Windows.Forms.Button pk3_up;
        private System.Windows.Forms.CheckBox Demo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox commands;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox config_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox config_list;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Host;
        private System.Windows.Forms.CheckBox Join;
        private System.Windows.Forms.TextBox Ip_box;
        private System.Windows.Forms.Label ip_label;
        private System.Windows.Forms.Label players_label;
        private System.Windows.Forms.NumericUpDown Number_players;
    }
}

