using System;
namespace ptg_project
{
    public class doctor
    {
        public doctor()
        {
        }
        public string username;
        public string pass;
        public string name;
        public string pname;
        public int page;
        public string ptest;
        public string presults;
        public string good;

        public void printhi(){
            Console.WriteLine($"Hello, Doctor {name}! Please enter the patient info.");
            Console.WriteLine(" ");
            }
        public void resp()
        {
            if (presults == "positive" || presults == "p" || presults == "Postivive" || presults == "+" && page <= 16)
            {
                good = "not good";
            } else if (presults == "negative" || presults == "n" || presults == "Negative"  || presults == "-" && page <= 16 || page > 16)
            {
                good = "good";
            } else if (presults == "positive" || presults == "p" || presults == "Postivive" || presults == "+" && page <= 40)
            {
                good = "not bad, not good";
            } else
            {
                Console.WriteLine("invalid input");
            }
            Console.WriteLine($"Thanks, {name}. The results for {pname} for {ptest} test are {presults}. {pname} is {page} years old. This is {good} restlts.");
        }
    }
}
