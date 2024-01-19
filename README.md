Upon execution, the program prompts Player 1 to input two integer values,'a' and 'b', representing the range within which a random number will be generated.
The program then generates a random number between 'a' and 'b', inclusive.
Player 1 is presented with the task of guessing this randomly generated number.
Player 1 begins the game by inputting a guess, and the program provides feedback, guiding Player 1 to guess higher or lower based on the comparison with the generated random number.
The game allows a maximum of 30 attempts for each player. If Player 1 correctly guesses the random number within the allowed attempts, the game announces their success and terminates.
Next, Player 2 enters the game, utilizing a binary search algorithm to efficiently narrow down the possible range for the random number.
Player 2's guesses are adjusted dynamically based on the feedback provided by the program, with the goal of reaching the correct answer within the allotted attempts.
At the end of the game, the program compares the remaining attempts of Player 1 and Player 2. The player with more remaining attempts is declared the winner, and in the case of a tie, the game is deemed a draw.
