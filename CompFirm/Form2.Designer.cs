namespace CompFirm
{
    partial class frmDesktop
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
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label ramLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label cdLabel;
            System.Windows.Forms.Label speedLabel;
            System.Windows.Forms.Label hdLabel;
            System.Windows.Forms.Label priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesktop));
            this.label1 = new System.Windows.Forms.Label();
            this.st03DataSet = new CompFirm.St03DataSet();
            this.pCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pCTableAdapter = new CompFirm.St03DataSetTableAdapters.PCTableAdapter();
            this.tableAdapterManager = new CompFirm.St03DataSetTableAdapters.TableAdapterManager();
            this.pCBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pCBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.ramTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.cdTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.hdTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            codeLabel = new System.Windows.Forms.Label();
            ramLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            cdLabel = new System.Windows.Forms.Label();
            speedLabel = new System.Windows.Forms.Label();
            hdLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.st03DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingNavigator)).BeginInit();
            this.pCBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(165, 112);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(29, 13);
            codeLabel.TabIndex = 2;
            codeLabel.Text = "Код:";
            // 
            // ramLabel
            // 
            ramLabel.AutoSize = true;
            ramLabel.Location = new System.Drawing.Point(167, 201);
            ramLabel.Name = "ramLabel";
            ramLabel.Size = new System.Drawing.Size(27, 13);
            ramLabel.TabIndex = 6;
            ramLabel.Text = "ram:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(145, 160);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(49, 13);
            modelLabel.TabIndex = 7;
            modelLabel.Text = "Модель:";
            // 
            // cdLabel
            // 
            cdLabel.AutoSize = true;
            cdLabel.Location = new System.Drawing.Point(172, 243);
            cdLabel.Name = "cdLabel";
            cdLabel.Size = new System.Drawing.Size(22, 13);
            cdLabel.TabIndex = 8;
            cdLabel.Text = "cd:";
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Location = new System.Drawing.Point(136, 281);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new System.Drawing.Size(58, 13);
            speedLabel.TabIndex = 10;
            speedLabel.Text = "Скорость:";
            // 
            // hdLabel
            // 
            hdLabel.AutoSize = true;
            hdLabel.Location = new System.Drawing.Point(172, 326);
            hdLabel.Name = "hdLabel";
            hdLabel.Size = new System.Drawing.Size(22, 13);
            hdLabel.TabIndex = 12;
            hdLabel.Text = "hd:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(153, 369);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(36, 13);
            priceLabel.TabIndex = 14;
            priceLabel.Text = "Цена:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(81, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Персональные компьютеры";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // st03DataSet
            // 
            this.st03DataSet.DataSetName = "St03DataSet";
            this.st03DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pCBindingSource
            // 
            this.pCBindingSource.DataMember = "PC";
            this.pCBindingSource.DataSource = this.st03DataSet;
            // 
            // pCTableAdapter
            // 
            this.pCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LaptopTableAdapter = null;
            this.tableAdapterManager.PCTableAdapter = this.pCTableAdapter;
            this.tableAdapterManager.PrinterTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CompFirm.St03DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pCBindingNavigator
            // 
            this.pCBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pCBindingNavigator.BindingSource = this.pCBindingSource;
            this.pCBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pCBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pCBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pCBindingNavigatorSaveItem});
            this.pCBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pCBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pCBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pCBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pCBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pCBindingNavigator.Name = "pCBindingNavigator";
            this.pCBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pCBindingNavigator.Size = new System.Drawing.Size(484, 25);
            this.pCBindingNavigator.TabIndex = 1;
            this.pCBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pCBindingNavigatorSaveItem
            // 
            this.pCBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pCBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pCBindingNavigatorSaveItem.Image")));
            this.pCBindingNavigatorSaveItem.Name = "pCBindingNavigatorSaveItem";
            this.pCBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pCBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.pCBindingNavigatorSaveItem.Click += new System.EventHandler(this.pCBindingNavigatorSaveItem_Click);
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pCBindingSource, "code", true));
            this.codeTextBox.Location = new System.Drawing.Point(200, 109);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 3;
            // 
            // ramTextBox
            // 
            this.ramTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pCBindingSource, "ram", true));
            this.ramTextBox.Location = new System.Drawing.Point(200, 198);
            this.ramTextBox.Name = "ramTextBox";
            this.ramTextBox.Size = new System.Drawing.Size(100, 20);
            this.ramTextBox.TabIndex = 7;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pCBindingSource, "model", true));
            this.modelTextBox.Location = new System.Drawing.Point(200, 157);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 8;
            // 
            // cdTextBox
            // 
            this.cdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pCBindingSource, "cd", true));
            this.cdTextBox.Location = new System.Drawing.Point(200, 240);
            this.cdTextBox.Name = "cdTextBox";
            this.cdTextBox.Size = new System.Drawing.Size(100, 20);
            this.cdTextBox.TabIndex = 9;
            // 
            // speedTextBox
            // 
            this.speedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pCBindingSource, "speed", true));
            this.speedTextBox.Location = new System.Drawing.Point(200, 281);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 11;
            // 
            // hdTextBox
            // 
            this.hdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pCBindingSource, "hd", true));
            this.hdTextBox.Location = new System.Drawing.Point(200, 323);
            this.hdTextBox.Name = "hdTextBox";
            this.hdTextBox.Size = new System.Drawing.Size(100, 20);
            this.hdTextBox.TabIndex = 13;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pCBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(200, 366);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(10, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(127, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(244, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 33);
            this.button3.TabIndex = 18;
            this.button3.Text = "Следущая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(361, 417);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 33);
            this.button4.TabIndex = 19;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.Location = new System.Drawing.Point(244, 456);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 33);
            this.button5.TabIndex = 20;
            this.button5.Text = "Удалить ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button6.Location = new System.Drawing.Point(127, 456);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 33);
            this.button6.TabIndex = 21;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button7.Location = new System.Drawing.Point(127, 495);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(228, 33);
            this.button7.TabIndex = 22;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // frmDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 540);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(hdLabel);
            this.Controls.Add(this.hdTextBox);
            this.Controls.Add(speedLabel);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(cdLabel);
            this.Controls.Add(this.cdTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(ramLabel);
            this.Controls.Add(this.ramTextBox);
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.pCBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDesktop";
            this.Text = "Персональные компьютеры";
            this.Load += new System.EventHandler(this.frmDesktop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.st03DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingNavigator)).EndInit();
            this.pCBindingNavigator.ResumeLayout(false);
            this.pCBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private St03DataSet st03DataSet;
        private System.Windows.Forms.BindingSource pCBindingSource;
        private St03DataSetTableAdapters.PCTableAdapter pCTableAdapter;
        private St03DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pCBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pCBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox ramTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox cdTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox hdTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}