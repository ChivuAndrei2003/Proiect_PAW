using Proiect_PAW_Chivu_Evelyn_Andrei.Entities;
using System.ComponentModel;
using System.Drawing.Printing;

namespace Proiect_PAW_Chivu_Evelyn_Andrei
{
    public partial class AdressForm : Form
    {
        #region Attributes
        private BindingList<Adress> _addresses;

        private int _currentAddressPrintIndex;
        #endregion

        public AdressForm()
        {
            InitializeComponent();

            _addresses = new BindingList<Adress>();

            dataGridView1.DataSource = _addresses;
            UpdateStatusStrip();
        }


        private Adress? GetSelectedAddress()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return null;
            }

            return dataGridView1.SelectedRows[0].DataBoundItem as Adress;
        }

        private void ValidateCity()
        {
            if (string.IsNullOrWhiteSpace(textbox_Nume_Oras.Text))
            {
                throw new InvalidAddressException("Orasul este obligatoriu.");
            }
        }

        private void textbox_Nume_Oras_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                ValidateCity();
                errorProvider1.SetError(textbox_Nume_Oras, "");
                e.Cancel = false;
            }
            catch (InvalidAddressException ex)
            {
                errorProvider1.SetError(textbox_Nume_Oras, ex.Message);
                e.Cancel = true;
            }
        }

        private void textBox_Strada_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_Strada_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Strada.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox_Strada, "Strada este obligatorie");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox_Strada, "");
            }
        }

        private void textBox_Numar_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Numar.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox_Numar, "Numarul este obligatoriu.");
            }
            else if (!int.TryParse(textBox_Numar.Text, out int numar) || numar <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox_Numar, "Numarul trebuie sa fie un numar pozitiv.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox_Numar, "");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Corecteaza erorile inainte de salvare");
                return;
            }

            Client client = new Client(0, "", "", new List<Comanda>());
            Adress address = new Adress(_addresses.Count + 1, textbox_Nume_Oras.Text, textBox_Strada.Text,
                textBox_Numar.Text, client);
            address.status = comboBox1.Text;

            _addresses.Add(address);
            UpdateStatusStrip();
        }

        private void btn_Main_Page_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Update_Click(object? sender, EventArgs e)
        {
            Adress? address = GetSelectedAddress();

            if (address == null)
            {
                MessageBox.Show("Alege o adresa");
                return;
            }

            if (!ValidateChildren())
            {
                MessageBox.Show("Corecteaza erorile inainte de salvare!!!");
                return;
            }

            address.oras = textbox_Nume_Oras.Text;
            address.strada = textBox_Strada.Text;
            address.numar = textBox_Numar.Text;
            address.status = comboBox1.Text;

            dataGridView1.Refresh();
            UpdateStatusStrip();
        }

        private void btn_Delete_Click(object? sender, EventArgs e)
        {
            Adress? address = GetSelectedAddress();

            if (address == null)
            {
                MessageBox.Show("Alege o adresa");
                return;
            }

            if (MessageBox.Show("Stergi adresa selectata?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes)
            {
                _addresses.Remove(address);
                UpdateStatusStrip();
            }
        }

        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            Adress? address = GetSelectedAddress();

            if (address == null)
            {
                return;
            }

            textbox_Nume_Oras.Text = address.oras;
            textBox_Strada.Text = address.strada;
            textBox_Numar.Text = address.numar;
            comboBox1.Text = address.status;
            UpdateStatusStrip();
        }

        private void btn_preview_print_Click(object sender, EventArgs e)
        {
            if (_addresses.Count == 0)
            {
                MessageBox.Show("Nu exista adrese de printat.");
                return;
            }

            try
            {
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Nu se poate incarca Print Preview. Verifica daca ai acces la o imprimanta.");
            }
        }

        private void AdressForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_print_Click_Click(object sender, EventArgs e)
        {
            if (_addresses.Count == 0)
            {
                MessageBox.Show("Nu exista adrese de printat.");
                return;
            }

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btn_CopySelected_Click(object sender, EventArgs e)
        {
            Adress? address = GetSelectedAddress();

            if (address == null)
            {
                MessageBox.Show("Alege o adresa");
                return;
            }

            Clipboard.SetText(FormatAddress(address));
            UpdateStatusStrip("Adresa selectata a fost copiata in Clipboard.");
        }

        private void tOCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV File|*.csv";
            saveFileDialog.Title = "Export adrese";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter writer = new StreamWriter(saveFileDialog.FileName);
                writer.WriteLine("Oras,Strada,Numar,Status");

                foreach (Adress address in _addresses)
                {
                    writer.WriteLine("{0},{1},{2},{3}",
                        EscapeCsv(address.oras),
                        EscapeCsv(address.strada),
                        EscapeCsv(address.numar),
                        EscapeCsv(address.status));
                }

                UpdateStatusStrip($"Export CSV finalizat: {_addresses.Count} adrese.");
            }
        }

        private void printDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            _currentAddressPrintIndex = 0;
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            using Font titleFont = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            using Font headerFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            using Font rowFont = new Font("Microsoft Sans Serif", 10);

            int marginLeft = e.MarginBounds.Left;
            int marginTop = e.MarginBounds.Top;
            int printAreaWidth = e.MarginBounds.Width;
            int printAreaHeight = e.MarginBounds.Height;
            Graphics? graphics = e.Graphics;

            if (graphics == null)
            {
                return;
            }

            int currentY = marginTop;
            graphics.DrawString("Raport adrese livrare", titleFont, Brushes.Black, marginLeft, currentY);
            currentY += 45;

            int rowHeight = 32;
            int[] columnWidths =
            {
                printAreaWidth * 25 / 100,
                printAreaWidth * 35 / 100,
                printAreaWidth * 15 / 100,
                printAreaWidth * 25 / 100
            };

            DrawPrintRow(graphics, headerFont, new[] { "Oras", "Strada", "Numar", "Status" },
                marginLeft, currentY, rowHeight, columnWidths, true);
            currentY += rowHeight;

            while (_currentAddressPrintIndex < _addresses.Count)
            {
                if (currentY - marginTop + rowHeight > printAreaHeight)
                {
                    e.HasMorePages = true;
                    return;
                }

                Adress address = _addresses[_currentAddressPrintIndex];
                DrawPrintRow(graphics, rowFont,
                    new[] { address.oras, address.strada, address.numar, address.status },
                    marginLeft, currentY, rowHeight, columnWidths, false);

                _currentAddressPrintIndex++;
                currentY += rowHeight;
            }

            e.HasMorePages = false;
        }

        private static void DrawPrintRow(Graphics graphics, Font font, string[] values, int x, int y,
            int rowHeight, int[] columnWidths, bool isHeader)
        {
            StringFormat format = new StringFormat(StringFormatFlags.LineLimit);
            format.Trimming = StringTrimming.EllipsisCharacter;
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Center;

            int currentX = x;

            for (int i = 0; i < values.Length; i++)
            {
                Rectangle cell = new Rectangle(currentX, y, columnWidths[i], rowHeight);

                if (isHeader)
                {
                    graphics.FillRectangle(SystemBrushes.ControlLight, cell);
                }

                graphics.DrawRectangle(Pens.Black, cell);
                RectangleF textBounds = new RectangleF(cell.X + 4, cell.Y, cell.Width - 8, cell.Height);
                graphics.DrawString(values[i], font, Brushes.Black, textBounds, format);

                currentX += columnWidths[i];
            }
        }

        private void UpdateStatusStrip(string? message = null)
        {
            toolStripStatusLabelCount.Text = $"Adrese: {_addresses.Count}";

            if (!string.IsNullOrWhiteSpace(message))
            {
                toolStripStatusLabelSelected.Text = message;
                return;
            }

            Adress? selectedAddress = GetSelectedAddress();
            toolStripStatusLabelSelected.Text = selectedAddress == null
                ? "Nici  o adresa selectata"
                : $"Selectata: {FormatAddress(selectedAddress)}";
        }

        private static string FormatAddress(Adress address)
        {
            return $"{address.oras}, {address.strada} {address.numar} - {address.status}";
        }

        private static string EscapeCsv(string value)
        {
            string safeValue = value.Replace("\"", "\"\"");
            return $"\"{safeValue}\"";
        }
    }
}
