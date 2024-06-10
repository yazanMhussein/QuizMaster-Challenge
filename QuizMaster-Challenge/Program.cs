using static System.Formats.Asn1.AsnWriter;

namespace QuizMaster_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // here I'm are using a try and catch method to test for errors.
            // I'm are first starting up the app  StartQuiz();.
            // if there is a error the catch method will get it.
            // finally will see if the app his finish and will tell the user about it.
            try
            {
                StartQuiz();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for participating in the quiz!");
            }
        }
        // here is where all of my logic for the code is
        public static void StartQuiz()
        {
            //here I,m printing to the console these two sentences
            Console.WriteLine("welcome to the Video Game Quiz");
            Console.WriteLine("Enter your answer using the letters A, B, C, or D");
            // here are my Questions
            string[] Questions ={
                "What year did the ps4 come out? \n A)1990 \n B) 2000 \n C) 2004  \n D) 2013",
                "What year did the xbox360 come out? \n A)1995 \n B) 2002 \n C) 2005  \n D) 2023",
                "What year did assassin's creed first gamme come out? \n A)2007 \n B) 2008 \n C) 2004  \n D) 2005",
                "What year did Grand Theft Auto come out? \n A)1990 \n B) 1997 \n C) 2004  \n D) 2008",
                "What year did Mass Effect come out? \n A)2009 \n B) 2006 \n C) 2007  \n D) 2008",
                "what is the most far cry game played? \n A)far cry 3 and far cry 5 \n B) far cry  1 and far 2 \n C) far cry 6 and far cry 4  \n D) far cry primal and new dawn"
            };
            // here are my Answer
            string[] Answer =
            {
                "D","C","A","B","C","A"

            };
            // I'm using the gameScore varibles to save and update the  gameScore 
            int gameScore = 0;
            // He I'm looping trough the Questions 
            for (int i = 0; i < Questions.Length; i++)
            {
                // Here I'm printing the Questions to the console by using the for i value for each questions.
                Console.WriteLine(Questions[i]);
                // Here I'm printing the answer to the console
                Console.WriteLine("Your answer : ");
                // here where is i let the user enter his answer using the console by using Console.ReadLine.
                string userAnswer = Console.ReadLine();

                // Here is where I'm check lot things 
                // frist i check to if the user enter the right answer if so then update the game score by 1
                // then removed the white space from the start and end of the answer that he put int using .Trim()
                // then i see if the the answer for the Questions that the user enter is equals to the right answer by using .Equals(Answer[i],
                // then i using this method to Ignore both upperCase and lowerCase because i will never what will the user enter so
                // i this method StringComparison.OrdinalIgnoreCase.
                //lasly if the user does not enter the right i give me the feedback with the right answer.
                if (userAnswer.Trim().Equals(Answer[i], StringComparison.OrdinalIgnoreCase))
                {
                    gameScore++;
                    Console.WriteLine("Correct!\n");
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is: " + Answer[i] + "\n");
                }
            }
            // here i print this at the end of the quiz so the user can know his score and know at the app his ended
            Console.WriteLine("Quiz completed. Your score is: " + gameScore + " out of " + Questions.Length);
        }
    }
}
 

