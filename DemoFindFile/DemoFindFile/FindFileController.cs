using System.IO;
using System.Linq;

namespace DemoFindFile
{
    /// <summary>
    /// ���
    /// </summary>
    public class FindFileController
    {

        /// <summary>
        /// �ɮפ���
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
        /// �����ɮױƧ�
        /// </summary>
        public string[] Files
        {
            get { return files; }
        }

        /// <summary>
        /// Ū���ɮ�
        /// </summary>
        private void LoadFiles(string spath)
        {
            this.files = Directory.GetFiles(spath,"*.*", SearchOption.AllDirectories);
        }

        /// <summary>
        /// �M���ɮ�
        /// </summary>
        public string[] FindFile(string p)
        {
            if (this.files == null)
                return null;

            //�Q��LINQ�j�����
            var query = from q in this.files
                        where q.IndexOf(p) > -1
                        select q;

            return query.ToArray();
        }

        /// <summary>
        /// �o����ɮ��������ժ��ɮ�
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
        /// �o���ɮ�����
        /// </summary>
        /// <returns></returns>
        public string[] FileTypes()
        {
            if (this.files == null)
                return null;

            this.filetype = this.files.ToLookup(fn => fn.Substring(fn.LastIndexOf('.')).ToUpper());

            //�o���ɮ������A�ñƧ�
            var ft = from t in this.filetype
                     orderby t.Key
                     select t.Key;

            return ft.ToArray();

        }
        
    }
}
