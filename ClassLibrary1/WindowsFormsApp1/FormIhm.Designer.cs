using System;

namespace WindowsFormsApp1
{
    partial class FormIhm
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
            this.components = new System.ComponentModel.Container();
            this.button_codeIataSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_codeIata = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luggageWaitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_search = new System.Windows.Forms.GroupBox();
            this.groupBox_result = new System.Windows.Forms.GroupBox();
            this.groupBox_luggage = new System.Windows.Forms.GroupBox();
            this.checkBox_continuation = new System.Windows.Forms.CheckBox();
            this.checkBox_rush = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox_flightRoute = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_flight = new System.Windows.Forms.GroupBox();
            this.textBox_airlineNub_p2 = new System.Windows.Forms.TextBox();
            this.textBox_datOfOperation = new System.Windows.Forms.TextBox();
            this.textBox_airlineNub_p1 = new System.Windows.Forms.TextBox();
            this.textBox_companyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox_search.SuspendLayout();
            this.groupBox_result.SuspendLayout();
            this.groupBox_luggage.SuspendLayout();
            this.groupBox_flight.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_codeIataSearch
            // 
            this.button_codeIataSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_codeIataSearch.Location = new System.Drawing.Point(440, 13);
            this.button_codeIataSearch.Margin = new System.Windows.Forms.Padding(0);
            this.button_codeIataSearch.Name = "button_codeIataSearch";
            this.button_codeIataSearch.Size = new System.Drawing.Size(75, 23);
            this.button_codeIataSearch.TabIndex = 0;
            this.button_codeIataSearch.Text = "Search";
            this.button_codeIataSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CodeIata : ";
            // 
            // textBox_codeIata
            // 
            this.textBox_codeIata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_codeIata.Location = new System.Drawing.Point(65, 13);
            this.textBox_codeIata.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_codeIata.Name = "textBox_codeIata";
            this.textBox_codeIata.Size = new System.Drawing.Size(363, 20);
            this.textBox_codeIata.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pageToolStripMenuItem
            // 
            this.pageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desconnexionToolStripMenuItem,
            this.luggageWaitToolStripMenuItem});
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            this.pageToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.pageToolStripMenuItem.Text = "Page";
            // 
            // desconnexionToolStripMenuItem
            // 
            this.desconnexionToolStripMenuItem.Name = "desconnexionToolStripMenuItem";
            this.desconnexionToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.desconnexionToolStripMenuItem.Text = "Desconnexion";
            this.desconnexionToolStripMenuItem.Click += new System.EventHandler(this.desconnexionToolStripMenuItem_Click);
            // 
            // luggageWaitToolStripMenuItem
            // 
            this.luggageWaitToolStripMenuItem.Name = "luggageWaitToolStripMenuItem";
            this.luggageWaitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.luggageWaitToolStripMenuItem.Text = "LuggageWait";
            // 
            // groupBox_search
            // 
            this.groupBox_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_search.BackColor = System.Drawing.Color.Red;
            this.groupBox_search.Controls.Add(this.textBox_codeIata);
            this.groupBox_search.Controls.Add(this.button_codeIataSearch);
            this.groupBox_search.Controls.Add(this.label1);
            this.groupBox_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_search.Location = new System.Drawing.Point(0, 24);
            this.groupBox_search.Name = "groupBox_search";
            this.groupBox_search.Size = new System.Drawing.Size(518, 46);
            this.groupBox_search.TabIndex = 4;
            this.groupBox_search.TabStop = false;
            this.groupBox_search.Text = "Search";
            // 
            // groupBox_result
            // 
            this.groupBox_result.BackColor = System.Drawing.Color.Blue;
            this.groupBox_result.Controls.Add(this.groupBox_luggage);
            this.groupBox_result.Controls.Add(this.groupBox_flight);
            this.groupBox_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_result.Location = new System.Drawing.Point(0, 70);
            this.groupBox_result.Name = "groupBox_result";
            this.groupBox_result.Size = new System.Drawing.Size(518, 201);
            this.groupBox_result.TabIndex = 5;
            this.groupBox_result.TabStop = false;
            this.groupBox_result.Text = "Result";
            // 
            // groupBox_luggage
            // 
            this.groupBox_luggage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_luggage.BackColor = System.Drawing.Color.Lime;
            this.groupBox_luggage.Controls.Add(this.checkBox_continuation);
            this.groupBox_luggage.Controls.Add(this.checkBox_rush);
            this.groupBox_luggage.Controls.Add(this.textBox2);
            this.groupBox_luggage.Controls.Add(this.textBox_flightRoute);
            this.groupBox_luggage.Controls.Add(this.label6);
            this.groupBox_luggage.Controls.Add(this.label5);
            this.groupBox_luggage.Location = new System.Drawing.Point(261, 16);
            this.groupBox_luggage.Name = "groupBox_luggage";
            this.groupBox_luggage.Size = new System.Drawing.Size(257, 185);
            this.groupBox_luggage.TabIndex = 7;
            this.groupBox_luggage.TabStop = false;
            this.groupBox_luggage.Text = "Luggage";
            // 
            // checkBox_continuation
            // 
            this.checkBox_continuation.AutoSize = true;
            this.checkBox_continuation.Location = new System.Drawing.Point(101, 77);
            this.checkBox_continuation.Name = "checkBox_continuation";
            this.checkBox_continuation.Size = new System.Drawing.Size(85, 17);
            this.checkBox_continuation.TabIndex = 4;
            this.checkBox_continuation.Text = "Continuation";
            this.checkBox_continuation.UseVisualStyleBackColor = true;
            // 
            // checkBox_rush
            // 
            this.checkBox_rush.AutoSize = true;
            this.checkBox_rush.Location = new System.Drawing.Point(101, 100);
            this.checkBox_rush.Name = "checkBox_rush";
            this.checkBox_rush.Size = new System.Drawing.Size(51, 17);
            this.checkBox_rush.TabIndex = 5;
            this.checkBox_rush.Text = "Rush";
            this.checkBox_rush.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox_flightRoute
            // 
            this.textBox_flightRoute.Location = new System.Drawing.Point(88, 17);
            this.textBox_flightRoute.Name = "textBox_flightRoute";
            this.textBox_flightRoute.Size = new System.Drawing.Size(152, 20);
            this.textBox_flightRoute.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Luggage Classe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Flight Roote :";
            // 
            // groupBox_flight
            // 
            this.groupBox_flight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_flight.BackColor = System.Drawing.Color.Yellow;
            this.groupBox_flight.Controls.Add(this.textBox_airlineNub_p2);
            this.groupBox_flight.Controls.Add(this.textBox_datOfOperation);
            this.groupBox_flight.Controls.Add(this.textBox_airlineNub_p1);
            this.groupBox_flight.Controls.Add(this.textBox_companyName);
            this.groupBox_flight.Controls.Add(this.label3);
            this.groupBox_flight.Controls.Add(this.label4);
            this.groupBox_flight.Controls.Add(this.label2);
            this.groupBox_flight.Location = new System.Drawing.Point(1, 16);
            this.groupBox_flight.Name = "groupBox_flight";
            this.groupBox_flight.Size = new System.Drawing.Size(266, 185);
            this.groupBox_flight.TabIndex = 6;
            this.groupBox_flight.TabStop = false;
            this.groupBox_flight.Text = "Flight";
            // 
            // textBox_airlineNub_p2
            // 
            this.textBox_airlineNub_p2.Location = new System.Drawing.Point(180, 44);
            this.textBox_airlineNub_p2.Name = "textBox_airlineNub_p2";
            this.textBox_airlineNub_p2.Size = new System.Drawing.Size(56, 20);
            this.textBox_airlineNub_p2.TabIndex = 13;
            // 
            // textBox_datOfOperation
            // 
            this.textBox_datOfOperation.Location = new System.Drawing.Point(112, 74);
            this.textBox_datOfOperation.Name = "textBox_datOfOperation";
            this.textBox_datOfOperation.Size = new System.Drawing.Size(124, 20);
            this.textBox_datOfOperation.TabIndex = 10;
            // 
            // textBox_airlineNub_p1
            // 
            this.textBox_airlineNub_p1.Location = new System.Drawing.Point(96, 44);
            this.textBox_airlineNub_p1.Name = "textBox_airlineNub_p1";
            this.textBox_airlineNub_p1.Size = new System.Drawing.Size(76, 20);
            this.textBox_airlineNub_p1.TabIndex = 11;
            // 
            // textBox_companyName
            // 
            this.textBox_companyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_companyName.Location = new System.Drawing.Point(80, 16);
            this.textBox_companyName.Name = "textBox_companyName";
            this.textBox_companyName.Size = new System.Drawing.Size(164, 20);
            this.textBox_companyName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Airline Number : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date of Operation : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Company : ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormIhm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 271);
            this.Controls.Add(this.groupBox_result);
            this.Controls.Add(this.groupBox_search);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormIhm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_search.ResumeLayout(false);
            this.groupBox_search.PerformLayout();
            this.groupBox_result.ResumeLayout(false);
            this.groupBox_luggage.ResumeLayout(false);
            this.groupBox_luggage.PerformLayout();
            this.groupBox_flight.ResumeLayout(false);
            this.groupBox_flight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_codeIataSearch;

        private void button1_Click(object sender, EventArgs e)
        {
            var bagage = MyAirport.Pim.Models.Factory.Model.GetBagage("023232546100");
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_codeIata;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox_search;
        private System.Windows.Forms.GroupBox groupBox_result;
        private System.Windows.Forms.GroupBox groupBox_flight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_airlineNub_p2;
        private System.Windows.Forms.TextBox textBox_datOfOperation;
        private System.Windows.Forms.TextBox textBox_airlineNub_p1;
        private System.Windows.Forms.TextBox textBox_companyName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox_luggage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox_flightRoute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_continuation;
        private System.Windows.Forms.CheckBox checkBox_rush;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luggageWaitToolStripMenuItem;
    }
}

