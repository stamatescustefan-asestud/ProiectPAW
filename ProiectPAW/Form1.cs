using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using ComertApp.Custom_Exceptions;
using ComertApp.Entities;
using ComertApp.Forms;
using ComertApp.Models;
using ComertControls;
using Microsoft.EntityFrameworkCore;

namespace ProiectPAW
{
    public partial class Form1 : Form
    {
        ComertDbContext ctx;
        private int magazinCurentIndex;
        private List<Magazin> magazineDePrintat;
        private StatusBarControl statusBarControl;

        public Form1()
        {
            InitializeComponent();
            statusBarControl = new StatusBarControl();
            statusBarControl.Dock = DockStyle.Bottom;
            this.Controls.Add(statusBarControl);
            ctx = new ComertDbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaMagazine();
            RefreshStatusBar();
        }

        #region StatusBarControlRefresh
        private void RefreshStatusBar()
        {
            int totalMagazine = ctx.Magazine.Count();
            int totalRaioane = ctx.Raioane.Count();
            int totalDesfaceri = ctx.Desfaceri.Count();

            statusBarControl.Refresh(totalMagazine, totalRaioane, totalDesfaceri);
        }
        #endregion

        #region toolstrip
        private void AfiseazaMagazine()
        {
            foreach (Control c in panelContainer.Controls)
            {
                c.Visible = false;
            }

            lblTitluListe.Text = "Magazine";
            dgvListe.DataSource = ctx.Magazine.ToList();

            panelListe.Visible = true;
        }
        private void AfiseazaRaioane()
        {

            foreach (Control c in panelContainer.Controls)
            {
                c.Visible = false;
            }

            lblTitluListe.Text = "Raioane";
            dgvListe.DataSource = ctx.Raioane
                .Include(r => r.Magazin)
                .Select(r => new RaionViewModel
                {
                    IdRaion = r.IdRaion,
                    NumeRaion = r.Nume,
                    NumarAngajati = r.NumarAngajati,
                    NumeMagazin = r.Magazin.Nume
                })
                .ToList();

            panelListe.Visible = true;
        }
        private void AfiseazaDesfaceri()
        {

            foreach (Control c in panelContainer.Controls)
            {
                c.Visible = false;
            }

            lblTitluListe.Text = "Desfaceri";
            dgvListe.DataSource = ctx.Desfaceri
                .Include(d => d.Raion)
                .ThenInclude(r => r.Magazin)
                .Select(d => new DesfacereViewModel
                {
                    IdDesfacere = d.IdDesfacere,
                    ProdusVandut = d.ProdusVandut,
                    Cantitate = d.Cantitate,
                    Valoare = d.Valoare,
                    DataVanzarii = d.DataVanzarii,
                    NumeRaion = d.Raion.Nume,
                    NumeMagazin = d.Raion.Magazin.Nume
                })
                .ToList();

            panelListe.Visible = true;
        }
        private void btnListaMagazineToolStrip_Click(object sender, EventArgs e)
        {
            AfiseazaMagazine();
        }

        private void btnAdaugaMagazinToolStrip_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelContainer.Controls)
            {
                c.Visible = false;
            }

