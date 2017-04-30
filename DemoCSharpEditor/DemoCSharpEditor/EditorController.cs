using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;

namespace DemoCSharpEditor
{
    /// <summary>
    /// 控制器
    /// </summary>
    public class EditorController
    {
        /// <summary>
        /// 高亮字颜色
        /// </summary>
        public Color LightColor { get; set; }

        /// <summary>
        /// 文本色
        /// </summary>
        public Color TextColor { get; set; }

        /// <summary>
        /// RichTextBox 控件引用
        /// </summary>
        private RichTextBox rich;

        private TextBox loginfo;

        /// <summary>
        /// 关键字列表
        /// </summary>
        private List<string> keywords = new List<string>();

        public EditorController(RichTextBox r, TextBox l)
        {
            if (r == null || l == null)
                throw new Exception("控制器，初始化失败。");

            this.loginfo = l;
            this.rich = r;
            this.rich.KeyUp += new KeyEventHandler(rich_KeyUp);
            this.LoadKeyWord();

            this.LightColor = Color.Blue;
            this.TextColor = this.rich.ForeColor;
        }

        void rich_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue < 229)
                this.LightCurrentKeyWord();
        }

        /// <summary>
        /// 从文本文件装载关键字列表
        /// </summary>
        private void LoadKeyWord()
        {
            string sf = "cs.txt";

            if (File.Exists(sf))
            {
                keywords.Clear();
                using (StreamReader sr = new StreamReader(sf))
                {
                    string sl = sr.ReadLine();
                    do
                    {
                        if (sl != null)
                            keywords.Add(sl);

                        sl = sr.ReadLine();
                    } while (sl != null);
                }
            }
        }

        /// <summary>
        /// 高亮关键字
        /// </summary>
        private void LightCurrentKeyWord()
        {
            CurrentWord last = this.rich.Text.CursorWord(this.rich.SelectionStart);

            if (last != null)
            {
                var query = from w in this.keywords
                            where w == last.Word
                            select w;

                int oldindex = this.rich.SelectionStart;
                int oldleng = this.rich.SelectionLength;
                this.rich.SelectionStart = last.StartIndex;
                this.rich.SelectionLength = last.Length;

                if (query.Count<string>() > 0)
                {
                    this.rich.SelectionColor = this.LightColor;
                }
                else
                {
                    this.rich.SelectionColor = this.TextColor;
                }

                this.rich.SelectionLength = oldleng;
                this.rich.SelectionStart = oldindex;
                this.rich.SelectionColor = this.TextColor;
            }
        }

        /// <summary>
        /// 格式化代码
        /// </summary>
        private string MakeCode()
        {
            string code = @" 
                    using System;
                    using System.Collections.Generic;
                    using System.ComponentModel;
                    using System.Data;
                    using System.Drawing;
                    using System.Text;
                    using System.Windows.Forms;
                    namespace DemoTest
                    {
                        public class Test 
                        {
                            public void TestMethod() 
                            {"
                                + this.rich.Text + @"
                            }
                        }
                    }";
            return code;
        }

        /// <summary>
        /// 编译并运行代码
        /// </summary>
        public void Compile()
        {
            this.loginfo.Text = "信息：准备编译。\n";
            using (CSharpCodeProvider provider = new CSharpCodeProvider())
            {
                string[] refs = { "System.dll", "System.Data.dll", "System.Deployment.dll", "System.Drawing.dll", "System.Windows.Forms.dll", "System.Xml.dll" };

                CompilerParameters opt = new CompilerParameters();
                opt.ReferencedAssemblies.AddRange(refs);

                CompilerResults res = provider.CompileAssemblyFromSource(opt, this.MakeCode());

                if (res.Errors.Count > 0)
                {
                    foreach (CompilerError e in res.Errors)
                        this.loginfo.AppendText(string.Format("编译错误：{0}\n", e.ErrorText));
                    return;
                }

                this.loginfo.AppendText("信息：编译成功，准备运行。\n");
                try
                {
                    Assembly assembly = res.CompiledAssembly;
                    Type type = assembly.GetType("DemoTest.Test");
                    object obj = Activator.CreateInstance(type);
                    this.loginfo.AppendText("信息：运行。\n");
                    type.GetMethod("TestMethod").Invoke(obj, null);
                }
                catch (Exception e)
                {
                    this.loginfo.AppendText(string.Format("运行错误：{0} \n  {1} \n", e.Message, e.StackTrace));
                }

                this.loginfo.AppendText("完毕。\n");
            }
        }


    }
}
