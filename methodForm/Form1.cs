using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace methodForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            //创建一个打开并选择文件对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //如果确定选中文件
            if (ofd.ShowDialog() == DialogResult.OK) {
                //得到全路径和文件名
                String[] files = ofd.FileNames;
                foreach (String item in files)
                {
                    
                }
                //实例化一个 xml 文档对象
                XmlDocument xdc = new XmlDocument();
                //把选中的文件加载到 xdc 对象中
                xdc.Load(files[0]);

            }
        }
        private List<String> LoadT_W(string location)
        {

            string path = System.Windows.Forms.Application.StartupPath + location;

            //MessageBox.Show(path);

            XmlDocument xdc = new XmlDocument();
            xdc.Load(path);
            XmlNode rootNode = xdc.DocumentElement;
            //MessageBox.Show(rootNode.Name);
            List<String> b = new List<string>();
            foreach (XmlNode item in rootNode)
            {
                String tp = item.Name.Substring(1);
                b.Add(tp);
                // lvRT3.Items.Add(tp);
            }

            return b;
        }
    }
}
