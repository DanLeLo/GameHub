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
            Menu();
        }
        static void Menu()
        {
       
            string choice;
            while (true)
            {

                Console.Clear();
                Console.WriteLine("vælg en");
                Console.WriteLine("1. mastermind");
                Console.WriteLine("2. jeopardy");
                Console.WriteLine("3. Chess");

                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                        {
                            Console.Clear();
                            MasterMind();
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            Jeopardy();
                            break;
                        }
                    case "3": {
                            Console.Clear();
                            Chess();
                            break;
                        }
                    case "quit":
                        {
                            return;
                        }
                }

            }
        
        }
        static void Jeopardy()
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
                Console.WriteLine($"         Du har nu {totalPoints} point");
                Console.WriteLine(" ==================================== ");

                Console.WriteLine("Du skal nu vælge et tema og et pointal for at bestemme dit svar");
                Console.WriteLine("Skriv det i form af f.eks." + "(B2)");
                Console.Write("Valg: ");

                string choice;

                choice = Console.ReadLine().ToUpper();

                if (choice == "QUIT")
                {
                    break;
                }

                if (choice.Length != 2 || !"ABC".Contains(choice[0]) || !"123".Contains(choice[1]))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ugyldigt valg. Prov igen.");
                    Console.ResetColor();
                    continue;
                }




                switch (choice)
                {
                    // Football 200
                    case "A1":
                        if (board[0, 0] == Point.EM)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
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

                        }
                        break;

                    // Football 400 
                    case "A2":
                        if (board[1, 0] == Point.EM)
                        {
                            Console.WriteLine();
                        }
                        else
                        {

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
                            board[1, 0] = Point.EM;
                        }
                        break;

                    // Football 600
                    case "A3":
                        if (board[2, 0] == Point.EM)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
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
                            board[2, 0] = Point.EM;
                        }

                        break;

                    // Movie 200
                    case "B1":
                        if (board[0, 1] == Point.EM)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
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
                            board[0, 1] = Point.EM;
                        }
                        break;

                    // Movie 400
                    case "B2":
                        if (board[1, 1] == Point.EM)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
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
                            board[1, 1] = Point.EM;

                        }
                        break;

                    // Movie 600
                    case "B3":
                        if (board[2, 1] == Point.EM)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
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
                            board[2, 1] = Point.EM;

                        }
                        break;

                    // Music 200
                    case "C1":
                        if (board[0, 2] == Point.EM)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
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
                            board[0, 2] = Point.EM;
                        }
                        break;

                    // Music 400
                    case "C2":
                        if (board[1, 2] == Point.EM)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
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
                            board[1, 2] = Point.EM;

                        }
                        break;

                    // Music 600
                    case "C3":
                        if (board[2, 2] == Point.EM)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
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
                            board[2, 2] = Point.EM;
                        }
                        break;

                }

                Console.Clear();

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

        static void MasterMind()
        {
            //    /*mit program skal indeholde
            //     * ---Velkomst samt regler--------------------------------------------------------------------------
            //     * random generator---------------------------------------------------------------------------------
            //     * spiller må kun skrive 4-cifret tal mellem 1111 og 9999-------------------------------------------
            //     * spiller har kun 10 forsøg------------------------------------------------------------------------
            //     * spiller skal have feedback for hvert gæt de har lavet samt antal gæt de har tilbage--------------
            //     * spiller skal have feedback om de har et rigtigt tal på rigtig plads------------------------------
            //     * spiller skal have feedback om de har et rigtigt tal på forkert plads
            //     * jeg skal lave en ui
            //     */

            int userCodeLenght = 4;
            int userTry = 1;
            int maxTry = 11;



            //Velkomst samt regelsæt
            Console.WriteLine("Velkommen til mastermind!");
            Console.WriteLine("Regler: ");
            Console.WriteLine("Du skal gætte en 4-cifret kode");
            Console.WriteLine("Du har 10 forsøg til at gætte koden");
            Console.WriteLine("Får du en sort pin betyder det at du har det rigtige tal på den rigtige plads");
            Console.WriteLine("Får du en hvid pin betyder det at du har et rigtig tal men forkert plads");

            //random gen
            Random rnd = new Random();
            int pcCode = rnd.Next(1111, 9999);
            //Console.WriteLine(pcCode); // Er kun for at se pckoden HUSK AT SLETTE!!!

            while (userTry < maxTry)
            {
                string userInput = Console.ReadLine();
                int userChoiceAsInt = int.Parse(userInput);
                if (userChoiceAsInt < 1111 || userChoiceAsInt > 9999)
                {
                    Console.WriteLine("Ugyldigt. dit gæt skal være 4-cifret mellem 1-9");
                    continue;
                }

                int korrektPlads = 0;
                int korrektTal = 0;

                //laver både user og pc kode til array
                char[] userGuess = userInput.ToCharArray();
                char[] pcArray = pcCode.ToString().ToCharArray();
                for (int i = 0; i < pcArray.Length; i++)
                {
                    if (userGuess[i] == pcArray[i])
                    {
                        korrektPlads++;
                    }
                }
                Console.WriteLine($"du har {korrektPlads} tal på rigtig plads");
                korrektPlads = 0;

                //for (int i = 0; i < pcArray.Length; i++)
                //{
                //    if (userGuess[i] == pcCode)// jeg skal have den til at tælle hvor mange rigtige men forkert plads
                //    {
                //        korrektTal++;
                //    }
                //    Console.WriteLine($"du har {korrektTal} rigtige tal men på forkert plads");
                //}


                if (userInput == pcCode + "")
                {
                    Console.WriteLine("Tillykke du har vundet");
                    break;
                }

                else
                {

                    Console.WriteLine($"Du har nu brugt {userTry++} ud af 10 forsøg");
                    continue;
                }

            }
            if (userTry == maxTry)
            {
                Console.WriteLine("Desværre du har brugt alle 10 forsøg");
            }
        }


        /// <summary>
        /// 
        /// Chess - aflevering
        /// af Johan k. Nielsen
        /// 
        /// </summary>

        //Variables
        public static bool IsRunning = true;

        //String
        private static string info_intro = "Current player: ", info_playgame = "Arrow keys to move\npress enter to select\nESC stops the game";

        //Chess board
        public static ChessPieces[,] ChessBoard = new ChessPieces[8, 8]; //8x8
        private static int ChessXY_Lenght = 7; //8 long (0 is first index)

        //Chess pieces
        public enum ChessPieces {
            Empty = 0,
            b_Pawn, b_Knight, b_Bishop, b_Rook, b_Queen, b_King,
            w_Pawn, w_Knight, w_Bishop, w_Rook, w_Queen, w_King
        }

        //fill in Top/Bottom row
        public static string[] TB_Chesspieces = { "_Rook", "_Knight", "_Bishop", "_Queen", "_King", "_Bishop", "_Knight", "_Rook" };

        //Cursor
        public enum CursorAction { Up, Down, Left, Right, Enter, Escape, None }
        public static int Cursor_x, Cursor_y;

        //Selected
        public static int Selected_x = -1, Selected_y = -1;

        //Player data
        public static bool IsPlayerOne = true;

        public static void Chess() {
            //Generate chess board
            InitChessBoard();
            //Game loop
            while (IsRunning) {
                DrawChessBoard();
                InfoPrint();
                PlayerController();
            }
        }

        private static void InfoPrint() {
            Print($"Cursor X: {Cursor_x} Y: {Cursor_y}");
            Print($"Selected X: {Selected_x} Y: {Selected_y}");

        }

        //Setup chessboard
        public static void InitChessBoard() {
            //Y loop
            for (int y = 0; y <= ChessXY_Lenght; y++) {
                //X loop
                for (int x = 0; x <= ChessXY_Lenght; x++) {
                    if (y == 0 || y == ChessXY_Lenght) { //First and last row?
                        char _type = (y == 0) ? 'b' : 'w';
                        //Parse chess piece from string array
                        ChessPieces _p = (ChessPieces)Enum.Parse(typeof(ChessPieces), $"{_type}{TB_Chesspieces[x]}", true);
                        ChessBoard[x, y] = _p;
                    } else if (y == 1) {
                        ChessBoard[x, y] = ChessPieces.b_Pawn;
                    } else if (y == ChessXY_Lenght - 1 || y == ChessXY_Lenght) {
                        ChessBoard[x, y] = ChessPieces.w_Pawn;
                    } else {
                        ChessBoard[x, y] = ChessPieces.Empty; //Empty
                    }
                }
            }
        }

        //Draws chessboard
        private static void DrawChessBoard() {
            //Set output to work with emojis / symbols
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Clear board
            Console.Clear();
            //Start message
            Print(info_intro + ((IsPlayerOne) ? "Black" : "White"));
            //Print colm index
            Print("  A B C D E F G H");
            //Y loop
            for (int y = 0; y <= ChessXY_Lenght; y++) {
                //write row index
                Console.BackgroundColor = ConsoleColor.Black;
                Write(y + 1 + " ");
                //X loop
                for (int x = 0; x <= ChessXY_Lenght; x++) {
                    //Checkerboard pattern
                    if ((y + x) % 2 == 1) {
                        Console.BackgroundColor = ConsoleColor.Black;
                    } else {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    //Get custom color (magenta is null)
                    if (GetBoardColor(x, y) != ConsoleColor.Magenta) {
                        Console.BackgroundColor = GetBoardColor(x, y);
                    }
                    //Write output
                    string _output = GetBoardPiece(x, y);
                    Write(_output);
                }
                //End of x loop, print board (new line)
                Print("");
            }
            //Reset color at end of loop
            Console.BackgroundColor = ConsoleColor.Black;
            //Write message to player
            Print(info_playgame);
        }

        //Retrives the relevant board piece
        public static string GetBoardPiece(int _x, int _y) {
            switch (ChessBoard[_x, _y]) {
                case ChessPieces.b_Pawn:
                    return "♟ ";
                case ChessPieces.w_Pawn:
                    return "♙ ";
                case ChessPieces.b_Knight:
                    return "♞ ";
                case ChessPieces.w_Knight:
                    return "♘ ";
                case ChessPieces.b_Bishop:
                    return "♝ ";
                case ChessPieces.w_Bishop:
                    return "♗ ";
                case ChessPieces.b_Rook:
                    return "♜ ";
                case ChessPieces.w_Rook:
                    return "♖ ";
                case ChessPieces.b_Queen:
                    return "♛ ";
                case ChessPieces.w_Queen:
                    return "♕ ";
                case ChessPieces.b_King:
                    return "♚ ";
                case ChessPieces.w_King:
                    return "♔ ";

                default:
                    return "  ";
            }
        }

        //Color chessboard
        public static ConsoleColor GetBoardColor(int x, int y) {
            //Set cusor color

            //Selected position
            if (x == Selected_x && y == Selected_y) {
                return ConsoleColor.DarkGreen;
            }

            //Cursor
            if (x == Cursor_x && y == Cursor_y) {
                //Valid piece highlight / invalid
                if ((IsPlayerOne && ChessBoard[x, y].ToString().StartsWith("b")) || (!IsPlayerOne && ChessBoard[x, y].ToString().StartsWith("w"))) {
                    if (Selected_x != -1 && Selected_y != -1) {
                        return ConsoleColor.Green; //Already has peice
                    } else {
                        return ConsoleColor.DarkGreen; //Valid
                    }
                }

                //Can move to here color
                if (Selected_x != -1 && Selected_y != -1) {
                    if (ChessBoard[x, y] == ChessPieces.Empty ||
                       (!IsPlayerOne && ChessBoard[x, y].ToString().StartsWith("b")) ||
                       (IsPlayerOne && ChessBoard[x, y].ToString().StartsWith("w"))) {
                        return ConsoleColor.Green;
                    }
                }

                //Normal color
                return ConsoleColor.DarkRed;
            }

            return ConsoleColor.Magenta; //None output color
        }

        //Player handler
        public static void PlayerController() {
            CursorAction cursorAction = ActiveInput();
            if (cursorAction == CursorAction.Escape) {
                IsRunning = false; //Stop game after pressing escape
            } else if (cursorAction == CursorAction.Enter) { //Select 
                CursorSelect(); //Win condition is nested here
            } else { //Default, just moves cursor around and clamps position
                MoveCursor(cursorAction);
            }

        }

        //Cursor select piece
        private static void CursorSelect() {
            //Validate choice
            if ((IsPlayerOne && ChessBoard[Cursor_x, Cursor_y].ToString().StartsWith("b")) ||
                (!IsPlayerOne && ChessBoard[Cursor_x, Cursor_y].ToString().StartsWith("w"))) {
                Selected_x = Cursor_x; //Set value
                Selected_y = Cursor_y; //Set value
            }
            //Selected cant be -1, and x or y need to be different
            if ((Selected_x != -1 && Selected_x != Cursor_x) || (Selected_y != -1 && Selected_y != Cursor_y)) { //move piece to
                if (ChessBoard[Cursor_x, Cursor_y] == ChessPieces.Empty ||
                        (!IsPlayerOne && ChessBoard[Cursor_x, Cursor_y].ToString().StartsWith("b")) ||
                        (IsPlayerOne && ChessBoard[Cursor_x, Cursor_y].ToString().StartsWith("w"))) {
                    //Player win????
                    if (Win() != "") {
                        Print(Win());
                        IsRunning = false; //Stop game
                    }

                    //Move selected to cursor
                    ChessBoard[Cursor_x, Cursor_y] = ChessBoard[Selected_x, Selected_y];
                    //Delete selected from board
                    ChessBoard[Selected_x, Selected_y] = ChessPieces.Empty;
                    //Reset seletion
                    Selected_x = -1;
                    Selected_y = -1;

                    //Change player
                    IsPlayerOne = !IsPlayerOne;
                }
            }
        }

        //Check for win
        private static string Win() {
            if (IsPlayerOne && ChessBoard[Cursor_x, Cursor_y] == ChessPieces.w_King) { //Player one win
                return "Checkmate\nBlack wins!";
            }
            if (!IsPlayerOne && ChessBoard[Cursor_x, Cursor_y] == ChessPieces.b_King) { //Player two win
                return "Checkmate\nWhite wins!";
            }
            return "";
        }

        //Cursor
        public static void MoveCursor(CursorAction _action) {
            switch (_action) {
                case CursorAction.Up:
                    Cursor_y--;
                    break;
                case CursorAction.Down:
                    Cursor_y++;
                    break;
                case CursorAction.Left:
                    Cursor_x--;
                    break;
                case CursorAction.Right:
                    Cursor_x++;
                    break;
            }
            //Clamp
            Cursor_x = ClampedValue(Cursor_x);
            Cursor_y = ClampedValue(Cursor_y);
        }

        //Player text input
        public static CursorAction ActiveInput() {
            ConsoleKey _key = Console.ReadKey().Key; //Get active key input
            switch (_key) {
                case ConsoleKey.UpArrow:
                    return CursorAction.Up;
                case ConsoleKey.DownArrow:
                    return CursorAction.Down;
                case ConsoleKey.LeftArrow:
                    return CursorAction.Left;
                case ConsoleKey.RightArrow:
                    return CursorAction.Right;
                case ConsoleKey.Enter:
                    return CursorAction.Enter;
                case ConsoleKey.Escape:
                    return CursorAction.Escape;
                default:
                    return CursorAction.None;
            }
        }

        //Simple print command
        private static void Print(string _output) {
            Console.WriteLine(_output);
        }
        //Simple write command
        private static void Write(string _output) {
            Console.Write(_output);
        }

        //Clamp
        public static int ClampedValue(int value, int max = 7, int min = 0) {
            if (value > max) {
                return max;
            } else if (value < min) {
                return min;
            }
            //Return
            return value;
        }


    }

}
