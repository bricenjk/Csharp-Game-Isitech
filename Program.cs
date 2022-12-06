using System;

namespace LeJustePrix
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var game = new Game();
            game.Init();
            while (true)
            {
                // Prompt the user to make a guess
                Console.Write("Enter your guess: ");
        
                var guess = int.Parse(Console.ReadLine());
                
                var result = game.ValidateGuess(guess);
                
                Console.WriteLine(result);
                
                if (game.HasWon(guess))
                {
                    Console.WriteLine("Congratulations! You have won the game!");
                    break;
                }
                else if (game.HasLost())
                {
                    Console.WriteLine("Sorry, you have lost the game. Better luck next time!");
                    break;
                }
    
            }
    }
  
    class Game
    {
       
        private int _price;
        private int _numGuesses;
        private const int _maxGuesses = 10;
        
    
        public void Init()
        {
            
            var random = new Random();
            _price = random.Next(1, 101);
            
            _numGuesses = 0;
        }
        
        public string ValidateGuess(int guess)
        {
            
            _numGuesses++;
            
            if (guess == _price)
            {
                return "You have guessed the correct price!";
            }
            if (guess < _price)
            {
                return "Your guess is too low. Try again.";
            }
            else
            {
                return "Your guess is too high. Try again.";
            }
        }

        public bool HasWon(int guess)
        {
            return _numGuesses > 0 && _numGuesses <= _maxGuesses && guess == _price;
        }
        
        public bool HasLost()
        {
            return _numGuesses > _maxGuesses;
        }
        
    
      
    }
}
}


