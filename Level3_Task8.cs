using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			double a=0.1, b=1, h=0.05;
            double sum = 0, meat = 1, y=0;
            for(double x=a;x<=b;x+=h){
                sum=0;
                meat=1;
                y=0;
                for(int i=0;abs(meat)>=0.0001;i++){
                    meat=Math.Pow(2*x,i)/fact(i);
                    sum+=meat;
                }
                y=Math.Pow(Math.E,2*x);
                Console.WriteLine($"X: {x}, S: {sum}, Y: {y}");
            }
		}
        static int fact(int n){
            if(n<=1) return 1;
            return n*fact(n-1);
        }
        static double abs(double n){
            if(n>0) return n;
            return -1*n;
        }
	}
}
