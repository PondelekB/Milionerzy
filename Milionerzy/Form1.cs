using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milionerzy
{
    public partial class Form1 : Form
    {
        // quiz game variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 8;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                // work out the percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                MessageBox.Show(
                "Quiz Ended!" + Environment.NewLine +
                "You have answered " + score + " questions correctly." + Environment.NewLine +
                "Your total percentage is " + percentage + "%" + Environment.NewLine +
                "Click OK to play again"
                );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Szkola;
                    lblQuestion.Text = "Jaka to przemyska szkola?";
                    button1.Text = "CKZiU Nr 2";
                    button2.Text = "CKZiU Nr 1";
                    button3.Text = "ZSEiO";
                    button4.Text = "II LO";
                    correctAnswer = 1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Robert;
                    lblQuestion.Text = "Pogodny twardziel na zdjeciu to?";
                    button1.Text = "Arnold Schwarzenegger";
                    button2.Text = "Pan Robert";
                    button3.Text = "Mariusz Pudzianowski";
                    button4.Text = "Mamed Chalidow";
                    correctAnswer = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Auto;
                    lblQuestion.Text = "Super bryka na fotce to?";
                    button1.Text = "Ferrari f50";
                    button2.Text = "Lamborghini Murcielago";
                    button3.Text = "Maserati GranTurismo";
                    button4.Text = "Honda CR-V III poliftowa";
                    correctAnswer = 4;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Przemysl;
                    lblQuestion.Text = "Miasto na zdjęciu to";
                    button1.Text = "Zamosc";
                    button2.Text = "Lublin";
                    button3.Text = "Przemysl";
                    button4.Text = "Konin";
                    correctAnswer = 3;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.Leopard;
                    lblQuestion.Text = "Kotek na foci to?";
                    button1.Text = "Pantera sniezna";
                    button2.Text = "Lew";
                    button3.Text = "Jaguar";
                    button4.Text = "Tygrys";
                    correctAnswer = 1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.Pandka;
                    lblQuestion.Text = "Firefox czyli Panda?";
                    button1.Text = "Wielka";
                    button2.Text = "Srednia";
                    button3.Text = "Mala";
                    button4.Text = "Nieduza";
                    correctAnswer = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.Rekin;
                    lblQuestion.Text = "Ten rekin to?";
                    button1.Text = "Kosogon";
                    button2.Text = "Tygrysi";
                    button3.Text = "Zarlacz bialy";
                    button4.Text = "Ostronos";
                    correctAnswer = 3;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.Orka;
                    lblQuestion.Text = "Fotografia przedstawia?";
                    button1.Text = "Butlonosa";
                    button2.Text = "Humbaka";
                    button3.Text = "Kaszalota";
                    button4.Text = "Orke";
                    correctAnswer = 4;
                    break;
            }
        }
        }
    }
