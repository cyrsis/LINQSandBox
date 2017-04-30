using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Linq2ObjectsDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //�w�q�Ӧr�Ŧ�Ʋ�
            string[] friends = { "�O�n���D", "���a�j�p�j", "�X�����D", "�]�ڸt�h", "���R���D" };

            Console.WriteLine("���ӶǲΪ���k�M��\n");

            //��l�Ƥ@�ӷs�����X�A�Ω��x�s�᭱�d�ߨ쪺����
            ArrayList values = new ArrayList();

            //�ϥζǲΪ���k�M��r�Ŧ�]�t�u���D�v�����աC
            //�ˬd�Ʋէ�_�X���󪺤�����Jvalues���X��
            foreach (string word in friends)
            {
                if (word.IndexOf("���D") > -1)
                    values.Add(word);
            }
            
            //�ﵲ�G�i��Ƨ�
            values.Sort();

            //�ˬd�ÿ�X�d�ߵ��G
            foreach (string w in values)
                Console.WriteLine(w);

            Console.WriteLine("\n------------------------\n");
            Console.WriteLine("�ϥ�LINQ��k�d��\n");

            //�ϥ�LINQ�޳N�M��]�t�u���D�v������,�ùﵲ�G�i��ƧǡC
            var value = from v in friends
                        where v.IndexOf("���D") > -1
                        orderby v
                        select v;

            
            //�ˬd�ÿ�X�d�ߵ��G
            foreach (var w in value)
                Console.WriteLine(w);

            //���F��K�˵����浲�G�A���ݨϥΪ̫���ᵲ���{��
            Console.ReadKey();
        }
    }
}
