# 🧠 Memory Matching Game – C# Console Game

Memory Matching Game is a simple and fun console-based game created using **C# and .NET**. The main goal of the game is to find all the matching pairs of cards.

When the game starts, the player sees a small game board with several numbered cards. Behind these cards are hidden letters, but the player cannot see them at the beginning. The letters are placed randomly, so the player does not know where each matching pair is located.

The player starts the game by choosing one card. The selected card is opened, and the hidden letter behind it is shown. After that, the player chooses a second card, and its hidden letter is also revealed.

Now the game checks both cards. If the two cards have the same letter, the game shows **"Match!"** and the pair is counted as successfully matched. These cards are considered a correct pair.

If the two cards have different letters, the game shows **"No match..."** and both cards are hidden again. The player then needs to remember where those letters were so they can try to find their matching cards later. This is why the game is called a **Memory Matching Game** because the player needs to use their memory to remember the locations of the hidden letters.

The player continues selecting two cards at a time and tries to find all the matching pairs. The game keeps track of how many pairs the player has successfully matched. Once the player finds every matching pair on the board, the game ends and displays a congratulations message:

**"Congratulations, you win!"**

The cards are also randomly shuffled every time the game starts, so the player gets a different arrangement of letters and has to find the pairs again.

This project is a simple way to understand how programming logic can be used to create an interactive game. It demonstrates important **C# programming concepts** such as arrays, loops, conditional statements, randomization, user input, methods, and game-state management.

Overall, this project is a beginner-friendly implementation of a classic Memory Matching Game using **C# and .NET**. It combines simple programming concepts with fun gameplay and provides a good foundation for developing more advanced games in the future.
