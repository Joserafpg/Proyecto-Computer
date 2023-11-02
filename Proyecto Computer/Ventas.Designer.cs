namespace Proyecto_Computer
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.codigos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuButton22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtidfactura = new System.Windows.Forms.TextBox();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.bunifuButton23 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnbuscar1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigos,
            this.name,
            this.precios,
            this.cantidad,
            this.Total});
            this.dtgv.Location = new System.Drawing.Point(217, 89);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.Size = new System.Drawing.Size(503, 200);
            this.dtgv.TabIndex = 0;
            this.dtgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgv_CellFormatting);
            this.dtgv.CurrentCellChanged += new System.EventHandler(this.dtgv_CurrentCellChanged);
            // 
            // codigos
            // 
            this.codigos.HeaderText = "Codigo";
            this.codigos.Name = "codigos";
            this.codigos.ReadOnly = true;
            this.codigos.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // precios
            // 
            this.precios.HeaderText = "Precio";
            this.precios.Name = "precios";
            this.precios.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Factura";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(293, 62);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(150, 20);
            this.txtcodigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(604, 302);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(104, 20);
            this.txttotal.TabIndex = 4;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // bunifuButton21
            // 
            this.bunifuButton21.AllowAnimations = true;
            this.bunifuButton21.AllowMouseEffects = true;
            this.bunifuButton21.AllowToggling = false;
            this.bunifuButton21.AnimationSpeed = 200;
            this.bunifuButton21.AutoGenerateColors = false;
            this.bunifuButton21.AutoRoundBorders = false;
            this.bunifuButton21.AutoSizeLeftIcon = true;
            this.bunifuButton21.AutoSizeRightIcon = true;
            this.bunifuButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton21.BackColor1 = System.Drawing.Color.LightGreen;
            this.bunifuButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton21.BackgroundImage")));
            this.bunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.ButtonText = "Facturar";
            this.bunifuButton21.ButtonTextMarginLeft = 0;
            this.bunifuButton21.ColorContrastOnClick = 45;
            this.bunifuButton21.ColorContrastOnHover = 45;
            this.bunifuButton21.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton21.CustomizableEdges = borderEdges1;
            this.bunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton21.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton21.IconMarginLeft = 11;
            this.bunifuButton21.IconPadding = 10;
            this.bunifuButton21.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton21.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton21.IconSize = 25;
            this.bunifuButton21.IdleBorderColor = System.Drawing.Color.LightGreen;
            this.bunifuButton21.IdleBorderRadius = 35;
            this.bunifuButton21.IdleBorderThickness = 1;
            this.bunifuButton21.IdleFillColor = System.Drawing.Color.LightGreen;
            this.bunifuButton21.IdleIconLeftImage = null;
            this.bunifuButton21.IdleIconRightImage = null;
            this.bunifuButton21.IndicateFocus = false;
            this.bunifuButton21.Location = new System.Drawing.Point(272, 350);
            this.bunifuButton21.Name = "bunifuButton21";
            this.bunifuButton21.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.OnDisabledState.BorderRadius = 35;
            this.bunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnDisabledState.BorderThickness = 1;
            this.bunifuButton21.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.OnDisabledState.IconLeftImage = null;
            this.bunifuButton21.OnDisabledState.IconRightImage = null;
            this.bunifuButton21.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton21.onHoverState.BorderRadius = 35;
            this.bunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.onHoverState.BorderThickness = 1;
            this.bunifuButton21.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton21.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.onHoverState.IconLeftImage = null;
            this.bunifuButton21.onHoverState.IconRightImage = null;
            this.bunifuButton21.OnIdleState.BorderColor = System.Drawing.Color.LightGreen;
            this.bunifuButton21.OnIdleState.BorderRadius = 35;
            this.bunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnIdleState.BorderThickness = 1;
            this.bunifuButton21.OnIdleState.FillColor = System.Drawing.Color.LightGreen;
            this.bunifuButton21.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnIdleState.IconLeftImage = null;
            this.bunifuButton21.OnIdleState.IconRightImage = null;
            this.bunifuButton21.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton21.OnPressedState.BorderRadius = 35;
            this.bunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnPressedState.BorderThickness = 1;
            this.bunifuButton21.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton21.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnPressedState.IconLeftImage = null;
            this.bunifuButton21.OnPressedState.IconRightImage = null;
            this.bunifuButton21.Size = new System.Drawing.Size(185, 45);
            this.bunifuButton21.TabIndex = 6;
            this.bunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton21.TextMarginLeft = 0;
            this.bunifuButton21.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton21.UseDefaultRadiusAndThickness = true;
            this.bunifuButton21.Click += new System.EventHandler(this.bunifuButton21_Click);
            // 
            // bunifuButton22
            // 
            this.bunifuButton22.AllowAnimations = true;
            this.bunifuButton22.AllowMouseEffects = true;
            this.bunifuButton22.AllowToggling = false;
            this.bunifuButton22.AnimationSpeed = 200;
            this.bunifuButton22.AutoGenerateColors = false;
            this.bunifuButton22.AutoRoundBorders = false;
            this.bunifuButton22.AutoSizeLeftIcon = true;
            this.bunifuButton22.AutoSizeRightIcon = true;
            this.bunifuButton22.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton22.BackColor1 = System.Drawing.Color.PaleTurquoise;
            this.bunifuButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton22.BackgroundImage")));
            this.bunifuButton22.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton22.ButtonText = "Nuevo";
            this.bunifuButton22.ButtonTextMarginLeft = 0;
            this.bunifuButton22.ColorContrastOnClick = 45;
            this.bunifuButton22.ColorContrastOnHover = 45;
            this.bunifuButton22.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton22.CustomizableEdges = borderEdges2;
            this.bunifuButton22.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton22.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton22.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton22.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton22.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuButton22.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton22.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton22.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton22.IconMarginLeft = 11;
            this.bunifuButton22.IconPadding = 10;
            this.bunifuButton22.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton22.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton22.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton22.IconSize = 25;
            this.bunifuButton22.IdleBorderColor = System.Drawing.Color.PaleTurquoise;
            this.bunifuButton22.IdleBorderRadius = 35;
            this.bunifuButton22.IdleBorderThickness = 1;
            this.bunifuButton22.IdleFillColor = System.Drawing.Color.PaleTurquoise;
            this.bunifuButton22.IdleIconLeftImage = null;
            this.bunifuButton22.IdleIconRightImage = null;
            this.bunifuButton22.IndicateFocus = false;
            this.bunifuButton22.Location = new System.Drawing.Point(477, 350);
            this.bunifuButton22.Name = "bunifuButton22";
            this.bunifuButton22.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton22.OnDisabledState.BorderRadius = 35;
            this.bunifuButton22.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton22.OnDisabledState.BorderThickness = 1;
            this.bunifuButton22.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton22.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton22.OnDisabledState.IconLeftImage = null;
            this.bunifuButton22.OnDisabledState.IconRightImage = null;
            this.bunifuButton22.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton22.onHoverState.BorderRadius = 35;
            this.bunifuButton22.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton22.onHoverState.BorderThickness = 1;
            this.bunifuButton22.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton22.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton22.onHoverState.IconLeftImage = null;
            this.bunifuButton22.onHoverState.IconRightImage = null;
            this.bunifuButton22.OnIdleState.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.bunifuButton22.OnIdleState.BorderRadius = 35;
            this.bunifuButton22.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton22.OnIdleState.BorderThickness = 1;
            this.bunifuButton22.OnIdleState.FillColor = System.Drawing.Color.PaleTurquoise;
            this.bunifuButton22.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton22.OnIdleState.IconLeftImage = null;
            this.bunifuButton22.OnIdleState.IconRightImage = null;
            this.bunifuButton22.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton22.OnPressedState.BorderRadius = 35;
            this.bunifuButton22.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton22.OnPressedState.BorderThickness = 1;
            this.bunifuButton22.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton22.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton22.OnPressedState.IconLeftImage = null;
            this.bunifuButton22.OnPressedState.IconRightImage = null;
            this.bunifuButton22.Size = new System.Drawing.Size(185, 45);
            this.bunifuButton22.TabIndex = 7;
            this.bunifuButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton22.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton22.TextMarginLeft = 0;
            this.bunifuButton22.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton22.UseDefaultRadiusAndThickness = true;
            this.bunifuButton22.Click += new System.EventHandler(this.bunifuButton22_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtidfactura
            // 
            this.txtidfactura.Location = new System.Drawing.Point(-105, 39);
            this.txtidfactura.Name = "txtidfactura";
            this.txtidfactura.Size = new System.Drawing.Size(100, 20);
            this.txtidfactura.TabIndex = 10;
            // 
            // txtempleado
            // 
            this.txtempleado.Location = new System.Drawing.Point(-105, 77);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(100, 20);
            this.txtempleado.TabIndex = 11;
            // 
            // bunifuButton23
            // 
            this.bunifuButton23.AllowAnimations = true;
            this.bunifuButton23.AllowMouseEffects = true;
            this.bunifuButton23.AllowToggling = false;
            this.bunifuButton23.AnimationSpeed = 200;
            this.bunifuButton23.AutoGenerateColors = false;
            this.bunifuButton23.AutoRoundBorders = false;
            this.bunifuButton23.AutoSizeLeftIcon = true;
            this.bunifuButton23.AutoSizeRightIcon = true;
            this.bunifuButton23.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton23.BackColor1 = System.Drawing.Color.LightGreen;
            this.bunifuButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton23.BackgroundImage")));
            this.bunifuButton23.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton23.ButtonText = "Facturar";
            this.bunifuButton23.ButtonTextMarginLeft = 0;
            this.bunifuButton23.ColorContrastOnClick = 45;
            this.bunifuButton23.ColorContrastOnHover = 45;
            this.bunifuButton23.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton23.CustomizableEdges = borderEdges3;
            this.bunifuButton23.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton23.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton23.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton23.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton23.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton23.ForeColor = System.Drawing.Color.White;
            this.bunifuButton23.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton23.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton23.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton23.IconMarginLeft = 11;
            this.bunifuButton23.IconPadding = 10;
            this.bunifuButton23.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton23.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton23.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton23.IconSize = 25;
            this.bunifuButton23.IdleBorderColor = System.Drawing.Color.LightGreen;
            this.bunifuButton23.IdleBorderRadius = 35;
            this.bunifuButton23.IdleBorderThickness = 1;
            this.bunifuButton23.IdleFillColor = System.Drawing.Color.LightGreen;
            this.bunifuButton23.IdleIconLeftImage = null;
            this.bunifuButton23.IdleIconRightImage = null;
            this.bunifuButton23.IndicateFocus = false;
            this.bunifuButton23.Location = new System.Drawing.Point(272, 350);
            this.bunifuButton23.Name = "bunifuButton23";
            this.bunifuButton23.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton23.OnDisabledState.BorderRadius = 35;
            this.bunifuButton23.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton23.OnDisabledState.BorderThickness = 1;
            this.bunifuButton23.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton23.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton23.OnDisabledState.IconLeftImage = null;
            this.bunifuButton23.OnDisabledState.IconRightImage = null;
            this.bunifuButton23.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton23.onHoverState.BorderRadius = 35;
            this.bunifuButton23.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton23.onHoverState.BorderThickness = 1;
            this.bunifuButton23.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton23.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton23.onHoverState.IconLeftImage = null;
            this.bunifuButton23.onHoverState.IconRightImage = null;
            this.bunifuButton23.OnIdleState.BorderColor = System.Drawing.Color.LightGreen;
            this.bunifuButton23.OnIdleState.BorderRadius = 35;
            this.bunifuButton23.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton23.OnIdleState.BorderThickness = 1;
            this.bunifuButton23.OnIdleState.FillColor = System.Drawing.Color.LightGreen;
            this.bunifuButton23.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton23.OnIdleState.IconLeftImage = null;
            this.bunifuButton23.OnIdleState.IconRightImage = null;
            this.bunifuButton23.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton23.OnPressedState.BorderRadius = 35;
            this.bunifuButton23.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton23.OnPressedState.BorderThickness = 1;
            this.bunifuButton23.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton23.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton23.OnPressedState.IconLeftImage = null;
            this.bunifuButton23.OnPressedState.IconRightImage = null;
            this.bunifuButton23.Size = new System.Drawing.Size(185, 45);
            this.bunifuButton23.TabIndex = 12;
            this.bunifuButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton23.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton23.TextMarginLeft = 0;
            this.bunifuButton23.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton23.UseDefaultRadiusAndThickness = true;
            this.bunifuButton23.Click += new System.EventHandler(this.bunifuButton23_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnbuscar1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bunifuButton21);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 450);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.txtbuscar);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(126, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 309);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(303, 33);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 11;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(151, 33);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(146, 20);
            this.txtbuscar.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(146, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(436, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnbuscar1
            // 
            this.btnbuscar1.Location = new System.Drawing.Point(536, 185);
            this.btnbuscar1.Name = "btnbuscar1";
            this.btnbuscar1.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar1.TabIndex = 9;
            this.btnbuscar1.Text = "Buscar";
            this.btnbuscar1.UseVisualStyleBackColor = true;
            this.btnbuscar1.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(384, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 23);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Desconocido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cliente:";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.bunifuButton22);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuButton23);
            this.Controls.Add(this.txtempleado);
            this.Controls.Add(this.txtidfactura);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttotal;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton22;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigos;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn precios;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox txtidfactura;
        private System.Windows.Forms.TextBox txtempleado;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton23;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnbuscar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
    }
}