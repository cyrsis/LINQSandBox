using System;
using System.Linq.Expressions;

namespace DemoLambda2
{
    class Program
    {
        static void Main(string[] args)
        {
            //�w�qLambd��F���ؿ���
            Expression<Func<int, bool>> tree = n => n > 168;

            //���Ѫ�F��
            BinaryExpression body = (BinaryExpression)tree.Body;
            ParameterExpression left = (ParameterExpression)body.Left;
            ConstantExpression right = (ConstantExpression)body.Right;

            //���ѵ��G
            Console.WriteLine("���ѵ��G: {0} {1} {2}\n",
                              left.Name, body.NodeType, right.Value);

            //�sĶ�ؿ���
            Func<int, bool> t = tree.Compile();


            //����ؿ���
            Console.WriteLine(string.Format("1000 �O�_�j�� 168 :{0}", t(1000)));


            Console.ReadKey();
        }
    }
}
