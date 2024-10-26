# 2D Game Project

This project is a complete 2D game framework written in C#, featuring player controls, enemies, power-ups, checkpoints, and UI management. It’s designed to be highly customizable, enabling developers to modify, expand, and use it as a foundation for 2D platformer games or similar genres.

## 📜 Table of Contents
- [Features](#features)
- [Component Overviews](#component-overviews)
- [Usage](#usage)
- [Customization](#customization)

---

## ✨ Features

- **Player Movement and Attack:** Allows player navigation and attack mechanics.
- **Enemy AI and Patrol:** Includes basic enemy behavior and patrol.
- **Item and Coin Collection:** Handles pickups for game rewards.
- **Checkpoint and Level Management:** Manages progression through levels with checkpoints.
- **Power-ups and Health Management:** Enhances player abilities temporarily and manages player health.
- **UI Management:** Manages the game’s user interface for scoring, health, and other elements.

---

## 🔍 Component Overviews

Below are descriptions of each C# script, detailing its purpose and use:

### 1. `PlayerMovement.cs`
   - Manages player movement mechanics, including running, jumping, and collision handling.
   - Customizable for various movement speeds, jump heights, and gravity.

### 2. `CameraFollow.cs`
   - Implements a camera follow system that centers the camera on the player, keeping the action in view.
   - Can be adjusted for smooth following, zoom levels, and boundary constraints.

### 3. `Checkpoint.cs`
   - Manages checkpoints where the player can respawn if they lose a life.
   - Stores player’s last active position and health status at each checkpoint.

### 4. `CoinTake.cs`
   - Handles coin pickups, rewarding the player with points.
   - Updates the score UI when coins are collected.

### 5. `Enemy.cs`
   - Controls enemy behaviors, including movement and player detection.
   - Can trigger attacks on the player if they come within range.

### 6. `EnemyPatrol.cs`
   - Governs enemy patrol paths and routines.
   - Supports setting patrol boundaries, wait times, and movement speeds.

### 7. `GameManager.cs`
   - Acts as a central controller for game events and state management.
   - Tracks game state (start, pause, end) and handles player lives, scoring, and win/loss conditions.

### 8. `Health.cs`
   - Manages the player’s health, handling damage, healing, and lives.
   - Works with the UI manager to update health status on the screen.

### 9. `ItemPickup.cs`
   - Manages non-coin item pickups, such as keys, gems, or other collectible items.
   - Each item can trigger unique effects or abilities when collected.

### 10. `LevelManager.cs`
   - Controls level transitions, including loading new levels and resetting the current level.
   - Useful for handling multi-level games or level-based checkpoints.

### 11. `PhysicsCollision.cs`
   - Contains collision logic for both the player and environmental elements.
   - Can be customized to handle different collision responses, such as bouncing, damage, or object destruction.

### 12. `PlayerAnimationController.cs`
   - Manages player animations, including idle, run, jump, and attack animations.
   - Synchronizes animation states with player actions.

### 13. `PlayerAttack.cs`
   - Adds attack functionality for the player, allowing them to damage enemies.
   - Supports various attack types and cooldown periods between attacks.

### 14. `PowerUp.cs`
   - Handles power-up pickups, providing temporary abilities or boosts (e.g., speed, health).
   - Each power-up can have unique effects and durations.

### 15. `UIManager.cs`
   - Manages all UI elements, including score, health bar, power-up indicators, and other on-screen information.
   - Ensures that UI reflects real-time changes in game status.

---

## 🕹️ Usage

1. **Setup:** Import the scripts into a Unity project.
2. **Player Setup:** Attach `PlayerMovement`, `PlayerAttack`, `Health`, and `PlayerAnimationController` to the player GameObject.
3. **Enemies and Patrols:** Attach `Enemy` and `EnemyPatrol` to enemy GameObjects and set patrol parameters.
4. **UI Management:** Use `UIManager` to display score, health, and power-up effects.
5. **Level and Game Management:** Use `LevelManager` and `GameManager` to create level transitions, checkpoints, and main menu handling.

---

## ⚙️ Customization

Each script can be customized to change behavior, parameters, or visual elements. Here are some examples:
- **Player Movement:** Adjust speed, jump height, and gravity for different movement styles.
- **Camera Behavior:** Modify `CameraFollow` settings for dynamic camera adjustments.
- **Power-ups:** Define custom power-up effects by modifying `PowerUp` properties.
- **Enemy AI:** Adjust patrol boundaries or add detection behaviors to make enemies more challenging.

---

## 📢 Conclusion

With these scripts, you can create a polished, engaging 2D platformer or adventure game. This framework provides foundational mechanics, and by customizing or adding features, you can develop a unique experience. Enjoy building your game!

