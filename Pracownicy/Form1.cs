using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Pracownicy
{
    public partial class Form1 : Form
    {
        private List<Pracownik> pracownicy = new List<Pracownik>();

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private bool setEmptyError(Control control)
        {
            if (control is TextBox)
            {
                TextBox tb = (TextBox)control;
                if (tb.Text == "")
                {
                    errorProvider1.SetError(tb, "Puste pole");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(tb, "");
                    return true;
                }
            }
            else if (control is ComboBox)
            {
                ComboBox cb = (ComboBox)control;
                if (cb.SelectedIndex == -1)
                {
                    errorProvider1.SetError(cb, "Wybierz opcję");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(cb, "");
                    return true;
                }
            }
            return true;
        }

        private bool setNameError(TextBox tb)
        {
            try
            {
                int.Parse(tb.Text);
                errorProvider1.SetError(tb, "Niepoprawna wartość");
                return (false);
            }
            catch
            {

                return (true);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string rUmowy = "";

            if (radioButton1.Checked)
                rUmowy = radioButton1.Text;
            else if (radioButton2.Checked)
                rUmowy = radioButton2.Text;
            else if (radioButton3.Checked)
                rUmowy = radioButton3.Text;
            else
            {
                errorProvider1.SetError(radioButton1, "Wybierz rodzaj umowy");
                errorProvider1.SetError(radioButton2, "Wybierz rodzaj umowy");
                errorProvider1.SetError(radioButton3, "Wybierz rodzaj umowy");
                return;
            }

            errorProvider1.SetError(radioButton1, "");
            errorProvider1.SetError(radioButton2, "");
            errorProvider1.SetError(radioButton3, "");

            if (setEmptyError(textBox1) & setNameError(textBox1) & setEmptyError(textBox2) & setNameError(textBox2) &setEmptyError(position))
            {
                Pracownik p = new Pracownik(textBox1.Text, textBox2.Text, birthDatePicker.Text, int.Parse(salary.Text), position.Text, rUmowy);
                pracownicy.Add(p);
                listBoxEmployees.Items.Add(p.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Pracownik>));
            using (TextWriter writer = new StreamWriter("pracownicy.xml"))
            {
                serializer.Serialize(writer, pracownicy);
            }
        }

        private void UpdateListBox()
        {
            listBoxEmployees.Items.Clear();
            foreach (var pracownik in pracownicy)
            {
                listBoxEmployees.Items.Add(pracownik.ToString());
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Pracownik>));
            try
            {
                using (FileStream fileStream = new FileStream("pracownicy.xml", FileMode.Open))
                {
                    pracownicy = (List<Pracownik>)serializer.Deserialize(fileStream);
                    UpdateListBox(); // Aktualizacja listy pracowników w ListBox
                }
            }
            catch (FileNotFoundException)
            {
                // Obsługa sytuacji, gdy plik nie istnieje
                MessageBox.Show("Plik 'pracownicy.xml' nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedIndex != -1)
            {
                int selectedIndex = listBoxEmployees.SelectedIndex;
                if (selectedIndex >= 0 && selectedIndex < pracownicy.Count)
                {
                    Pracownik selectedPracownik = pracownicy[selectedIndex];
                    textBox1.Text = selectedPracownik.Imie;
                    textBox2.Text = selectedPracownik.Nazwisko;
                    birthDatePicker.Text = selectedPracownik.DUrodzenia;
                    salary.Text = selectedPracownik.Pensja.ToString();
                    position.Text = selectedPracownik.Stanowisko;
                    if (selectedPracownik.Umowa == radioButton1.Text)
                        radioButton1.Checked = true;
                    else if (selectedPracownik.Umowa == radioButton2.Text)
                        radioButton2.Checked = true;
                    else if (selectedPracownik.Umowa == radioButton3.Text)
                        radioButton3.Checked = true;
                }
            }
        }

    }
}
