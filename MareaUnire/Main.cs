using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MareaUnire.Model;
using MareaUnire.Repository;
using MareaUnire.Service;
using MareaUnire.Utils;

namespace MareaUnire
{
    public partial class Main : Form
    {

        private QuizService quizService;
        private DatabaseConfig databaseConfig = DatabaseConfig.GetInstance();
        string raspunsCorect;
        int nota = 0;

        public Main()
        {
            InitializeComponent();
            this.Text = "Marea Unire";
            // Set background to dark grey
            this.BackColor = Color.FromArgb(64, 64, 64);
            // Set size to 800*600
            this.Size = new Size(800, 600);
            // Make the form non-resizable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LabelText.AutoEllipsis = false;
            LabelText.AutoSize = false;
            LabelText.Dock = DockStyle.Fill;

            quizService = new QuizService(new IntrebariRepository(databaseConfig));
            LabelCounter.Visible = false;
            LabelCounterIntrebari.Text = "Intrebarea " + index + " din 10";
            LabelCounter.Text = nota + "/10";
            LabelCounterIntrebari.Visible = false;
            LabelText.Visible = false;
            raspuns1.Visible = false;
            raspuns2.Visible = false;
            raspuns3.Visible = false;
            raspuns4.Visible = false;
        }

        private void ButtonStart_MouseEnter(object sender, EventArgs e)
        {
            ButtonStart.BackColor = Color.FromArgb(128, 0, 128);
            ButtonStart.ForeColor = Color.White;
        }

        private void ButtonStart_MouseLeave(object sender, EventArgs e)
        {
            ButtonStart.BackColor = Color.Silver;
            ButtonStart.ForeColor = Color.Black;
        }
        int index = 0;
        List<Intrebare> intrebare;
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            intrebare = quizService.GetRandomIntrebari();
            index = 0;
            LabelText.Text = intrebare[index].Text;
            raspuns1.Text = intrebare[index].Raspuns1;
            raspuns2.Text = intrebare[index].Raspuns2;
            raspuns3.Text = intrebare[index].Raspuns3;
            raspuns4.Text = intrebare[index].Raspuns4;
            raspunsCorect = intrebare[index].RaspunsCorect;


            ButtonStart.Visible = false;
            LabelCounterIntrebari.Visible = true;
            LabelCounter.Visible = true;
            LabelText.Visible = true;
            raspuns1.Visible = true;
            raspuns2.Visible = true;
            raspuns3.Visible = true;
            raspuns4.Visible = true;
        }

        private void ButtonRaspuns_Click(object sender, MouseEventArgs e)
        {
            // Get the button that was clicked
            Button clickedButton = (Button)sender;

            if (clickedButton.Text == raspunsCorect)
            {
                MessageBox.Show("Ai raspuns corect!");
                nota++;
                LabelCounter.Text = nota + "/10";
                urmatoareaIntrebare();
            }
            else
            {
                MessageBox.Show("Mai incearca!");
                urmatoareaIntrebare();
            }

        }

        private void urmatoareaIntrebare()
        {
            index++;
            if (index < 10)
            {
                LabelCounterIntrebari.Text = "Intrebarea " + index + " din 10";
                Intrebare urmatoarea = intrebare[index];
                LabelText.Text = urmatoarea.Text;
                raspuns1.Text = urmatoarea.Raspuns1;
                raspuns2.Text = urmatoarea.Raspuns2;
                raspuns3.Text = urmatoarea.Raspuns3;
                raspuns4.Text = urmatoarea.Raspuns4;
                raspunsCorect = urmatoarea.RaspunsCorect;

            }
              else
            {
                MessageBox.Show("Felicitari ai obtinut nota " + nota);
                index = 0;
                nota = 0;
                ButtonStart.Visible = true;
                LabelCounterIntrebari.Visible = false;
                LabelCounter.Visible = false;
                LabelText.Visible = false;
                raspuns1.Visible = false;
                raspuns2.Visible = false;
                raspuns3.Visible = false;
                raspuns4.Visible = false;
            }
        }
    }
}
