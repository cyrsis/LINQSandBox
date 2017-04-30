using System;
using System.Linq.Expressions;

namespace DemoLambda2
{
    class Program
    {
        static void Main(string[] args)
        {
            //定義Lambd表達式目錄樹
            Expression<Func<int, bool>> tree = n => n > 168;

            //分解表達式
            BinaryExpression body = (BinaryExpression)tree.Body;
            ParameterExpression left = (ParameterExpression)body.Left;
            ConstantExpression right = (ConstantExpression)body.Right;

            //分解結果
            Console.WriteLine("分解結果: {0} {1} {2}\n",
                              left.Name, body.NodeType, right.Value);

            //編譯目錄樹
            Func<int, bool> t = tree.Compile();


            //執行目錄樹
            Console.WriteLine(string.Format("1000 是否大於 168 :{0}", t(1000)));


            Console.ReadKey();
        }
    }
}
