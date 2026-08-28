# VR Loy Krathong Interaction

<p align="center">
  <img src="Pictures/Screenshot%202026-01-21%20144034.png" width="800" alt="VR Loy Krathong Screenshot">
</p>

<p align="center">
  <strong>A VR recreation of the Loy Krathong festival</strong><br>
  <em>An immersive and environmentally conscious way to experience and preserve the tradition</em>
</p>

---

## About

Experience the magic of Thailand's Loy Krathong festival in virtual reality. Release floating lanterns onto the water, interact with the environment, and celebrate this beautiful tradition -- all without contributing physical waste to waterways.

### Features

- **Immersive VR Experience** -- Full 360 degree virtual reality environment
- **Hand Tracking** -- Natural hand interactions using Oculus/Meta Quest controllers
- **Interactive Objects** -- Pick up and release krathongs onto the water
- **Radio Integration** -- Listen to traditional Loy Krathong music
- **Dynamic Environment** -- Day/night cycle with atmospheric lighting

---

## Getting Started

### Prerequisites

| Software | Version | Download |
|----------|---------|----------|
| **Unity** | 2022.3.58f1 | [Download Unity Hub](https://unity.com/download) |
| **VR Headset** | Meta Quest 2/3/Pro | [Meta Quest Setup](https://www.meta.com/quest/setup/) |
| **Git** | Latest | [Download Git](https://git-scm.com/downloads) |

### Installation

#### Option 1: Clone the Repository (Recommended)

```bash
# Open terminal or command prompt
git clone https://github.com/jdseyen/VR-Loy-Krathong-Interaction-.git

# Navigate to the project folder
cd VR-Loy-Krathong-Interaction-
```

#### Option 2: Download ZIP

1. Go to [GitHub Repository](https://github.com/jdseyen/VR-Loy-Krathong-Interaction-)
2. Click **Code** then **Download ZIP**
3. Extract the ZIP file to your desired location

---

## Opening in Unity

### Step-by-Step Instructions

1. **Install Unity Hub**
   - Download and install [Unity Hub](https://unity.com/download)

2. **Install Unity Version**
   - Open Unity Hub then go to **Installs** then **Install Editor**
   - Select version **2022.3.58f1** (LTS)
   - During installation, ensure **Android Build Support** is included (for Quest)

3. **Add the Project**
   - Open Unity Hub then go to **Projects** then **Open** then **Add project from disk**
   - Browse to the cloned/downloaded folder: `VR-Loy-Krathong-Interaction-`
   - Select the project folder and click **Open**

4. **Wait for Unity to Load**
   - First launch may take 5-10 minutes as Unity regenerates the Library folder
   - This is normal -- the Library folder is not stored in the repo (it's auto-generated)

5. **Open the Main Scene**
   - In Unity, go to `Assets/Scenes/`
   - Double-click **SampleScene.unity** or **VR Setup.unity**

6. **Connect Your VR Headset**
   - Connect your Meta Quest via USB or ensure Air Link is configured
   - In Unity: **Edit** then **Project Settings** then **XR Plug-in Management**
   - Ensure **Oculus** (or **OpenXR**) is checked

7. **Enter Play Mode**
   - Put on your VR headset
   - Click the **Play** button (triangle) at the top of Unity
   - Enjoy the experience!

---

## Project Structure

```
Assets/
+-- Editor/              # Unity editor scripts
+-- Environment/         # 3D environment assets
|   +-- Day-Night Skyboxes/
|   +-- Objects/
|   +-- Plants and Trees/
|   +-- Rocks/
|   +-- Water/
+-- Import/              # Imported 3D models
+-- Materials/           # Unity materials
+-- Oculus Hands/        # Hand tracking assets
+-- Particles/           # Particle effects
+-- Prefabs/             # Reusable game objects
+-- Scenes/              # Unity scenes
+-- Scripts/             # Custom C# scripts
|   +-- OnButtonPress.cs    # VR button interaction
|   +-- RadioPlayer.cs      # Audio playback
|   +-- ToggleRay.cs        # Ray/direct toggle
+-- Settings/            # XR settings
+-- Sound/               # Audio files
+-- Source Files/        # Source assets
+-- XR/                  # XR configuration
```

---

## Controls

| Action | Controller |
|--------|------------|
| **Grab Object** | Grip Button |
| **Release Object** | Release Grip |
| **Interact** | Trigger Button |
| **Point/Select** | Point with controller |

---

## Technical Details

- **Engine:** Unity 2022.3.58f1 (LTS)
- **Render Pipeline:** Universal Render Pipeline (URP)
- **VR SDK:** XR Interaction Toolkit 2.6.4
- **Hand Tracking:** XR Hands 1.4.3
- **Target Platform:** Meta Quest 2/3/Pro

---

## Screenshots

<p align="center">
  <img src="Pictures/Screenshot%202026-01-21%20144316.png" width="400" alt="Screenshot 1">
  &nbsp;&nbsp;
  <img src="Pictures/Screenshot%202026-01-21%20144453.png" width="400" alt="Screenshot 2">
</p>

<p align="center">
  <img src="Pictures/Screenshot%202026-01-21%20144518.png" width="400" alt="Screenshot 3">
  &nbsp;&nbsp;
  <img src="Pictures/Screenshot%202026-01-21%20144603.png" width="400" alt="Screenshot 4">
</p>

---

## Troubleshooting

| Issue | Solution |
|-------|----------|
| **Library folder missing** | Normal! Unity regenerates it on first open |
| **VR headset not detected** | Check USB connection or Air Link setup |
| **Black screen in VR** | Ensure XR Plug-in Management is configured |
| **Scripts not compiling** | Verify Unity version is 2022.3.58f1 |

---

## License

This project is for educational and personal use.

---

<p align="center">
  <sub>Built with Unity and VR Technology</sub>
</p>
