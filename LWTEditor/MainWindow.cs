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

namespace LWTEditor
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }
        private void BrowseBtnClick(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePath.Text = ofd.FileName;
            }
        }
        private void EditBtnClick(object sender, EventArgs e)
        {
            try
            {
                var file = new FileInfo(filePath.Text);
                if (!file.Exists)
                {
                    MessageBox.Show("文件不存在或是目录", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    file.LastWriteTime = editTimePicker.Value;
                    MessageBox.Show("操作成功完成", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("拒绝访问", "", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("路径不能为空", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
