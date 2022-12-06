using System;

namespace LeJustePrix
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var game = new Game();
            game.ValidateGuess();
            
         
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
        
    
      
    }
}


