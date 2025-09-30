using System.Drawing;

namespace GameHub___Afl
{
    enum Point : int
    {
        EM = 0,
        S1 = 200,
        S2 = 400,
        S3 = 600
    }

    enum Tema { EM = 0, Fodbold, Film, Musik }

    internal class Program
    {
        static void Main(string[] args)
        {
            Jeopardy();
        }

        static void Jeopardy()
        {
            {
                string[] answersFootball =
                    {
                "Dette er det runde objekt, som \nspillerne sparker til i fodbold",
                "Denne argentinske spiller scorede \ndet berømte \"Guds hånd\"-mål ved VM i 1986.",
                "Denne italienske klub har vundet \nflest Champions League-titler."
                };
                string[] answersMovie =
                    {
                "Denne filmtrilogi følger Frodo \nog hans rejse for at ødelægge Ringen.",
                "Denne film fra 2010, instrueret \naf Christopher Nolan, handler om \ndrømme inden i drømme.",
                "Denne science fiction-film fra \n1982, instrueret af Ridley Scott, foregår \ni en dystopisk fremtid med replikanter"
                };
                string[] answersMusic =
                    {
                "Denne britiske sanger er kendt \nsom \"The King of Pop\" og havde hits som \n\"Thriller\" og \"Billie Jean\".",
                "Denne gruppe fra Liverpool blev \nverdensberømte i 1960'erne og er kendt for \nsange som Hey Jude og Let It Be.",
                "Denne britiske sangerinde fik global \nsucces med albummet 25 og hittet Hello."
                };

                int totalPoints = 0;

                Point[,] board = new Point[3, 3];
                Tema[,] answers = new Tema[1, 3];

                Console.WriteLine(" ==================================== ");
                Console.WriteLine("        VELKOMMEN TIL JEOPARDY        ");
                Console.WriteLine(" ==================================== ");

                SetupStartingPosition(board);
                SetupThemeStartingPosition(answers);


                Console.ResetColor();
                while (true)

                {
                    Console.WriteLine("       A          B          C");
                    PrintBoardAnswers(answers);
                    PrintBoard(board);

                    Console.ResetColor();

                    Console.WriteLine(" ==================================== ");
                    Console.WriteLine($"          Du har nu {totalPoints} point");
                    Console.WriteLine(" ==================================== ");

                    Console.WriteLine("Du skal nu vælge et tema og et pointal for at bestemme dit svar");
                    Console.WriteLine("Skriv det i form af f.eks." + "(B2)");
                    Console.Write("Valg: ");

                    string choice;

                    choice = Console.ReadLine();

                    if (choice == "quit")
                    {
                        break;
                    }

                    if (choice.Length != 2 || !"ABC".Contains(choice[0]) || !"123".Contains(choice[1]))
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ugyldigt valg. Prøv igen.");
                        Console.ResetColor();
                        continue;
                    }

                    switch (choice)
                    {
                        // Football 200
                        case "A1":
                            Console.Clear();
                            string football200 = answersFootball[0];
                            string[] optionsFootball200 = {
                        "Hvad er en fodbold?",
                        "Hvad er en håndbold?",
                        "Hvad er en basketbold?"
                    };
                            int correctFootball200 = 0;

                            int footballPoints200 = 200;

                            totalPoints = HandleQuestion(football200, optionsFootball200, correctFootball200, footballPoints200, totalPoints);
                            board[0, 0] = Point.EM;
                            break;

                        // Football 400 
                        case "A2":
                            Console.Clear();
                            string football400 = answersFootball[1];
                            string[] optionsFootball400 = {
                        "Hvem er Gary Lineker?",
                        "Hvem er Diego Maradona?",
                        "Hvem er Pele?"
                    };

                            int correctFootball400 = 1;

                            int footballPoints400 = 400;

                            totalPoints = HandleQuestion(football400, optionsFootball400, correctFootball400, footballPoints400, totalPoints);

                            break;

                        // Football 600
                        case "A3":
                            Console.Clear();
                            string football600 = answersFootball[2];
                            string[] optionsFootball600 = {
                        "Hvad er AC Milam?",
                        "Hvad er Juventus?",
                        "Hvad er Inter Milan?"
                    };

                            int correctFootball600 = 0;

                            int footballPoints600 = 600;

                            totalPoints = HandleQuestion(football600, optionsFootball600, correctFootball600, footballPoints600, totalPoints);

                            break;

                        // Movie 200
                        case "B1":
                            Console.Clear();
                            string movie200 = answersMovie[0];
                            string[] optionsMovie200 = {
                        "Hvad er Star Wars?",
                        "Hvad er Harry Potter?",
                        "Hvad er Ringes Herre?"
                    };

                            int correctMovie200 = 2;

                            int moviePoints200 = 200;

                            totalPoints = HandleQuestion(movie200, optionsMovie200, correctMovie200, moviePoints200, totalPoints);

                            break;

                        // Movie 400
                        case "B2":
                            Console.Clear();
                            string movie400 = answersMovie[1];
                            string[] optionsMovie400 = {
                        "Hvad er Memento?",
                        "Hvad er Inception?",
                        "Hvad er The Prestige?"
                    };

                            int correctMovie400 = 1;

                            int moviePoints400 = 400;

                            totalPoints = HandleQuestion(movie400, optionsMovie400, correctMovie400, moviePoints400, totalPoints);

                            break;

                        // Movie 600
                        case "B3":
                            Console.Clear();
                            string movie600 = answersMovie[2];
                            string[] optionsMovie600 = {
                        "Hvad er Alien?",
                        "Hvad er Tron?",
                        "Hvad er Blade Runner?"
                    };

                            int correctMovie600 = 2;

                            int moviePoints600 = 600;

                            totalPoints = HandleQuestion(movie600, optionsMovie600, correctMovie600, moviePoints600, totalPoints);

                            break;

                        // Music 200
                        case "C1":
                            Console.Clear();
                            string music200 = answersMusic[0];
                            string[] optionsMusic200 = {
                        "Hvem er Micheal Jackson?",
                        "Hvem er Freddie Mercury?",
                        "Hvem er Elton John"
                    };

                            int correctMusic200 = 0;

                            int musicPoints200 = 200;

                            totalPoints = HandleQuestion(music200, optionsMusic200, correctMusic200, musicPoints200, totalPoints);

                            break;

                        // Music 400
                        case "C2":
                            Console.Clear();
                            string music400 = answersMusic[1];
                            string[] optionsMusic400 = {
                        "Hvem er Queen?",
                        "Hvem er The Rolling Stones?",
                        "Hvem er The Beatles?"
                    };

                            int correctMusic400 = 2;

                            int musicPoints400 = 400;

                            totalPoints = HandleQuestion(music400, optionsMusic400, correctMusic400, musicPoints400, totalPoints);

                            break;

                        // Music 600
                        case "C3":
                            Console.Clear();
                            string music600 = answersMusic[2];
                            string[] optionsMusic600 = {
                        "Hvem er Dua Lipa",
                        "Hvem er Adele?",
                        "Hvem er Jessie J"
                    };

                            int correctMusic600 = 1;

                            int musicPoints600 = 600;

                            totalPoints = HandleQuestion(music600, optionsMusic600, correctMusic600, musicPoints600, totalPoints);

                            break;

                    }

                    Console.Clear();
                }
            }


