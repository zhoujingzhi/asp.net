using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "景珍", "林惠祥", "成蓉", "洪南昌", "龙玉民", "单江开", "田武山", "王三明" };
            int[] score = { 90, 65, 88, 70, 46, 81, 100, 68 };
            int sum = 0, avg;//总分和平均值
            string avgnames = "";//高于平均分的同学
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            avg = sum / score.Length;//获得平均值;
            Console.Write("平均分是{0}，高于平均分的有：", avg);
            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] > avg)
                {
                    avgnames += avgnames.Length > 0 ? ' ' + names[i] : names[i];
                }
            }
            Console.Write(avgnames);
        }
    }
}
