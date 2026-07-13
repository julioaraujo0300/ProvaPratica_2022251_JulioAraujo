# Prova Prática 2022251 - Julio Araujo

This is a Unity project that presents a simple solar-system style scene with:

- The Earth as the main reference object
- A Moon orbiting the Earth
- Three on-screen buttons that switch between different camera views

## Features

- **General camera** for the overall scene
- **Earth camera** focused on the Earth
- **Moon camera** focused on the Moon
- Button-based camera switching through the `CameraController` script

## Controls

Use the three UI buttons in the scene to switch the active camera:

- General view
- Earth view
- Moon view

## Project Notes

- Built in **Unity**
- Uses **Cinemachine** for camera control
- The active camera is managed by `Assets/CameraController.cs`

## How It Works

The `CameraController` script keeps three virtual cameras in the scene and changes their priority when a button is pressed. The active camera receives the highest priority, so Cinemachine displays that view.
