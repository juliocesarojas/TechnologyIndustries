﻿namespace Win.TechnologyIndustries
{
    partial class IngresoInventarioForm
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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label descripciónLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label ubicaciónLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoInventarioForm));
            this.listadeProductosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listadeProductosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.descripciónTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.ubicaciónTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listadeProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            activoLabel = new System.Windows.Forms.Label();
            descripciónLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            ubicaciónLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProductosBindingNavigator)).BeginInit();
            this.listadeProductosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activoLabel.Location = new System.Drawing.Point(15, 233);
            activoLabel.Name = "activoLabel";
            activoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            activoLabel.Size = new System.Drawing.Size(41, 15);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // descripciónLabel
            // 
            descripciónLabel.AutoSize = true;
            descripciónLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripciónLabel.Location = new System.Drawing.Point(15, 130);
            descripciónLabel.Name = "descripciónLabel";
            descripciónLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            descripciónLabel.Size = new System.Drawing.Size(75, 15);
            descripciónLabel.TabIndex = 3;
            descripciónLabel.Text = "Descripción:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(15, 104);
            iDLabel.Name = "iDLabel";
            iDLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            iDLabel.Size = new System.Drawing.Size(22, 15);
            iDLabel.TabIndex = 5;
            iDLabel.Text = "ID:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(15, 156);
            precioLabel.Name = "precioLabel";
            precioLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            precioLabel.Size = new System.Drawing.Size(45, 15);
            precioLabel.TabIndex = 7;
            precioLabel.Text = "Precio:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockLabel.Location = new System.Drawing.Point(15, 182);
            stockLabel.Name = "stockLabel";
            stockLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            stockLabel.Size = new System.Drawing.Size(40, 15);
            stockLabel.TabIndex = 9;
            stockLabel.Text = "Stock:";
            // 
            // ubicaciónLabel
            // 
            ubicaciónLabel.AutoSize = true;
            ubicaciónLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ubicaciónLabel.Location = new System.Drawing.Point(15, 208);
            ubicaciónLabel.Name = "ubicaciónLabel";
            ubicaciónLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ubicaciónLabel.Size = new System.Drawing.Size(65, 15);
            ubicaciónLabel.TabIndex = 11;
            ubicaciónLabel.Text = "Ubicación:";
            // 
            // listadeProductosBindingNavigator
            // 
            this.listadeProductosBindingNavigator.AddNewItem = null;
            this.listadeProductosBindingNavigator.BindingSource = this.listadeProductosBindingSource;
            this.listadeProductosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listadeProductosBindingNavigator.DeleteItem = null;
            this.listadeProductosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listadeProductosBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listadeProductosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listadeProductosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listadeProductosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listadeProductosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listadeProductosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listadeProductosBindingNavigator.Name = "listadeProductosBindingNavigator";
            this.listadeProductosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listadeProductosBindingNavigator.Size = new System.Drawing.Size(483, 25);
            this.listadeProductosBindingNavigator.TabIndex = 0;
            this.listadeProductosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listadeProductosBindingNavigatorSaveItem
            // 
            this.listadeProductosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listadeProductosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listadeProductosBindingNavigatorSaveItem.Image")));
            this.listadeProductosBindingNavigatorSaveItem.Name = "listadeProductosBindingNavigatorSaveItem";
            this.listadeProductosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listadeProductosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listadeProductosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listadeProductosBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listadeProductosBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(96, 233);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(15, 18);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // descripciónTextBox
            // 
            this.descripciónTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProductosBindingSource, "Descripción", true));
            this.descripciónTextBox.Location = new System.Drawing.Point(96, 129);
            this.descripciónTextBox.Name = "descripciónTextBox";
            this.descripciónTextBox.Size = new System.Drawing.Size(218, 20);
            this.descripciónTextBox.TabIndex = 4;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProductosBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(96, 103);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.ShortcutsEnabled = false;
            this.iDTextBox.Size = new System.Drawing.Size(218, 20);
            this.iDTextBox.TabIndex = 6;
            this.iDTextBox.TextChanged += new System.EventHandler(this.iDTextBox_TextChanged);
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProductosBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(96, 155);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(218, 20);
            this.precioTextBox.TabIndex = 8;
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProductosBindingSource, "Stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(96, 181);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(218, 20);
            this.stockTextBox.TabIndex = 10;
            // 
            // ubicaciónTextBox
            // 
            this.ubicaciónTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProductosBindingSource, "Ubicación", true));
            this.ubicaciónTextBox.Location = new System.Drawing.Point(96, 207);
            this.ubicaciónTextBox.Name = "ubicaciónTextBox";
            this.ubicaciónTextBox.Size = new System.Drawing.Size(218, 20);
            this.ubicaciónTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "TECHNOLOGY INDUSTRIES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Win.TechnologyIndustries.Properties.Resources.Imagen2;
            this.pictureBox1.Location = new System.Drawing.Point(368, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listadeProductosBindingSource
            // 
            this.listadeProductosBindingSource.DataSource = typeof(BL.Technology.Producto);
            // 
            // IngresoInventarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(483, 286);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(descripciónLabel);
            this.Controls.Add(this.descripciónTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(ubicaciónLabel);
            this.Controls.Add(this.ubicaciónTextBox);
            this.Controls.Add(this.listadeProductosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IngresoInventarioForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de Inventario";
            this.Load += new System.EventHandler(this.IngresoInventarioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadeProductosBindingNavigator)).EndInit();
            this.listadeProductosBindingNavigator.ResumeLayout(false);
            this.listadeProductosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProductosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listadeProductosBindingSource;
        private System.Windows.Forms.BindingNavigator listadeProductosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listadeProductosBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox descripciónTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox ubicaciónTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
    }
}