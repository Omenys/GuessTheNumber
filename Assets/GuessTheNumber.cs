using TMPro;
using UnityEngine;

public class GuessTheNumber : MonoBehaviour
{
    [SerializeField] TMP_Text header;
    [SerializeField] TMP_Text inputField;
    int number = 0;
    int numberOfGuesses = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameSetup();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeHeader(string text)
    {
        header.text = text;
    }

    public void GameSetup()
    {
        // Choose the random number that the player must guess (1-10)
        number = Random.Range(1, 11);

        // Guesses remaining
        numberOfGuesses = 3;

        // Update the header text to let the player know how many attempts are remaining
        header.text = numberOfGuesses.ToString() + " guesses remaining";
        // Clear the text in the input field
        inputField.text = "Enter your guess...";
    }

    public void SubmitGuess()
    {
        // Store user input
        int input = 0;

        // Update header text if correct
        if (input == number)
        {
            header.text = "You won!";
        }
        // Update header text if incorrect
        else
        {
            header.text = "Try again!";
        }
        // Decrease remaining attempts
        numberOfGuesses = numberOfGuesses - 1;

    }

}
