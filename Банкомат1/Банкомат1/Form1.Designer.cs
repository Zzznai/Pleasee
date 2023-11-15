
namespace Банкомат1
{
    partial class Банкомат
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
            this.labelId = new System.Windows.Forms.Label();
            this.lblSmetka = new System.Windows.Forms.Label();
            this.labelT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtIDRecipient = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelId.Location = new System.Drawing.Point(33, 44);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(118, 26);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Въведи ID";
            // 
            // lblSmetka
            // 
            this.lblSmetka.AutoSize = true;
            this.lblSmetka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblSmetka.Location = new System.Drawing.Point(33, 101);
            this.lblSmetka.Name = "lblSmetka";
            this.lblSmetka.Size = new System.Drawing.Size(89, 26);
            this.lblSmetka.TabIndex = 1;
            this.lblSmetka.Text = "Сметка";
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelT.Location = new System.Drawing.Point(33, 151);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(94, 26);
            this.labelT.TabIndex = 2;
            this.labelT.Text = "Титуляр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(437, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Баланс";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(33, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Въведи сума";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(33, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = " Въведи ID сметка на получателя";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtID.Location = new System.Drawing.Point(157, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(122, 32);
            this.txtID.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtAmount.Location = new System.Drawing.Point(185, 207);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(160, 32);
            this.txtAmount.TabIndex = 7;
            // 
            // txtIDRecipient
            // 
            this.txtIDRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtIDRecipient.Location = new System.Drawing.Point(396, 274);
            this.txtIDRecipient.Name = "txtIDRecipient";
            this.txtIDRecipient.Size = new System.Drawing.Size(167, 32);
            this.txtIDRecipient.TabIndex = 8;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDeposit.Location = new System.Drawing.Point(396, 207);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(106, 32);
            this.btnDeposit.TabIndex = 9;
            this.btnDeposit.Text = "Внасяне";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button2.Location = new System.Drawing.Point(315, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(321, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Проверкана на наличност";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblIBAN
            // 
            this.lblIBAN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIBAN.CausesValidation = false;
            this.lblIBAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblIBAN.Location = new System.Drawing.Point(128, 101);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(238, 26);
            this.lblIBAN.TabIndex = 11;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnWithdraw.Location = new System.Drawing.Point(527, 207);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(156, 32);
            this.btnWithdraw.TabIndex = 12;
            this.btnWithdraw.Text = "Внасяне";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountHolder.CausesValidation = false;
            this.lblAccountHolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAccountHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAccountHolder.Location = new System.Drawing.Point(128, 150);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(238, 26);
            this.lblAccountHolder.TabIndex = 13;
            // 
            // lblBalance
            // 
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBalance.CausesValidation = false;
            this.lblBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblBalance.Location = new System.Drawing.Point(527, 151);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(142, 26);
            this.lblBalance.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.Location = new System.Drawing.Point(584, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Внасяне";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Банкомат
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAccountHolder);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblIBAN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtIDRecipient);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.lblSmetka);
            this.Controls.Add(this.labelId);
            this.Name = "Банкомат";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label lblSmetka;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtIDRecipient;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblAccountHolder;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button button1;
    }
}

