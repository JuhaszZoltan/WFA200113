using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA200113
{
    public partial class FrmDiak : Form
    {
        OleDbConnection conn;

        public FrmDiak(OleDbConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            this.Icon = Properties.Resources.student;
        }

        private void FrmDiak_Load(object sender, EventArgs e)
        {
            conn.Open();
            var cmd = new OleDbCommand("SELECT iskola_neve FROM iskola", conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                cbIskola.Items.Add(r[0]);
            }
            conn.Close();
        }

        private void KeresesTSMI_Click(object sender, EventArgs e)
        {
            var frm = new FrmDiakLista();
            frm.ShowDialog();
        }

        private void MentesTSMI_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbNev.Text) && cbIskola.SelectedIndex != -1)
            {
                if (string.IsNullOrWhiteSpace(tbAzon.Text))
                {
                    //INSERT
                    int iskID = GetIskId(cbIskola.SelectedItem.ToString());

                    conn.Open();
                    var adp = new OleDbDataAdapter()
                    {
                        InsertCommand = new OleDbCommand(
                            "INSERT INTO diak (nev, evfolyam, iskID) VALUES " +
                            $"('{tbNev.Text}', {nudEvf.Value}, {iskID});", conn),
                    };
                    adp.InsertCommand.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Új diák hozzáadva");
                    //UresUrlap();
                }
                else
                {
                    //UPDATE
                    conn.Open();
                    var adp = new OleDbDataAdapter()
                    {
                        UpdateCommand = new OleDbCommand(
                            "UPDATE diak SET " +
                            $"nev = '{tbNev.Text}', " +
                            $"evfolyam = {nudEvf.Value}, " +
                            $"iskID = {GetIskId(cbIskola.SelectedItem.ToString())}" +
                            $"WHERE diakID = {tbAzon.Text}", conn),
                    };
                    adp.UpdateCommand.ExecuteNonQuery();

                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("A név és az iskola megadása is kötelező");
            }
        }

        private void UresUrlap()
        {
            tbAzon.Text = "";
            tbNev.Text = "";
            nudEvf.Value = 9;
            cbIskola.SelectedIndex = -1;
        }

        private int GetIskId(string iskNeve)
        {
            conn.Open();
            var cmd = new OleDbCommand(
                "SELECT iskID FROM iskola " +
                $"WHERE iskola_neve LIKE '{iskNeve}'", conn);
            var r = cmd.ExecuteReader();
            r.Read();
            int iskId = r.GetInt32(0);
            conn.Close();
            return iskId;
        }

        private void TorlesTSMI_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(
                "Biztos, hogy törlöd?",
                "TÖRLÉS",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if(res == DialogResult.Yes)
            {
                //DELETE
                conn.Open();
                var adp = new OleDbDataAdapter()
                {
                    DeleteCommand = new OleDbCommand(
                        $"DELETE FROM diak WHERE diakID = {tbAzon.Text}", conn),
                };
                adp.DeleteCommand.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Diák törölve!");
                UresUrlap();
            }
        }
    }
}
