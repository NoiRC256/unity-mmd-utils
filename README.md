# unity-mmd-utils

Some of the stagework scripts for unity, used in https://www.bilibili.com/video/BV1ZA411s7Tx

## CameraController
Updates FoV of all child cameras based on distance to target, useful for creating a 3D feel when using video backgrounds on some flat surface. Works with Cinemachine.

### Usage
- Assign to empty GameObject.

- Assign cameras as children.

- Set target, tweak baseFoV.

- If you wish to use Cinemachine & vcams, simply assign CinemachineBrain to this parent GameObject.

## SignalManager

A simple management script for timeline signals.

- Updates ambient lighting colors on-demand.

### Usage
- Assign to empty GameObject.

- Create a SignalReceiver with Signals

- For each Signal, set the SignalManager, select the SignalManager.UpdateAmbientColor function and assign an integer to each: 1 corresponds to Color1; 2 corresponds to Color2, etc.

- On the SignalReceiver track, place SignalEmitter tags where you want to update ambient lighting color, select some Signal for each tag to emit

## Rotator
Rotates Transform at set speed or smoothly swing back and forth.

### Usage
- Assign to GameObject and set parameters.

## FaceDirectionManager

Originally used for debugging Genshin style face shading. Sends GameObject/bone's current heading to some shader. 

### Usage
- Shader needs to accept _DirectionVector.

- Set target transform and name of target material.
