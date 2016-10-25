# HelloHolograms
A variation of the [Holograms 100 tutorial](https://developer.microsoft.com/en-us/windows/holographic/holograms_100) from the Holographic Academy. This one uses the HoloToolkit for Unity, and it also includes additional features like shooting balls around the space, and spatial mapping to use the real world in the virtual balls physics. The spatial mesh can be visually turned on and off, though it always remains active for collision detection.

## Features
* Displays a cube 2 meters in front of the user.
* Air tap the cube to make the cube follow your gaze for placement. Tap again to place the cube. There is a current issue with this (see notes below).
* Shoot white balls into the environment by air tapping in the space; watch them bouce around the real-world space thanks to spatial mapping on the HoloLens.
* Show or hide the spatial mesh of your environment with the "display mesh" and "hide mesh" voice commands.

## Implementation Notes
* This sample uses Unity's high performance physics by enabling Continuous Dynamic Collision Detection on the sphere prefab's Rigidbody to prevent issues where the sphere would fall through the floor's spatial mesh.
* There is a current issue where air tapping to shoot balls interferes with the ability to pickup the starter cube  to move it around.

## Follow Me
* Twitter: [@ActiveNick](http://twitter.com/ActiveNick)
* Blog: [AgeofMobility.com](http://AgeofMobility.com)
* SlideShare: [http://www.slideshare.net/ActiveNick](http://www.slideshare.net/ActiveNick)
