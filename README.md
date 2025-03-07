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
