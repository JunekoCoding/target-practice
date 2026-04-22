# target-practice

This project is a **physics-based virtual reality interaction prototype**, featuring modular C# state management, 3D spatial audio, and efficient object reset logic.

---

### 🛠 Technical Overview
* **Platform:** Built for **Meta Quest 3** using **Unity 6**, the prototype integrates several modular systems for robust performance.
* **Architecture:** The **modular C# architecture** separates interaction logic from entity behaviour to ensure scalability, while supporting the integration of other key features.

---

### ✨ Key Features

* **Physics-Based Interaction:** This design underpins the interaction system, which includes a decentralized respawn mechanism for both successful target hits and “out-of-bounds” recovery.
* **Performance Optimization:** Performance is optimized by using lightweight physics resetting and component caching, maintaining consistent VR frame rates throughout interactions.
* **Audio Immersion:** Further enhancing user experience, 3D spatial audio with randomized pitch shifting has been integrated to provide immersive feedback.

---

### 📂 Included Scripts
* **ColorOrb.cs**: Manages individual entity state, including "home" position memory and out-of-bounds safety checks.
* **ColorTarget.cs**: Handles collision detection, dynamic material updates, and triggers the audio-visual feedback loop.
* **ObjectMover.cs**: Implements smooth sinusoidal movement for targets using world-space mathematics.
