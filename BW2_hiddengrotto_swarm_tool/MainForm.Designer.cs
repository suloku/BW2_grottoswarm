/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 17/10/2015
 * Time: 16:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BW2_hiddengrotto_swarm_tool
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button load_but;
		private System.Windows.Forms.TextBox savegamename;
		private System.Windows.Forms.ComboBox Grotto_route;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox normalgrottobox;
		private System.Windows.Forms.ComboBox fungrottobox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox normalgrottogroupbox;
		private System.Windows.Forms.ComboBox fungrottogroupbox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox normalgrottoavailable;
		private System.Windows.Forms.CheckBox fungrottoavailable;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button save_button;
		private System.Windows.Forms.ComboBox swarmbox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox lastgrottobox;
		private System.Windows.Forms.Button lastvisitedhelp;
		private System.Windows.Forms.Button fungrottohelp;
		private System.Windows.Forms.NumericUpDown unknowngrottobox;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox gender5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox gender10;
		private System.Windows.Forms.TextBox gender30;
		private System.Windows.Forms.TextBox gender60;
		private System.Windows.Forms.Button forceMale_but;
		private System.Windows.Forms.Button forceFemale_but;
		private System.Windows.Forms.Button note_but;
		private System.Windows.Forms.Button grotto_help;
		private System.Windows.Forms.Button table_but;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.load_but = new System.Windows.Forms.Button();
			this.savegamename = new System.Windows.Forms.TextBox();
			this.Grotto_route = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.normalgrottobox = new System.Windows.Forms.ComboBox();
			this.fungrottobox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.normalgrottogroupbox = new System.Windows.Forms.ComboBox();
			this.fungrottogroupbox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.normalgrottoavailable = new System.Windows.Forms.CheckBox();
			this.fungrottoavailable = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.fungrottohelp = new System.Windows.Forms.Button();
			this.note_but = new System.Windows.Forms.Button();
			this.save_button = new System.Windows.Forms.Button();
			this.swarmbox = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.grotto_help = new System.Windows.Forms.Button();
			this.table_but = new System.Windows.Forms.Button();
			this.forceMale_but = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.gender5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.gender10 = new System.Windows.Forms.TextBox();
			this.gender60 = new System.Windows.Forms.TextBox();
			this.gender30 = new System.Windows.Forms.TextBox();
			this.forceFemale_but = new System.Windows.Forms.Button();
			this.lastvisitedhelp = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lastgrottobox = new System.Windows.Forms.ComboBox();
			this.unknowngrottobox = new System.Windows.Forms.NumericUpDown();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.unknowngrottobox)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// load_but
			// 
			this.load_but.Location = new System.Drawing.Point(264, 12);
			this.load_but.Name = "load_but";
			this.load_but.Size = new System.Drawing.Size(162, 23);
			this.load_but.TabIndex = 0;
			this.load_but.Text = "Load B/W 2 Savegame";
			this.load_but.UseVisualStyleBackColor = true;
			this.load_but.Click += new System.EventHandler(this.load_butClick);
			// 
			// savegamename
			// 
			this.savegamename.Location = new System.Drawing.Point(13, 41);
			this.savegamename.Name = "savegamename";
			this.savegamename.Size = new System.Drawing.Size(694, 20);
			this.savegamename.TabIndex = 1;
			this.savegamename.TextChanged += new System.EventHandler(this.SavegamenameTextChanged);
			// 
			// Grotto_route
			// 
			this.Grotto_route.FormattingEnabled = true;
			this.Grotto_route.Items.AddRange(new object[] {
			"Sangi Ranch (10-15)",
			"Route 5 (20-25)",
			"Lostlorn Forest (20-25)",
			"Route 6 [Field] (25-30)",
			"Route 6 [Cave] (25-30)",
			"Route 7 (30-35)",
			"Route 13 [StairLeft] (35-40)",
			"Route 13 [StairDown] (35-40)",
			"Route 9 (35-40)",
			"Giant Chasm (45-50)",
			"Route 22 (40-45)",
			"Route 23 (50-55)",
			"Abundant [Field] (35-40)",
			"Abundant [Pond] (35-40)",
			"Pinwheel [Interior] (55-60)",
			"Pinwheel [Exterior] (55-60)",
			"Route 3 [Daycare] (55-60)",
			"Route 3 [Pond] (55-60)",
			"Route 2 (55-60)",
			"Route 18 (55-60)"});
			this.Grotto_route.Location = new System.Drawing.Point(23, 30);
			this.Grotto_route.Name = "Grotto_route";
			this.Grotto_route.Size = new System.Drawing.Size(197, 21);
			this.Grotto_route.TabIndex = 6;
			this.Grotto_route.SelectedIndexChanged += new System.EventHandler(this.Grotto_routeSelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(68, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Slot";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(68, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Slot";
			// 
			// normalgrottobox
			// 
			this.normalgrottobox.FormattingEnabled = true;
			this.normalgrottobox.Items.AddRange(new object[] {
			"Pokemon 1",
			"Pokemon 2",
			"Pokemon 3",
			"Item 1",
			"Item 2",
			"Item 3",
			"Item 4",
			"Dowsing 1",
			"Dowsing 2",
			"Dowsing 3",
			"Dowsing 4",
			"Unknown/Not used/Buggy 1",
			"Unknown/Not used/Buggy 2",
			"Unknown/Not used/Buggy 3",
			"Unknown/Not used/Buggy 4",
			"Unknown/Not used/Buggy 5"});
			this.normalgrottobox.Location = new System.Drawing.Point(68, 34);
			this.normalgrottobox.Name = "normalgrottobox";
			this.normalgrottobox.Size = new System.Drawing.Size(121, 21);
			this.normalgrottobox.TabIndex = 10;
			// 
			// fungrottobox
			// 
			this.fungrottobox.FormattingEnabled = true;
			this.fungrottobox.Items.AddRange(new object[] {
			"Pokemon 1",
			"Pokemon 2",
			"Pokemon 3 - GROUP A FEMALE 5% ^^^^",
			"Item 1",
			"Item 2 - GROUP A FEMALE 10% ^^^^",
			"Item 3",
			"Item 4",
			"Dowsing 1",
			"Dowsing 2",
			"Dowsing 3",
			"Dowsing 4",
			"Unknown/Not used/Buggy 1",
			"Unknown/Not used/Buggy 2",
			"Unknown - GROUP B FEMALE 60% ^^^^",
			"Unknown - GROUP A FEMALE 30% ^^^^",
			"Unknown/Not used/Buggy 5"});
			this.fungrottobox.Location = new System.Drawing.Point(68, 33);
			this.fungrottobox.Name = "fungrottobox";
			this.fungrottobox.Size = new System.Drawing.Size(204, 21);
			this.fungrottobox.TabIndex = 11;
			this.fungrottobox.SelectedIndexChanged += new System.EventHandler(this.FungrottoboxSelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(14, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Group";
			// 
			// normalgrottogroupbox
			// 
			this.normalgrottogroupbox.FormattingEnabled = true;
			this.normalgrottogroupbox.Items.AddRange(new object[] {
			"A",
			"B",
			"C",
			"D"});
			this.normalgrottogroupbox.Location = new System.Drawing.Point(14, 34);
			this.normalgrottogroupbox.Name = "normalgrottogroupbox";
			this.normalgrottogroupbox.Size = new System.Drawing.Size(48, 21);
			this.normalgrottogroupbox.TabIndex = 13;
			// 
			// fungrottogroupbox
			// 
			this.fungrottogroupbox.FormattingEnabled = true;
			this.fungrottogroupbox.Items.AddRange(new object[] {
			"A",
			"B",
			"C",
			"D"});
			this.fungrottogroupbox.Location = new System.Drawing.Point(14, 33);
			this.fungrottogroupbox.Name = "fungrottogroupbox";
			this.fungrottogroupbox.Size = new System.Drawing.Size(48, 21);
			this.fungrottogroupbox.TabIndex = 15;
			this.fungrottogroupbox.SelectedIndexChanged += new System.EventHandler(this.FungrottogroupboxSelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(14, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "Group";
			// 
			// normalgrottoavailable
			// 
			this.normalgrottoavailable.Location = new System.Drawing.Point(68, 61);
			this.normalgrottoavailable.Name = "normalgrottoavailable";
			this.normalgrottoavailable.Size = new System.Drawing.Size(104, 24);
			this.normalgrottoavailable.TabIndex = 16;
			this.normalgrottoavailable.Text = "Available";
			this.normalgrottoavailable.UseVisualStyleBackColor = true;
			// 
			// fungrottoavailable
			// 
			this.fungrottoavailable.Location = new System.Drawing.Point(68, 60);
			this.fungrottoavailable.Name = "fungrottoavailable";
			this.fungrottoavailable.Size = new System.Drawing.Size(104, 24);
			this.fungrottoavailable.TabIndex = 17;
			this.fungrottoavailable.Text = "Available";
			this.fungrottoavailable.UseVisualStyleBackColor = true;
			this.fungrottoavailable.CheckedChanged += new System.EventHandler(this.FungrottoavailableCheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.normalgrottoavailable);
			this.groupBox1.Controls.Add(this.normalgrottogroupbox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.normalgrottobox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(23, 66);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(195, 98);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Normal Grotto";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.fungrottohelp);
			this.groupBox2.Controls.Add(this.fungrottoavailable);
			this.groupBox2.Controls.Add(this.fungrottogroupbox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.fungrottobox);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(224, 67);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(278, 97);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Funfest Grotto ?";
			// 
			// fungrottohelp
			// 
			this.fungrottohelp.Location = new System.Drawing.Point(256, 0);
			this.fungrottohelp.Name = "fungrottohelp";
			this.fungrottohelp.Size = new System.Drawing.Size(22, 23);
			this.fungrottohelp.TabIndex = 23;
			this.fungrottohelp.Text = "?";
			this.fungrottohelp.UseVisualStyleBackColor = true;
			this.fungrottohelp.Click += new System.EventHandler(this.FungrottohelpClick);
			// 
			// note_but
			// 
			this.note_but.Location = new System.Drawing.Point(23, 170);
			this.note_but.Name = "note_but";
			this.note_but.Size = new System.Drawing.Size(75, 23);
			this.note_but.TabIndex = 24;
			this.note_but.Text = "Note";
			this.note_but.UseVisualStyleBackColor = true;
			this.note_but.Click += new System.EventHandler(this.Note_butClick);
			// 
			// save_button
			// 
			this.save_button.Enabled = false;
			this.save_button.Location = new System.Drawing.Point(537, 298);
			this.save_button.Name = "save_button";
			this.save_button.Size = new System.Drawing.Size(162, 23);
			this.save_button.TabIndex = 20;
			this.save_button.Text = "Save";
			this.save_button.UseVisualStyleBackColor = true;
			this.save_button.Click += new System.EventHandler(this.Save_buttonClick);
			// 
			// swarmbox
			// 
			this.swarmbox.FormattingEnabled = true;
			this.swarmbox.Items.AddRange(new object[] {
			"Route 1",
			"Dreamyard",
			"Route 6",
			"Route 3",
			"Route 9",
			"Resort Desert",
			"Route 5",
			"Route 7",
			"Route 12",
			"Route 8",
			"Route 11",
			"Route 13",
			"Abundant Shrine",
			"Route 15",
			"Route 16",
			"Route 18",
			"Rebirth Mountain",
			"Route 20",
			"Route 22"});
			this.swarmbox.Location = new System.Drawing.Point(6, 30);
			this.swarmbox.Name = "swarmbox";
			this.swarmbox.Size = new System.Drawing.Size(161, 21);
			this.swarmbox.TabIndex = 22;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.grotto_help);
			this.groupBox3.Controls.Add(this.table_but);
			this.groupBox3.Controls.Add(this.note_but);
			this.groupBox3.Controls.Add(this.forceMale_but);
			this.groupBox3.Controls.Add(this.groupBox5);
			this.groupBox3.Controls.Add(this.forceFemale_but);
			this.groupBox3.Controls.Add(this.lastvisitedhelp);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.lastgrottobox);
			this.groupBox3.Controls.Add(this.groupBox2);
			this.groupBox3.Controls.Add(this.groupBox1);
			this.groupBox3.Controls.Add(this.Grotto_route);
			this.groupBox3.Location = new System.Drawing.Point(13, 67);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(508, 254);
			this.groupBox3.TabIndex = 23;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Hidden Grotto";
			// 
			// grotto_help
			// 
			this.grotto_help.Location = new System.Drawing.Point(307, 30);
			this.grotto_help.Name = "grotto_help";
			this.grotto_help.Size = new System.Drawing.Size(18, 23);
			this.grotto_help.TabIndex = 25;
			this.grotto_help.Text = "?";
			this.grotto_help.UseVisualStyleBackColor = true;
			this.grotto_help.Click += new System.EventHandler(this.Grotto_helpClick);
			// 
			// table_but
			// 
			this.table_but.Enabled = false;
			this.table_but.Location = new System.Drawing.Point(226, 30);
			this.table_but.Name = "table_but";
			this.table_but.Size = new System.Drawing.Size(75, 23);
			this.table_but.TabIndex = 25;
			this.table_but.Text = "Grotto Table";
			this.table_but.UseVisualStyleBackColor = true;
			this.table_but.Click += new System.EventHandler(this.Black2table_butClick);
			// 
			// forceMale_but
			// 
			this.forceMale_but.Location = new System.Drawing.Point(365, 43);
			this.forceMale_but.Name = "forceMale_but";
			this.forceMale_but.Size = new System.Drawing.Size(103, 23);
			this.forceMale_but.TabIndex = 26;
			this.forceMale_but.Text = "Force Male";
			this.forceMale_but.UseVisualStyleBackColor = true;
			this.forceMale_but.Click += new System.EventHandler(this.ForceMale_butClick);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label9);
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Controls.Add(this.gender5);
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Controls.Add(this.gender10);
			this.groupBox5.Controls.Add(this.gender60);
			this.groupBox5.Controls.Add(this.gender30);
			this.groupBox5.Location = new System.Drawing.Point(368, 170);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(134, 76);
			this.groupBox5.TabIndex = 24;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Gender";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(63, 46);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(27, 23);
			this.label9.TabIndex = 31;
			this.label9.Text = "60%";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(25, 23);
			this.label6.TabIndex = 28;
			this.label6.Text = "5%";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(2, 46);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(27, 23);
			this.label8.TabIndex = 30;
			this.label8.Text = "30%";
			// 
			// gender5
			// 
			this.gender5.Enabled = false;
			this.gender5.Location = new System.Drawing.Point(35, 22);
			this.gender5.Name = "gender5";
			this.gender5.Size = new System.Drawing.Size(22, 20);
			this.gender5.TabIndex = 24;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(65, 19);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(27, 23);
			this.label7.TabIndex = 29;
			this.label7.Text = "10%";
			// 
			// gender10
			// 
			this.gender10.Enabled = false;
			this.gender10.Location = new System.Drawing.Point(96, 19);
			this.gender10.Name = "gender10";
			this.gender10.Size = new System.Drawing.Size(22, 20);
			this.gender10.TabIndex = 25;
			// 
			// gender60
			// 
			this.gender60.Enabled = false;
			this.gender60.Location = new System.Drawing.Point(96, 46);
			this.gender60.Name = "gender60";
			this.gender60.Size = new System.Drawing.Size(22, 20);
			this.gender60.TabIndex = 27;
			// 
			// gender30
			// 
			this.gender30.Enabled = false;
			this.gender30.Location = new System.Drawing.Point(35, 46);
			this.gender30.Name = "gender30";
			this.gender30.Size = new System.Drawing.Size(22, 20);
			this.gender30.TabIndex = 26;
			// 
			// forceFemale_but
			// 
			this.forceFemale_but.Location = new System.Drawing.Point(365, 14);
			this.forceFemale_but.Name = "forceFemale_but";
			this.forceFemale_but.Size = new System.Drawing.Size(103, 23);
			this.forceFemale_but.TabIndex = 25;
			this.forceFemale_but.Text = "Force Female";
			this.forceFemale_but.UseVisualStyleBackColor = true;
			this.forceFemale_but.Click += new System.EventHandler(this.ForceFemale_butClick);
			// 
			// lastvisitedhelp
			// 
			this.lastvisitedhelp.Location = new System.Drawing.Point(323, 201);
			this.lastvisitedhelp.Name = "lastvisitedhelp";
			this.lastvisitedhelp.Size = new System.Drawing.Size(22, 23);
			this.lastvisitedhelp.TabIndex = 22;
			this.lastvisitedhelp.Text = "?";
			this.lastvisitedhelp.UseVisualStyleBackColor = true;
			this.lastvisitedhelp.Click += new System.EventHandler(this.LastvisitedhelpClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(20, 204);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 23);
			this.label1.TabIndex = 21;
			this.label1.Text = "Last Visited Grotto";
			// 
			// lastgrottobox
			// 
			this.lastgrottobox.FormattingEnabled = true;
			this.lastgrottobox.Items.AddRange(new object[] {
			"Sangi Ranch (10-15)",
			"Route 5 (20-25)",
			"Lostlorn Forest (20-25)",
			"Route 6 [Field] (25-30)",
			"Route 6 [Cave] (25-30)",
			"Route 7 (30-35)",
			"Route 13 [StairLeft] (35-40)",
			"Route 13 [StairDown] (35-40)",
			"Route 9 (35-40)",
			"Giant Chasm (45-50)",
			"Route 22 (40-45)",
			"Route 23 (50-55)",
			"Abundant [Field] (35-40)",
			"Abundant [Pond] (35-40)",
			"Pinwheel [Interior] (55-60)",
			"Pinwheel [Exterior] (55-60)",
			"Route 3 [Daycare] (55-60)",
			"Route 3 [Pond] (55-60)",
			"Route 2 (55-60)",
			"Route 18 (55-60)"});
			this.lastgrottobox.Location = new System.Drawing.Point(120, 201);
			this.lastgrottobox.Name = "lastgrottobox";
			this.lastgrottobox.Size = new System.Drawing.Size(197, 21);
			this.lastgrottobox.TabIndex = 20;
			// 
			// unknowngrottobox
			// 
			this.unknowngrottobox.Location = new System.Drawing.Point(538, 149);
			this.unknowngrottobox.Maximum = new decimal(new int[] {
			255,
			0,
			0,
			0});
			this.unknowngrottobox.Name = "unknowngrottobox";
			this.unknowngrottobox.Size = new System.Drawing.Size(52, 20);
			this.unknowngrottobox.TabIndex = 23;
			this.unknowngrottobox.Visible = false;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.swarmbox);
			this.groupBox4.Location = new System.Drawing.Point(532, 67);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(175, 65);
			this.groupBox4.TabIndex = 24;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Current Swarm";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 333);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.save_button);
			this.Controls.Add(this.savegamename);
			this.Controls.Add(this.load_but);
			this.Controls.Add(this.unknowngrottobox);
			this.Name = "MainForm";
			this.Text = "BW2 Grotto & Swarm tool 0.1 by suloku";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.unknowngrottobox)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
