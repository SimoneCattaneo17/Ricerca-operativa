using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace ricerca_operativa {
    public partial class Form1 : Form {
        private bool msg = false;

        public Form1() {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void False(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            Tabella.AllowUserToAddRows = false;
            Tabella.AllowUserToDeleteRows = false;
            Tabella.AllowUserToOrderColumns = false;
            Tabella.RowHeadersVisible = false;
            Tabella.AllowDrop = false;
            Tabella.AllowUserToResizeColumns = false;
            Tabella.AllowUserToResizeRows = false;
        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            crea();
        }

        private void button2_Click(object sender, EventArgs e) {
            riempi();
        }

        private void button3_Click(object sender, EventArgs e) {
            nordOvest();
        }

        private void Tabella_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
            e.Control.KeyPress -= new KeyPressEventHandler(Tabella_KeyPress);
            TextBox tb = e.Control as TextBox;
            tb.ShortcutsEnabled = false;
            if (tb != null) {
                tb.KeyPress += new KeyPressEventHandler(Tabella_KeyPress);
            }
        }

        private void Tabella_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void crea() {
            if (flatNumericUpDown1.Value > 1 && flatNumericUpDown2.Value > 1 && flatNumericUpDown1.Value < 51 && flatNumericUpDown2.Value < 51) {

                Tabella.Rows.Clear();
                Tabella.Columns.Clear();

                for (int i = 0; i <= flatNumericUpDown2.Value; i++) {
                    if (i != 0) {
                        Tabella.Columns.Add("D" + i, "D" + i);
                    }
                    else {
                        Tabella.Columns.Add(" ", " ");
                    }
                }

                for (int i = 0; i < flatNumericUpDown1.Value; i++) {
                    Tabella.Rows.Add("UP" + (i + 1));
                }

                Tabella.Columns.Add("Totali", "Totali");
                Tabella.Rows.Add("Totali");

                foreach (DataGridViewColumn t in Tabella.Columns) {
                    t.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
                }

                Tabella.Columns[0].ReadOnly = true;

                this.Tabella.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            else {
                MessageBox.Show("Il numero dei produttori e dei consumatori deve essere maggiore di 1 e non più di 50", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void riempi() {
            if (Tabella.Rows.Count < 2 && Tabella.Columns.Count < 2) {
                MessageBox.Show("Tabella non ancora creata", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Random rnd = new Random();
                int sum = 0, temp = 0;

                for (int i = 0; i < Tabella.Rows.Count - 1; i++) {
                    for (int j = 1; j < Tabella.Columns.Count - 1; j++) {
                        Tabella.Rows[i].Cells[j].Value = rnd.Next(1, 128);
                    }
                }

                //inserisce nell'ultima riga
                for (int i = 1; i < Tabella.Columns.Count - 1; i++) {
                    if (Tabella.Columns.Count > 20 || Tabella.Rows.Count > 20) {
                        Tabella.Rows[Tabella.Rows.Count - 1].Cells[i].Value = rnd.Next(128, 512);
                    }
                    else {
                        Tabella.Rows[Tabella.Rows.Count - 1].Cells[i].Value = rnd.Next(1, 256);
                    }
                }

                //somma i valori nell'ultima riga
                for (int i = 1; i < Tabella.Columns.Count - 1; i++) {
                    sum += Convert.ToInt32(Tabella.Rows[Tabella.Rows.Count - 1].Cells[i].Value);
                }

                Tabella.Rows[Tabella.Rows.Count - 1].Cells[Tabella.Columns.Count - 1].Value = sum;

                //inserisce nell'ultima colonna

                /*
                int n = 0;
                int m = Tabella.Rows.Count - 1;
                for (int i = 0; i < Tabella.Rows.Count - 1; i++) {
                    if (i == Tabella.Rows.Count - 2) {
                        Tabella.Rows[i].Cells[Tabella.Columns.Count - 1].Value = sum;
                    }
                    else {
                        if (n > m / 2) {
                            temp = rnd.Next(1, sum / 4);
                            Tabella.Rows[i].Cells[Tabella.Columns.Count - 1].Value = temp;
                            sum -= temp;
                        }
                        else {
                            temp = rnd.Next(1, sum / 6);
                            Tabella.Rows[i].Cells[Tabella.Columns.Count - 1].Value = temp;
                            sum -= temp;
                        }
                    }
                    n++;
                }
                */

                //non ancora finito, controllare il valore per cui si moltiplica la media
                int media = (sum / Tabella.Rows.Count) / 2;
                int n = 0;
                int m = Tabella.Rows.Count - 1;
                for (int i = 0; i < Tabella.Rows.Count - 1; i++) {
                    if (i == Tabella.Rows.Count - 2) {
                        Tabella.Rows[i].Cells[Tabella.Columns.Count - 1].Value = sum;
                    }
                    else {
                        if (n > m / 1.5) {
                            temp = rnd.Next(media / 2, media * 4);
                        }
                        else {
                            temp = rnd.Next(media / 2, media * 3);
                        }
                        Tabella.Rows[i].Cells[Tabella.Columns.Count - 1].Value = temp;
                        sum -= temp;
                    }
                    n++;
                }
            }
        }
        private bool verificaTotali() {
            int sumRighe = 0, sumColonne = 0;
            bool b;
            for (int i = 1; i < Tabella.Columns.Count - 1; i++) {
                sumRighe += Convert.ToInt32(Tabella.Rows[Tabella.Rows.Count - 1].Cells[i].Value);
            }
            for (int i = 0; i < Tabella.Rows.Count - 1; i++) {
                sumColonne += Convert.ToInt32(Tabella.Rows[i].Cells[Tabella.Columns.Count - 1].Value);
            }

            b = (sumColonne == sumRighe) ? true : false;

            return b;
        }
        private bool verificaCaselle() {
            bool a = true;
            int x = 0;
            for (int i = 1; i < Tabella.Columns.Count - 1; i++) {
                for (int j = 0; j < Tabella.Rows.Count - 1; j++) {
                    try {
                        x = Convert.ToInt32(Tabella.Rows[j].Cells[i].Value);
                    }
                    catch {
                        Tabella.Rows[j].Cells[i].Value = "";
                        a = false;
                    }
                    if (Convert.ToString(Tabella.Rows[j].Cells[i].Value) == "") {
                        a = false;
                    }
                }
            }
            return a;
        }
        private void nordOvest() {
            if (Tabella.Rows.Count < 2 && Tabella.Columns.Count < 2) {
                MessageBox.Show("Tabella non ancora creata", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (verificaTotali() && verificaCaselle()) {
                    Form2 f2 = new Form2();
                    f2.Show();
                    int costo = 0;
                    int a = 0, b = 0, c = 0;
                    int q, p;
                    f2.aggiungi("Nord-Ovest:");
                    f2.aggiungi("");

                    while (Tabella.Rows.Count > 1) {
                        b = Convert.ToInt32(Tabella.Rows[Tabella.Rows.Count - 1].Cells[1].Value);
                        a = Convert.ToInt32(Tabella.Rows[0].Cells[Tabella.Columns.Count - 1].Value);
                        c = Convert.ToInt32(Tabella.Rows[0].Cells[1].Value);

                        p = c;
                        if (a >= b) {
                            q = b;
                            if (a != b) {
                                costo += c * b;
                                Tabella.Rows[0].Cells[Tabella.Columns.Count - 1].Value = a - b;
                                Tabella.Columns.RemoveAt(1);
                            }
                            else {
                                costo += c * b;
                                Tabella.Columns.RemoveAt(1);
                                Tabella.Rows.RemoveAt(0);
                            }
                        }
                        else {
                            q = a;
                            costo += c * a;
                            Tabella.Rows[Tabella.Rows.Count - 1].Cells[1].Value = b - a;
                            Tabella.Rows.RemoveAt(0);
                        }

                        /*
                        if (a <= b) {
                            p = c;
                            q = b;
                            costo += p * q;

                            if (a == b) {
                                Tabella.Columns.RemoveAt(1);
                            }
                            else {
                                Tabella.Rows[Tabella.Rows.Count - 1].Cells[1].Value = Convert.ToInt32(Tabella.Rows[Tabella.Rows.Count - 1].Cells[1].Value) - Convert.ToInt32(Tabella.Rows[0].Cells[Tabella.Columns.Count - 1].Value);
                                Tabella.Rows[Tabella.Rows.Count - 1].Cells[Tabella.Columns.Count - 1].Value = Convert.ToInt32(Tabella.Rows[Tabella.Rows.Count - 1].Cells[Tabella.Columns.Count - 1].Value) - Convert.ToInt32(Tabella.Rows[0].Cells[Tabella.Columns.Count - 1].Value);
                            }
                            Tabella.Rows.RemoveAt(0);
                        }
                        else {
                            p = c;
                            q = a;
                            costo += p * q;
                            Tabella.Rows[0].Cells[Tabella.Columns.Count - 1].Value = Convert.ToInt32(Tabella.Rows[0].Cells[Tabella.Columns.Count - 1].Value) - Convert.ToInt32(Tabella.Rows[Tabella.Rows.Count - 1].Cells[1].Value);
                            Tabella.Rows[Tabella.Rows.Count - 1].Cells[Tabella.Columns.Count - 1].Value = Convert.ToInt32(Tabella.Rows[Tabella.Rows.Count - 1].Cells[Tabella.Columns.Count - 1].Value) - Convert.ToInt32(Tabella.Rows[Tabella.Rows.Count - 1].Cells[1].Value);
                            Tabella.Columns.RemoveAt(1);
                        }
                        */
                        //capire se tenere o togliere u e €
                        f2.aggiungi(q.ToString() + "u * " + p.ToString() + "€ = " + (q * p).ToString() + "€");
                        Thread.Sleep(350);
                        Tabella.Update();
                        Tabella.Refresh();
                        f2.aggiorna();
                    }
                    f2.aggiungi("");
                    f2.aggiungi("Costo Finale: " + costo.ToString() + "€");
                    //scegliere se meglio i due clear o i due removeAt
                    Tabella.Rows.Clear();
                    Tabella.Columns.Clear();
                }
                else {
                    MessageBox.Show("Una o più caselle contengono dati non corretti\n(Numeri troppo grandi o caselle vuote)", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void minimiCosti() {
            if (Tabella.Rows.Count < 2 && Tabella.Columns.Count < 2) {
                MessageBox.Show("Tabella non ancora creata", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (verificaTotali() && verificaCaselle()) {

                }
                else {
                    MessageBox.Show("Errore, controllare la tabella in input", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            minimiCosti();
        }

        private void rjButtons1_Click(object sender, EventArgs e) {
            crea();
        }

        private void rjButtons2_Click(object sender, EventArgs e) {
            riempi();
        }

        private void rjButtons3_Click(object sender, EventArgs e) {
            nordOvest();
        }

        private void rjButtons4_Click(object sender, EventArgs e) {
            minimiCosti();
        }
    }
}

/*lista di cose da fare in seguito:
 * 
 * metodo minimi costi
 * 
 */