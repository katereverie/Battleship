# Battleship

## Overview

The **Battleship** project is a console-based implementation of the classic naval strategy game. This application allows two players to engage in a strategic battle to sink each other's ships on a 10x10 grid. Players can either play against each other or compete against a computer opponent. The game incorporates features such as ship placement, turn-based shooting, and game outcome detection.

## Architecture

### Pattern (n-Tier-architecture)

- __UI__: Manages player interactions, including ship placement, shot-taking, and game feedback, all via CLI (command-line interface).
- __BLL__: Contains the core game mechanics, such as ship validation, tracking hits and misses, and determining when a game ends.
- __UnitTests__: Responsible for verifying the correctness of core game logic. Using a framework like NUnit, unit tests are created for scenarios such as:
    * Ship Placement: Ensuring ships are correctly placed on the grid without overlaps or out-of-bound placements.
    * Shot Accuracy: Validating whether shots are recorded as hits or misses and ensuring duplicate shots are prevented.
    * Game State: Testing end-game conditions to confirm when a player has sunk all ships.

## Technology Stack

- Programming Languages: C#
- Frameworks & Libraries: .NET Core (for building the application), NUnit (for unit testing)
- Other tools: Visual Studio (for development)

## Features

### Current Functionalities

- **Game Setup**:
  - Allows players to place ships on a grid with validation to prevent overlaps and ensure correct placement.
  - Supports placement of five types of ships with varying sizes.
- **Gameplay**:
  - Players take turns shooting at each other’s grids, with feedback provided on hits, misses, and sunk ships.
  - Keeps track of shot history to prevent duplicate shots.
- **Game End**:
  - Detects when a player has sunk all of the opponent’s ships and announces the winner.
- **User Interface**:
  - Command-line interface with clear prompts and output for player actions and game status.
  - 
### Future Features to Add

- **Graphical User Interface**: Develop a graphical interface for a more engaging user experience.
- **AI Improvements**: Enhance the computer opponent's strategy to make it more challenging.
- **Advanced Game Modes**: Introduce additional game modes or variations, such as different grid sizes or ship types.
- **Network Play**: Implement network functionality to allow online play between different users.

## Video Demonstration 

### Player Selection

https://github.com/user-attachments/assets/767633f1-a302-4d19-bdb8-695a91dec097

### Ship Placement

https://github.com/user-attachments/assets/b731c34b-38fb-49bc-b695-6d6b075a967a

### Game Play

https://github.com/user-attachments/assets/0e9add5b-2f30-4f08-9171-cfc587a5e1e1

## Challenges Faced and Solutions

### Challenge 1: Ship Placement Validation
**Problem**: Ensuring that ships were placed correctly on the grid without overlapping and within bounds was complex. It required careful validation to meet game rules.<br>
**Solution**: Implemented a validation mechanism that checks for overlaps and ensures ships fit within the grid before finalizing their placement. Utilized a grid-based approach to simplify the validation logic.

### Challenge 2: Turn-Based Gameplay Management
**Problem**: Managing the turn-based gameplay and ensuring that each player could only make a move on their turn required careful coordination.<br>
**Solution**: Designed a game loop that alternates turns between players and keeps track of whose turn it is. Implemented logic to handle user input and validate actions based on the current game state.

### Challenge 3: Command-Line Interface User Interaction
**Problem**: Creating an intuitive and user-friendly command-line interface proved challenging due to the limited feedback mechanisms of the console.<br>
**Solution**: Focused on providing clear and concise prompts and output messages. Used formatting techniques to enhance readability and provide sufficient feedback on game status and player actions.

### Challenge 4: Unit Testing for Game Logic
**Problem**: Ensuring that all game logic components were thoroughly tested, including ship placement and shot validation, was challenging.<br>
**Solution**: Developed a comprehensive suite of unit tests using NUnit to cover critical game logic scenarios. Implemented mock objects to simulate different game states and verify the correctness of the functionality.


