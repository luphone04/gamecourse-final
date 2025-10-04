# Three-in-One Game
<img width="1437" height="826" alt="Screenshot 2025-10-04 at 11 33 08" src="https://github.com/user-attachments/assets/511a88fb-4b1b-4321-8637-dce7ef054ef2" />
<img width="1440" height="798" alt="Screenshot 2025-10-04 at 11 33 27" src="https://github.com/user-attachments/assets/37cdc492-cd9b-4801-9472-9993c43c3e11" />
<img width="1440" height="805" alt="Screenshot 2025-10-04 at 11 33 34" src="https://github.com/user-attachments/assets/01a996fa-860c-4576-aef1-9127be673efb" />
<img width="1440" height="821" alt="Screenshot 2025-10-04 at 11 33 48" src="https://github.com/user-attachments/assets/2ea73131-15ad-499d-a9eb-5327b8487562" />



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