            static void PrintBoard(Point[,] b)

            {

                for (int row = 0; row < b.GetLength(0); row++)
                {
                    Console.ResetColor();
                    Console.Write(" " + (row + 1));


                    for (int col = 0; col < b.GetLength(1); col++)
                    {

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        if (b[row, col] == Point.EM)
                        {
                            Console.Write("   ");
                            Console.Write("    ");
                            Console.Write("    ");
                        }
                        else
                        {
                            Console.Write("    ");
                            Console.Write((int)b[row, col]);
                            Console.Write("    ");
                        }


                    }


                    Console.WriteLine();
                }
            }
            static void PrintBoardAnswers(Tema[,] b)

            {

                for (int row = 0; row < b.GetLength(0); row++)
                {
                    for (int col = 0; col < b.GetLength(1); col++)

                    {

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Blue;

                        if (b[row, col] == Tema.EM)
                        {
                            Console.Write("  ");
                        }
                        else
                        {
                            Console.Write("   ");
                            Console.Write(b[row, col]);
                            Console.Write("    ");
                        }


                    }


                    Console.WriteLine();
                }
            }
            static void SetupStartingPosition(Point[,] b)
            {


                b[0, 0] = Point.S1;
                b[0, 1] = Point.S1;
                b[0, 2] = Point.S1;

                b[1, 0] = Point.S2;
                b[1, 1] = Point.S2;
                b[1, 2] = Point.S2;

                b[2, 0] = Point.S3;
                b[2, 1] = Point.S3;
                b[2, 2] = Point.S3;


            }
            static void SetupThemeStartingPosition(Tema[,] b)
            {
                b[0, 0] = Tema.Fodbold;
                b[0, 1] = Tema.Film;
                b[0, 2] = Tema.Musik;
            }
            static int HandleQuestion(string question, string[] options, int correctOption, int points, int totalPoints)
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" ======== TIL 200 POINT ======== ");
                    Console.ResetColor();
                    Console.WriteLine(question);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" =============================== ");
                    Console.WriteLine();
                    Console.WriteLine("Du har nu 3 valgmuligheder:");

                    for (int i = 0; i < options.Length; i++)
                    {
                        Console.ResetColor();
                        Console.WriteLine($"{i + 1}. {options[i]}");
                    }
                    Console.ResetColor();

                    Console.Write("Valg: ");
                    string answer = Console.ReadLine();

                    if (answer == (correctOption + 1).ToString())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        totalPoints += points;
                        Console.WriteLine("KORREKT + " + points);
                        Console.ResetColor();
                        Console.WriteLine("Tryk på en knap for at prøve igen");
                        Console.ReadKey();
                    }
                    else if (answer != "1" && answer != "2" && answer != "3")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ugyldigt valg. Prøv igen.");
                        Console.ResetColor();
                        continue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        totalPoints -= points;
                        Console.WriteLine("FORKERT - " + points);
                        Console.ResetColor();
                        Console.WriteLine("Tryk på en knap for at prøve igen");
                        Console.ReadKey();
                    }

                    return totalPoints;
                }
            }

        }
    }
    
}
