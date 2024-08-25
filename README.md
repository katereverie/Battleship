# Battleship Game

## Project Overview
This project is a console-based implementation of the classic Battleship game. It allows two players (human or computer) to place ships on a grid and take turns trying to sink each other's fleet. The game features a command-line interface with color-coded output for enhanced user experience.

## Technologies Used
- Programming Language: C#
- Framework: .NET Core
- Testing: NUnit

## Current Features
- Two-player gameplay (Human vs Human, Human vs Computer, or Computer vs Computer)
- 10x10 grid system with letter-number coordinates
- Five types of ships with varying lengths
- Ship placement system (vertical or horizontal)
- Turn-based shooting mechanism
- Shot history tracking and display
- Colorized console output (red for hits, yellow for misses)
- Computer player with random ship placement and shooting
- Game state tracking (hit, miss, sunk ships)
- Input validation for ship placement and shooting

## Planned Future Features
- Diagonal ship placement
- Smarter AI for computer player
- Graphical user interface (GUI) version
- Custom board sizes and ship configurations

## Learning Outcomes
Through this project, I have gained valuable experience and knowledge in:
- Implementing complex game logic and rules
- Designing and working with multi-dimensional data structures
- Creating a user-friendly command-line interface
- Applying object-oriented programming principles in a real-world scenario
- Implementing and utilizing polymorphism with interfaces and inheritance
- Developing a robust input validation system
- Writing comprehensive unit tests for critical game functionalities
- Managing game state and turn-based mechanics
- Implementing a basic AI for the computer player

## Challenges Faced and Solutions

1. Challenge: Representing the game board efficiently
   Solution: Instead of using a 2D-array, I implemented a ship class containing an array of coordinates, simplifying hit detection and game state management.

2. Challenge: Validating ship placement
   Solution: I developed a robust validation system checking for grid boundaries, overlaps, and adherence to placement rules.

3. Challenge: Managing game state across turns
   Solution: I created a centralized game state manager to track ship positions, hits, misses, and overall game progress.

4. Challenge: Implementing an intuitive user interface in the console
   Solution: I used color coding and clear formatting to present game information effectively, and implemented a grid display system for shot history.

5. Challenge: Developing a computer player with random but valid moves
   Solution: I Implemented a strategy pattern for player types, allowing easy switching between human and computer players. I also Used a combination of random selection and validity checks for computer moves.

6. Challenge: Ensuring code reusability for potential future expansions
   Solution: I designed the system with clear separation of concerns, using interfaces and base classes to allow for easy addition of new features or game modes.

7. Challenge: Writing comprehensive unit tests for game logic
   Solution: I identified key components of the game logic and created extensive test cases to cover various scenarios, including edge cases and invalid inputs.
