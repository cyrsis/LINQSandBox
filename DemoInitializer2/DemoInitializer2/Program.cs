using System;
using System.Collections.Generic;

namespace DemoInitializer2
{
    /// <summary>
    /// �ܽd����
    /// </summary>
    class Girlfriend
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    /// <summary>
    /// �ܽd����
    /// </summary>
    class Boy
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        /// <summary>
        /// ���X���e
        /// </summary>
        public List<Girlfriend> Girls { get; set;}
    }


    class Program
    {
        static void Main(string[] args)
        {
            //�ζ��X��l�ƾ��إ߶��X
            List<string> gfs1 = new List<string> { "�v�C�x", "������", "������" };

            //������
            List<string> gfs2 = new List<string>();
            gfs2.Add("�v�C�x");
            gfs2.Add("������");
            gfs2.Add("������");

            //���󶰦X��l�ƾ��_�X�ϥ�
            Boy boy = new Boy { Name = "�L�ߺa", Age = 24, 
                                    Girls = new List<Girlfriend> 
                                    { 
                                        new Girlfriend { Name = "�v�C�x", Age = 23 }, 
                                        new Girlfriend { Name = "������", Age = 18 }, 
                                        new Girlfriend { Name = "������", Age = 16 } 
                                    } 
                               };


            Console.ReadKey();

        }
    }
}
