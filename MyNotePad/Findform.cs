using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad
{
    public partial class Findform : Form
    {
        Mainform mf;
        int iFindStartIndex = 0;
        public Findform(Mainform form)
        {
            InitializeComponent();
            mf = form;
        }

        private int FindMyText(string searchText, int searchStart, int searchEnd)
        {
            // Initialize the return value to false by default.
            int returnValue = -1;

            // Ensure that a search string and a valid starting point are specified.
            if (searchText.Length > 0 && searchStart >= 0)
            {
                // Ensure that a valid ending value is provided.
                if (searchEnd > searchStart || searchEnd == -1)
                {
                    // Obtain the location of the search string in richTextBox1.
                    int indexToText = mf.tbContents.Find(searchText, searchStart, searchEnd, RichTextBoxFinds.MatchCase);
                    // Determine whether the text was found in richTextBox1.
                    if (indexToText >= 0)
                    {
                        // Return the index to the specified search text.
                        returnValue = indexToText;
                    }
                }
            }

            return returnValue;
        }

        private int WordNum(String String, String Word)
        {
            int Num;
            Num = String.Length - String.Replace(Word, "").Length;
            Num = Num / Word.Length;

            return Num;

        }

        private void findClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void findCount_Click(object sender, EventArgs e)
        {
            findStatus.Text = WordNum(mf.tbContents.Text, findTarget.Text).ToString();
        }

        private void findNext_Click(object sender, EventArgs e)
        {
            //찾는 문자열 길이
            int iFindLength = findTarget.TextLength;
            iFindStartIndex = FindMyText(findTarget.Text, iFindStartIndex, mf.tbContents.TextLength);
            if (iFindStartIndex == -1)
            {
                iFindStartIndex = 0;
                findStatus.Text = "Can't find";
                return;
            }

            findStatus.Text = "Find";
            mf.tbContents.Focus();

            //다음 찾기를 위해 찾은 문자열 위치 저장
            iFindStartIndex += iFindLength;
        }

        private void findReplace_Click(object sender, EventArgs e)
        {
            //찾는 문자열 길이
            int iFindLength = findTarget.TextLength;
            iFindStartIndex = FindMyText(findTarget.Text, iFindStartIndex, mf.tbContents.TextLength);
            if (iFindStartIndex == -1)
            {
                iFindStartIndex = 0;
                findStatus.Text = "Can't find";
                return;
            }

            mf.tbContents.SelectedText = mf.tbContents.SelectedText.Replace(findTarget.Text, findReplaceTarget.Text);
            findStatus.Text = "Replaced";
            mf.tbContents.Focus();

            //다음 찾기를 위해 찾은 문자열 위치 저장
            iFindStartIndex += iFindLength;
        }
    }
}
