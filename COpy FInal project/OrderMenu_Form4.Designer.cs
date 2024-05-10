namespace Final_Project
{
    partial class OrderMenu_Form4
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
            this.productsInBasketLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.nameOfProduct1Label = new System.Windows.Forms.Label();
            this.nameOfProduct2Label = new System.Windows.Forms.Label();
            this.nameOfProduct3Label = new System.Windows.Forms.Label();
            this.quantityOfProduct1ComboBox = new System.Windows.Forms.ComboBox();
            this.quantityOfProduct2ComboBox = new System.Windows.Forms.ComboBox();
            this.quantityOfProduct3ComboBox = new System.Windows.Forms.ComboBox();
            this.priceLabelProduct1 = new System.Windows.Forms.Label();
            this.priceLabelProduct2 = new System.Windows.Forms.Label();
            this.priceLabelProduct3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.payInCashRadioButton = new System.Windows.Forms.RadioButton();
            this.payWithCardRadioButton = new System.Windows.Forms.RadioButton();
            this.labelDeliveryAdres = new System.Windows.Forms.Label();
            this.deliveryAdressTextBox = new System.Windows.Forms.TextBox();
            this.changeAdressButton = new System.Windows.Forms.Button();
            this.toPaymentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // productsInBasketLabel
            // 
            this.productsInBasketLabel.AutoSize = true;
            this.productsInBasketLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.productsInBasketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.productsInBasketLabel.Location = new System.Drawing.Point(27, 22);
            this.productsInBasketLabel.Name = "productsInBasketLabel";
            this.productsInBasketLabel.Size = new System.Drawing.Size(238, 31);
            this.productsInBasketLabel.TabIndex = 0;
            this.productsInBasketLabel.Text = "Products in basket";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 114);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(45, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 114);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(45, 404);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 114);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // nameOfProduct1Label
            // 
            this.nameOfProduct1Label.AutoSize = true;
            this.nameOfProduct1Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nameOfProduct1Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfProduct1Label.Location = new System.Drawing.Point(289, 99);
            this.nameOfProduct1Label.Name = "nameOfProduct1Label";
            this.nameOfProduct1Label.Size = new System.Drawing.Size(192, 26);
            this.nameOfProduct1Label.TabIndex = 4;
            this.nameOfProduct1Label.Text = "Name of product1";
            // 
            // nameOfProduct2Label
            // 
            this.nameOfProduct2Label.AutoSize = true;
            this.nameOfProduct2Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nameOfProduct2Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfProduct2Label.Location = new System.Drawing.Point(289, 250);
            this.nameOfProduct2Label.Name = "nameOfProduct2Label";
            this.nameOfProduct2Label.Size = new System.Drawing.Size(199, 26);
            this.nameOfProduct2Label.TabIndex = 5;
            this.nameOfProduct2Label.Text = "Name of product 2";
            // 
            // nameOfProduct3Label
            // 
            this.nameOfProduct3Label.AutoSize = true;
            this.nameOfProduct3Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nameOfProduct3Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfProduct3Label.Location = new System.Drawing.Point(289, 404);
            this.nameOfProduct3Label.Name = "nameOfProduct3Label";
            this.nameOfProduct3Label.Size = new System.Drawing.Size(199, 26);
            this.nameOfProduct3Label.TabIndex = 6;
            this.nameOfProduct3Label.Text = "Name of product 3";
            // 
            // quantityOfProduct1ComboBox
            // 
            this.quantityOfProduct1ComboBox.FormattingEnabled = true;
            this.quantityOfProduct1ComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.quantityOfProduct1ComboBox.Location = new System.Drawing.Point(640, 99);
            this.quantityOfProduct1ComboBox.Name = "quantityOfProduct1ComboBox";
            this.quantityOfProduct1ComboBox.Size = new System.Drawing.Size(44, 24);
            this.quantityOfProduct1ComboBox.TabIndex = 7;
            // 
            // quantityOfProduct2ComboBox
            // 
            this.quantityOfProduct2ComboBox.FormattingEnabled = true;
            this.quantityOfProduct2ComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.quantityOfProduct2ComboBox.Location = new System.Drawing.Point(640, 252);
            this.quantityOfProduct2ComboBox.Name = "quantityOfProduct2ComboBox";
            this.quantityOfProduct2ComboBox.Size = new System.Drawing.Size(44, 24);
            this.quantityOfProduct2ComboBox.TabIndex = 8;
            // 
            // quantityOfProduct3ComboBox
            // 
            this.quantityOfProduct3ComboBox.FormattingEnabled = true;
            this.quantityOfProduct3ComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.quantityOfProduct3ComboBox.Location = new System.Drawing.Point(640, 406);
            this.quantityOfProduct3ComboBox.Name = "quantityOfProduct3ComboBox";
            this.quantityOfProduct3ComboBox.Size = new System.Drawing.Size(44, 24);
            this.quantityOfProduct3ComboBox.TabIndex = 9;
            // 
            // priceLabelProduct1
            // 
            this.priceLabelProduct1.AutoSize = true;
            this.priceLabelProduct1.Location = new System.Drawing.Point(737, 107);
            this.priceLabelProduct1.Name = "priceLabelProduct1";
            this.priceLabelProduct1.Size = new System.Drawing.Size(0, 16);
            this.priceLabelProduct1.TabIndex = 10;
            // 
            // priceLabelProduct2
            // 
            this.priceLabelProduct2.AutoSize = true;
            this.priceLabelProduct2.Location = new System.Drawing.Point(737, 255);
            this.priceLabelProduct2.Name = "priceLabelProduct2";
            this.priceLabelProduct2.Size = new System.Drawing.Size(0, 16);
            this.priceLabelProduct2.TabIndex = 11;
            // 
            // priceLabelProduct3
            // 
            this.priceLabelProduct3.AutoSize = true;
            this.priceLabelProduct3.Location = new System.Drawing.Point(718, 412);
            this.priceLabelProduct3.Name = "priceLabelProduct3";
            this.priceLabelProduct3.Size = new System.Drawing.Size(0, 16);
            this.priceLabelProduct3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(822, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select payment method";
            // 
            // payInCashRadioButton
            // 
            this.payInCashRadioButton.AutoSize = true;
            this.payInCashRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.payInCashRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payInCashRadioButton.Location = new System.Drawing.Point(827, 120);
            this.payInCashRadioButton.Name = "payInCashRadioButton";
            this.payInCashRadioButton.Size = new System.Drawing.Size(117, 24);
            this.payInCashRadioButton.TabIndex = 14;
            this.payInCashRadioButton.TabStop = true;
            this.payInCashRadioButton.Text = "Pay in cash";
            this.payInCashRadioButton.UseVisualStyleBackColor = false;
            this.payInCashRadioButton.CheckedChanged += new System.EventHandler(this.payInCashRadioButton_CheckedChanged);
            // 
            // payWithCardRadioButton
            // 
            this.payWithCardRadioButton.AutoSize = true;
            this.payWithCardRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.payWithCardRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payWithCardRadioButton.Location = new System.Drawing.Point(827, 169);
            this.payWithCardRadioButton.Name = "payWithCardRadioButton";
            this.payWithCardRadioButton.Size = new System.Drawing.Size(131, 24);
            this.payWithCardRadioButton.TabIndex = 15;
            this.payWithCardRadioButton.TabStop = true;
            this.payWithCardRadioButton.Text = "Pay with card";
            this.payWithCardRadioButton.UseVisualStyleBackColor = false;
            this.payWithCardRadioButton.CheckedChanged += new System.EventHandler(this.payWithCardRadioButton_CheckedChanged);
            // 
            // labelDeliveryAdres
            // 
            this.labelDeliveryAdres.AutoSize = true;
            this.labelDeliveryAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelDeliveryAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeliveryAdres.Location = new System.Drawing.Point(822, 242);
            this.labelDeliveryAdres.Name = "labelDeliveryAdres";
            this.labelDeliveryAdres.Size = new System.Drawing.Size(185, 29);
            this.labelDeliveryAdres.TabIndex = 16;
            this.labelDeliveryAdres.Text = "Delivery adress:";
            // 
            // deliveryAdressTextBox
            // 
            this.deliveryAdressTextBox.Location = new System.Drawing.Point(822, 299);
            this.deliveryAdressTextBox.Name = "deliveryAdressTextBox";
            this.deliveryAdressTextBox.Size = new System.Drawing.Size(281, 22);
            this.deliveryAdressTextBox.TabIndex = 17;
            // 
            // changeAdressButton
            // 
            this.changeAdressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeAdressButton.Location = new System.Drawing.Point(980, 349);
            this.changeAdressButton.Name = "changeAdressButton";
            this.changeAdressButton.Size = new System.Drawing.Size(123, 30);
            this.changeAdressButton.TabIndex = 18;
            this.changeAdressButton.Text = "Change adress";
            this.changeAdressButton.UseVisualStyleBackColor = true;
            // 
            // toPaymentButton
            // 
            this.toPaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toPaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toPaymentButton.Location = new System.Drawing.Point(822, 498);
            this.toPaymentButton.Name = "toPaymentButton";
            this.toPaymentButton.Size = new System.Drawing.Size(281, 56);
            this.toPaymentButton.TabIndex = 19;
            this.toPaymentButton.Text = "To Payment";
            this.toPaymentButton.UseVisualStyleBackColor = false;
            this.toPaymentButton.Click += new System.EventHandler(this.toPaymentButton_Click);
            // 
            // OrderMenu_Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1150, 575);
            this.Controls.Add(this.toPaymentButton);
            this.Controls.Add(this.changeAdressButton);
            this.Controls.Add(this.deliveryAdressTextBox);
            this.Controls.Add(this.labelDeliveryAdres);
            this.Controls.Add(this.payWithCardRadioButton);
            this.Controls.Add(this.payInCashRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceLabelProduct3);
            this.Controls.Add(this.priceLabelProduct2);
            this.Controls.Add(this.priceLabelProduct1);
            this.Controls.Add(this.quantityOfProduct3ComboBox);
            this.Controls.Add(this.quantityOfProduct2ComboBox);
            this.Controls.Add(this.quantityOfProduct1ComboBox);
            this.Controls.Add(this.nameOfProduct3Label);
            this.Controls.Add(this.nameOfProduct2Label);
            this.Controls.Add(this.nameOfProduct1Label);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.productsInBasketLabel);
            this.Name = "OrderMenu_Form4";
            this.Text = "OrderMenu_Form4";
            this.Load += new System.EventHandler(this.OrderMenu_Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productsInBasketLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label nameOfProduct1Label;
        private System.Windows.Forms.Label nameOfProduct2Label;
        private System.Windows.Forms.Label nameOfProduct3Label;
        private System.Windows.Forms.ComboBox quantityOfProduct1ComboBox;
        private System.Windows.Forms.ComboBox quantityOfProduct2ComboBox;
        private System.Windows.Forms.ComboBox quantityOfProduct3ComboBox;
        private System.Windows.Forms.Label priceLabelProduct1;
        private System.Windows.Forms.Label priceLabelProduct2;
        private System.Windows.Forms.Label priceLabelProduct3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton payInCashRadioButton;
        private System.Windows.Forms.RadioButton payWithCardRadioButton;
        private System.Windows.Forms.Label labelDeliveryAdres;
        private System.Windows.Forms.TextBox deliveryAdressTextBox;
        private System.Windows.Forms.Button changeAdressButton;
        private System.Windows.Forms.Button toPaymentButton;
    }
}

