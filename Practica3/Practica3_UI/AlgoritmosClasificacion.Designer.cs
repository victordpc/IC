namespace Practica3_UI
{
    partial class AlgoritmosClasificacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarFicheroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kmediasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bayesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lloydToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.entrenarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bwCargarFichero = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKmediasb = new System.Windows.Forms.TextBox();
            this.txtKmediasTolerancia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLloydAprendizaje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLloydIteraciones = new System.Windows.Forms.TextBox();
            this.txtLloydTolerancia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtClase2Centro4 = new System.Windows.Forms.TextBox();
            this.txtClase2Centro3 = new System.Windows.Forms.TextBox();
            this.txtClase2Centro2 = new System.Windows.Forms.TextBox();
            this.txtClase2Centro1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClase1Centro4 = new System.Windows.Forms.TextBox();
            this.txtClase1Centro3 = new System.Windows.Forms.TextBox();
            this.txtClase1Centro2 = new System.Windows.Forms.TextBox();
            this.txtClase1Centro1 = new System.Windows.Forms.TextBox();
            this.gbKmedias = new System.Windows.Forms.GroupBox();
            this.lblKmediasResultado = new System.Windows.Forms.Label();
            this.btnKmediasComprobar = new System.Windows.Forms.Button();
            this.txtKmediasMuestra4 = new System.Windows.Forms.TextBox();
            this.txtKmediasMuestra3 = new System.Windows.Forms.TextBox();
            this.txtKmediasMuestra2 = new System.Windows.Forms.TextBox();
            this.txtKmediasMuestra1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKmediasFichero = new System.Windows.Forms.Button();
            this.txtKmediasFichero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbBayes = new System.Windows.Forms.GroupBox();
            this.lblBayesResultado = new System.Windows.Forms.Label();
            this.btnBayesComprobar = new System.Windows.Forms.Button();
            this.txtBayesMuestra4 = new System.Windows.Forms.TextBox();
            this.txtBayesMuestra3 = new System.Windows.Forms.TextBox();
            this.txtBayesMuestra2 = new System.Windows.Forms.TextBox();
            this.txtBayesMuestra1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBayesFichero = new System.Windows.Forms.Button();
            this.txtBayesFichero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbLloyd = new System.Windows.Forms.GroupBox();
            this.lblLloydResultado = new System.Windows.Forms.Label();
            this.btnLloydComprobar = new System.Windows.Forms.Button();
            this.txtLloydMuestra4 = new System.Windows.Forms.TextBox();
            this.txtLloydMuestra3 = new System.Windows.Forms.TextBox();
            this.txtLloydMuestra2 = new System.Windows.Forms.TextBox();
            this.txtLloydMuestra1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLloydFichero = new System.Windows.Forms.Button();
            this.txtLloyFichero = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bwKmedias = new System.ComponentModel.BackgroundWorker();
            this.bwBayes = new System.ComponentModel.BackgroundWorker();
            this.bwLloyd = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCargarFichero = new System.Windows.Forms.Button();
            this.btnTodosEntrenar = new System.Windows.Forms.Button();
            this.btnLloydEntrenar = new System.Windows.Forms.Button();
            this.btnBayesEntrenar = new System.Windows.Forms.Button();
            this.btnKmediasEntrenar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbKmedias.SuspendLayout();
            this.gbBayes.SuspendLayout();
            this.gbLloyd.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.entrenarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarFicheroToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarFicheroToolStripMenuItem
            // 
            this.cargarFicheroToolStripMenuItem.Name = "cargarFicheroToolStripMenuItem";
            this.cargarFicheroToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.cargarFicheroToolStripMenuItem.Text = "Cargar fichero";
            this.cargarFicheroToolStripMenuItem.Click += new System.EventHandler(this.btnCargarFichero_Click);
            // 
            // entrenarToolStripMenuItem
            // 
            this.entrenarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kmediasToolStripMenuItem,
            this.bayesToolStripMenuItem,
            this.lloydToolStripMenuItem,
            this.toolStripSeparator1,
            this.entrenarTodosToolStripMenuItem});
            this.entrenarToolStripMenuItem.Name = "entrenarToolStripMenuItem";
            this.entrenarToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.entrenarToolStripMenuItem.Text = "Entrenar";
            // 
            // kmediasToolStripMenuItem
            // 
            this.kmediasToolStripMenuItem.Name = "kmediasToolStripMenuItem";
            this.kmediasToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.kmediasToolStripMenuItem.Text = "Kmedias";
            this.kmediasToolStripMenuItem.Click += new System.EventHandler(this.btnKmediasEntrenar_Click);
            // 
            // bayesToolStripMenuItem
            // 
            this.bayesToolStripMenuItem.Name = "bayesToolStripMenuItem";
            this.bayesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.bayesToolStripMenuItem.Text = "Bayes";
            this.bayesToolStripMenuItem.Click += new System.EventHandler(this.btnBayesEntrenar_Click);
            // 
            // lloydToolStripMenuItem
            // 
            this.lloydToolStripMenuItem.Name = "lloydToolStripMenuItem";
            this.lloydToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.lloydToolStripMenuItem.Text = "Lloyd";
            this.lloydToolStripMenuItem.Click += new System.EventHandler(this.btnLloydEntrenar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // entrenarTodosToolStripMenuItem
            // 
            this.entrenarTodosToolStripMenuItem.Name = "entrenarTodosToolStripMenuItem";
            this.entrenarTodosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.entrenarTodosToolStripMenuItem.Text = "Entrenar todos";
            this.entrenarTodosToolStripMenuItem.Click += new System.EventHandler(this.btnEntrenarTodos_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bwCargarFichero
            // 
            this.bwCargarFichero.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCargarFichero_DoWork);
            this.bwCargarFichero.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCargarFichero_RunWorkerCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKmediasb);
            this.groupBox1.Controls.Add(this.txtKmediasTolerancia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicialización K-Medias";
            // 
            // txtKmediasb
            // 
            this.txtKmediasb.Location = new System.Drawing.Point(146, 52);
            this.txtKmediasb.Name = "txtKmediasb";
            this.txtKmediasb.Size = new System.Drawing.Size(150, 22);
            this.txtKmediasb.TabIndex = 3;
            this.txtKmediasb.Text = "2";
            // 
            // txtKmediasTolerancia
            // 
            this.txtKmediasTolerancia.Location = new System.Drawing.Point(146, 18);
            this.txtKmediasTolerancia.Name = "txtKmediasTolerancia";
            this.txtKmediasTolerancia.Size = new System.Drawing.Size(150, 22);
            this.txtKmediasTolerancia.TabIndex = 2;
            this.txtKmediasTolerancia.Text = "0,01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso exponencial b:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tolerancia ε:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLloydAprendizaje);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtLloydIteraciones);
            this.groupBox3.Controls.Add(this.txtLloydTolerancia);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 115);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inicialización Lloyd";
            // 
            // txtLloydAprendizaje
            // 
            this.txtLloydAprendizaje.Location = new System.Drawing.Point(146, 82);
            this.txtLloydAprendizaje.Name = "txtLloydAprendizaje";
            this.txtLloydAprendizaje.Size = new System.Drawing.Size(150, 22);
            this.txtLloydAprendizaje.TabIndex = 9;
            this.txtLloydAprendizaje.Text = "0,1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Razon aprendizaje:";
            // 
            // txtLloydIteraciones
            // 
            this.txtLloydIteraciones.Location = new System.Drawing.Point(146, 52);
            this.txtLloydIteraciones.Name = "txtLloydIteraciones";
            this.txtLloydIteraciones.Size = new System.Drawing.Size(150, 22);
            this.txtLloydIteraciones.TabIndex = 7;
            this.txtLloydIteraciones.Text = "10";
            // 
            // txtLloydTolerancia
            // 
            this.txtLloydTolerancia.Location = new System.Drawing.Point(146, 18);
            this.txtLloydTolerancia.Name = "txtLloydTolerancia";
            this.txtLloydTolerancia.Size = new System.Drawing.Size(150, 22);
            this.txtLloydTolerancia.TabIndex = 6;
            this.txtLloydTolerancia.Text = "0,000001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Iteraciones:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tolerancia ε:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtClase2Centro4);
            this.groupBox2.Controls.Add(this.txtClase2Centro3);
            this.groupBox2.Controls.Add(this.txtClase2Centro2);
            this.groupBox2.Controls.Add(this.txtClase2Centro1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtClase1Centro4);
            this.groupBox2.Controls.Add(this.txtClase1Centro3);
            this.groupBox2.Controls.Add(this.txtClase1Centro2);
            this.groupBox2.Controls.Add(this.txtClase1Centro1);
            this.groupBox2.Location = new System.Drawing.Point(12, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 85);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Centros iniciales";
            // 
            // txtClase2Centro4
            // 
            this.txtClase2Centro4.Location = new System.Drawing.Point(263, 53);
            this.txtClase2Centro4.Name = "txtClase2Centro4";
            this.txtClase2Centro4.Size = new System.Drawing.Size(33, 22);
            this.txtClase2Centro4.TabIndex = 9;
            this.txtClase2Centro4.Text = "0,7";
            // 
            // txtClase2Centro3
            // 
            this.txtClase2Centro3.Location = new System.Drawing.Point(224, 53);
            this.txtClase2Centro3.Name = "txtClase2Centro3";
            this.txtClase2Centro3.Size = new System.Drawing.Size(33, 22);
            this.txtClase2Centro3.TabIndex = 8;
            this.txtClase2Centro3.Text = "4,6";
            // 
            // txtClase2Centro2
            // 
            this.txtClase2Centro2.Location = new System.Drawing.Point(185, 53);
            this.txtClase2Centro2.Name = "txtClase2Centro2";
            this.txtClase2Centro2.Size = new System.Drawing.Size(33, 22);
            this.txtClase2Centro2.TabIndex = 7;
            this.txtClase2Centro2.Text = "3,4";
            // 
            // txtClase2Centro1
            // 
            this.txtClase2Centro1.Location = new System.Drawing.Point(146, 53);
            this.txtClase2Centro1.Name = "txtClase2Centro1";
            this.txtClase2Centro1.Size = new System.Drawing.Size(33, 22);
            this.txtClase2Centro1.TabIndex = 6;
            this.txtClase2Centro1.Text = "6,8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Iris-versicolor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Iris-setosa:";
            // 
            // txtClase1Centro4
            // 
            this.txtClase1Centro4.Location = new System.Drawing.Point(263, 25);
            this.txtClase1Centro4.Name = "txtClase1Centro4";
            this.txtClase1Centro4.Size = new System.Drawing.Size(33, 22);
            this.txtClase1Centro4.TabIndex = 3;
            this.txtClase1Centro4.Text = "0";
            // 
            // txtClase1Centro3
            // 
            this.txtClase1Centro3.Location = new System.Drawing.Point(224, 25);
            this.txtClase1Centro3.Name = "txtClase1Centro3";
            this.txtClase1Centro3.Size = new System.Drawing.Size(33, 22);
            this.txtClase1Centro3.TabIndex = 2;
            this.txtClase1Centro3.Text = "4";
            // 
            // txtClase1Centro2
            // 
            this.txtClase1Centro2.Location = new System.Drawing.Point(185, 25);
            this.txtClase1Centro2.Name = "txtClase1Centro2";
            this.txtClase1Centro2.Size = new System.Drawing.Size(33, 22);
            this.txtClase1Centro2.TabIndex = 1;
            this.txtClase1Centro2.Text = "3";
            // 
            // txtClase1Centro1
            // 
            this.txtClase1Centro1.Location = new System.Drawing.Point(146, 25);
            this.txtClase1Centro1.Name = "txtClase1Centro1";
            this.txtClase1Centro1.Size = new System.Drawing.Size(33, 22);
            this.txtClase1Centro1.TabIndex = 0;
            this.txtClase1Centro1.Text = "4,6";
            // 
            // gbKmedias
            // 
            this.gbKmedias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbKmedias.Controls.Add(this.lblKmediasResultado);
            this.gbKmedias.Controls.Add(this.btnKmediasComprobar);
            this.gbKmedias.Controls.Add(this.txtKmediasMuestra4);
            this.gbKmedias.Controls.Add(this.txtKmediasMuestra3);
            this.gbKmedias.Controls.Add(this.txtKmediasMuestra2);
            this.gbKmedias.Controls.Add(this.txtKmediasMuestra1);
            this.gbKmedias.Controls.Add(this.label9);
            this.gbKmedias.Controls.Add(this.btnKmediasFichero);
            this.gbKmedias.Controls.Add(this.txtKmediasFichero);
            this.gbKmedias.Controls.Add(this.label6);
            this.gbKmedias.Enabled = false;
            this.gbKmedias.Location = new System.Drawing.Point(471, 39);
            this.gbKmedias.Name = "gbKmedias";
            this.gbKmedias.Size = new System.Drawing.Size(494, 114);
            this.gbKmedias.TabIndex = 13;
            this.gbKmedias.TabStop = false;
            this.gbKmedias.Text = "Clasificación K-Medias";
            // 
            // lblKmediasResultado
            // 
            this.lblKmediasResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKmediasResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKmediasResultado.Location = new System.Drawing.Point(9, 84);
            this.lblKmediasResultado.Name = "lblKmediasResultado";
            this.lblKmediasResultado.Size = new System.Drawing.Size(370, 22);
            this.lblKmediasResultado.TabIndex = 16;
            this.lblKmediasResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnKmediasComprobar
            // 
            this.btnKmediasComprobar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKmediasComprobar.Image = global::Practica3_UI.Properties.Resources.check_ok;
            this.btnKmediasComprobar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnKmediasComprobar.Location = new System.Drawing.Point(385, 77);
            this.btnKmediasComprobar.Name = "btnKmediasComprobar";
            this.btnKmediasComprobar.Size = new System.Drawing.Size(102, 30);
            this.btnKmediasComprobar.TabIndex = 15;
            this.btnKmediasComprobar.Text = "Comprobar";
            this.btnKmediasComprobar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKmediasComprobar.UseVisualStyleBackColor = true;
            this.btnKmediasComprobar.Click += new System.EventHandler(this.btnKmediasComprobar_Click);
            // 
            // txtKmediasMuestra4
            // 
            this.txtKmediasMuestra4.Location = new System.Drawing.Point(243, 49);
            this.txtKmediasMuestra4.Name = "txtKmediasMuestra4";
            this.txtKmediasMuestra4.Size = new System.Drawing.Size(33, 22);
            this.txtKmediasMuestra4.TabIndex = 14;
            // 
            // txtKmediasMuestra3
            // 
            this.txtKmediasMuestra3.Location = new System.Drawing.Point(204, 49);
            this.txtKmediasMuestra3.Name = "txtKmediasMuestra3";
            this.txtKmediasMuestra3.Size = new System.Drawing.Size(33, 22);
            this.txtKmediasMuestra3.TabIndex = 13;
            // 
            // txtKmediasMuestra2
            // 
            this.txtKmediasMuestra2.Location = new System.Drawing.Point(165, 49);
            this.txtKmediasMuestra2.Name = "txtKmediasMuestra2";
            this.txtKmediasMuestra2.Size = new System.Drawing.Size(33, 22);
            this.txtKmediasMuestra2.TabIndex = 12;
            // 
            // txtKmediasMuestra1
            // 
            this.txtKmediasMuestra1.Location = new System.Drawing.Point(126, 49);
            this.txtKmediasMuestra1.Name = "txtKmediasMuestra1";
            this.txtKmediasMuestra1.Size = new System.Drawing.Size(33, 22);
            this.txtKmediasMuestra1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Datos muestra:";
            // 
            // btnKmediasFichero
            // 
            this.btnKmediasFichero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKmediasFichero.Location = new System.Drawing.Point(452, 22);
            this.btnKmediasFichero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKmediasFichero.Name = "btnKmediasFichero";
            this.btnKmediasFichero.Size = new System.Drawing.Size(35, 24);
            this.btnKmediasFichero.TabIndex = 2;
            this.btnKmediasFichero.Text = "...";
            this.btnKmediasFichero.UseVisualStyleBackColor = true;
            this.btnKmediasFichero.Click += new System.EventHandler(this.btnKmediasFichero_Click);
            // 
            // txtKmediasFichero
            // 
            this.txtKmediasFichero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKmediasFichero.Location = new System.Drawing.Point(126, 21);
            this.txtKmediasFichero.Name = "txtKmediasFichero";
            this.txtKmediasFichero.Size = new System.Drawing.Size(325, 22);
            this.txtKmediasFichero.TabIndex = 1;
            this.txtKmediasFichero.Click += new System.EventHandler(this.btnKmediasFichero_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fichero muestra:";
            // 
            // gbBayes
            // 
            this.gbBayes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBayes.Controls.Add(this.lblBayesResultado);
            this.gbBayes.Controls.Add(this.btnBayesComprobar);
            this.gbBayes.Controls.Add(this.txtBayesMuestra4);
            this.gbBayes.Controls.Add(this.txtBayesMuestra3);
            this.gbBayes.Controls.Add(this.txtBayesMuestra2);
            this.gbBayes.Controls.Add(this.txtBayesMuestra1);
            this.gbBayes.Controls.Add(this.label10);
            this.gbBayes.Controls.Add(this.btnBayesFichero);
            this.gbBayes.Controls.Add(this.txtBayesFichero);
            this.gbBayes.Controls.Add(this.label11);
            this.gbBayes.Enabled = false;
            this.gbBayes.Location = new System.Drawing.Point(471, 159);
            this.gbBayes.Name = "gbBayes";
            this.gbBayes.Size = new System.Drawing.Size(494, 114);
            this.gbBayes.TabIndex = 16;
            this.gbBayes.TabStop = false;
            this.gbBayes.Text = "Clasificación Bayes";
            // 
            // lblBayesResultado
            // 
            this.lblBayesResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBayesResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBayesResultado.Location = new System.Drawing.Point(9, 84);
            this.lblBayesResultado.Name = "lblBayesResultado";
            this.lblBayesResultado.Size = new System.Drawing.Size(370, 22);
            this.lblBayesResultado.TabIndex = 17;
            this.lblBayesResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBayesComprobar
            // 
            this.btnBayesComprobar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBayesComprobar.Image = global::Practica3_UI.Properties.Resources.check_ok;
            this.btnBayesComprobar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBayesComprobar.Location = new System.Drawing.Point(385, 77);
            this.btnBayesComprobar.Name = "btnBayesComprobar";
            this.btnBayesComprobar.Size = new System.Drawing.Size(102, 30);
            this.btnBayesComprobar.TabIndex = 15;
            this.btnBayesComprobar.Text = "Comprobar";
            this.btnBayesComprobar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBayesComprobar.UseVisualStyleBackColor = true;
            this.btnBayesComprobar.Click += new System.EventHandler(this.btnBayesComprobar_Click);
            // 
            // txtBayesMuestra4
            // 
            this.txtBayesMuestra4.Location = new System.Drawing.Point(243, 49);
            this.txtBayesMuestra4.Name = "txtBayesMuestra4";
            this.txtBayesMuestra4.Size = new System.Drawing.Size(33, 22);
            this.txtBayesMuestra4.TabIndex = 14;
            // 
            // txtBayesMuestra3
            // 
            this.txtBayesMuestra3.Location = new System.Drawing.Point(204, 49);
            this.txtBayesMuestra3.Name = "txtBayesMuestra3";
            this.txtBayesMuestra3.Size = new System.Drawing.Size(33, 22);
            this.txtBayesMuestra3.TabIndex = 13;
            // 
            // txtBayesMuestra2
            // 
            this.txtBayesMuestra2.Location = new System.Drawing.Point(165, 49);
            this.txtBayesMuestra2.Name = "txtBayesMuestra2";
            this.txtBayesMuestra2.Size = new System.Drawing.Size(33, 22);
            this.txtBayesMuestra2.TabIndex = 12;
            // 
            // txtBayesMuestra1
            // 
            this.txtBayesMuestra1.Location = new System.Drawing.Point(126, 49);
            this.txtBayesMuestra1.Name = "txtBayesMuestra1";
            this.txtBayesMuestra1.Size = new System.Drawing.Size(33, 22);
            this.txtBayesMuestra1.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Datos muestra:";
            // 
            // btnBayesFichero
            // 
            this.btnBayesFichero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBayesFichero.Location = new System.Drawing.Point(452, 22);
            this.btnBayesFichero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBayesFichero.Name = "btnBayesFichero";
            this.btnBayesFichero.Size = new System.Drawing.Size(35, 24);
            this.btnBayesFichero.TabIndex = 2;
            this.btnBayesFichero.Text = "...";
            this.btnBayesFichero.UseVisualStyleBackColor = true;
            this.btnBayesFichero.Click += new System.EventHandler(this.btnBayesFichero_Click);
            // 
            // txtBayesFichero
            // 
            this.txtBayesFichero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBayesFichero.Location = new System.Drawing.Point(126, 21);
            this.txtBayesFichero.Name = "txtBayesFichero";
            this.txtBayesFichero.Size = new System.Drawing.Size(325, 22);
            this.txtBayesFichero.TabIndex = 1;
            this.txtBayesFichero.Click += new System.EventHandler(this.btnBayesFichero_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Fichero muestra:";
            // 
            // gbLloyd
            // 
            this.gbLloyd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLloyd.Controls.Add(this.lblLloydResultado);
            this.gbLloyd.Controls.Add(this.btnLloydComprobar);
            this.gbLloyd.Controls.Add(this.txtLloydMuestra4);
            this.gbLloyd.Controls.Add(this.txtLloydMuestra3);
            this.gbLloyd.Controls.Add(this.txtLloydMuestra2);
            this.gbLloyd.Controls.Add(this.txtLloydMuestra1);
            this.gbLloyd.Controls.Add(this.label12);
            this.gbLloyd.Controls.Add(this.btnLloydFichero);
            this.gbLloyd.Controls.Add(this.txtLloyFichero);
            this.gbLloyd.Controls.Add(this.label13);
            this.gbLloyd.Enabled = false;
            this.gbLloyd.Location = new System.Drawing.Point(471, 279);
            this.gbLloyd.Name = "gbLloyd";
            this.gbLloyd.Size = new System.Drawing.Size(494, 114);
            this.gbLloyd.TabIndex = 17;
            this.gbLloyd.TabStop = false;
            this.gbLloyd.Text = "Clasificación Lloyd";
            // 
            // lblLloydResultado
            // 
            this.lblLloydResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLloydResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLloydResultado.Location = new System.Drawing.Point(9, 84);
            this.lblLloydResultado.Name = "lblLloydResultado";
            this.lblLloydResultado.Size = new System.Drawing.Size(370, 22);
            this.lblLloydResultado.TabIndex = 18;
            this.lblLloydResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLloydComprobar
            // 
            this.btnLloydComprobar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLloydComprobar.Image = global::Practica3_UI.Properties.Resources.check_ok;
            this.btnLloydComprobar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLloydComprobar.Location = new System.Drawing.Point(385, 77);
            this.btnLloydComprobar.Name = "btnLloydComprobar";
            this.btnLloydComprobar.Size = new System.Drawing.Size(102, 30);
            this.btnLloydComprobar.TabIndex = 15;
            this.btnLloydComprobar.Text = "Comprobar";
            this.btnLloydComprobar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLloydComprobar.UseVisualStyleBackColor = true;
            this.btnLloydComprobar.Click += new System.EventHandler(this.btnLloydComprobar_Click);
            // 
            // txtLloydMuestra4
            // 
            this.txtLloydMuestra4.Location = new System.Drawing.Point(243, 49);
            this.txtLloydMuestra4.Name = "txtLloydMuestra4";
            this.txtLloydMuestra4.Size = new System.Drawing.Size(33, 22);
            this.txtLloydMuestra4.TabIndex = 14;
            // 
            // txtLloydMuestra3
            // 
            this.txtLloydMuestra3.Location = new System.Drawing.Point(204, 49);
            this.txtLloydMuestra3.Name = "txtLloydMuestra3";
            this.txtLloydMuestra3.Size = new System.Drawing.Size(33, 22);
            this.txtLloydMuestra3.TabIndex = 13;
            // 
            // txtLloydMuestra2
            // 
            this.txtLloydMuestra2.Location = new System.Drawing.Point(165, 49);
            this.txtLloydMuestra2.Name = "txtLloydMuestra2";
            this.txtLloydMuestra2.Size = new System.Drawing.Size(33, 22);
            this.txtLloydMuestra2.TabIndex = 12;
            // 
            // txtLloydMuestra1
            // 
            this.txtLloydMuestra1.Location = new System.Drawing.Point(126, 49);
            this.txtLloydMuestra1.Name = "txtLloydMuestra1";
            this.txtLloydMuestra1.Size = new System.Drawing.Size(33, 22);
            this.txtLloydMuestra1.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Datos muestra:";
            // 
            // btnLloydFichero
            // 
            this.btnLloydFichero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLloydFichero.Location = new System.Drawing.Point(452, 22);
            this.btnLloydFichero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLloydFichero.Name = "btnLloydFichero";
            this.btnLloydFichero.Size = new System.Drawing.Size(35, 24);
            this.btnLloydFichero.TabIndex = 2;
            this.btnLloydFichero.Text = "...";
            this.btnLloydFichero.UseVisualStyleBackColor = true;
            this.btnLloydFichero.Click += new System.EventHandler(this.btnLloydFichero_Click);
            // 
            // txtLloyFichero
            // 
            this.txtLloyFichero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLloyFichero.Location = new System.Drawing.Point(126, 21);
            this.txtLloyFichero.Name = "txtLloyFichero";
            this.txtLloyFichero.Size = new System.Drawing.Size(325, 22);
            this.txtLloyFichero.TabIndex = 1;
            this.txtLloyFichero.Click += new System.EventHandler(this.btnLloydFichero_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Fichero muestra:";
            // 
            // bwKmedias
            // 
            this.bwKmedias.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwKmedias_DoWork);
            this.bwKmedias.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwKmedias_ProgressChanged);
            this.bwKmedias.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwKmedias_RunWorkerCompleted);
            // 
            // bwBayes
            // 
            this.bwBayes.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwBayes_DoWork);
            this.bwBayes.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwBayes_ProgressChanged);
            this.bwBayes.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwBayes_RunWorkerCompleted);
            // 
            // bwLloyd
            // 
            this.bwLloyd.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLloyd_DoWork);
            this.bwLloyd.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwLloyd_ProgressChanged);
            this.bwLloyd.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLloyd_RunWorkerCompleted);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCargarFichero);
            this.groupBox4.Location = new System.Drawing.Point(12, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 54);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fichero";
            // 
            // btnCargarFichero
            // 
            this.btnCargarFichero.Image = global::Practica3_UI.Properties.Resources.file;
            this.btnCargarFichero.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCargarFichero.Location = new System.Drawing.Point(146, 15);
            this.btnCargarFichero.Name = "btnCargarFichero";
            this.btnCargarFichero.Size = new System.Drawing.Size(150, 30);
            this.btnCargarFichero.TabIndex = 16;
            this.btnCargarFichero.Text = "Cargar fichero";
            this.btnCargarFichero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarFichero.UseVisualStyleBackColor = true;
            this.btnCargarFichero.Click += new System.EventHandler(this.btnCargarFichero_Click);
            // 
            // btnTodosEntrenar
            // 
            this.btnTodosEntrenar.Enabled = false;
            this.btnTodosEntrenar.Image = global::Practica3_UI.Properties.Resources.actions;
            this.btnTodosEntrenar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnTodosEntrenar.Location = new System.Drawing.Point(330, 185);
            this.btnTodosEntrenar.Name = "btnTodosEntrenar";
            this.btnTodosEntrenar.Size = new System.Drawing.Size(135, 43);
            this.btnTodosEntrenar.TabIndex = 12;
            this.btnTodosEntrenar.Text = "Entrenar\r\nTodos";
            this.btnTodosEntrenar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosEntrenar.UseVisualStyleBackColor = true;
            this.btnTodosEntrenar.Click += new System.EventHandler(this.btnEntrenarTodos_Click);
            // 
            // btnLloydEntrenar
            // 
            this.btnLloydEntrenar.Enabled = false;
            this.btnLloydEntrenar.Image = global::Practica3_UI.Properties.Resources.actions;
            this.btnLloydEntrenar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLloydEntrenar.Location = new System.Drawing.Point(330, 136);
            this.btnLloydEntrenar.Name = "btnLloydEntrenar";
            this.btnLloydEntrenar.Size = new System.Drawing.Size(135, 43);
            this.btnLloydEntrenar.TabIndex = 10;
            this.btnLloydEntrenar.Text = "Entrenar\r\nLloyd";
            this.btnLloydEntrenar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLloydEntrenar.UseVisualStyleBackColor = true;
            this.btnLloydEntrenar.Click += new System.EventHandler(this.btnLloydEntrenar_Click);
            // 
            // btnBayesEntrenar
            // 
            this.btnBayesEntrenar.Enabled = false;
            this.btnBayesEntrenar.Image = global::Practica3_UI.Properties.Resources.actions;
            this.btnBayesEntrenar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBayesEntrenar.Location = new System.Drawing.Point(330, 87);
            this.btnBayesEntrenar.Name = "btnBayesEntrenar";
            this.btnBayesEntrenar.Size = new System.Drawing.Size(135, 43);
            this.btnBayesEntrenar.TabIndex = 0;
            this.btnBayesEntrenar.Text = "Entrenar\r\nBayes";
            this.btnBayesEntrenar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBayesEntrenar.UseVisualStyleBackColor = true;
            this.btnBayesEntrenar.Click += new System.EventHandler(this.btnBayesEntrenar_Click);
            // 
            // btnKmediasEntrenar
            // 
            this.btnKmediasEntrenar.Enabled = false;
            this.btnKmediasEntrenar.Image = global::Practica3_UI.Properties.Resources.actions;
            this.btnKmediasEntrenar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnKmediasEntrenar.Location = new System.Drawing.Point(330, 38);
            this.btnKmediasEntrenar.Name = "btnKmediasEntrenar";
            this.btnKmediasEntrenar.Size = new System.Drawing.Size(135, 43);
            this.btnKmediasEntrenar.TabIndex = 4;
            this.btnKmediasEntrenar.Text = "Entrenar\r\nK-Medias";
            this.btnKmediasEntrenar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKmediasEntrenar.UseVisualStyleBackColor = true;
            this.btnKmediasEntrenar.Click += new System.EventHandler(this.btnKmediasEntrenar_Click);
            // 
            // AlgoritmosClasificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 398);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbLloyd);
            this.Controls.Add(this.gbBayes);
            this.Controls.Add(this.gbKmedias);
            this.Controls.Add(this.btnTodosEntrenar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLloydEntrenar);
            this.Controls.Add(this.btnBayesEntrenar);
            this.Controls.Add(this.btnKmediasEntrenar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AlgoritmosClasificacion";
            this.Text = "Algoritmos clasificacion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbKmedias.ResumeLayout(false);
            this.gbKmedias.PerformLayout();
            this.gbBayes.ResumeLayout(false);
            this.gbBayes.PerformLayout();
            this.gbLloyd.ResumeLayout(false);
            this.gbLloyd.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarFicheroToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker bwCargarFichero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtKmediasb;
        private System.Windows.Forms.TextBox txtKmediasTolerancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLloydIteraciones;
        private System.Windows.Forms.TextBox txtLloydTolerancia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKmediasEntrenar;
        private System.Windows.Forms.TextBox txtLloydAprendizaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem entrenarToolStripMenuItem;
        private System.Windows.Forms.Button btnBayesEntrenar;
        private System.Windows.Forms.Button btnLloydEntrenar;
        private System.Windows.Forms.ToolStripMenuItem kmediasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bayesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lloydToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem entrenarTodosToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClase1Centro4;
        private System.Windows.Forms.TextBox txtClase1Centro3;
        private System.Windows.Forms.TextBox txtClase1Centro2;
        private System.Windows.Forms.TextBox txtClase1Centro1;
        private System.Windows.Forms.TextBox txtClase2Centro4;
        private System.Windows.Forms.TextBox txtClase2Centro3;
        private System.Windows.Forms.TextBox txtClase2Centro2;
        private System.Windows.Forms.TextBox txtClase2Centro1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTodosEntrenar;
        private System.Windows.Forms.GroupBox gbKmedias;
        private System.Windows.Forms.Button btnKmediasComprobar;
        private System.Windows.Forms.TextBox txtKmediasMuestra4;
        private System.Windows.Forms.TextBox txtKmediasMuestra3;
        private System.Windows.Forms.TextBox txtKmediasMuestra2;
        private System.Windows.Forms.TextBox txtKmediasMuestra1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKmediasFichero;
        private System.Windows.Forms.TextBox txtKmediasFichero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbBayes;
        private System.Windows.Forms.Button btnBayesComprobar;
        private System.Windows.Forms.TextBox txtBayesMuestra4;
        private System.Windows.Forms.TextBox txtBayesMuestra3;
        private System.Windows.Forms.TextBox txtBayesMuestra2;
        private System.Windows.Forms.TextBox txtBayesMuestra1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBayesFichero;
        private System.Windows.Forms.TextBox txtBayesFichero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbLloyd;
        private System.Windows.Forms.Button btnLloydComprobar;
        private System.Windows.Forms.TextBox txtLloydMuestra4;
        private System.Windows.Forms.TextBox txtLloydMuestra3;
        private System.Windows.Forms.TextBox txtLloydMuestra2;
        private System.Windows.Forms.TextBox txtLloydMuestra1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLloydFichero;
        private System.Windows.Forms.TextBox txtLloyFichero;
        private System.Windows.Forms.Label label13;
        private System.ComponentModel.BackgroundWorker bwKmedias;
        private System.ComponentModel.BackgroundWorker bwBayes;
        private System.ComponentModel.BackgroundWorker bwLloyd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCargarFichero;
        private System.Windows.Forms.Label lblKmediasResultado;
        private System.Windows.Forms.Label lblBayesResultado;
        private System.Windows.Forms.Label lblLloydResultado;
    }
}