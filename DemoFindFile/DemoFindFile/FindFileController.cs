using System.IO;
using System.Linq;

namespace DemoFindFile
{
    /// <summary>
    /// 控制器
    /// </summary>
    public class FindFileController
    {

        /// <summary>
        /// 檔案分類
        /// </summary>
        private ILookup<string, string> filetype;

        private string path;
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                this.LoadFiles(value);
                this.path = value;
            }
        }

        private string[] files;
        /// <summary>
        /// 全部檔案排序
        /// </summary>
        public string[] Files
        {
            get { return files; }
        }

        /// <summary>
        /// 讀取檔案
        /// </summary>
        private void LoadFiles(string spath)
        {
            this.files = Directory.GetFiles(spath,"*.*", SearchOption.AllDirectories);
        }

        /// <summary>
        /// 尋找檔案
        /// </summary>
        public string[] FindFile(string p)
        {
            if (this.files == null)
                return null;

            //利用LINQ搜索資料
            var query = from q in this.files
                        where q.IndexOf(p) > -1
                        select q;

            return query.ToArray();
        }

        /// <summary>
        /// 得到按檔案類型分組的檔案
        /// </summary>
        public string[] GetFilesByType(string stype)
        {
            if (this.filetype == null || stype == null)
                return null;

            var files = from fn in (from f in this.filetype
                                    where f.Key == stype 
                                    select f).First()
                        orderby fn
                        select fn;

            return files.ToArray();
        }

        /// <summary>
        /// 得到檔案類型
        /// </summary>
        /// <returns></returns>
        public string[] FileTypes()
        {
            if (this.files == null)
                return null;

            this.filetype = this.files.ToLookup(fn => fn.Substring(fn.LastIndexOf('.')).ToUpper());

            //得到檔案類型，並排序
            var ft = from t in this.filetype
                     orderby t.Key
                     select t.Key;

            return ft.ToArray();

        }
        
    }
}
