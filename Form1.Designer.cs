using MySql.Data.MySqlClient;

namespace UVRPV2tov3Migration
{
    partial class LoadNext
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
            this.edtServer = new System.Windows.Forms.TextBox();
            this.DBame = new System.Windows.Forms.TextBox();
            this.ServerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.CharacterSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newStash = new System.Windows.Forms.Label();
            this.newApptStash = new System.Windows.Forms.Label();
            this.remiburseAmt = new System.Windows.Forms.Label();
            this.reimbusreLbl = new System.Windows.Forms.Label();
            this.CitizenID = new System.Windows.Forms.Label();
            this.PlayerLiscense = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.licLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.destinationUser = new System.Windows.Forms.TextBox();
            this.destinationServer = new System.Windows.Forms.TextBox();
            this.destinationDB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NewItemsLUA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OVLPath = new System.Windows.Forms.Label();
            this.OVLPathText = new System.Windows.Forms.TextBox();
            this.LoadSource = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.rt1 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.newBankLbl = new System.Windows.Forms.Label();
            this.newBankVal = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtServer
            // 
            this.edtServer.Location = new System.Drawing.Point(76, 19);
            this.edtServer.Name = "edtServer";
            this.edtServer.Size = new System.Drawing.Size(245, 23);
            this.edtServer.TabIndex = 0;
            this.edtServer.Text = "127.0.0.1";
            // 
            // DBame
            // 
            this.DBame.Location = new System.Drawing.Point(76, 48);
            this.DBame.Name = "DBame";
            this.DBame.Size = new System.Drawing.Size(245, 23);
            this.DBame.TabIndex = 1;
            this.DBame.Text = "qbcoreframework_4347c9";
            // 
            // ServerName
            // 
            this.ServerName.AutoSize = true;
            this.ServerName.Location = new System.Drawing.Point(15, 24);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(39, 15);
            this.ServerName.TabIndex = 2;
            this.ServerName.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(76, 77);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(245, 23);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "User";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 776);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1206, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connStatus
            // 
            this.connStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.connStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connStatus.Name = "connStatus";
            this.connStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // CharacterSelect
            // 
            this.CharacterSelect.FormattingEnabled = true;
            this.CharacterSelect.Location = new System.Drawing.Point(110, 190);
            this.CharacterSelect.Name = "CharacterSelect";
            this.CharacterSelect.Size = new System.Drawing.Size(121, 23);
            this.CharacterSelect.TabIndex = 9;
            this.CharacterSelect.TextChanged += new System.EventHandler(this.CharacterSelect_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Character";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newBankVal);
            this.groupBox1.Controls.Add(this.newBankLbl);
            this.groupBox1.Controls.Add(this.newStash);
            this.groupBox1.Controls.Add(this.newApptStash);
            this.groupBox1.Controls.Add(this.remiburseAmt);
            this.groupBox1.Controls.Add(this.reimbusreLbl);
            this.groupBox1.Controls.Add(this.CitizenID);
            this.groupBox1.Controls.Add(this.PlayerLiscense);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.licLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(237, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 166);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Player Details";
            // 
            // newStash
            // 
            this.newStash.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.newStash.AutoSize = true;
            this.newStash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newStash.Location = new System.Drawing.Point(467, 42);
            this.newStash.Name = "newStash";
            this.newStash.Size = new System.Drawing.Size(0, 15);
            this.newStash.TabIndex = 18;
            // 
            // newApptStash
            // 
            this.newApptStash.AutoSize = true;
            this.newApptStash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newApptStash.Location = new System.Drawing.Point(439, 19);
            this.newApptStash.Name = "newApptStash";
            this.newApptStash.Size = new System.Drawing.Size(118, 15);
            this.newApptStash.TabIndex = 17;
            this.newApptStash.Text = "New  Stash Number";
            // 
            // remiburseAmt
            // 
            this.remiburseAmt.AutoSize = true;
            this.remiburseAmt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remiburseAmt.Location = new System.Drawing.Point(33, 133);
            this.remiburseAmt.Name = "remiburseAmt";
            this.remiburseAmt.Size = new System.Drawing.Size(0, 15);
            this.remiburseAmt.TabIndex = 16;
            // 
            // reimbusreLbl
            // 
            this.reimbusreLbl.AutoSize = true;
            this.reimbusreLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reimbusreLbl.Location = new System.Drawing.Point(17, 107);
            this.reimbusreLbl.Name = "reimbusreLbl";
            this.reimbusreLbl.Size = new System.Drawing.Size(170, 15);
            this.reimbusreLbl.TabIndex = 15;
            this.reimbusreLbl.Text = "Vehicle Reimbursement Total";
            // 
            // CitizenID
            // 
            this.CitizenID.AutoSize = true;
            this.CitizenID.Location = new System.Drawing.Point(33, 92);
            this.CitizenID.Name = "CitizenID";
            this.CitizenID.Size = new System.Drawing.Size(0, 15);
            this.CitizenID.TabIndex = 14;
            // 
            // PlayerLiscense
            // 
            this.PlayerLiscense.AutoSize = true;
            this.PlayerLiscense.Location = new System.Drawing.Point(33, 42);
            this.PlayerLiscense.Name = "PlayerLiscense";
            this.PlayerLiscense.Size = new System.Drawing.Size(0, 15);
            this.PlayerLiscense.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "CitizenID";
            // 
            // licLabel
            // 
            this.licLabel.AutoSize = true;
            this.licLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.licLabel.Location = new System.Drawing.Point(17, 19);
            this.licLabel.Name = "licLabel";
            this.licLabel.Size = new System.Drawing.Size(48, 15);
            this.licLabel.TabIndex = 0;
            this.licLabel.Text = "License";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UserName);
            this.groupBox2.Controls.Add(this.edtServer);
            this.groupBox2.Controls.Add(this.DBame);
            this.groupBox2.Controls.Add(this.ServerName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 111);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Source Server";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.destinationUser);
            this.groupBox3.Controls.Add(this.destinationServer);
            this.groupBox3.Controls.Add(this.destinationDB);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(358, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 111);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Destination Server";
            // 
            // destinationUser
            // 
            this.destinationUser.Location = new System.Drawing.Point(76, 77);
            this.destinationUser.Name = "destinationUser";
            this.destinationUser.Size = new System.Drawing.Size(245, 23);
            this.destinationUser.TabIndex = 4;
            this.destinationUser.Text = "root";
            // 
            // destinationServer
            // 
            this.destinationServer.Location = new System.Drawing.Point(76, 19);
            this.destinationServer.Name = "destinationServer";
            this.destinationServer.Size = new System.Drawing.Size(245, 23);
            this.destinationServer.TabIndex = 0;
            this.destinationServer.Text = "127.0.0.1";
            // 
            // destinationDB
            // 
            this.destinationDB.Location = new System.Drawing.Point(76, 48);
            this.destinationDB.Name = "destinationDB";
            this.destinationDB.Size = new System.Drawing.Size(245, 23);
            this.destinationDB.TabIndex = 1;
            this.destinationDB.Text = "qbcoreframework_4347c9";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Database";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "User";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NewItemsLUA);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.OVLPath);
            this.groupBox4.Controls.Add(this.OVLPathText);
            this.groupBox4.Location = new System.Drawing.Point(704, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(490, 165);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configuration";
            // 
            // NewItemsLUA
            // 
            this.NewItemsLUA.Location = new System.Drawing.Point(6, 136);
            this.NewItemsLUA.Name = "NewItemsLUA";
            this.NewItemsLUA.Size = new System.Drawing.Size(462, 23);
            this.NewItemsLUA.TabIndex = 9;
            this.NewItemsLUA.Text = "C:\\FXServer\\txData\\QBCoreFramework_4347C9.base\\resources\\[qb]\\qb-core\\shared\\item" +
    "s1.lua";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Absolute Path to NEW Items LUA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(462, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "C:\\FXServer\\txData\\QBCoreFramework_4347C9.base\\resources\\[qb]\\qb-core\\shared\\item" +
    "s.lua";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Absolute Path to Old Items LUA";
            // 
            // OVLPath
            // 
            this.OVLPath.AutoSize = true;
            this.OVLPath.Location = new System.Drawing.Point(6, 27);
            this.OVLPath.Name = "OVLPath";
            this.OVLPath.Size = new System.Drawing.Size(182, 15);
            this.OVLPath.TabIndex = 1;
            this.OVLPath.Text = "Absolute Path to Old Vehicle LUA";
            // 
            // OVLPathText
            // 
            this.OVLPathText.Location = new System.Drawing.Point(6, 48);
            this.OVLPathText.Name = "OVLPathText";
            this.OVLPathText.Size = new System.Drawing.Size(462, 23);
            this.OVLPathText.TabIndex = 0;
            this.OVLPathText.Text = "C:\\FXServer\\txData\\QBCoreFramework_4347C9.base\\resources\\[qb]\\qb-core\\shared\\vehi" +
    "cles.lua";
            // 
            // LoadSource
            // 
            this.LoadSource.Location = new System.Drawing.Point(12, 154);
            this.LoadSource.Name = "LoadSource";
            this.LoadSource.Size = new System.Drawing.Size(219, 23);
            this.LoadSource.TabIndex = 15;
            this.LoadSource.Text = "Load Data from Source";
            this.LoadSource.UseVisualStyleBackColor = true;
            this.LoadSource.Click += new System.EventHandler(this.LoadData);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(110, 228);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(121, 23);
            this.NextButton.TabIndex = 16;
            this.NextButton.Text = "Load Next Player";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // rt1
            // 
            this.rt1.Location = new System.Drawing.Point(27, 365);
            this.rt1.Name = "rt1";
            this.rt1.Size = new System.Drawing.Size(1145, 372);
            this.rt1.TabIndex = 17;
            this.rt1.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "New Stash Inventory";
           
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1049, 750);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Send Updates to V3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newBankLbl
            // 
            this.newBankLbl.AutoSize = true;
            this.newBankLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newBankLbl.Location = new System.Drawing.Point(439, 66);
            this.newBankLbl.Name = "newBankLbl";
            this.newBankLbl.Size = new System.Drawing.Size(115, 15);
            this.newBankLbl.TabIndex = 19;
            this.newBankLbl.Text = "New  Bank Amount";
            // 
            // newBankVal
            // 
            this.newBankVal.AutoSize = true;
            this.newBankVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newBankVal.Location = new System.Drawing.Point(473, 92);
            this.newBankVal.Name = "newBankVal";
            this.newBankVal.Size = new System.Drawing.Size(0, 15);
            this.newBankVal.TabIndex = 20;
            // 
            // LoadNext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 798);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rt1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.LoadSource);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CharacterSelect);
            this.Controls.Add(this.statusStrip1);
            this.Name = "LoadNext";
            this.Text = "UVRPMigration";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private TextBox edtServer;
        private TextBox DBame;
        private Label ServerName;
        private Label label2;
        private TextBox UserName;
        private Label label3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel connStatus;
        private ComboBox CharacterSelect;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label licLabel;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox destinationUser;
        private TextBox destinationServer;
        private TextBox destinationDB;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox4;
        private Label PlayerLiscense;
        private Label CitizenID;
        private Button LoadSource;
        private Label OVLPath;
        private TextBox OVLPathText;
        private TextBox NewItemsLUA;
        private Label label9;
        private TextBox textBox1;
        private Label label8;
        private Button NextButton;
        private Label remiburseAmt;
        private Label reimbusreLbl;
        private RichTextBox rt1;
        private Label label10;
        private Label newStash;
        private Label newApptStash;
        private Button button2;
        private Label newBankVal;
        private Label newBankLbl;
    }
}