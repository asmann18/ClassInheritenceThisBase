namespace ClassInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new("Asiman", "Qasimzade", "P327", 199);
            student.GetInfo();
            student.CheckGraduation();
            student.GetDiplomDegree();


            //// task 2
            ////methodlarla
            int[] ReshadsPoint = new int[3];
            int[] AydansPoint = new int[3];
            Console.WriteLine("Reshad");
            InsertPointToArray(ReshadsPoint);
            Console.WriteLine("Aydan");
            InsertPointToArray(AydansPoint);
            CheckWinner(ReshadsPoint, AydansPoint);

            ////class
            Player Reshad = CreatePlayer();
            Player Aydan = CreatePlayer();
            CheckWinner(Reshad, Aydan);

            //task3 customSplit
            var arr = CustomSplit("salam men Ab104 telebesiyem", ' ');
            PrintArray(arr);

            //task4 CustomTrim TrimStart TrimEnd
            string trim = "-----salam-----";
            Console.WriteLine(CustomTrim(trim, '-'));

            //task5 

            int[,] arr1 = { {1,2,3 },{4,5,6},{8,9,10 } };
            int[,] arr2 = { {1,2,3 },{4,5,6},{8,9,10 } };
            SumArrays(arr1, arr2);
        }
        public static void InsertPointToArray(int[] arr)
        {
            Console.WriteLine("Ballari daxil edin");
            for (int i = 0; i < arr.Length; i++)
            {
                restart:
                Console.Write(i+1+": ");
                bool isParse=int.TryParse(Console.ReadLine(), out arr[i]);
                if(!isParse || arr[i]>100 || arr[i]<0) 
                {
                    Console.WriteLine("Duzgun simvol daxil edin.");
                    goto restart;
                }
            }
        }
        public static void CheckWinner(int[] Player1, int[] Player2)
        {
            byte player1Point=0;
            byte player2Point=0;
            for (int i = 0;i < Player1.Length;i++)
            {
                if (Player1[i] > Player2[i])
                {
                    player1Point++;
                }
                else if (Player1[i] < Player2[i])
                {
                    player2Point++;
                }
            }
            Console.WriteLine($"Player 1 Point:{player1Point} \n" +
                $"Player 2 Point:{player2Point}");
        }
        public static void CheckWinner(Player player1, Player player2)
        {
            if (player1.Point1 > player2.Point1)
            {
                player1.TotalScore++;
            }
            else if(player1.Point1 < player2.Point1)
            {
                player2.TotalScore++;
            }


            if (player1.Point2 > player2.Point2)
            {
                player1.TotalScore++;
            }
            else if (player1.Point2 < player2.Point2)
            {
                player2.TotalScore++;
            }



            if (player1.Point3 > player2.Point3)
            {
                player1.TotalScore++;
            }
            else if (player1.Point3 < player2.Point3)
            {
                player2.TotalScore++;
            }

            Console.WriteLine($"{player1.Name} Score: {player1.TotalScore} \n" +
                $"{player2.Name} Score: {player2.TotalScore}");
        }
        public static Player CreatePlayer()
        {
            Console.Write("Player adi daxil edin:");
            restartName:
            string name=Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Duzgun daxil edin");
                goto restartName;
            }
            Console.Write("Oyun 1 in neticesini daxil edin:");
            restartGame1:
            bool isParse = int.TryParse(Console.ReadLine(), out int point1);
            if(!isParse || point1 < 0 || point1 > 100)
            {
                Console.WriteLine("Duzgun eded daxil edin;");
                goto restartGame1;
            }
            
            
            Console.Write("Oyun 2 in neticesini daxil edin:");
            restartGame2:
            isParse = int.TryParse(Console.ReadLine(), out int point2);
            if(!isParse || point2 < 0 || point2 > 100)
            {
                Console.WriteLine("Duzgun eded daxil edin;");
                goto restartGame2;
            }            
            
            Console.Write("Oyun 3 un neticesini daxil edin:");
            restartGame3:
            isParse = int.TryParse(Console.ReadLine(), out int point3);
            if(!isParse || point3 < 0 || point3 > 100)
            {
                Console.WriteLine("Duzgun eded daxil edin;");
                goto restartGame3;
            }
            return new(name, point1, point2, point3 );
        }


        public static string[] CustomSplit(string sentence,char symbol)
        {
            string word = "";
            string[] words = new string[0];
            for (int i = 0; i < sentence.Length; i++) 
            {
                if (sentence[i] == symbol || i==sentence.Length-1)
                {

                    Array.Resize(ref words, words.Length + 1);
                    if(i==sentence.Length-1)
                        word += sentence[i];
                    words[words.Length - 1] = word;
                    word = "";
                }
                else
                {
                    word += sentence[i];
                }
            }
            return words;
        }
        public static void PrintArray(string[] array)
        {
            for (int i = 0;i < array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j]+" ");
                }
                Console.WriteLine();

            }
        }


        public static string CustomTrimStart(string word,char trimSymbol=' ')
        {
            int startIndex=0;
            string newWord="";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == trimSymbol)
                {
                    continue;
                }
                else
                {
                    startIndex = i;
                    break;
                }
            }
            for (int i = startIndex; i < word.Length; i++)
            {
                newWord += word[i];
            }
            return newWord;
        }
        public static string CustomTrimEnd(string word,char trimSymbol=' ')
        {
            int endIndex=word.Length-1;
            string newWord = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (word[i] == trimSymbol)
                {
                    continue;
                }
                else
                {
                    endIndex = i;
                    break;
                }

            }
            for (int i = 0; i <= endIndex; i++)
            {
                newWord += word[i];
            }
            return newWord;
        }
        public static string CustomTrim(string word,char trimSymbol=' ')
        {
            string newWord=CustomTrimStart(word,trimSymbol);
            newWord=CustomTrimEnd(newWord,trimSymbol);
            return newWord;
        }


        public static void SumArrays(int[,] array1, int[,] array2)
        {
            for (int i = 0;i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i, j] += array2[i, j];
                }
            }
            PrintArray(array1);
        }

    }
}