using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppt_5_guestnum
{
    public partial class Form1 : Form
    {
        int Count, Answer;
        int Max, Min;

        

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Random rn = new Random();
            Count = 0;  //設定猜測次數的初值
            Answer = rn.Next(1, 1000);
            Min = 1; //設定答案範圍的最小值
            Max = 999; //設定答案範圍的最大值
            MessageLabel.Text = Min.ToString() + " < ? < " + Max.ToString();
            CountLabel.Text = "共猜了" + Count.ToString() + "次";
            GuessTxtBox.Text =" "; //將輸入方塊裡的文字設為空白
            GuessTxtBox.Focus(); //讓輸入方塊擁有輸入焦點，即游標會停在此方塊內

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void ComfirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(GuessTxtBox.Text); //將輸入文字方塊的內容轉成數字
                Count++;
                if (num < Answer)
                {
                    if (num > Min) Min = num;
                    MessageBox.Show("再大一點");
                    MessageLabel.Text = Min.ToString() + " < ? < " + Max.ToString();
                }
                else if (num > Answer)
                {
                    if (num < Max) Max = num;
                    MessageBox.Show("再小一點");
                    MessageLabel.Text = Min.ToString() + " < ? < " + Max.ToString();
                }
                else
                {
                    MessageBox.Show("賓果");
                    MessageLabel.Text = "答案是" + Answer.ToString();
                }
                CountLabel.Text = "共猜了" + Count.ToString() + "次";
                GuessTxtBox.Text = "";  //清除文字方塊的內容
                GuessTxtBox.Focus();    //讓文字方塊重新取得輸入焦點
            }

            //當有錯誤發生時，不做任何處理，直接清除文字方塊的內容並讓文字方塊重新取得輸入焦點
            catch
            {
                GuessTxtBox.Text = "";
                GuessTxtBox.Focus();
            }
        }
    }
}
