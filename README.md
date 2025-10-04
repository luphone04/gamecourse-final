# Three-in-One Game

## Main Menu Implementation
- UI Canvas with TextMeshPro elements
- 4 Buttons: Mad Driver, Fly Like a Bird, I'm a Sumo and a Ball, Exit
- MenuManager.cs script using SceneManager.LoadScene() for navigation
- Application.Quit() for exit functionality

## In-Game Pause Menu
- Escape key detection using Input.GetKeyDown(KeyCode.Escape)
- PauseManager.cs controls Time.timeScale for pause/resume
- Prefab-based UI reused across all 3 game scenes
- Buttons trigger: Resume(), RestartGame(), BackToMainMenu()

## Technical Details
- Scene management via SceneManager
- UI built with TextMeshPro
- Pause menu implemented as prefab for consistency
- Time.timeScale = 0 for pause, = 1 for resume
