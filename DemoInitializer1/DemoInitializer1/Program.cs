using System;

namespace DemoInitializer1
{
    class Girlfriend
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Boy
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Girlfriend Girl{ get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //�Ϊ����l�ƾ��إߪ���
            Girlfriend gf1 = new Girlfriend { Name = "���P��",  };
            
            //������
            Girlfriend gf2 = new Girlfriend();
            gf2.Name = "���ɭY";
            gf2.Age = 21;

            //�δO�M����H��l�ƾ��إߪ���
            Boy boy1 = new Boy { Name = "�L�ߺa", Age = 24, Girl = new Girlfriend { Name = "�v�C�x", Age = 20 } };

            //������
            Boy boy2 = new Boy();
            Girlfriend gf3 = new Girlfriend();

            gf3.Name = "������";
            gf3.Age = 18;
            boy2.Name = "�L�T";
            boy2.Age = 24;
            boy2.Girl = gf3;

            Console.WriteLine("gf1 ��l�ƪ������G" + gf1.GetType().Name);
            Console.WriteLine("boy1 ��l�ƪ������G" + boy1.GetType().Name);

            Console.ReadKey();
        }
    }
}
