using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace CheckBrainApp.Forms
{
    public partial class FormTesting : Form
    {
        private string bankPath;                                    //путь к банку вопросов относительно коренной папки приложения
        private DateTime fullTimeToTest = TimeToTest.Time;
        List<QuestionsBankQuestion> questions;                      //Лист вопросов (банк)
        private int questionsCount;                                 //Количество вопросов в банке
        private bool lastAnswerIsEmpty = true;                      //Булева переменная на проверку ответа на предыдущий вопрос
        private int rightAnswersPercent = 0;                        //Процент правильно отвеченных вопросов
        private int answerPrice;                                    //Цена вопроса
        private List<string> lastAnswer = new List<string>();       //Предыдущий ответ
        private List<string> lastTrueAnswer = new List<string>();   //Предыдущий правильный ответ
        private string lastQuestionType;                            //тип последнего вопроса
        private int questionNumber = 0;                             //Номер вопроса
        private DateTime endTestTime = new DateTime();              //Переменная конца отсчета = 00:00
        private List<Guna2CircleButton> questionButtons = new List<Guna2CircleButton>(); //лист с кнопками для навигации по вопросам

        public FormTesting()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = string.Empty;
        }
        /// <summary>
        /// Метод загрузки темы в форму
        /// </summary>
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }

            }
        }

        private void FormTestingOnLoad(object sender, EventArgs e)
        {
            LoadTheme();
        }

        /// <summary>
        /// Метод выбора вопроса на который еще не дан ответ
        /// </summary>
        private void setUnlockedQuestion()
        {
            bool theLastQues = true;
            if (questionNumber == questions.Count)
            {
                questionNumber = 0;
                setUnlockedQuestion();
            }
            if (questions[questionNumber].IsLocked == false && questions[questionNumber].GivenAnswer.Count <= 0)
            {
                LoadNextQuestion();
            }
            else
            {
                for (int i = questionNumber; i < questions.Count; i++)
                {
                    if (questions[i].IsLocked == false && questions[i].GivenAnswer.Count <= 0)
                    {
                        questionNumber = i;
                        LoadNextQuestion();
                        theLastQues = false;
                        break;
                    }
                }
                if (theLastQues)
                {
                    checkAllQuesDisabled();
                    questionNumber = 0;
                    setUnlockedQuestion();
                }
            }
        }


        /// <summary>
        /// Метод проверки на то, дан ли ответ на все вопросы
        /// </summary>
        private void checkAllQuesDisabled()
        {
            int count = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].IsLocked == true || questions[i].GivenAnswer.Count > 0)
                {
                    count++;
                }
            }
            if (count == questions.Count)
            {
                EndTheTest();
            }
        }


        /// <summary>
        /// Метод загрузки следующего вопроса
        /// </summary>
        private void LoadNextQuestion()
        {
            setQuestionButtonSelected(questionButtons[questionNumber], null);
            if (questions.Count == questionNumber + 1)
            {
                btnAnswer.Text = "Завершить";
            }
            else
            {
                btnAnswer.Text = "Ответ";
            }

            panelAnswers.Controls.Clear();
            panelAnswers.Location = new Point(0, lblQuestion.Location.Y + lblQuestion.Size.Height + 10);
            QuestionsBankQuestion question = questions[questionNumber];
            int answerSizePoints = 0;
            lblQuestion.Text = question.QuestionText;
            lblInfo.Text = (questionNumber + 1) + " вопрос из " + questionsCount;


            List<string> answers = question.Answers.ToString().Split(';').ToList();
            Random rand = new Random();
            answers = answers.OrderBy(x => rand.Next()).ToList();
            for (int i = 0; i < answers.Count; i++)
            {
                if (question.QuestionType.ToString().ToLower() == QuestionTypes.Checkbox.ToString().ToLower())
                {
                    lastQuestionType = QuestionTypes.Checkbox.ToString().ToLower();
                    CheckBox checkbox = new CheckBox();
                    checkbox.Font = new Font("Microsoft Sans Serif", 12);
                    checkbox.Location = new Point(50, answerSizePoints);
                    checkbox.Size = new Size(panelTesting.Width - 100, 50);
                    checkbox.Text = answers[i];
                    if (questions[questionNumber].GivenAnswer.Count > 0)
                    {
                        if (questions[questionNumber].GivenAnswer.Contains(checkbox.Text.ToLower()))
                        {
                            checkbox.Checked = true;
                        }
                    }
                    panelAnswers.Controls.Add(checkbox);
                }

                if (question.QuestionType.ToString().ToLower() == QuestionTypes.Radiobutton.ToString().ToLower())
                {
                    lastQuestionType = QuestionTypes.Radiobutton.ToString().ToLower();
                    RadioButton radio = new RadioButton();
                    radio.Font = new Font("Microsoft Sans Serif", 12);
                    radio.Location = new Point(50, answerSizePoints);
                    radio.Size = new Size(panelTesting.Width - 100, 40);
                    radio.Text = answers[i];
                    if (questions[questionNumber].GivenAnswer.Count > 0)
                    {
                        if (questions[questionNumber].GivenAnswer.Contains(radio.Text.ToLower()))
                        {
                            radio.Checked = true;
                        }
                    }
                    panelAnswers.Controls.Add(radio);
                }

                if (question.QuestionType.ToString().ToLower() == QuestionTypes.Textbox.ToString().ToLower())
                {
                    lastQuestionType = QuestionTypes.Textbox.ToString().ToLower();
                    TextBox box = new TextBox();
                    box.Visible = true;
                    box.Font = new Font("Microsoft Sans Serif", 14);
                    box.Size = new Size(panelTesting.Width - 100, 40);
                    box.Location = new Point(50, answerSizePoints);
                    if (questions[questionNumber].GivenAnswer.Count > 0)
                    {
                        box.Text = questions[questionNumber].GivenAnswer[0];
                    }
                    panelAnswers.Controls.Add(box);
                }
                answerSizePoints += 40;
            }
            lastTrueAnswer = question.RightAnswer.ToString().Split(';').ToList();
            questionNumber++;

            timerTest.Enabled = true;

        }


        /// <summary>
        /// Метод начала тестирования
        /// </summary>
        private void StartTesting()
        {
            timerTest.Enabled = true;
            lblQuestion.Visible = true;
            btnAnswer.Visible = true;
            btnCancelTest.Visible = true;
            lblMain.Visible = false;
            btnTesting.Visible = false;
            panelTesting.Visible = true;
            pnlQuestionsList.Visible = true;


        }


        Guna.UI2.WinForms.Helpers.PanelScrollHelper vScrollHelper;
        /// <summary>
        /// Метод загрузки скролл-панели
        /// </summary>
        private void LoadScrollQuestions()
        {
            vScrollHelper = new Guna.UI2.WinForms.Helpers.PanelScrollHelper(pnlQuestionsList, scrollQuestions);

            int ControlX = 0;
            questionsCount = questions.Count;
            for (int i = 0; i < questions.Count; i++)
            {
                Guna2CircleButton button = new Guna2CircleButton();
                button.Size = new Size(pnlQuestionsList.Size.Height - 18, pnlQuestionsList.Size.Height - 18);
                button.Text = (i + 1).ToString();
                button.Name = (i + 1).ToString();
                button.Font = new Font("Microsoft Sans Serif", 12F);
                button.FillColor = ThemeColor.PrimaryColor;
                button.Location = new Point(ControlX, 0);
                button.MouseClick += btnChooseQuestionOnClick;
                questionButtons.Add(button);
                ControlX += pnlQuestionsList.Size.Height + 10;
            }
            foreach (Guna2CircleButton btn in questionButtons)
            {
                pnlQuestionsList.Controls.Add(btn);
            }
            vScrollHelper.UpdateScrollBar();
            pnlQuestionsList.HorizontalScroll.Visible = false;
        }


        /// <summary>
        /// Метод, который устанавливает цвет кнопки вопроса, который является активным
        /// </summary>
        /// <param name="sender">Кнопка с вопросом</param>
        /// <param name="e">Действие</param>
        private void setQuestionButtonSelected(object sender, MouseEventArgs e)
        {
            Guna2CircleButton btn = (Guna2CircleButton)sender;
            btn.FillColor = ThemeColor.SecondaryColor;
        }


        /// <summary>
        /// Событие, которое происходит при нажатии на кнопку из скролл-панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChooseQuestionOnClick(object sender, MouseEventArgs e)
        {

            Guna2CircleButton btn = (Guna2CircleButton)sender;
            setQuestionButtonSelected(btn,e);
            if (Convert.ToInt32(btn.Text) != questionNumber)
            {
                CheckAnswer();
                questionNumber = Convert.ToInt32(btn.Text) - 1;
                LoadNextQuestion();
            }

        }


        /// <summary>
        /// Метод загрузки банка вопросов в форму
        /// </summary>
        private void LoadQuestionBank()
        {
            QuestionsBank bank = new QuestionsBank();
            bank.path = bankPath;
            questions = bank.GetRandomQuestions();
            decimal unroundedPercent = 100 / questions.Count;
            answerPrice = (int)Math.Ceiling((unroundedPercent));
            LoadScrollQuestions();
            fullTimeToTest = TimeToTest.Time;
        }
        private void LoadTotalQuestionBank()
        {
            QuestionsBank bank = new QuestionsBank();
            questions = bank.LoadTotalQuestions("test.xml", "test1.xml", "test2.xml");
            decimal unroundedPercent = 100 / questions.Count;
            answerPrice = (int)Math.Ceiling((unroundedPercent));
            LoadScrollQuestions();
        }
        private void btnTestingOnClick(object sender, EventArgs e)
        {
            FormWait form = new FormWait();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (SelectedTest.SelectedNum == 1)
                {
                    bankPath = "test.xml";
                    LoadQuestionBank();
                }
                if (SelectedTest.SelectedNum == 2)
                {
                    bankPath = "test1.xml";
                    LoadQuestionBank();
                }
                if (SelectedTest.SelectedNum == 3)
                {
                    bankPath = "test2.xml";
                    LoadQuestionBank();
                }
                if (SelectedTest.SelectedNum == 4)
                {
                    LoadTotalQuestionBank();
                }
                
                StartTesting();
                LoadNextQuestion();
            }


        }
      
        /// <summary>
        /// Метод проверки ответа
        /// </summary>
        private void CheckAnswer()
        {
            timerTest.Enabled = false;
            questions[questionNumber - 1].GivenAnswer.Clear();
            if (lastQuestionType == QuestionTypes.Checkbox.ToString().ToLower())
            {
                foreach (Control item in panelAnswers.Controls)
                {
                    if (item.GetType() == typeof(CheckBox))
                    {
                        CheckBox chk = (CheckBox)item;
                        if (chk.Checked)
                        {
                            string answr = chk.Text.ToLower();
                            lastAnswer.Add(answr);
                            lastAnswerIsEmpty = false;
                            questions[questionNumber - 1].GivenAnswer.Add(answr);
                        }

                    }
                }
            }
            if (lastQuestionType == QuestionTypes.Radiobutton.ToString().ToLower())
            {
                foreach (Control item in panelAnswers.Controls)
                {
                    if (item.GetType() == typeof(RadioButton))
                    {
                        RadioButton btn = (RadioButton)item;
                        if (btn.Checked)
                        {
                            string answr = btn.Text.ToLower();
                            lastAnswer.Add(answr);
                            lastAnswerIsEmpty = false;
                            questions[questionNumber - 1].GivenAnswer.Add(answr);
                        }
                    }
                }
            }
            if (lastQuestionType == QuestionTypes.Textbox.ToString().ToLower())
            {
                foreach (Control item in panelAnswers.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        TextBox textBox = (TextBox)item;
                        if (!String.IsNullOrWhiteSpace(textBox.Text))
                        {
                            string answr = textBox.Text.ToLower();
                            lastAnswer.Add(answr);
                            lastAnswerIsEmpty = false;
                            questions[questionNumber - 1].GivenAnswer.Add(answr);
                        }

                    }

                }
            }
            if (lastAnswer.Count == 0)
            {
                lastAnswerIsEmpty = true;
                setQuestionButtonUnanswered();
            }
            else
            {
                setQuestionButtonAnswered();
                if (lastAnswer.Count == lastTrueAnswer.Count)
                {
                    for (int i = 0; i < lastTrueAnswer.Count; i++)
                    {
                        if (lastQuestionType == QuestionTypes.Checkbox.ToString().ToLower())
                        {
                            if (lastAnswer.IndexOf(lastTrueAnswer[i].ToLower()) != -1)
                            {
                                rightAnswersPercent += answerPrice / lastTrueAnswer.Count;
                            }
                        }
                        else if (lastTrueAnswer[i].ToLower() == lastAnswer[i].ToLower())
                        {
                            rightAnswersPercent += answerPrice;
                        }

                    }
                }

            }
            lastAnswer.Clear();


        }


        /// <summary>
        /// Метод установки цвета кнопки при том, что на вопрос дан ответ
        /// </summary>
        private void setQuestionButtonAnswered()
        {
            questionButtons[questionNumber - 1].FillColor = Color.FromArgb(0, 150, 136);
        }


        /// <summary>
        /// Метод установки цвета кнопки при том, что на вопрос не дан ответ
        /// </summary>
        private void setQuestionButtonUnanswered()
        {
            questionButtons[questionNumber-1].FillColor = ThemeColor.PrimaryColor;
        }


        /// <summary>
        /// Функция, которая возвращает оценку за тест
        /// </summary>
        /// <returns></returns>
        private int GetMark()
        {
            if (rightAnswersPercent >= 90)
            {
                return 5;
            }
            else if (rightAnswersPercent >= 80)
            {
                return 4;
            }
            else if (rightAnswersPercent >= 60)
            {
                return 3;
            }
            else return 2;
        }


        /// <summary>
        /// Метод, который заканчивает тест
        /// </summary>
        private void EndTheTest()
        {
            pnlQuestionsList.Visible = false;
            lblInfo.Visible = false;
            scrollQuestions.Visible = false;
            lblTime.Visible = false;
            panelAnswers.Visible = false;
            btnAnswer.Visible = false;
            lblQuestion.Visible = false;
            btnCancelTest.Visible = false;
            lblTotal.Text = "Вы выполнили тест на " + rightAnswersPercent + "%\n" + "Ваша итоговая оценка : " + GetMark().ToString();
            lblTotal.Visible = true;
            timerTest.Enabled = false;

        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            CheckAnswer();
            if (lastAnswerIsEmpty)
            {
                MessageBox.Show("Вы не выбрали ни одного ответа!");
            }
            else if (questionNumber == questions.Count - 1)
            {
                btnAnswer.Text = "Завершить";
                LoadNextQuestion();
            }
            else if (questionNumber == questions.Count)
            {
                EndTheTest();
            }
            else
            {
                LoadNextQuestion();
            }
        }

        private void btnCancelTest_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы действительно хотите выйти из тестирования?\nВаши результаты не будут сохранены!", "Завершение тестирования", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void timerTest_Tick(object sender, EventArgs e)
        {
            if (questions[questionNumber - 1].TimeToQuestion == endTestTime)
            {
                questions[questionNumber - 1].IsLocked = true;
                CheckAnswer();
                setUnlockedQuestion();
            }
            fullTimeToTest = fullTimeToTest.AddSeconds(-0.1);
            lblTime.Text = "Время на тест: " + fullTimeToTest.ToString("m:ss");
        }

        private void FormTesting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timerTest.Enabled == true)
            {
                if (MessageBox.Show("Вы действительно хотите выйти из тестирования?\nВаши результаты не будут сохранены!.", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                   
                }
                else
                {
                    e.Cancel = true;
                }
            }
           
        }
    }
}
