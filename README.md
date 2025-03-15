# SoccerMomsVan
SoccerMom's Van

Description

SoccerMom's Van is a two-player Pong-style game with a soccer theme, built using Unity. The game allows two players to control paddles using different keybindings, aiming to hit the ball into the opponent's goal. The game follows physics-based movement, where the ball slows down over time, and resets when a player scores.

Controls

Player 1: Uses WASD for movement.

Player 2: Uses the Arrow Keys for movement.

The ball starts stationary and moves only when a player hits it.

Game Features

Two-player local gameplay.

Soccer-themed visuals and mechanics.

Ball slows down over time.

Players reset to their positions after a goal is scored.

The ball stays within the game boundaries to prevent it from leaving the play area.

Challenges Faced

1. Player Input Issues

Initially, both players were moving with the same set of controls due to improper input handling. This was fixed by manually checking key presses with Input.GetKey() instead of relying on Unity's default input manager.

2. Ball Moving on Start

The ball originally moved as soon as the game started. To prevent this, a boolean flag (hasStarted) was added, ensuring that the ball stays stationary until a player touches it.

3. Physics Adjustments

The ball initially moved indefinitely without slowing down. A slowdown effect was implemented using velocity *= slowDownFactor; inside the Update() function.

4. Resetting the Ball on Goal

When a player scored, the ball sometimes did not properly reset. This was due to the ResetBall() function being private. Changing it to public resolved the issue.

5. Ball Escaping the Play Area

The ball would sometimes fly off the screen. To fix this, walls were added as BoxCollider2D objects around the play area to contain the ball within the game field.
