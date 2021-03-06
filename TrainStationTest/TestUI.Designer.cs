﻿namespace TrainStationTest
{
    partial class TestUI
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
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.allstationstxt = new System.Windows.Forms.Label();
            this.nostationlbl = new System.Windows.Forms.Label();
            this.liststations = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.keylistview = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.Location = new System.Drawing.Point(399, 94);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(303, 34);
            this.searchTxtBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search train station:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Train Staions Test by Tudor Boca";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(738, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Press";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // allstationstxt
            // 
            this.allstationstxt.AutoSize = true;
            this.allstationstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allstationstxt.Location = new System.Drawing.Point(33, 289);
            this.allstationstxt.Name = "allstationstxt";
            this.allstationstxt.Size = new System.Drawing.Size(223, 29);
            this.allstationstxt.TabIndex = 17;
            this.allstationstxt.Text = "Station suggestions";
            // 
            // nostationlbl
            // 
            this.nostationlbl.AutoSize = true;
            this.nostationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nostationlbl.Location = new System.Drawing.Point(33, 229);
            this.nostationlbl.Name = "nostationlbl";
            this.nostationlbl.Size = new System.Drawing.Size(0, 29);
            this.nostationlbl.TabIndex = 18;
            // 
            // liststations
            // 
            this.liststations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liststations.LabelWrap = false;
            this.liststations.Location = new System.Drawing.Point(262, 289);
            this.liststations.Name = "liststations";
            this.liststations.Size = new System.Drawing.Size(684, 211);
            this.liststations.TabIndex = 19;
            this.liststations.UseCompatibleStateImageBehavior = false;
            this.liststations.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Available keys to press next:";
            // 
            // keylistview
            // 
            this.keylistview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keylistview.Location = new System.Drawing.Point(410, 162);
            this.keylistview.Name = "keylistview";
            this.keylistview.Size = new System.Drawing.Size(403, 37);
            this.keylistview.TabIndex = 21;
            this.keylistview.UseCompatibleStateImageBehavior = false;
            // 
            // TestUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 519);
            this.Controls.Add(this.keylistview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.liststations);
            this.Controls.Add(this.nostationlbl);
            this.Controls.Add(this.allstationstxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TestUI";
            this.Text = "TestUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label allstationstxt;
        private System.Windows.Forms.Label nostationlbl;
        private System.Windows.Forms.ListView liststations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView keylistview;
    }
}