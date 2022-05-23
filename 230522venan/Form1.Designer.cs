namespace _230522venan
{
    partial class FormPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_first = new System.Windows.Forms.Button();
            this.bt_previous = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_last = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.dtpbirth = new System.Windows.Forms.DateTimePicker();
            this.cbteam = new System.Windows.Forms.ComboBox();
            this.teamnum = new System.Windows.Forms.NumericUpDown();
            this.btsave = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.cbnationality = new System.Windows.Forms.ComboBox();
            this.lblavailable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamnum)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_first
            // 
            this.bt_first.Location = new System.Drawing.Point(35, 21);
            this.bt_first.Name = "bt_first";
            this.bt_first.Size = new System.Drawing.Size(190, 45);
            this.bt_first.TabIndex = 0;
            this.bt_first.Text = "<<";
            this.bt_first.UseVisualStyleBackColor = true;
            this.bt_first.Click += new System.EventHandler(this.bt_first_Click);
            // 
            // bt_previous
            // 
            this.bt_previous.Location = new System.Drawing.Point(231, 21);
            this.bt_previous.Name = "bt_previous";
            this.bt_previous.Size = new System.Drawing.Size(190, 45);
            this.bt_previous.TabIndex = 1;
            this.bt_previous.Text = "<";
            this.bt_previous.UseVisualStyleBackColor = true;
            this.bt_previous.Click += new System.EventHandler(this.bt_previous_Click);
            // 
            // bt_next
            // 
            this.bt_next.Location = new System.Drawing.Point(427, 21);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(190, 45);
            this.bt_next.TabIndex = 2;
            this.bt_next.Text = ">";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // bt_last
            // 
            this.bt_last.Location = new System.Drawing.Point(623, 21);
            this.bt_last.Name = "bt_last";
            this.bt_last.Size = new System.Drawing.Size(190, 45);
            this.bt_last.TabIndex = 3;
            this.bt_last.Text = ">>";
            this.bt_last.UseVisualStyleBackColor = true;
            this.bt_last.Click += new System.EventHandler(this.bt_last_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player  ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player Name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "BirthDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nationality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Team Number";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(169, 130);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(233, 26);
            this.tbid.TabIndex = 10;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(169, 183);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(365, 26);
            this.tbname.TabIndex = 11;
            // 
            // dtpbirth
            // 
            this.dtpbirth.Location = new System.Drawing.Point(169, 229);
            this.dtpbirth.Name = "dtpbirth";
            this.dtpbirth.Size = new System.Drawing.Size(274, 26);
            this.dtpbirth.TabIndex = 13;
            // 
            // cbteam
            // 
            this.cbteam.FormattingEnabled = true;
            this.cbteam.Items.AddRange(new object[] {
            "Algeria",
            "Argentina",
            "Australia",
            "Austria",
            "Belgium",
            "Benin",
            "Bosnia and Herzegovina",
            "Brazil",
            "Burkina Faso",
            "Cameroon",
            "Canada",
            "Chile",
            "Colombia",
            "Congo",
            "Costa Rica",
            "Croatia",
            "Curaçao",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "DR Congo",
            "Ecuador",
            "Egypt",
            "England",
            "Finland",
            "France",
            "Gambia",
            "Germany",
            "Ghana",
            "Greece",
            "Hungary",
            "Iceland",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Kenya",
            "Lithuania",
            "Macedonia",
            "Mali",
            "Mexico",
            "Morocco",
            "Netherlands",
            "New Zealand",
            "Nigeria",
            "Northern Ireland",
            "Norway",
            "Poland",
            "Portugal",
            "Republic of Ireland",
            "Romania",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Scotland",
            "Senegal",
            "Serbia",
            "Slovakia",
            "Slovenia",
            "South Africa",
            "South Korea",
            "Spain",
            "Sweden",
            "Switzerland",
            "Togo",
            "Tunisia",
            "Turkey",
            "United States",
            "Uruguay",
            "Venezuela",
            "Wales",
            "Yugoslavia",
            "Zimbabwe"});
            this.cbteam.Location = new System.Drawing.Point(169, 328);
            this.cbteam.Name = "cbteam";
            this.cbteam.Size = new System.Drawing.Size(233, 28);
            this.cbteam.TabIndex = 14;
            this.cbteam.SelectedIndexChanged += new System.EventHandler(this.cbteam_SelectedIndexChanged);
            // 
            // teamnum
            // 
            this.teamnum.Location = new System.Drawing.Point(169, 384);
            this.teamnum.Name = "teamnum";
            this.teamnum.Size = new System.Drawing.Size(233, 26);
            this.teamnum.TabIndex = 15;
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(35, 441);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(190, 39);
            this.btsave.TabIndex = 16;
            this.btsave.Text = "Save";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(271, 441);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(190, 39);
            this.btcancel.TabIndex = 17;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // cbnationality
            // 
            this.cbnationality.FormattingEnabled = true;
            this.cbnationality.Items.AddRange(new object[] {
            "Arsenal",
            "Aston Villa",
            "Bournemouth",
            "Chelsea",
            "Crystal Palace",
            "Everton",
            "Leicester City",
            "Liverpool",
            "Manchester City",
            "Manchester United",
            "Newcastle United",
            "Norwich City",
            "Southampton",
            "Stoke City",
            "Sunderland",
            "Swansea City",
            "Tottenham Hotspur",
            "Watford",
            "West Bromwich Albion",
            "West Ham United"});
            this.cbnationality.Location = new System.Drawing.Point(169, 279);
            this.cbnationality.Name = "cbnationality";
            this.cbnationality.Size = new System.Drawing.Size(233, 28);
            this.cbnationality.TabIndex = 18;
            this.cbnationality.SelectedIndexChanged += new System.EventHandler(this.cbnationality_SelectedIndexChanged);
            // 
            // lblavailable
            // 
            this.lblavailable.AutoSize = true;
            this.lblavailable.Location = new System.Drawing.Point(471, 390);
            this.lblavailable.Name = "lblavailable";
            this.lblavailable.Size = new System.Drawing.Size(72, 20);
            this.lblavailable.TabIndex = 19;
            this.lblavailable.Text = "Available";
            this.lblavailable.Click += new System.EventHandler(this.lblavailable_Click);
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 524);
            this.Controls.Add(this.lblavailable);
            this.Controls.Add(this.cbnationality);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.teamnum);
            this.Controls.Add(this.cbteam);
            this.Controls.Add(this.dtpbirth);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_last);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.bt_previous);
            this.Controls.Add(this.bt_first);
            this.Name = "FormPlayer";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_first;
        private System.Windows.Forms.Button bt_previous;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Button bt_last;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.DateTimePicker dtpbirth;
        private System.Windows.Forms.ComboBox cbteam;
        private System.Windows.Forms.NumericUpDown teamnum;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.ComboBox cbnationality;
        private System.Windows.Forms.Label lblavailable;
    }
}

