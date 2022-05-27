using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyNotePad
{
    public partial class Mainform : Form
    {
        private bool isModified;//열린 파일의 수정
        public Mainform()
        {
            InitializeComponent();
            this.isModified = false;
        }

        public Color MirSelColor()  // ColorDialog로 색상 선택
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                return cd.Color;
            }
            else { return Color.Black; }
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbContents.Text = "";
            this.isModified = false;
            toolStripStatusLabel3.Text = "New";
        }

        string filename = "";

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.isModified)
            {
                string msg = string.Format("{0} 파일의 내용이 변경되었습니다.\r\n\r\n변경된 내용을 저장하시겠습니까?", filename);
                DialogResult result = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    //저장 메뉴 실행과 동일
                    저장ToolStripMenuItem_Click(null, null);
                }
                else if (result == DialogResult.Cancel)
                {
                    //취소 -> 파일 열기 실행 X
                    return;
                }
            }

            //1. 사용자에게 열 파일 을 선택 하게 함
            this.openFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            openFileDialog1.ShowDialog();


            //1-1 선택한 파일명을 변수에 저장
            filename = openFileDialog1.FileName;

            //2. 파일의 내용을 읽는다.
            string Data = System.IO.File.ReadAllText(filename);

            //3. 화면에 표시 한다.
            tbContents.Text = Data;
            this.isModified = false;
            toolStripStatusLabel3.Text = "New";
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //그렇지 않으면 다른이름으로 저장과 동일
            if (filename == "")
            {
                //1. 사용자 에게 저장할 파일을 선택 하게 함
                this.saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
                this.saveFileDialog1.ShowDialog();


                //2. 파일을 저장 한다.            
                System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);
                this.isModified = false;
                toolStripStatusLabel3.Text = "Saved";

                //3. 파일명을 기억
                filename = saveFileDialog1.FileName;
            }
            else
            {
                //해당 파일명으로 현재 내용을 저장

                //2. 파일을 저장 한다.            
                System.IO.File.WriteAllText(filename, tbContents.Text);
                this.isModified = false;
                toolStripStatusLabel3.Text = "Saved";
            }

        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. 사용자 에게 저장할 파일을 선택 하게 함
            this.saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            this.saveFileDialog1.ShowDialog();

            //2. 파일을 저장 한다.            
            System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);
            this.isModified = false;
            toolStripStatusLabel3.Text = "Saved";
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.isModified)
            {
                string msg = string.Format("{0} 파일의 내용이 변경되었습니다.\r\n\r\n변경된 내용을 저장하시겠습니까?", filename);
                DialogResult result = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    //저장 메뉴 실행과 동일
                    저장ToolStripMenuItem_Click(null, null);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 프로그램 종료
            this.Close();
        }

        private void 자동줄바꿈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbContents.WordWrap = !tbContents.WordWrap;
            자동줄바꿈ToolStripMenuItem.Checked = !자동줄바꿈ToolStripMenuItem.Checked;
        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
            tbContents.Font = fontDialog1.Font;
        }

        private void 상태표시줄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = 상태표시줄ToolStripMenuItem.Checked;
        }

        private void 메모장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAbout f = new fAbout();
            f.ShowDialog();
        }

        private void 배경색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 배경색 변경
            tbContents.BackColor = MirSelColor();
        }

        private void 글자색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 글자색 변경
            tbContents.ForeColor = MirSelColor();
        }

        private void TbContents_SelectionChanged(object sender, EventArgs e)
        {
            // 현재 Ln, Col
            int ln = tbContents.GetLineFromCharIndex(tbContents.SelectionStart) + 1;
            int col = tbContents.SelectionStart - tbContents.GetFirstCharIndexOfCurrentLine();
            toolStripStatusLabel1.Text = "Ln : " + ln + "   " + "Col : " + col;

            // 전채 length, lines
            int length = tbContents.TextLength;
            long lines = tbContents.GetLineFromCharIndex(tbContents.TextLength) + 1;
            toolStripStatusLabel2.Text = "Length : " + length + "   " + "Lines : " + lines;
        }



        private void 찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Findform findForm = new Findform(this);
            findForm.Show();
        }

        private void tbContents_TextChanged(object sender, EventArgs e)
        {
            this.isModified = true;
            if (toolStripStatusLabel3.Text != "Editing")
                toolStripStatusLabel3.Text = "Editing";
        }
    }
}

