# unity-mmd-utils

Some scripts to assist MMD-style video creation in Unity.

## CameraController
Updates FoV of all child cameras depending on distance to Bg, useful for creating a "3D" feel when using video backgrounds playing on a flat surface.

Also works with Cinemachine.
### Usage
- Assign to an empty GameObject.

- Assign cameras as its children.

- Set the desired target Bg and tweak InitialFoV.

- If you wish to use Cinemachine & vcams, simply assign CinemachineBrain to this parent GameObject.

## SignalManager

Signal management script

- Updates ambient lighting colors on-demand.

You can add more colors and functionality.
### Usage
- Assign to an empty GameObject.

- Create a SignalReceiver with desired Signals

- For each Signal, set the SignalManager, select the SignalManager.UpdateAmbientColor function and assign an integer to each: 1 corresponds to Color1; 2 corresponds to Color2, and so on.

- On the SignalReceiver track, place SignalEmitter tags where you want to update ambient lighting color, select a desired Signal for each tag to emit

## Rotator
Rotates Transform at a set speed or smoothly swing from side to side.

SwingMode currently works properly when object starts at 0°.
### Usage
- Assign to GameObject, set parameters.

## FaceDirectionManager

Sends GameObject/bone's current heading to a material's shader. 

Originally used for debugging Genshin style face shading.

### Usage
- Shader needs to receive _DirectionVector.

- Set target transform and name of target material.
