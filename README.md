# PlayerMovement Component

## Overview

The PlayerMovement component is a reusable Unity script designed to handle smooth acceleration-based movement for a 2D character. It supports:

- Acceleration and deceleration for smooth movement

- Velocity clamping to prevent excessive speed

- External pull forces (e.g., wind, magnets, gravity effects)

- Compatibility with AI and player-controlled characters

## Features

- Acceleration-Based Movement – Smoothly increase and decrease speed.

- Deceleration – Stops movement naturally instead of instantly.

- Max Speed Limit – Prevents excessive movement speed.

- Pull Forces – Allows external forces to influence movement.

- Modular Design – Works for both player-controlled and AI-controlled characters.

- Inspector-Friendly – Easily adjustable settings in the Unity Inspector.

## Installation

Download or clone this repository.

Place the PlayerMovement.cs script in your Unity project inside the Scripts/ folder.

Attach the PlayerMovement script to a GameObject (e.g., Player or AI character).

Attach a Rigidbody2D component to the GameObject.

Set Gravity Scale = 0.

## Usage

For Player-Controlled Movement:

Attach the PlayerInputHandler.cs script to the same GameObject.

This script will take player input and pass it to the PlayerMovement component.

For AI-Controlled Movement:

Attach a custom AI script (e.g., AIController.cs).

Call SetInput(Vector2 direction) to move the AI towards a target.

![1](https://github.com/user-attachments/assets/e82edf53-b21f-428f-8578-db304fb4c424)

- Is Active: Turn on or off to stop running the script.

- Use Acceleration: Turn off if you would like static movement without acceleration.

- Speed: The speed at which the player starts upon moving.

- Max Speed: The max possible speed the player can accelerate to.

- Acceleration: The rate at which the player increases in speed when moving.

- Deceleration: The rate at which the player reduces in speed when stopping.

- Pull Dampening: The strength of the pull effect when using the full function.

## Presets

# Osmosis 
[![Osmosis](https://img.youtube.com/vi/qGuieN5-6dI/0.jpg)](https://www.youtube.com/watch?v=qGuieN5-6dI)

speed = 3


maxSpeed = 5


acceleration = 6


deceleration = 5


pullDampening = 10


useAcceleration = true

# Vampire Survivors (Static Movement) 
[![Vampire Survivors](https://img.youtube.com/vi/6HXNxWbRgsg/0.jpg)](https://www.youtube.com/watch?v=6HXNxWbRgsg)

speed = 5


maxSpeed = 5


playerMovement.pullDampening = 2


useAcceleration = false

# Heavy Boulder
![Heavy Stuff](https://github.com/user-attachments/assets/242460d0-b1f5-4986-9a79-077087e79579)

speed = 3


maxSpeed = 10


acceleration = 2


deceleration = 2


pullDampening = 20


useAcceleration = true
