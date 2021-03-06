using System.Collections.Generic;

namespace RockPaperScissors.Objects
{
  public class Game
  {
    private string _player1Choice;
    private string _player2Choice;
    public static List<Game> gameInstances = new List<Game>{};

    public Game(string player1Choice, string player2Choice)
    {
      _player1Choice = player1Choice;
      _player2Choice = player2Choice;
      gameInstances.Add(this);
    }

    public string getChoice1()
    {
      return _player1Choice;
    }

    public void setChoice1(string choice)
    {
      _player1Choice = choice;
    }

    public string getChoice2()
    {
      return _player2Choice;
    }

    public void setChoice2(string choice)
    {
      _player2Choice = choice;
    }

    public string TestFunction()
    {
      // If Player 1  and Player 2 did not choose the same thing,
      // If Player 2 chose the losing option(in relation to Player 1's choice), Player 1 Wins, otherwise Player 2 wins
      if (_player1Choice == "rock" && _player2Choice != "rock")
      {
        return (_player2Choice == "scissors") ? "Rock crushes scissors. Player 1 Wins!" : "Paper covers rock. Player 2 Wins!";
      }
      else if (_player1Choice == "paper" && _player2Choice != "paper")
      {
        return (_player2Choice == "rock") ? "Paper covers rock. Player 1 Wins!" : "Scissors cut paper. Player 2 Wins!";
      }
      else if (_player1Choice == "scissors" && _player2Choice != "scissors")
      {
        return (_player2Choice == "paper") ? "Scissors cut paper. Player 1 Wins!" : "Rock crushes scissors. Player 2 Wins!";
      }
      return "It's a Draw";
    }

    public string DetermineWinner()
    {
      if(_player1Choice == "rock" && _player2Choice == "scissors")
      {
        return "Rock crushes scissors. Player 1 Wins!";
      }
      else if (_player2Choice == "rock" && _player1Choice == "scissors")
      {
        return "Rock crushes scissors. Player 2 Wins!";
      }
      else if (_player1Choice == "rock" && _player2Choice == "lizard")
      {
        return "Rock crushes lizard. Player 1 Wins!";
      }
      else if (_player2Choice == "rock" && _player1Choice == "lizard")
      {
        return "Rock crushes lizard. Player 2 Wins!";
      }
      else if (_player1Choice == "paper" && _player2Choice == "rock")
      {
        return "Paper covers rock. Player 1 Wins!";
      }
      else if (_player2Choice == "paper" && _player1Choice == "rock")
      {
        return "Paper covers rock. Player 2 Wins!";
      }
      else if (_player1Choice == "paper" && _player2Choice == "Spock")
      {
        return "Paper disproves Spock. Player 1 Wins!";
      }
      else if (_player2Choice == "paper" && _player1Choice == "Spock")
      {
        return "Paper disproves Spock. Player 2 Wins!";
      }
      else if (_player1Choice == "scissors" && _player2Choice == "paper")
      {
        return "Scissors cut paper. Player 1 Wins!";
      }
      else if(_player2Choice == "scissors" && _player1Choice == "paper")
      {
        return "Scissors cut paper. Player 2 Wins!";
      }
      else if (_player1Choice == "scissors" && _player2Choice == "lizard")
      {
        return "Scissors decapitates lizard. Player 1 Wins!";
      }
      else if (_player2Choice == "scissors" && _player1Choice == "lizard")
      {
        return "Scissors decapitates lizard. Player 2 Wins!";
      }
      else if (_player1Choice == "lizard" && _player2Choice == "paper")
      {
        return "Lizard eats paper. Player 1 Wins!";
      }
      else if(_player2Choice == "lizard" && _player1Choice == "paper")
      {
        return "Lizard eats paper. Player 2 Wins!";
      }
      else if (_player1Choice == "lizard" && _player2Choice == "Spock")
      {
        return "Lizard poisions Spock. Player 1 Wins!";
      }
      else if (_player2Choice == "lizard" && _player1Choice == "Spock")
      {
        return "Lizard poisions Spock. Player 2 Wins!";
      }
      else if (_player1Choice == "Spock" && _player2Choice == "rock")
      {
        return "Spock vaporizes rock. Player 1 Wins!";
      }
      else if(_player2Choice == "Spock" && _player1Choice == "rock")
      {
        return "Spock vaporizes rock. Player 2 Wins!";
      }
      else if (_player1Choice == "Spock" && _player2Choice == "scissors")
      {
        return "Spock smashes scissors. Player 1 Wins!";
      }
      else if (_player2Choice == "Spock" && _player1Choice == "scissors")
      {
        return "Spock smashes scissors. Player 2 Wins!";
      }
      else
      {
        return "It's a Draw";
      }
    }
  }
}
