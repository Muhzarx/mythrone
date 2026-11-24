# MYTHRONE — RISE. FIGHT. RULE.
Copyright © 2026 Muhzarx

Unity 6 / URP / C#. This repository is an **initial playable-systems foundation**, not a finished commercial MOBA.
Unity Editor and .NET/Unity compilation are not installed in the authoring environment, so Unity compilation, Android/Windows builds, NavMesh baking and runtime QA remain unverified.

## Open
1. Install Unity Hub and a Unity 6 LTS editor with Android Build Support (SDK/NDK + OpenJDK) and Windows Build Support.
2. Create a new **3D URP** project named `MYTHRONE`.
3. Copy the `Assets/MYTHRONE` folder from this package into the project `Assets/`.
4. Open the project and let Unity compile scripts.
5. Create a scene named `Battlefield`; add a Plane, directional light, camera and NavMeshSurface (AI Navigation package). Bake the NavMesh.
6. Add a HeroDefinition asset for each roster entry using Create > MYTHRONE > Hero Definition.
7. Add `MatchBootstrap` to an empty GameObject and assign the player prefab and hero definition. Assign a baked NavMesh for bot navigation.

## Current foundation
- Ten original ScriptableObject hero definitions generated at runtime by the editor menu.
- Health, team/faction, basic combat, player movement, camera follow, bot lane patrol/engage state logic, core objective and match win/lose checks.
- No online networking; single-player offline match foundation.

## Explicitly not finished yet
Full authored 3D models/rigs/animations, full map art, all unique hero abilities/ultimates, minion waves, jungle camps/buffs/objectives, towers, item economy/shop, mobile UI/joystick, PC input remapping, audio, save/settings, polished menus, performance profiling and release builds. Temporary primitive visuals are marked as placeholders. Do not advertise this as feature-complete.

## License / assets
All code and names in this starter are original project material © 2026 Muhzarx. No third-party art, music, models or copyrighted MOBA assets are bundled. Primitive runtime visuals are development placeholders.