            tbNumeMagazin.Clear();
            tbAdresaMagazin.Clear();
            tbIdMagazin.Text = "0";
            btnAdaugaMagazin.Text = "Adauga";
            panelFormMagazin.Visible = true;
        }

        private void btnAdaugaRaionToolStrip_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelContainer.Controls)
            {
                c.Visible = false;
            }

            tbNumeRaion.Clear();
            nudNumarAngajati.Value = 0;
            tbIdRaion.Text = "0";

            btnAdaugaRaion.Text = "Adauga";

            cbMagazinRaion.DataSource = ctx.Magazine.Select(m => new { Nume = m.Nume, Valoare = m.IdMagazin }).ToList();
            cbMagazinRaion.DisplayMember = "Nume";
            cbMagazinRaion.ValueMember = "Valoare";

            panelFormRaion.Visible = true;
        }

        private void btnAdaugaDesfacereToolStrip_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelContainer.Controls)
            {
                c.Visible = false;
            }

            tbIdDesfacere.Text = "0";
            tbProdusVandut.Clear();
            nudCantitate.Value = 0;
            nudValoare.Value = 0;
            dtpDataVanzarii.Value = DateTime.Now;

            var ceva = ctx.Magazine.Select(m => new { NumeMagazin = m.Nume, Valoare = m.IdMagazin }).ToList();
            cbSelectareMagazinDesfacere.DataSource = ceva;
            cbSelectareMagazinDesfacere.DisplayMember = "NumeMagazin";
            cbSelectareMagazinDesfacere.ValueMember = "Valoare";

            var magazinSelectat = ceva[0].Valoare;

            cbSelectareRaionDesfacere.DataSource = ctx.Raioane.Where(r => magazinSelectat == r.IdMagazin)
                .Select(n => new { NumeRaion = n.Nume, Valoare = n.IdRaion }).ToList();
            cbSelectareRaionDesfacere.DisplayMember = "NumeRaion";
            cbSelectareRaionDesfacere.ValueMember = "Valoare";

            btnAdaugaDesfacere.Text = "Adauga";

            panelFormDesfacere.Visible = true;
        }

        private void btnListaRaioaneToolStrip_Click(object sender, EventArgs e)
        {
            AfiseazaRaioane();
        }

        private void btnListaDesfaceriToolStrip_Click(object sender, EventArgs e)
        {
            AfiseazaDesfaceri();
        }

        private void tsmiSerializare_Click(object sender, EventArgs e)
        {
            SerializeazaMagazine();
        }

        private void tsmiDeserializare_Click(object sender, EventArgs e)
        {
            DeserializareMagazine();
        }
        private void adaugaMagazinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportRaport();
        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = ctx.Magazine.Select(m => new { m.Nume, Total = m.ListaRaioane.SelectMany(r => r.Desfaceri).Sum(d => (float)d.Valoare) })
                .AsEnumerable()
                .Select(x => new BarChartValue(x.Nume, x.Total))
                .ToArray();
            var form = new FormGrafic();
            form.barChartControl.Data = data;
            form.Show();
        }

        private void printeazaFisaMagazinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region AdaugaMagazin
        private void tbNumeMagazin_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsNumeMagazinValid())
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Name is empty or already in use.");
            }
        }

        private void tbNumeMagazin_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private bool IsNumeMagazinValid()
        {
            var numeMagazin = tbNumeMagazin.Text;
            if (string.IsNullOrEmpty(numeMagazin)) { return false; }
            if (ctx.Magazine.Any(m => m.Nume == numeMagazin)) { return false; }
            return true;
        }

        private void tbAdresaMagazin_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsAdresaMagazinValid())
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Name is empty or already in use.");
            }
        }

        private void tbAdresaMagazin_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private bool IsAdresaMagazinValid()
        {
            var adresaMagazin = tbAdresaMagazin.Text;
            if (string.IsNullOrEmpty(adresaMagazin)) { return false; }
            return true;
        }

        private void btnAdaugaMagazin_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Visible))
            {
                MessageBox.Show("The form contains errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(tbIdMagazin.Text) == 0)
            {

                try
                {
                    string numeMagazin = tbNumeMagazin.Text.Trim();
                    string adresaMagazin = tbAdresaMagazin.Text.Trim();
                    var magazin = new Magazin
                    {
                        Nume = numeMagazin,
                        Adresa = adresaMagazin
                    };

                    ctx.Magazine.Add(magazin);
                    ctx.SaveChanges();
                    lblStatus.Text = "Magazin adaugat cu succes!";
                    AfiseazaMagazine();
                    RefreshStatusBar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    var id = int.Parse(tbIdMagazin.Text);
                    var magazin = ctx.Magazine.Where(m => m.IdMagazin == id).FirstOrDefault();
                    magazin.Nume = tbNumeMagazin.Text.Trim();
                    magazin.Adresa = tbAdresaMagazin.Text.Trim();
                    ctx.Magazine.Update(magazin);
                    ctx.SaveChanges();
                    lblStatus.Text = "Magazin editat cu succes!";
                    AfiseazaMagazine();
                    RefreshStatusBar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region AdaugaRaion
        private void cbMagazinRaion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsIdMagazinValid())
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Please select a shop from the list!");
            }
        }

        private void cbMagazinRaion_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
            if (!string.IsNullOrEmpty(tbNumeRaion.Text))
            {
                tbNumeRaion_Validating(tbNumeRaion, new System.ComponentModel.CancelEventArgs());
            }
        }

        private void tbNumeRaion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsNumeRaionValid())
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Name is empty or already in use.");
            }
        }

        private void tbNumeRaion_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private bool IsNumeRaionValid()
        {
            var numeRaion = tbNumeRaion.Text;
            var magazinSelectat = cbMagazinRaion.SelectedValue;
            var idMagazin = -1;
            if (magazinSelectat != null)
            {
                idMagazin = (int)magazinSelectat;
            }
            if (string.IsNullOrEmpty(numeRaion)) { return false; }
            if (ctx.Raioane.Any(r => r.Nume == numeRaion && r.IdMagazin == idMagazin && idMagazin > 0)) { return false; }
            return true;
        }

        private bool IsIdMagazinValid()
        {
            var valoareSelectata = cbMagazinRaion.SelectedValue;
            if (valoareSelectata == null)
            {
                return false;
            }

            var magazinulSelectat = ctx.Magazine.Where(m => (int)valoareSelectata == m.IdMagazin).FirstOrDefault();

            if (magazinulSelectat == null)
            {
                return false;
            }

            return true;
        }
        private void nudNumarAngajati_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsNumarAngajatiValid())
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Name is empty or already in use.");
            }
        }

        private void nudNumarAngajati_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private bool IsNumarAngajatiValid()
        {
            var numarAngajati = nudNumarAngajati.Value;
            if (numarAngajati != Math.Abs(numarAngajati) || numarAngajati <= 0) { return false; }
            return true;
        }

        private void btnAdaugaRaion_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Visible))
            {
                MessageBox.Show("The form contains errors!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(tbIdRaion.Text) == 0)
            {
                try
                {
                    var idMagazin = (int)cbMagazinRaion.SelectedValue;
                    var numeRaion = tbNumeRaion.Text.Trim();
                    var numarAngajati = (int)nudNumarAngajati.Value;
                    Raion raion = new Raion
                    {
                        IdMagazin = idMagazin,
                        Nume = numeRaion,
                        NumarAngajati = numarAngajati
                    };
                    ctx.Raioane.Add(raion);
                    ctx.SaveChanges();
                    lblStatus.Text = "Raion adaugat cu succes!";
                    AfiseazaRaioane();
                    RefreshStatusBar();
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
            else
            {
                try
                {
                    var idRaion = int.Parse(tbIdRaion.Text);
                    var raion = ctx.Raioane.Where(r => r.IdRaion == idRaion).FirstOrDefault();
                    raion.Nume = tbNumeRaion.Text.Trim();
                    raion.NumarAngajati = (int)nudNumarAngajati.Value;
                    raion.IdMagazin = (int)cbMagazinRaion.SelectedValue;
                    ctx.Raioane.Update(raion);
                    ctx.SaveChanges();
                    lblStatus.Text = "Raion editat cu succes!";
                    AfiseazaRaioane();
                    RefreshStatusBar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region AdaugaDesfacere
        private void cbSelectareMagazinDesfacere_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsIdMagazinDesfacereValid())
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Please select a shop from the list!");
            }
        }

        private void cbSelectareMagazinDesfacere_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);

            var magazinSelectat = (int)cbSelectareMagazinDesfacere.SelectedValue;

            cbSelectareRaionDesfacere.DataSource = ctx.Raioane.Where(r => magazinSelectat == r.IdMagazin).Select(n => new { NumeRaion = n.Nume, Valoare = n.IdRaion }).ToList();
            cbSelectareRaionDesfacere.DisplayMember = "NumeRaion";
            cbSelectareRaionDesfacere.ValueMember = "Valoare";
        }

        private void cbSelectareRaionDesfacere_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsIdRaionDesfacereValid())
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Please select a department from the list!");
            }
        }

        private void cbSelectareRaionDesfacere_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void tbProdusVandut_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsProdusVandutValid())
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Product name is empty or invalid.");
            }
        }

        private void tbProdusVandut_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void nudCantitate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsCantitateValid())
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Name is empty or already in use.");
            }
        }

        private void nudCantitate_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private bool IsCantitateValid()
        {
            var cantitate = nudCantitate.Value;
            if (cantitate != Math.Abs(cantitate) || cantitate <= 0) { return false; }
            return true;
        }

        private void nudValoare_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsValoareValid())
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Name is empty or already in use.");
            }
        }

        private void nudValoare_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private bool IsValoareValid()
        {
            var valoare = nudValoare.Value;
            if (valoare <= 0) { return false; }
            return true;
        }

        private bool IsProdusVandutValid()
        {
            var numeProdus = tbProdusVandut.Text;
            if (string.IsNullOrEmpty(numeProdus)) { return false; }
            return true;
        }

        private bool IsIdMagazinDesfacereValid()
        {
            var valoareSelectata = cbSelectareMagazinDesfacere.SelectedValue;
            if (valoareSelectata == null)
            {
                return false;
            }

            var magazinulSelectat = ctx.Magazine.Where(m => (int)valoareSelectata == m.IdMagazin).FirstOrDefault();

            if (magazinulSelectat == null)
            {
                return false;
            }

            return true;
        }

        private bool IsIdRaionDesfacereValid()
        {
            var valoareSelectata = cbSelectareRaionDesfacere.SelectedValue;
            if (valoareSelectata == null)
            {
                return false;
            }

            var raionulSelectat = ctx.Raioane.Where(r => (int)valoareSelectata == r.IdRaion).FirstOrDefault();

            if (raionulSelectat == null)
            {
                return false;
            }

            return true;
        }

        private void btnAdaugaDesfacere_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Visible))
            {
                MessageBox.Show("The form contains errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(tbIdDesfacere.Text) == 0)
            {
                try
                {
                    var idRaion = (int)cbSelectareRaionDesfacere.SelectedValue;
                    var numeProdus = tbProdusVandut.Text;
                    var cantitate = nudCantitate.Value;
                    var valoare = nudValoare.Value;
                    var dataVanzare = dtpDataVanzarii.Value;

                    var desfacere = new Desfacere
                    {
                        IdRaion = idRaion,
                        ProdusVandut = numeProdus,
                        Cantitate = (int)cantitate,
                        Valoare = valoare,
                        DataVanzarii = DateOnly.FromDateTime(dataVanzare)
                    };

                    ctx.Desfaceri.Add(desfacere);
                    ctx.SaveChanges();
                    lblStatus.Text = "Desfacere adaugata cu succes!";
                    AfiseazaDesfaceri();
                    RefreshStatusBar();
                }
                catch (InvalidSaleDateException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    var idDesfacere = int.Parse(tbIdDesfacere.Text);
                    var desfacere = ctx.Desfaceri.Where(d => d.IdDesfacere == idDesfacere).FirstOrDefault();
                    desfacere.IdRaion = (int)cbSelectareRaionDesfacere.SelectedValue;
                    desfacere.ProdusVandut = tbProdusVandut.Text;
                    desfacere.Cantitate = (int)nudCantitate.Value;
                    desfacere.Valoare = nudValoare.Value;
                    desfacere.DataVanzarii = DateOnly.FromDateTime(dtpDataVanzarii.Value);

                    ctx.Desfaceri.Update(desfacere);
                    ctx.SaveChanges();
                    lblStatus.Text = "Desfacere editata cu succes!";
                    AfiseazaDesfaceri();
                    RefreshStatusBar();
                }
                catch (InvalidSaleDateException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region EditareStergereCopiere
        private void cmiSterge_Click(object sender, EventArgs e)
        {
            var entitate = dgvListe.SelectedRows[0].DataBoundItem;
            if (entitate is Magazin m)
            {
                ctx.Magazine.Remove(m);
                ctx.SaveChanges();
                lblStatus.Text = "Magazin sters cu succes!";
                AfiseazaMagazine();
                RefreshStatusBar();
            }
            else if (entitate is RaionViewModel rvm)
            {
                var r = ctx.Raioane.Where(r => r.IdRaion == rvm.IdRaion).FirstOrDefault();
                ctx.Raioane.Remove(r);
                ctx.SaveChanges();
                lblStatus.Text = "Raion sters cu succes!";
                AfiseazaRaioane();
                RefreshStatusBar();
            }
            else if (entitate is Desfacere d)
            {
                ctx.Desfaceri.Remove(d);
                ctx.SaveChanges();
                lblStatus.Text = "Desfacere stearsa cu succes!";
                AfiseazaDesfaceri();
                RefreshStatusBar();
            }
        }

        private void cmiEditare_Click(object sender, EventArgs e)
        {
            var entitate = dgvListe.SelectedRows[0].DataBoundItem;
            if (entitate is Magazin m)
            {
                editareMagazin(m);
            }
            else if (entitate is RaionViewModel rvm)
            {
                var r = ctx.Raioane.Where(r => r.IdRaion == rvm.IdRaion).FirstOrDefault();
                editareRaion(r);
            }
            else if (entitate is DesfacereViewModel dvm)
            {
                var d = ctx.Desfaceri.Where(d => d.IdDesfacere == dvm.IdDesfacere).Include(d => d.Raion).FirstOrDefault();
                editareDesfacere(d);
            }
        }

        private void editareMagazin(Magazin m)
        {
            foreach (Control c in panelContainer.Controls)
            {
                c.Visible = false;
            }

            tbNumeMagazin.Text = m.Nume;
            tbAdresaMagazin.Text = m.Adresa;
            tbIdMagazin.Text = m.IdMagazin.ToString();

            btnAdaugaMagazin.Text = "Editare";

            panelFormMagazin.Visible = true;
        }

        private void editareRaion(Raion r)
        {
            foreach (Control c in panelContainer.Controls)
            {
                c.Visible = false;
            }

            tbNumeRaion.Text = r.Nume;
            nudNumarAngajati.Text = r.NumarAngajati.ToString();
            tbIdRaion.Text = r.IdRaion.ToString();

            btnAdaugaRaion.Text = "Editare";

            cbMagazinRaion.DataSource = ctx.Magazine.Select(m => new { Nume = m.Nume, Valoare = m.IdMagazin }).ToList();
            cbMagazinRaion.DisplayMember = "Nume";
            cbMagazinRaion.ValueMember = "Valoare";
            cbMagazinRaion.SelectedValue = r.IdMagazin;

            panelFormRaion.Visible = true;
        }

        private void editareDesfacere(Desfacere d)
        {
            foreach (Control c in panelContainer.Controls)
            {
                c.Visible = false;
            }

            tbIdDesfacere.Text = d.IdDesfacere.ToString();
            tbProdusVandut.Text = d.ProdusVandut;
            nudCantitate.Value = d.Cantitate;
            nudValoare.Value = d.Valoare;
            dtpDataVanzarii.Value = d.DataVanzarii.ToDateTime(TimeOnly.FromDateTime(DateTime.Now));

            cbSelectareMagazinDesfacere.DataSource = ctx.Magazine.Select(m => new { Nume = m.Nume, Valoare = m.IdMagazin }).ToList();
            cbSelectareMagazinDesfacere.DisplayMember = "Nume";
            cbSelectareMagazinDesfacere.ValueMember = "Valoare";
            cbSelectareMagazinDesfacere.SelectedValue = d.Raion.IdMagazin;

            cbSelectareRaionDesfacere.DataSource = ctx.Raioane.Where(r => r.IdMagazin == d.Raion.IdMagazin)
                .Select(n => new { NumeRaion = n.Nume, Valoare = n.IdRaion }).ToList();
            cbSelectareRaionDesfacere.DisplayMember = "NumeRaion";
            cbSelectareRaionDesfacere.ValueMember = "Valoare";
            cbSelectareRaionDesfacere.SelectedValue = d.IdRaion;

            btnAdaugaDesfacere.Text = "Editare";

            panelFormDesfacere.Visible = true;

        }

        private void dgvListe_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvListe.ClearSelection();

                dgvListe.Rows[e.RowIndex].Selected = true;

                dgvListe.CurrentCell = dgvListe.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void cmiCopiaza_Click(object sender, EventArgs e)
        {
            var data = dgvListe.GetClipboardContent();
            if (data != null)
            {
                Clipboard.SetDataObject(data);
            }
            lblStatus.Text = "Date copiate cu succes!";
        }
        #endregion

        #region SerializareSiDeserializare
        private void SerializeazaMagazine()
        {
            var magazine = ctx.Magazine.Include(m => m.ListaRaioane).ThenInclude(r => r.Desfaceri).ToList();
            using (FileStream stream = File.Create("magazine.json"))
            {
                JsonSerializer.Serialize(stream, magazine, new JsonSerializerOptions { WriteIndented = true });
            }
            lblStatus.Text = "Magazine serializate cu succes!";
        }

        private void DeserializareMagazine()
        {
            using (FileStream stream = File.OpenRead("magazine.json"))
            {
                var magazine = JsonSerializer.Deserialize<List<Magazin>>(stream);

                if (magazine != null)
                {
                    foreach (var m in magazine)
                    {
                        var magazinExistent = ctx.Magazine.FirstOrDefault(x => x.IdMagazin == m.IdMagazin);

                        if (magazinExistent == null)
                        {
                            m.IdMagazin = 0;
                            foreach (var r in m.ListaRaioane ?? [])
                            {
                                r.IdRaion = 0;
                                foreach (var d in r.Desfaceri ?? [])
                                {
                                    d.IdDesfacere = 0;
                                }
                            }
                            ctx.Magazine.Add(m);
                        }
                        else
                        {
                            magazinExistent.Nume = m.Nume;
                            magazinExistent.Adresa = m.Adresa;
                            ctx.Magazine.Update(magazinExistent);
                        }
                    }
                    ctx.SaveChanges();
                    AfiseazaMagazine();
                    lblStatus.Text = "Magazine deserializate cu succes!";
                }
            }
        }
        #endregion

        #region ExportRaportText
        private void ExportRaport()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("IdMagazin, Nume, Adresa");
                    foreach (var m in ctx.Magazine.ToList())
                    {
                        sw.WriteLine("\"{0}\", \"{1}\", \"{2}\"",
                            m.IdMagazin,
                            m.Nume.Replace("\"", "\"\""),
                            m.Adresa.Replace("\"", "\"\""));
                    }
                }

                lblStatus.Text = "Raport magazine exportat in format txt cu succes!";
            }
        }
        #endregion

        #region Print
        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            magazinCurentIndex = 0;
            magazineDePrintat = ctx.Magazine.ToList();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 12);
            Font fontHeader = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            var pageSettings = e.PageSettings;
            var printAreaHeight = e.MarginBounds.Height;
            var printAreaWidth = e.MarginBounds.Width;
            var marginLeft = pageSettings.Margins.Left;
            var marginTop = pageSettings.Margins.Top;

            if (pageSettings.Landscape)
            {
                var temp = printAreaHeight;
                printAreaHeight = printAreaWidth;
                printAreaWidth = temp;
            }

            const int rowHeight = 40;
            var columnWidth = printAreaWidth / 3;

            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;
            e.Graphics.DrawString("ID", fontHeader, Brushes.Black, new RectangleF(marginLeft, currentY, columnWidth, rowHeight), fmt);
            e.Graphics.DrawString("Nume", fontHeader, Brushes.Black, new RectangleF(marginLeft + columnWidth, currentY, columnWidth, rowHeight), fmt);
            e.Graphics.DrawString("Adresa", fontHeader, Brushes.Black, new RectangleF(marginLeft + 2 * columnWidth, currentY, columnWidth, rowHeight), fmt);

            e.Graphics.DrawRectangle(Pens.Black, marginLeft, currentY, columnWidth, rowHeight);
            e.Graphics.DrawRectangle(Pens.Black, marginLeft + columnWidth, currentY, columnWidth, rowHeight);
            e.Graphics.DrawRectangle(Pens.Black, marginLeft + 2 * columnWidth, currentY, columnWidth, rowHeight);

            currentY += rowHeight;

            while (magazinCurentIndex < magazineDePrintat.Count)
            {
                var currentX = marginLeft;
                var m = magazineDePrintat[magazinCurentIndex];

                e.Graphics.DrawRectangle(Pens.Black, currentX, currentY, columnWidth, rowHeight);
                e.Graphics.DrawString(m.IdMagazin.ToString(), font, Brushes.Black, new RectangleF(currentX, currentY, columnWidth, rowHeight), fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(Pens.Black, currentX, currentY, columnWidth, rowHeight);
                e.Graphics.DrawString(m.Nume, font, Brushes.Black, new RectangleF(currentX, currentY, columnWidth, rowHeight), fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(Pens.Black, currentX, currentY, columnWidth, rowHeight);
                e.Graphics.DrawString(m.Adresa, font, Brushes.Black, new RectangleF(currentX, currentY, columnWidth, rowHeight), fmt);
                currentX += columnWidth;

                magazinCurentIndex++;
                currentY += rowHeight;

                if (currentY + rowHeight > marginTop + printAreaHeight)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
            e.HasMorePages = false;
        }
        #endregion
    }
}