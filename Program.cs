using System;
namespace ExerciseLoop {
    public class StudentCode {
        public double GetAverage(int[] numbers) {
            double results = 0.0;

            if(numbers.Length > 0) {
                int total=0;
                int i = 0;
                do{
                    total+=numbers[i];
                    i++;
                }
                while(i < numbers.Length);

                results = (double)total / numbers.Length;
            }
            return results;
        }
    }
    class Program{
        static void Main(string [] args){
            int[] numbers={1,2,3};
            StudentCode studentCode = new StudentCode();
            double avarge = studentCode.GetAverage(numbers);
            Console.WriteLine("Avarge: "+ avarge);
        }
    }
}