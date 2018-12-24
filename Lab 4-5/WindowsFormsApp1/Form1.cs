using System;
using System.Collections.Generic;
//using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        //{

        //}
        List<string> list = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "*|*.txt";
            if (fd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show(" невыбран файл");
            }
            else
            {
                Stopwatch t = new Stopwatch();
                t.Start();
                //Чтение файла в виде строки
                string text = File.ReadAllText(fd.FileName);
                //Разделительные символы для чтения из файла 
                char[] separators = new char[] {' ','.',',','!','?','/','\t','\n'};
                string[] textArray = text.Split(separators);
                foreach (string strTemp in textArray)
                { //Удаление пробелов в начале и конце строки 
                    string str = strTemp.Trim(); //Добавление строки в список, если строка не содержится в списке 
                    if (!list.Contains(str))
                        list.Add(str);
                }
                    t.Stop(); this.textBoxFileReadTime.Text = t.Elapsed.ToString();
                    this.textBoxFileReadCount.Text = list.Count.ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string word = this.textBoxFind.Text.Trim();
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                string wordUpper = word.ToUpper();
                List<string> tempList = new List<string>();
                Stopwatch t = new Stopwatch(); t.Start();
                foreach (string str in list)
                {
                    if (str.ToUpper().Contains(wordUpper))
                    {
                        tempList.Add(str);
                    }
                }
                t.Stop();
                this.textBoxExactTime.Text = t.Elapsed.ToString();
                this.listBoxResult.BeginUpdate();
                this.listBoxResult.Items.Clear();
                foreach (string str in tempList)
                {
                    this.listBoxResult.Items.Add(str);
                }
                this.listBoxResult.EndUpdate();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
        }


        public class ParallelSearchResult
        {
            public string word { get; set; }
            public int dist { get; set; }
            public int ThreadNum { get; set; }
        }
        class ParallelSearchThreadParam
        {
            public List<string> tempList { get; set; }
            public string wordPattern { get; set; }
            public int maxDist { get; set; }
            public int ThreadNum { get; set; }
        }
        public static List<ParallelSearchResult> ArrayThreadTask(object paramObj)
        {
            ParallelSearchThreadParam param = (ParallelSearchThreadParam)paramObj;
            string wordUpper = param.wordPattern.Trim().ToUpper();
            List<ParallelSearchResult> Result = new List<ParallelSearchResult>();
            foreach (string str in param.tempList)
            {
                int dist = EditDistance.Distance(str.ToUpper(), wordUpper);
                if (dist <= param.maxDist)
                {
                    ParallelSearchResult temp = new ParallelSearchResult()
                    {
                        word = str,
                        dist = dist,
                        ThreadNum = param.ThreadNum
                    };
                    Result.Add(temp);
                }
            }
            return Result;
        }
        public class MinMax
        {
            public int Min { get; set; }
            public int Max { get; set; }

            public MinMax(int pmin, int pmax)
            {
                this.Min = pmin;
                this.Max = pmax;
            }
        }
        public static class SubArrays
        {
            public static List<MinMax> DivideSubArrays(int beginIndex, int endIndex, int subArraysCount)
            {
                List<MinMax> result = new List<MinMax>();
                if ((endIndex - beginIndex) <= subArraysCount)
                {
                    result.Add(new MinMax(0, (endIndex - beginIndex)));
                }
                else
                {
                    int delta = (endIndex - beginIndex) / subArraysCount;
                    int currentBegin = beginIndex;
                    while ((endIndex - currentBegin) >= 2 * delta)
                    {
                        result.Add(new MinMax(currentBegin, currentBegin + delta));
                        currentBegin += delta;
                    }
                    result.Add(new MinMax(currentBegin, endIndex));
                }
                return result;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string word = this.textBoxFind.Text.Trim();
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                int maxDist;
                if (!int.TryParse(this.textBoxThreadCountAll.Text.Trim(), out maxDist))    //////////// !!!!!!!!!!!!!!!!!!!!
                {
                    MessageBox.Show("Необходимо указать максимальное расстояние");
                    return;
                }
                if (maxDist < 1 || maxDist > 5)
                {
                    MessageBox.Show("Максимальное расстояние должно быть в диапазоне от 1 до 5");
                    return;
                }
                int ThreadCount;
                if (!int.TryParse(this.textBoxThreadCount.Text.Trim(), out ThreadCount))
                {
                    MessageBox.Show("Необходимо указать количество потоков");
                    return;
                }
                Stopwatch timer = new Stopwatch();
                timer.Start();
                List<ParallelSearchResult> Result = new List<ParallelSearchResult>();
                List<MinMax> arrayDivList = SubArrays.DivideSubArrays(0, list.Count, ThreadCount);
                int count = arrayDivList.Count;
                Task<List<ParallelSearchResult>>[] tasks = new Task<List<ParallelSearchResult>>[count];
                for (int i = 0; i < count; i++)
                {
                    List<string> tempTaskList = list.GetRange(arrayDivList[i].Min, arrayDivList[i].Max - arrayDivList[i].Min);
                    tasks[i] = new Task<List<ParallelSearchResult>>(ArrayThreadTask, new ParallelSearchThreadParam()
                    {
                        tempList = tempTaskList,
                        maxDist = maxDist,
                        ThreadNum = i,
                        wordPattern = word
                    });
                    tasks[i].Start();
                }
                Task.WaitAll(tasks);
                timer.Stop();
                for (int i = 0; i < count; i++)
                {
                    Result.AddRange(tasks[i].Result);
                }
                timer.Stop();
                this.textBoxApproxTime.Text = timer.Elapsed.ToString();
                this.textBoxMaxDist.Text = count.ToString();
                this.listBoxResult.BeginUpdate();
                this.listBoxResult.Items.Clear();
                foreach (var x in Result)
                {
                    string temp = x.word + "(расстояние=" + x.dist.ToString() + " поток=" + x.ThreadNum.ToString() + ")";
                    this.listBoxResult.Items.Add(temp);
                }
                this.listBoxResult.EndUpdate();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
        }

    }
    public static class EditDistance
    {
        public static int Distance(string str1Param, string str2Param)
        {
            if ((str1Param == null) || (str2Param == null)) return -1;
            int str1Len = str1Param.Length; int str2Len = str2Param.Length;
            if ((str1Len == 0) && (str2Len == 0)) return 0;
            if (str1Len == 0) return str2Len;
            if (str2Len == 0) return str1Len;
            string str1 = str1Param.ToUpper();
            string str2 = str2Param.ToUpper();
            int[,] matrix = new int[str1Len + 1, str2Len + 1];
            for (int i = 0; i <= str1Len; i++) matrix[i, 0] = i;
            for (int j = 0; j <= str2Len; j++) matrix[0, j] = j;
            for (int i = 1; i <= str1Len; i++)
            {
                for (int j = 1; j <= str2Len; j++)
                {
                    int symbEqual = ((str1.Substring(i - 1, 1) == str2.Substring(j - 1, 1)) ? 0 : 1);
                    int ins = matrix[i, j - 1] + 1;
                    int del = matrix[i - 1, j] + 1;
                    int subst = matrix[i - 1, j - 1] + symbEqual;
                    matrix[i, j] = Math.Min(Math.Min(ins, del), subst);
                    if ((i > 1) && (j > 1) && (str1.Substring(i - 1, 1) == str2.Substring(j - 2, 1)) && (str1.Substring(i - 2, 1) == str2.Substring(j - 1, 1)))
                    {
                        matrix[i, j] = Math.Min(matrix[i, j], matrix[i - 2, j - 2] + symbEqual);
                    }
                }
            }
            return matrix[str1Len, str2Len];
        }



    }
}



