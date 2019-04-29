using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_LINQ
{
    public partial class Form1 : Form
    {
        private LINQsys exp;
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        private void Randomize(int[] array)
        {
            Random rnd = new Random();
            int size = array.Length;
            for(int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(-1000, 1000);
            }
        }
        private void Init()
        {
            _tbN.Text = "10";
            _cbOut.Checked = true;
        }

        private int getN()
        {
            return Convert.ToInt32(_tbN.Text);
        }

        private void createArray()
        {
            exp = new LINQsys(getN(), Randomize);
            _rtbT.AppendText("Новый массив:\n");
            if (_cbOut.Checked)
            {
                for (int i = 0; i < exp.Length; i++)
                {
                    _rtbT.AppendText(exp[i].ToString() + "   ");
                }
            }
            _rtbT.AppendText("\n");
        }
        private void getEven()
        {
            IEnumerable<int> answer = default(IEnumerable<int>);
            try
            {
                answer = exp.findEven();
            }
            catch (NullReferenceException)
            {
                createArray();
                answer = exp.findEven();
            }
            finally
            {
                outEnumerable(answer, "Четные числа");
            }
        }

        private void getOdd()
        {
            IEnumerable<int> answer = default(IEnumerable<int>);
            try
            {

                answer = exp.findOdd();
            }
            catch (NullReferenceException)
            {
                createArray();
                answer = exp.findOdd();
            }
            finally
            {
                outEnumerable(answer, "Нечетные числа");
            }
        }

        private void getSumSix()
        {
            IEnumerable<int> answer = default(IEnumerable<int>);
            try
            {
                answer = exp.findSumFLEqSix();
            }
            catch (NullReferenceException)
            {
                createArray();
                answer = exp.findSumFLEqSix();
            }
            finally
            {
                outEnumerable(answer, "Сумма первого и последнего числа 6");
            }
        }

        private void getSixSix()
        {
            IEnumerable<int> answer = default(IEnumerable<int>);
            try
            {
                answer = exp.findSixSix();
            }
            catch (NullReferenceException)
            {
                createArray();
                answer = exp.findSixSix();
            }
            finally
            {
                outEnumerable(answer, "Содержит 666");
            }
        }
        /// <summary>
        /// ///
        /// </summary>
        private void getEvenAsParallel()
        {
            ParallelQuery<int> answer = default(ParallelQuery<int>);
            try
            {
                answer = exp.findEvenAsParallel();
            }
            catch (NullReferenceException)
            {
                createArray();
                answer = exp.findEvenAsParallel();
            }
            finally
            {
                outEnumerable(answer, "Четные числа");
            }
        }

        private void getOddAsParallel()
        {
            ParallelQuery<int> answer = default(ParallelQuery<int>);
            try
            {
                answer = exp.findOddAsParallel();
            }
            catch (NullReferenceException)
            {
                createArray();
                answer = exp.findOddAsParallel();
            }
            finally
            {
                outEnumerable(answer, "Нечетные числа");
            }
        }

        private void getSumSixAsParallel()
        {
            ParallelQuery<int> answer = default(ParallelQuery<int>);

            try
            {
                answer = exp.findSumFLEqSixAsParallel();
            }
            catch (NullReferenceException)
            {
                createArray();
                answer = exp.findSumFLEqSixAsParallel();
            }
            finally
            {
                outEnumerable(answer, "Сумма первого и последнего числа 6");
            }
        }

        private void getSixSixAsParallel()
        {
            ParallelQuery<int> answer = default(ParallelQuery<int>);
            try
            {
                answer = exp.findSixSixAsParallel();
            }
            catch (NullReferenceException)
            {
                createArray();
                answer = exp.findSixSixAsParallel();
            }
            finally
            {
                outEnumerable(answer, "Содержит 666");
            }
        }
        private void outEnumerable(IEnumerable<int> sequence, string name)
        {
            _rtbT.AppendText(name + ": ");
            Stopwatch time = new Stopwatch();
            //time.Start();
            //foreach (int num in sequence)
            //{
            //}
            //time.Stop();
                  
            time.Start();
            foreach (int num in sequence)
            {
                if(_cbOut.Checked)
                    _rtbT.AppendText(num + "  ");
            }
            time.Stop();
            double restime = time.Elapsed.TotalMilliseconds;
            time.Reset();
            _rtbT.AppendText("\nВремя " + restime.ToString() + "\n");
        }

        private void outEnumerable(ParallelQuery<int> sequence, string name)
        {
            _rtbT.AppendText(name + ": ");
            Stopwatch time = new Stopwatch();

            time.Start();
            foreach (int num in sequence)
            {
                if (_cbOut.Checked)
                    _rtbT.AppendText(num + "  ");
            }
            time.Stop();
            double restime = time.Elapsed.TotalMilliseconds;
            time.Reset();
            _rtbT.AppendText("\nВремя " + restime.ToString() + "\n");
        }
        private void _btnRand_Click(object sender, EventArgs e)
        {

            createArray();
        }

        private void _btnTask1_Click(object sender, EventArgs e)
        {
            _rtbT.AppendText("Последовательно:\n");
            getEven();
            getOdd();
            getSumSix();
            getSixSix();
        }
        private void _btnTest_Click(object sender, EventArgs e)
        {
            exp = new LINQsys(8, (int[] array) =>
            {
                array[0] = 302;
                array[1] = 301;
                array[1] = -482;
                array[3] = 303;
                array[4] = 501;
                array[5] = 666;
                array[6] = 138666;
                array[7] = -76668;
            }
            );
            _rtbT.AppendText("Новый массив:\n");
            for (int i = 0; i < exp.Length; i++)
            {
                _rtbT.AppendText(exp[i].ToString() + "   ");
            }
            _rtbT.AppendText("\n");
        }

        private void _btnClear_Click(object sender, EventArgs e)
        {
            _rtbT.Clear();
        }

        private void _tbTask2_Click(object sender, EventArgs e)
        {
            _rtbT.AppendText("Параллельно:\n");
            getEvenAsParallel();
            getOddAsParallel();
            getSumSixAsParallel();
            getSixSixAsParallel();
        }
    }
}
