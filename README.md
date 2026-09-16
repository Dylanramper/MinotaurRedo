# Minotaur Run

Minotaur Run is a 2D infinite runner developed in Unity and C#. This was an early project in my development as a Unity programmer and helped establish my foundation in gameplay programming.

## My Role

**Gameplay Programmer / Solo Developer**

I was responsible for programming the core gameplay systems, including player controls, enemy systems, combat interactions, animation states, and the scrolling background system.

## Screenshots

### Jumping

![Minotaur Run - Jumping](Screenshots/Minotaur_jump.png)

### Attacking

![Minotaur Run - Attacking](Screenshots/Minotaur_attack.png)

### Sliding

![Minotaur Run - Sliding](Screenshots/Minotaur_slide.png)

## Gameplay Systems

### Player Controller

* Implemented player jumping, sliding, and attacking using C#.
* Managed player gameplay states to prevent conflicting actions.
* Used Unity's `Rigidbody2D` for player movement and jumping.
* Implemented dynamic `BoxCollider2D` adjustments for the sliding mechanic.
* Connected gameplay states to Unity's animation system.

### Enemy Systems

* Implemented timed enemy spawning.
* Created randomized enemy selection between multiple enemy types.
* Developed enemy movement and off-screen cleanup.
* Implemented player/enemy collision interactions.
* Added enemy defeat states and death animations.

### Background System

* Created a continuously looping background movement system.
* Used configurable movement speeds for background layers to create a parallax-style effect.
* Implemented automatic repositioning when background layers reached the edge of the play area.

## Technologies

* Unity
* C#
* 2D Physics
* Unity Animator
* Unity Standard Assets / Cross-Platform Input
* Android development

## Project Status

This is an earlier Unity project that has been preserved as part of my development portfolio.

The original project was developed for Android. The repository contains the original Unity project and source code demonstrating the gameplay systems I implemented.

## What I Learned

Minotaur Run was an important early project in my development as a programmer. It gave me practical experience with Unity, C#, 2D physics, collision detection, animation systems, enemy spawning, and gameplay state management.
