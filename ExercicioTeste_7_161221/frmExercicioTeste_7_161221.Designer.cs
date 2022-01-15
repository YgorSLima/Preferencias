namespace ExercicioTeste_7_161221
{
    partial class frmExercicioTeste_7_161221
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercicioTeste_7_161221));
            this.btnDesvCond = new System.Windows.Forms.Button();
            this.btnImpTxt = new System.Windows.Forms.Button();
            this.lstbxPreferencias = new System.Windows.Forms.ListBox();
            this.btnImpBdCon = new System.Windows.Forms.Button();
            this.btnImpBdDesc = new System.Windows.Forms.Button();
            this.btnConsBd = new System.Windows.Forms.Button();
            this.dtgdvwPrefenrecias = new System.Windows.Forms.DataGridView();
            this.bndnv = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bndsrc = new System.Windows.Forms.BindingSource(this.components);
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
            this.bndnvBtnIncPref = new System.Windows.Forms.ToolStripButton();
            this.bndndTxtPesqPref = new System.Windows.Forms.ToolStripTextBox();
            this.bndndBtnPesqPref = new System.Windows.Forms.ToolStripButton();
            this.btnIncBd = new System.Windows.Forms.Button();
            this.btnExcBd = new System.Windows.Forms.Button();
            this.btnAltBd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdvwPrefenrecias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndnv)).BeginInit();
            this.bndnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndsrc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesvCond
            // 
            this.btnDesvCond.Location = new System.Drawing.Point(12, 12);
            this.btnDesvCond.Name = "btnDesvCond";
            this.btnDesvCond.Size = new System.Drawing.Size(206, 38);
            this.btnDesvCond.TabIndex = 0;
            this.btnDesvCond.Text = "Desvio condicional";
            this.btnDesvCond.UseVisualStyleBackColor = true;
            this.btnDesvCond.Click += new System.EventHandler(this.btnDesvCond_Click);
            // 
            // btnImpTxt
            // 
            this.btnImpTxt.Location = new System.Drawing.Point(12, 56);
            this.btnImpTxt.Name = "btnImpTxt";
            this.btnImpTxt.Size = new System.Drawing.Size(206, 38);
            this.btnImpTxt.TabIndex = 1;
            this.btnImpTxt.Text = "Importar texto";
            this.btnImpTxt.UseVisualStyleBackColor = true;
            this.btnImpTxt.Click += new System.EventHandler(this.btnImpTxt_Click);
            // 
            // lstbxPreferencias
            // 
            this.lstbxPreferencias.FormattingEnabled = true;
            this.lstbxPreferencias.Location = new System.Drawing.Point(224, 12);
            this.lstbxPreferencias.Name = "lstbxPreferencias";
            this.lstbxPreferencias.Size = new System.Drawing.Size(395, 173);
            this.lstbxPreferencias.TabIndex = 2;
            // 
            // btnImpBdCon
            // 
            this.btnImpBdCon.Location = new System.Drawing.Point(12, 100);
            this.btnImpBdCon.Name = "btnImpBdCon";
            this.btnImpBdCon.Size = new System.Drawing.Size(206, 38);
            this.btnImpBdCon.TabIndex = 3;
            this.btnImpBdCon.Text = "banco de dados conctado";
            this.btnImpBdCon.UseVisualStyleBackColor = true;
            this.btnImpBdCon.Click += new System.EventHandler(this.btnImpBdCon_Click);
            // 
            // btnImpBdDesc
            // 
            this.btnImpBdDesc.Location = new System.Drawing.Point(12, 144);
            this.btnImpBdDesc.Name = "btnImpBdDesc";
            this.btnImpBdDesc.Size = new System.Drawing.Size(206, 38);
            this.btnImpBdDesc.TabIndex = 4;
            this.btnImpBdDesc.Text = "importar banco de dados desconectado";
            this.btnImpBdDesc.UseVisualStyleBackColor = true;
            this.btnImpBdDesc.Click += new System.EventHandler(this.btnImpBdDesc_Click);
            // 
            // btnConsBd
            // 
            this.btnConsBd.Location = new System.Drawing.Point(12, 221);
            this.btnConsBd.Name = "btnConsBd";
            this.btnConsBd.Size = new System.Drawing.Size(206, 38);
            this.btnConsBd.TabIndex = 5;
            this.btnConsBd.Text = "Consultar banco de dados";
            this.btnConsBd.UseVisualStyleBackColor = true;
            this.btnConsBd.Click += new System.EventHandler(this.btnConsBd_Click);
            // 
            // dtgdvwPrefenrecias
            // 
            this.dtgdvwPrefenrecias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdvwPrefenrecias.Location = new System.Drawing.Point(224, 221);
            this.dtgdvwPrefenrecias.Name = "dtgdvwPrefenrecias";
            this.dtgdvwPrefenrecias.Size = new System.Drawing.Size(395, 170);
            this.dtgdvwPrefenrecias.TabIndex = 6;
            this.dtgdvwPrefenrecias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdvwPrefenrecias_CellClick);
            // 
            // bndnv
            // 
            this.bndnv.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bndnv.BindingSource = this.bndsrc;
            this.bndnv.CountItem = this.bindingNavigatorCountItem;
            this.bndnv.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bndnv.Dock = System.Windows.Forms.DockStyle.None;
            this.bndnv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bndnvBtnIncPref,
            this.bndndTxtPesqPref,
            this.bndndBtnPesqPref});
            this.bndnv.Location = new System.Drawing.Point(224, 193);
            this.bndnv.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bndnv.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bndnv.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bndnv.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bndnv.Name = "bndnv";
            this.bndnv.PositionItem = this.bindingNavigatorPositionItem;
            this.bndnv.Size = new System.Drawing.Size(403, 25);
            this.bndnv.TabIndex = 7;
            this.bndnv.Text = "bindingNavigator1";
            this.bndnv.RefreshItems += new System.EventHandler(this.bndnv_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bndnvBtnIncPref
            // 
            this.bndnvBtnIncPref.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bndnvBtnIncPref.Image = ((System.Drawing.Image)(resources.GetObject("bndnvBtnIncPref.Image")));
            this.bndnvBtnIncPref.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bndnvBtnIncPref.Name = "bndnvBtnIncPref";
            this.bndnvBtnIncPref.Size = new System.Drawing.Size(23, 22);
            this.bndnvBtnIncPref.Text = "Incluir Preferencia";
            this.bndnvBtnIncPref.Click += new System.EventHandler(this.bndnvBtnIncPref_Click);
            // 
            // bndndTxtPesqPref
            // 
            this.bndndTxtPesqPref.Name = "bndndTxtPesqPref";
            this.bndndTxtPesqPref.Size = new System.Drawing.Size(100, 25);
            // 
            // bndndBtnPesqPref
            // 
            this.bndndBtnPesqPref.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bndndBtnPesqPref.Image = ((System.Drawing.Image)(resources.GetObject("bndndBtnPesqPref.Image")));
            this.bndndBtnPesqPref.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bndndBtnPesqPref.Name = "bndndBtnPesqPref";
            this.bndndBtnPesqPref.Size = new System.Drawing.Size(23, 22);
            this.bndndBtnPesqPref.Text = "Pesquisar preferencia";
            this.bndndBtnPesqPref.Click += new System.EventHandler(this.bndndBtnPesqPref_Click);
            // 
            // btnIncBd
            // 
            this.btnIncBd.Location = new System.Drawing.Point(12, 265);
            this.btnIncBd.Name = "btnIncBd";
            this.btnIncBd.Size = new System.Drawing.Size(206, 38);
            this.btnIncBd.TabIndex = 8;
            this.btnIncBd.Text = "incluir banco de dados";
            this.btnIncBd.UseVisualStyleBackColor = true;
            this.btnIncBd.Click += new System.EventHandler(this.btnIncBd_Click);
            // 
            // btnExcBd
            // 
            this.btnExcBd.Location = new System.Drawing.Point(12, 309);
            this.btnExcBd.Name = "btnExcBd";
            this.btnExcBd.Size = new System.Drawing.Size(206, 38);
            this.btnExcBd.TabIndex = 9;
            this.btnExcBd.Text = "exluir banco de dados";
            this.btnExcBd.UseVisualStyleBackColor = true;
            this.btnExcBd.Click += new System.EventHandler(this.btnExcBd_Click);
            // 
            // btnAltBd
            // 
            this.btnAltBd.Location = new System.Drawing.Point(12, 353);
            this.btnAltBd.Name = "btnAltBd";
            this.btnAltBd.Size = new System.Drawing.Size(206, 38);
            this.btnAltBd.TabIndex = 10;
            this.btnAltBd.Text = "alterar  banco de dados";
            this.btnAltBd.UseVisualStyleBackColor = true;
            this.btnAltBd.Click += new System.EventHandler(this.btnAltBd_Click);
            // 
            // frmExercicioTeste_7_161221
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 401);
            this.Controls.Add(this.btnAltBd);
            this.Controls.Add(this.btnExcBd);
            this.Controls.Add(this.btnIncBd);
            this.Controls.Add(this.bndnv);
            this.Controls.Add(this.dtgdvwPrefenrecias);
            this.Controls.Add(this.btnConsBd);
            this.Controls.Add(this.btnImpBdDesc);
            this.Controls.Add(this.btnImpBdCon);
            this.Controls.Add(this.lstbxPreferencias);
            this.Controls.Add(this.btnImpTxt);
            this.Controls.Add(this.btnDesvCond);
            this.Name = "frmExercicioTeste_7_161221";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmExercicioTeste_7_161221_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdvwPrefenrecias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndnv)).EndInit();
            this.bndnv.ResumeLayout(false);
            this.bndnv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndsrc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesvCond;
        private System.Windows.Forms.Button btnImpTxt;
        private System.Windows.Forms.ListBox lstbxPreferencias;
        private System.Windows.Forms.Button btnImpBdCon;
        private System.Windows.Forms.Button btnImpBdDesc;
        private System.Windows.Forms.Button btnConsBd;
        private System.Windows.Forms.DataGridView dtgdvwPrefenrecias;
        private System.Windows.Forms.BindingNavigator bndnv;
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
        private System.Windows.Forms.ToolStripButton bndnvBtnIncPref;
        private System.Windows.Forms.ToolStripTextBox bndndTxtPesqPref;
        private System.Windows.Forms.ToolStripButton bndndBtnPesqPref;
        private System.Windows.Forms.BindingSource bndsrc;
        private System.Windows.Forms.Button btnIncBd;
        private System.Windows.Forms.Button btnExcBd;
        private System.Windows.Forms.Button btnAltBd;
    }
}

