namespace ProiectPAW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportRaportTXTToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            adaugaMagazinToolStripMenuItem = new ToolStripMenuItem();
            printeazaFisaMagazinToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnListaMagazineToolStrip = new ToolStripButton();
            btnAdaugaMagazinToolStrip = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnListaRaioaneToolStrip = new ToolStripButton();
            btnAdaugaRaionToolStrip = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnListaDesfaceriToolStrip = new ToolStripButton();
            btnAdaugaDesfacereToolStrip = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            contextStripEntitate = new ContextMenuStrip(components);
            cmiSterge = new ToolStripMenuItem();
            cmiEditare = new ToolStripMenuItem();
            cmiCopiaza = new ToolStripMenuItem();
            panelContainer = new Panel();
            panelFormRaion = new Panel();
            tbIdRaion = new TextBox();
            btnAdaugaRaion = new Button();
            nudNumarAngajati = new NumericUpDown();
            lblNumarAngajati = new Label();
            lblNumeRaion = new Label();
            lblSelectareMagazinRaion = new Label();
            tbNumeRaion = new TextBox();
            cbMagazinRaion = new ComboBox();
            lblTitluRaion = new Label();
            panelFormMagazin = new Panel();
            tbIdMagazin = new TextBox();
            btnAdaugaMagazin = new Button();
            lblAdresaMagazin = new Label();
            lblNumeMagazin = new Label();
            tbAdresaMagazin = new TextBox();
            tbNumeMagazin = new TextBox();
            lblTitluMagazin = new Label();
            panelListe = new Panel();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblTitluListe = new Label();
            dgvListe = new DataGridView();
            panelFormDesfacere = new Panel();
            dtpDataVanzarii = new DateTimePicker();
            nudValoare = new NumericUpDown();
            nudCantitate = new NumericUpDown();
            tbProdusVandut = new TextBox();
            btnAdaugaDesfacere = new Button();
            lblDataVanzarii = new Label();
            lblValoare = new Label();
            lblCantitate = new Label();
            lblProdusVandut = new Label();
            cbSelectareRaionDesfacere = new ComboBox();
            lblSelectareRaionDesfacere = new Label();
            cbSelectareMagazinDesfacere = new ComboBox();
            lblSelectareMagazinDesfacere = new Label();
            lblTitluDesfacere = new Label();
            comertDbContextBindingSource = new BindingSource(components);
            magazinBindingSource = new BindingSource(components);
            errorProvider = new ErrorProvider(components);
            raionBindingSource = new BindingSource(components);
            tbIdDesfacere = new TextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            contextStripEntitate.SuspendLayout();
            panelContainer.SuspendLayout();
            panelFormRaion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumarAngajati).BeginInit();
            panelFormMagazin.SuspendLayout();
            panelListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListe).BeginInit();
            panelFormDesfacere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudValoare).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantitate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comertDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)magazinBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)raionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportRaportTXTToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 20);
            fileToolStripMenuItem.Text = "&Fisier";
            // 
            // exportRaportTXTToolStripMenuItem
            // 
            exportRaportTXTToolStripMenuItem.Name = "exportRaportTXTToolStripMenuItem";
            exportRaportTXTToolStripMenuItem.Size = new Size(101, 22);
            exportRaportTXTToolStripMenuItem.Text = "&Iesire";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { adaugaMagazinToolStripMenuItem, printeazaFisaMagazinToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(66, 20);
            toolStripMenuItem1.Text = "Rapoarte";
            // 
            // adaugaMagazinToolStripMenuItem
            // 
            adaugaMagazinToolStripMenuItem.Name = "adaugaMagazinToolStripMenuItem";
            adaugaMagazinToolStripMenuItem.Size = new Size(193, 22);
            adaugaMagazinToolStripMenuItem.Text = "&Export Raport TXT";
            // 
            // printeazaFisaMagazinToolStripMenuItem
            // 
            printeazaFisaMagazinToolStripMenuItem.Name = "printeazaFisaMagazinToolStripMenuItem";
            printeazaFisaMagazinToolStripMenuItem.Size = new Size(193, 22);
            printeazaFisaMagazinToolStripMenuItem.Text = "Printeaza Fisa Magazin";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnListaMagazineToolStrip, btnAdaugaMagazinToolStrip, toolStripSeparator1, btnListaRaioaneToolStrip, btnAdaugaRaionToolStrip, toolStripSeparator2, btnListaDesfaceriToolStrip, btnAdaugaDesfacereToolStrip });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnListaMagazineToolStrip
            // 
            btnListaMagazineToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnListaMagazineToolStrip.Image = (Image)resources.GetObject("btnListaMagazineToolStrip.Image");
            btnListaMagazineToolStrip.ImageTransparentColor = Color.Magenta;
            btnListaMagazineToolStrip.Name = "btnListaMagazineToolStrip";
            btnListaMagazineToolStrip.Size = new Size(89, 22);
            btnListaMagazineToolStrip.Text = "Lista Magazine";
            btnListaMagazineToolStrip.Click += btnListaMagazineToolStrip_Click;
            // 
            // btnAdaugaMagazinToolStrip
            // 
            btnAdaugaMagazinToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAdaugaMagazinToolStrip.Image = (Image)resources.GetObject("btnAdaugaMagazinToolStrip.Image");
            btnAdaugaMagazinToolStrip.ImageTransparentColor = Color.Magenta;
            btnAdaugaMagazinToolStrip.Name = "btnAdaugaMagazinToolStrip";
            btnAdaugaMagazinToolStrip.Size = new Size(100, 22);
            btnAdaugaMagazinToolStrip.Text = "Adauga Magazin";
            btnAdaugaMagazinToolStrip.Click += btnAdaugaMagazinToolStrip_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnListaRaioaneToolStrip
            // 
            btnListaRaioaneToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnListaRaioaneToolStrip.Image = (Image)resources.GetObject("btnListaRaioaneToolStrip.Image");
            btnListaRaioaneToolStrip.ImageTransparentColor = Color.Magenta;
            btnListaRaioaneToolStrip.Name = "btnListaRaioaneToolStrip";
            btnListaRaioaneToolStrip.Size = new Size(80, 22);
            btnListaRaioaneToolStrip.Text = "Lista Raioane";
            btnListaRaioaneToolStrip.Click += btnListaRaioaneToolStrip_Click;
            // 
            // btnAdaugaRaionToolStrip
            // 
            btnAdaugaRaionToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAdaugaRaionToolStrip.Image = (Image)resources.GetObject("btnAdaugaRaionToolStrip.Image");
            btnAdaugaRaionToolStrip.ImageTransparentColor = Color.Magenta;
            btnAdaugaRaionToolStrip.Name = "btnAdaugaRaionToolStrip";
            btnAdaugaRaionToolStrip.Size = new Size(85, 22);
            btnAdaugaRaionToolStrip.Text = "Adauga Raion";
            btnAdaugaRaionToolStrip.Click += btnAdaugaRaionToolStrip_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnListaDesfaceriToolStrip
            // 
            btnListaDesfaceriToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnListaDesfaceriToolStrip.Image = (Image)resources.GetObject("btnListaDesfaceriToolStrip.Image");
            btnListaDesfaceriToolStrip.ImageTransparentColor = Color.Magenta;
            btnListaDesfaceriToolStrip.Name = "btnListaDesfaceriToolStrip";
            btnListaDesfaceriToolStrip.Size = new Size(86, 22);
            btnListaDesfaceriToolStrip.Text = "Lista Desfaceri";
            btnListaDesfaceriToolStrip.Click += btnListaDesfaceriToolStrip_Click;
            // 
            // btnAdaugaDesfacereToolStrip
            // 
            btnAdaugaDesfacereToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAdaugaDesfacereToolStrip.Image = (Image)resources.GetObject("btnAdaugaDesfacereToolStrip.Image");
            btnAdaugaDesfacereToolStrip.ImageAlign = ContentAlignment.TopCenter;
            btnAdaugaDesfacereToolStrip.ImageTransparentColor = Color.Magenta;
            btnAdaugaDesfacereToolStrip.Name = "btnAdaugaDesfacereToolStrip";
            btnAdaugaDesfacereToolStrip.Size = new Size(106, 22);
            btnAdaugaDesfacereToolStrip.Text = "Adauga Desfacere";
            btnAdaugaDesfacereToolStrip.Click += btnAdaugaDesfacereToolStrip_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(176, 17);
            lblStatus.Text = "Aplicatia a pornit. Gata de lucru.";
            // 
            // contextStripEntitate
            // 
            contextStripEntitate.Items.AddRange(new ToolStripItem[] { cmiSterge, cmiEditare, cmiCopiaza });
            contextStripEntitate.Name = "contextMenuStrip3";
            contextStripEntitate.Size = new Size(153, 70);
            // 
            // cmiSterge
            // 
            cmiSterge.Name = "cmiSterge";
            cmiSterge.Size = new Size(152, 22);
            cmiSterge.Text = "Sterge";
            cmiSterge.Click += cmiSterge_Click;
            // 
            // cmiEditare
            // 
            cmiEditare.Name = "cmiEditare";
            cmiEditare.Size = new Size(152, 22);
            cmiEditare.Text = "Editare";
            cmiEditare.Click += cmiEditare_Click;
            // 
            // cmiCopiaza
            // 
            cmiCopiaza.Name = "cmiCopiaza";
            cmiCopiaza.Size = new Size(152, 22);
            cmiCopiaza.Text = "Copiaza Detalii";
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(panelFormDesfacere);
            panelContainer.Controls.Add(panelFormRaion);
            panelContainer.Controls.Add(panelFormMagazin);
            panelContainer.Controls.Add(panelListe);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 49);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(800, 379);
            panelContainer.TabIndex = 3;
            // 
            // panelFormRaion
            // 
            panelFormRaion.Controls.Add(tbIdRaion);
            panelFormRaion.Controls.Add(btnAdaugaRaion);
            panelFormRaion.Controls.Add(nudNumarAngajati);
            panelFormRaion.Controls.Add(lblNumarAngajati);
            panelFormRaion.Controls.Add(lblNumeRaion);
            panelFormRaion.Controls.Add(lblSelectareMagazinRaion);
            panelFormRaion.Controls.Add(tbNumeRaion);
            panelFormRaion.Controls.Add(cbMagazinRaion);
            panelFormRaion.Controls.Add(lblTitluRaion);
            panelFormRaion.Dock = DockStyle.Fill;
            panelFormRaion.Location = new Point(0, 0);
            panelFormRaion.Name = "panelFormRaion";
            panelFormRaion.Size = new Size(800, 379);
            panelFormRaion.TabIndex = 2;
            panelFormRaion.Visible = false;
            // 
            // tbIdRaion
            // 
            tbIdRaion.Location = new Point(149, 11);
            tbIdRaion.Name = "tbIdRaion";
            tbIdRaion.Size = new Size(100, 23);
            tbIdRaion.TabIndex = 10;
            tbIdRaion.Visible = false;
            // 
            // btnAdaugaRaion
            // 
            btnAdaugaRaion.Location = new Point(44, 220);
            btnAdaugaRaion.Name = "btnAdaugaRaion";
            btnAdaugaRaion.Size = new Size(75, 23);
            btnAdaugaRaion.TabIndex = 9;
            btnAdaugaRaion.Text = "Adauga";
            btnAdaugaRaion.UseVisualStyleBackColor = true;
            btnAdaugaRaion.Click += btnAdaugaRaion_Click;
            // 
            // nudNumarAngajati
            // 
            nudNumarAngajati.Location = new Point(172, 173);
            nudNumarAngajati.Name = "nudNumarAngajati";
            nudNumarAngajati.Size = new Size(121, 23);
            nudNumarAngajati.TabIndex = 8;
            // 
            // lblNumarAngajati
            // 
            lblNumarAngajati.AutoSize = true;
            lblNumarAngajati.Location = new Point(44, 174);
            lblNumarAngajati.Name = "lblNumarAngajati";
            lblNumarAngajati.Size = new Size(91, 15);
            lblNumarAngajati.TabIndex = 7;
            lblNumarAngajati.Text = "Numar Angajati";
            // 
            // lblNumeRaion
            // 
            lblNumeRaion.AutoSize = true;
            lblNumeRaion.Location = new Point(44, 125);
            lblNumeRaion.Name = "lblNumeRaion";
            lblNumeRaion.Size = new Size(73, 15);
            lblNumeRaion.TabIndex = 6;
            lblNumeRaion.Text = "Nume Raion";
            // 
            // lblSelectareMagazinRaion
            // 
            lblSelectareMagazinRaion.AutoSize = true;
            lblSelectareMagazinRaion.Location = new Point(44, 76);
            lblSelectareMagazinRaion.Name = "lblSelectareMagazinRaion";
            lblSelectareMagazinRaion.Size = new Size(102, 15);
            lblSelectareMagazinRaion.TabIndex = 5;
            lblSelectareMagazinRaion.Text = "Selectare Magazin";
            // 
            // tbNumeRaion
            // 
            tbNumeRaion.Location = new Point(172, 120);
            tbNumeRaion.Name = "tbNumeRaion";
            tbNumeRaion.Size = new Size(121, 23);
            tbNumeRaion.TabIndex = 3;
            tbNumeRaion.Validating += tbNumeRaion_Validating;
            tbNumeRaion.Validated += tbNumeRaion_Validated;
            // 
            // cbMagazinRaion
            // 
            cbMagazinRaion.FormattingEnabled = true;
            cbMagazinRaion.Location = new Point(172, 73);
            cbMagazinRaion.Name = "cbMagazinRaion";
            cbMagazinRaion.Size = new Size(121, 23);
            cbMagazinRaion.TabIndex = 2;
            cbMagazinRaion.Validating += cbMagazinRaion_Validating;
            cbMagazinRaion.Validated += cbMagazinRaion_Validated;
            // 
            // lblTitluRaion
            // 
            lblTitluRaion.AutoSize = true;
            lblTitluRaion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitluRaion.Location = new Point(13, 9);
            lblTitluRaion.Name = "lblTitluRaion";
            lblTitluRaion.Size = new Size(130, 25);
            lblTitluRaion.TabIndex = 1;
            lblTitluRaion.Text = "Adauga Raion";
            // 
            // panelFormMagazin
            // 
            panelFormMagazin.Controls.Add(tbIdMagazin);
            panelFormMagazin.Controls.Add(btnAdaugaMagazin);
            panelFormMagazin.Controls.Add(lblAdresaMagazin);
            panelFormMagazin.Controls.Add(lblNumeMagazin);
            panelFormMagazin.Controls.Add(tbAdresaMagazin);
            panelFormMagazin.Controls.Add(tbNumeMagazin);
            panelFormMagazin.Controls.Add(lblTitluMagazin);
            panelFormMagazin.Dock = DockStyle.Fill;
            panelFormMagazin.Location = new Point(0, 0);
            panelFormMagazin.Name = "panelFormMagazin";
            panelFormMagazin.Size = new Size(800, 379);
            panelFormMagazin.TabIndex = 1;
            panelFormMagazin.Visible = false;
            // 
            // tbIdMagazin
            // 
            tbIdMagazin.Location = new Point(173, 11);
            tbIdMagazin.Name = "tbIdMagazin";
            tbIdMagazin.Size = new Size(100, 23);
            tbIdMagazin.TabIndex = 6;
            tbIdMagazin.Visible = false;
            // 
            // btnAdaugaMagazin
            // 
            btnAdaugaMagazin.Location = new Point(88, 216);
            btnAdaugaMagazin.Name = "btnAdaugaMagazin";
            btnAdaugaMagazin.Size = new Size(75, 23);
            btnAdaugaMagazin.TabIndex = 5;
            btnAdaugaMagazin.Text = "Adauga";
            btnAdaugaMagazin.UseVisualStyleBackColor = true;
            btnAdaugaMagazin.Click += btnAdaugaMagazin_Click;
            // 
            // lblAdresaMagazin
            // 
            lblAdresaMagazin.AutoSize = true;
            lblAdresaMagazin.Location = new Point(88, 146);
            lblAdresaMagazin.Name = "lblAdresaMagazin";
            lblAdresaMagazin.Size = new Size(91, 15);
            lblAdresaMagazin.TabIndex = 4;
            lblAdresaMagazin.Text = "Adresa Magazin";
            // 
            // lblNumeMagazin
            // 
            lblNumeMagazin.AutoSize = true;
            lblNumeMagazin.Location = new Point(88, 73);
            lblNumeMagazin.Name = "lblNumeMagazin";
            lblNumeMagazin.Size = new Size(88, 15);
            lblNumeMagazin.TabIndex = 3;
            lblNumeMagazin.Text = "Nume Magazin";
            // 
            // tbAdresaMagazin
            // 
            tbAdresaMagazin.Location = new Point(193, 143);
            tbAdresaMagazin.Name = "tbAdresaMagazin";
            tbAdresaMagazin.Size = new Size(100, 23);
            tbAdresaMagazin.TabIndex = 2;
            tbAdresaMagazin.Validating += tbAdresaMagazin_Validating;
            tbAdresaMagazin.Validated += tbAdresaMagazin_Validated;
            // 
            // tbNumeMagazin
            // 
            tbNumeMagazin.Location = new Point(193, 70);
            tbNumeMagazin.Name = "tbNumeMagazin";
            tbNumeMagazin.Size = new Size(100, 23);
            tbNumeMagazin.TabIndex = 1;
            tbNumeMagazin.Validating += tbNumeMagazin_Validating;
            tbNumeMagazin.Validated += tbNumeMagazin_Validated;
            // 
            // lblTitluMagazin
            // 
            lblTitluMagazin.AutoSize = true;
            lblTitluMagazin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitluMagazin.Location = new Point(12, 9);
            lblTitluMagazin.Name = "lblTitluMagazin";
            lblTitluMagazin.Size = new Size(155, 25);
            lblTitluMagazin.TabIndex = 0;
            lblTitluMagazin.Text = "Adauga Magazin";
            // 
            // panelListe
            // 
            panelListe.Controls.Add(btnUpdate);
            panelListe.Controls.Add(btnDelete);
            panelListe.Controls.Add(lblTitluListe);
            panelListe.Controls.Add(dgvListe);
            panelListe.Dock = DockStyle.Fill;
            panelListe.Location = new Point(0, 0);
            panelListe.Name = "panelListe";
            panelListe.Size = new Size(800, 379);
            panelListe.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(632, 345);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(713, 345);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblTitluListe
            // 
            lblTitluListe.AutoSize = true;
            lblTitluListe.Font = new Font("Segoe UI", 14.25F);
            lblTitluListe.Location = new Point(12, 6);
            lblTitluListe.Name = "lblTitluListe";
            lblTitluListe.Size = new Size(95, 25);
            lblTitluListe.TabIndex = 1;
            lblTitluListe.Text = "Magazine";
            // 
            // dgvListe
            // 
            dgvListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListe.ContextMenuStrip = contextStripEntitate;
            dgvListe.Location = new Point(0, 40);
            dgvListe.Name = "dgvListe";
            dgvListe.Size = new Size(797, 299);
            dgvListe.TabIndex = 0;
            dgvListe.CellMouseDown += dgvListe_CellMouseDown;
            // 
            // panelFormDesfacere
            // 
            panelFormDesfacere.Controls.Add(tbIdDesfacere);
            panelFormDesfacere.Controls.Add(dtpDataVanzarii);
            panelFormDesfacere.Controls.Add(nudValoare);
            panelFormDesfacere.Controls.Add(nudCantitate);
            panelFormDesfacere.Controls.Add(tbProdusVandut);
            panelFormDesfacere.Controls.Add(btnAdaugaDesfacere);
            panelFormDesfacere.Controls.Add(lblDataVanzarii);
            panelFormDesfacere.Controls.Add(lblValoare);
            panelFormDesfacere.Controls.Add(lblCantitate);
            panelFormDesfacere.Controls.Add(lblProdusVandut);
            panelFormDesfacere.Controls.Add(cbSelectareRaionDesfacere);
            panelFormDesfacere.Controls.Add(lblSelectareRaionDesfacere);
            panelFormDesfacere.Controls.Add(cbSelectareMagazinDesfacere);
            panelFormDesfacere.Controls.Add(lblSelectareMagazinDesfacere);
            panelFormDesfacere.Controls.Add(lblTitluDesfacere);
            panelFormDesfacere.Dock = DockStyle.Fill;
            panelFormDesfacere.Location = new Point(0, 0);
            panelFormDesfacere.Name = "panelFormDesfacere";
            panelFormDesfacere.Size = new Size(800, 379);
            panelFormDesfacere.TabIndex = 3;
            panelFormDesfacere.Visible = false;
            // 
            // dtpDataVanzarii
            // 
            dtpDataVanzarii.Location = new Point(231, 250);
            dtpDataVanzarii.Name = "dtpDataVanzarii";
            dtpDataVanzarii.Size = new Size(194, 23);
            dtpDataVanzarii.TabIndex = 16;
            // 
            // nudValoare
            // 
            nudValoare.Location = new Point(231, 203);
            nudValoare.Name = "nudValoare";
            nudValoare.Size = new Size(120, 23);
            nudValoare.TabIndex = 15;
            // 
            // nudCantitate
            // 
            nudCantitate.Location = new Point(231, 156);
            nudCantitate.Name = "nudCantitate";
            nudCantitate.Size = new Size(120, 23);
            nudCantitate.TabIndex = 14;
            // 
            // tbProdusVandut
            // 
            tbProdusVandut.Location = new Point(231, 109);
            tbProdusVandut.Name = "tbProdusVandut";
            tbProdusVandut.Size = new Size(120, 23);
            tbProdusVandut.TabIndex = 12;
            // 
            // btnAdaugaDesfacere
            // 
            btnAdaugaDesfacere.Location = new Point(81, 307);
            btnAdaugaDesfacere.Name = "btnAdaugaDesfacere";
            btnAdaugaDesfacere.Size = new Size(75, 23);
            btnAdaugaDesfacere.TabIndex = 11;
            btnAdaugaDesfacere.Text = "Adauga";
            btnAdaugaDesfacere.UseVisualStyleBackColor = true;
            btnAdaugaDesfacere.Click += btnAdaugaDesfacere_Click;
            // 
            // lblDataVanzarii
            // 
            lblDataVanzarii.AutoSize = true;
            lblDataVanzarii.Location = new Point(81, 256);
            lblDataVanzarii.Name = "lblDataVanzarii";
            lblDataVanzarii.Size = new Size(74, 15);
            lblDataVanzarii.TabIndex = 10;
            lblDataVanzarii.Text = "Data Vanzarii";
            // 
            // lblValoare
            // 
            lblValoare.AutoSize = true;
            lblValoare.Location = new Point(81, 205);
            lblValoare.Name = "lblValoare";
            lblValoare.Size = new Size(45, 15);
            lblValoare.TabIndex = 9;
            lblValoare.Text = "Valoare";
            // 
            // lblCantitate
            // 
            lblCantitate.AutoSize = true;
            lblCantitate.Location = new Point(81, 158);
            lblCantitate.Name = "lblCantitate";
            lblCantitate.Size = new Size(55, 15);
            lblCantitate.TabIndex = 8;
            lblCantitate.Text = "Cantitate";
            // 
            // lblProdusVandut
            // 
            lblProdusVandut.AutoSize = true;
            lblProdusVandut.Location = new Point(81, 112);
            lblProdusVandut.Name = "lblProdusVandut";
            lblProdusVandut.Size = new Size(84, 15);
            lblProdusVandut.TabIndex = 7;
            lblProdusVandut.Text = "Produs Vandut";
            // 
            // cbSelectareRaionDesfacere
            // 
            cbSelectareRaionDesfacere.FormattingEnabled = true;
            cbSelectareRaionDesfacere.Location = new Point(535, 62);
            cbSelectareRaionDesfacere.Name = "cbSelectareRaionDesfacere";
            cbSelectareRaionDesfacere.Size = new Size(121, 23);
            cbSelectareRaionDesfacere.TabIndex = 6;
            // 
            // lblSelectareRaionDesfacere
            // 
            lblSelectareRaionDesfacere.AutoSize = true;
            lblSelectareRaionDesfacere.Location = new Point(400, 65);
            lblSelectareRaionDesfacere.Name = "lblSelectareRaionDesfacere";
            lblSelectareRaionDesfacere.Size = new Size(87, 15);
            lblSelectareRaionDesfacere.TabIndex = 5;
            lblSelectareRaionDesfacere.Text = "Selectare Raion";
            // 
            // cbSelectareMagazinDesfacere
            // 
            cbSelectareMagazinDesfacere.FormattingEnabled = true;
            cbSelectareMagazinDesfacere.Location = new Point(231, 62);
            cbSelectareMagazinDesfacere.Name = "cbSelectareMagazinDesfacere";
            cbSelectareMagazinDesfacere.Size = new Size(121, 23);
            cbSelectareMagazinDesfacere.TabIndex = 4;
            cbSelectareMagazinDesfacere.Validating += cbSelectareMagazinDesfacere_Validating;
            cbSelectareMagazinDesfacere.Validated += cbSelectareMagazinDesfacere_Validated;
            // 
            // lblSelectareMagazinDesfacere
            // 
            lblSelectareMagazinDesfacere.AutoSize = true;
            lblSelectareMagazinDesfacere.Location = new Point(81, 65);
            lblSelectareMagazinDesfacere.Name = "lblSelectareMagazinDesfacere";
            lblSelectareMagazinDesfacere.Size = new Size(102, 15);
            lblSelectareMagazinDesfacere.TabIndex = 3;
            lblSelectareMagazinDesfacere.Text = "Selectare Magazin";
            // 
            // lblTitluDesfacere
            // 
            lblTitluDesfacere.AutoSize = true;
            lblTitluDesfacere.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitluDesfacere.Location = new Point(12, 9);
            lblTitluDesfacere.Name = "lblTitluDesfacere";
            lblTitluDesfacere.Size = new Size(165, 25);
            lblTitluDesfacere.TabIndex = 2;
            lblTitluDesfacere.Text = "Adauga Desfacere";
            // 
            // comertDbContextBindingSource
            // 
            comertDbContextBindingSource.DataSource = typeof(ComertApp.Entities.ComertDbContext);
            // 
            // magazinBindingSource
            // 
            magazinBindingSource.DataSource = typeof(ComertApp.Entities.Magazin);
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // raionBindingSource
            // 
            raionBindingSource.DataSource = typeof(ComertApp.Entities.Raion);
            // 
            // tbIdDesfacere
            // 
            tbIdDesfacere.Location = new Point(183, 9);
            tbIdDesfacere.Name = "tbIdDesfacere";
            tbIdDesfacere.Size = new Size(100, 23);
            tbIdDesfacere.TabIndex = 17;
            tbIdDesfacere.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContainer);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextStripEntitate.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panelFormRaion.ResumeLayout(false);
            panelFormRaion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumarAngajati).EndInit();
            panelFormMagazin.ResumeLayout(false);
            panelFormMagazin.PerformLayout();
            panelListe.ResumeLayout(false);
            panelListe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListe).EndInit();
            panelFormDesfacere.ResumeLayout(false);
            panelFormDesfacere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudValoare).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantitate).EndInit();
            ((System.ComponentModel.ISupportInitialize)comertDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)magazinBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)raionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem raportToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdaugaMagazinToolStrip;
        private ToolStripButton btnAdaugaRaionToolStrip;
        private ToolStripButton btnAdaugaDesfacereToolStrip;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripMenuItem exportRaportTXTToolStripMenuItem;
        private ToolStripMenuItem adaugaMagazinToolStripMenuItem;
        private ToolStripMenuItem printeazaFisaMagazinToolStripMenuItem;
        private ContextMenuStrip contextStripEntitate;
        private ToolStripMenuItem cmiSterge;
        private ToolStripMenuItem cmiEditare;
        private ToolStripMenuItem cmiCopiaza;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnListaMagazineToolStrip;
        private ToolStripButton btnListaRaioaneToolStrip;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnListaDesfaceriToolStrip;
        private Panel panelContainer;
        private DataGridView dgvListe;
        private Panel panelFormMagazin;
        private Label lblTitluMagazin;
        private Label lblAdresaMagazin;
        private Label lblNumeMagazin;
        private TextBox tbAdresaMagazin;
        private TextBox tbNumeMagazin;
        private Button btnAdaugaMagazin;
        private Panel panelFormRaion;
        private Label lblTitluRaion;
        private ComboBox cbMagazinRaion;
        private Label lblNumarAngajati;
        private Label lblNumeRaion;
        private Label lblSelectareMagazinRaion;
        private TextBox tbNumeRaion;
        private NumericUpDown nudNumarAngajati;
        private Button btnAdaugaRaion;
        private Panel panelFormDesfacere;
        private Label lblTitluDesfacere;
        private ComboBox cbSelectareMagazinDesfacere;
        private Label lblSelectareMagazinDesfacere;
        private ComboBox cbSelectareRaionDesfacere;
        private Label lblSelectareRaionDesfacere;
        private Label lblValoare;
        private Label lblCantitate;
        private Label lblProdusVandut;
        private Label lblDataVanzarii;
        private Button btnAdaugaDesfacere;
        private TextBox tbProdusVandut;
        private DateTimePicker dtpDataVanzarii;
        private NumericUpDown nudValoare;
        private NumericUpDown nudCantitate;
        private ErrorProvider errorProvider;
        private BindingSource raionBindingSource;
        private BindingSource magazinBindingSource;
        private BindingSource comertDbContextBindingSource;
        private TextBox tbIdMagazin;
        private Panel panelListe;
        private Label lblTitluListe;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox tbIdRaion;
        private TextBox tbIdDesfacere;
    }
}
