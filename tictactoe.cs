 static void DrawBoard(string[] b)
        {
            Console.Clear();
            Console.WriteLine($"{b[0]} | {b[1]} | {b[2]} ");
            Console.WriteLine("---------");
            Console.WriteLine($"{b[3]} | {b[4]} | {b[5]} ");
            Console.WriteLine("---------");
            Console.WriteLine($"{b[6]} | {b[7]} | {b[8]} ");
        }

        static void Main(string[] args)
        {
            string[] board = {"1", "2", "3",
                              "4", "5", "6",
                              "7", "8", "9"};

            string currentPlayer = "X"; //or maybe O
            Console.WriteLine("Welcome to Tic Tac Toe!");
            DrawBoard(board);

            while (true)
            {
               
                //ask for a move from the currentplayer
                int position = AskForMove(currentPlayer);


                //check if move is valid
                //bool valid = IsValidMove(position);
                //if not then ask again
                //updated the board at the slot they specified.
                board[position - 1] = currentPlayer;

                //draw the board
                DrawBoard(board);

                //check for the 8 possible win conditions.
                bool hasWon = HasPlayerWon(board, currentPlayer);

                //if they won, print they won
                if (hasWon == true)
                {
                    Console.WriteLine($"Player {currentPlayer} has Won!");
                    break;
                }

                //if the board is full, then print 'tie game'
                bool isFull = CheckIfBoardIsFull(board);
                if (isFull)
                {
                    Console.WriteLine($"Tie Game");
                    break;
                }

                //otherwise swap player turns
                currentPlayer = SwapPlayerTurns(currentPlayer);

            }

            Console.ReadLine();

        }

        private static string SwapPlayerTurns(string currentPlayer)
        {
            if (currentPlayer == "X")
            {
                return "O";
            }
            else
            {
                return "X";
            }

        }

        private static bool CheckIfBoardIsFull(string[] board)
        {
            foreach (var spot in board)
            {
                //if there isn't an x or an o then there's a number and thus the board is still
                //playable
                if (spot != "X" && spot != "O")
                {
                    return false;
                }
            }

            //we've checkd all the spots and they are all x's or o's, thus the board is full
            return true;
        }

        private static bool HasPlayerWon(string[] board, string currentPlayer)
        {
            
            if (board[0] == currentPlayer && board[4] == currentPlayer && board[8] == currentPlayer)
            {
                return true;
            }

            if (board[2] == currentPlayer && board[4] == currentPlayer && board[6] == currentPlayer)
            {
                return true;
            }

            if (board[0] == currentPlayer && board[1] == currentPlayer && board[2] == currentPlayer)
            {
                return true;
            }

            if (board[3] == currentPlayer && board[4] == currentPlayer && board[5] == currentPlayer)
            {
                return true;
            }

            if (board[6] == currentPlayer && board[7] == currentPlayer && board[8] == currentPlayer)
            {
                return true;
            }


            if (board[0] == currentPlayer && board[3] == currentPlayer && board[6] == currentPlayer)
            {
                return true;
            }

            if (board[1] == currentPlayer && board[4] == currentPlayer && board[7] == currentPlayer)
            {
                return true;
            }

            if (board[2] == currentPlayer && board[5] == currentPlayer && board[8] == currentPlayer)
            {
                return true;
            }

            return false;
        }

        private static int AskForMove(string currentPlayer)
        {
          
                Console.WriteLine($"What's your move {currentPlayer}?");
                string move = Console.ReadLine();
                var moveAsNumber = int.Parse(move);

                return moveAsNumber;
           
        }
