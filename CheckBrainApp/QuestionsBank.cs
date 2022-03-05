using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CheckBrainApp
{
   
    public enum QuestionTypes
    {
        Textbox,
        Checkbox,
        Radiobutton
    }

    // Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class QuestionsBank
    {
        int defaultCount = 12;
        public string path;
        public List<QuestionsBankQuestion> LoadTotalQuestions(string path1, string path2, string path3)
        {
            path = path1;
            List<QuestionsBankQuestion> result1 = GetRandomQuestions();
            path = path2;
            List<QuestionsBankQuestion> result2 = GetRandomQuestions();
            path = path3;
            List<QuestionsBankQuestion> result3 = GetRandomQuestions();

            result1.AddRange(result2);
            result1.AddRange(result3);
            return RandomizeQuestions(result1);
        }

        public List<QuestionsBankQuestion> GetQuestions()
        {
            // объект для сериализации

            int fullTime = new int();
            var doc = XDocument.Load(path);
            var result = doc.Descendants("Question")
                            .Select(e => new QuestionsBankQuestion()
                            {
                                QuestionType = (string)e.Element("QuestionType"),
                                QuestionText = (string)e.Element("QuestionText"),
                                Answers = (string)e.Element("Answers"),
                                RightAnswer = (string)e.Element("RightAnswer")
                            })
                            .ToList();
            foreach (QuestionsBankQuestion question in result)
            {
                if (question.QuestionType == "Checkbox")
                {
                    DateTime time = new DateTime();
                    question.TimeToQuestion = time.AddSeconds(60);
                    fullTime += 60;
                }
                if (question.QuestionType == "Textbox")
                {
                    DateTime time = new DateTime();
                    question.TimeToQuestion = time.AddSeconds(90);
                    fullTime +=90;
                }
                if (question.QuestionType == "Radiobutton")
                {
                    DateTime time = new DateTime();
                    question.TimeToQuestion = time.AddSeconds(30);
                    fullTime += 30;
                }
            }
            TimeToTest.AddToTime(fullTime);
            return result;
        }
        
        public List<QuestionsBankQuestion> GetRandomQuestions()
        {
            List<QuestionsBankQuestion> list = GetQuestions();
            Random random = new Random();
            int n = list.Count;
            while (n > 1)
            {

                n--;
                int k = random.Next(n + 1);
                QuestionsBankQuestion value = list[k];
                if (list[n]!= list[k])
                {
                    list[k] = list[n];
                    list[n] = value;
                }
                
            }
            return list.Take(10).ToList();
        }

        

        private List<QuestionsBankQuestion> RandomizeQuestions(List<QuestionsBankQuestion> list)
        {
            Random random = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                QuestionsBankQuestion value = list[k];
                if (list[n] != list[k])
                {
                    list[k] = list[n];
                    list[n] = value;
                }

            }
            list.RemoveAt(list.Count - 5);
            return list;
        }


        private QuestionsBankQuestion[] questionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Question")]
        public QuestionsBankQuestion[] Question
        {
            get
            {
                return this.questionField;
            }
            set
            {
                this.questionField = value;
            }
        }
       
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class QuestionsBankQuestion
    {

        private string questionTypeField;

        private string questionTextField;

        private string answersField;

        private string rightAnswerField;

        private DateTime timeToQuestion;

        private List<string> givenAnswer = new List<string>();

        private bool isLocked;

        /// <remarks/>
        public string QuestionType
        {
            get
            {
                return this.questionTypeField;
            }
            set
            {
                this.questionTypeField = value;
            }
        }

        /// <remarks/>
        public string QuestionText
        {
            get
            {
                return this.questionTextField;
            }
            set
            {
                this.questionTextField = value;
            }
        }

        /// <remarks/>
        public string Answers
        {
            get
            {
                return this.answersField;
            }
            set
            {
                this.answersField = value;
            }
        }

        /// <remarks/>
        public string RightAnswer
        {
            get
            {
                return this.rightAnswerField;
            }
            set
            {
                this.rightAnswerField = value;
            }
        }

        public DateTime TimeToQuestion { get => timeToQuestion; set => timeToQuestion = value; }
        public List<string> GivenAnswer { get => givenAnswer; set => givenAnswer = value; }
        public bool IsLocked { get => isLocked; set => isLocked = value; }
    }
  
}
