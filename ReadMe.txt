-- Enhanced Play Clip At Point
-- Dan Brackenbury

These scripts allow playing a clip at a point, much like the built in method, while still returning the AudioSource to a
variable / reference in order to be used elsewhere in code, or otherwise tracked.

These scripts include a clip tester and a very basic form of audio occlusion. In order for audio occlusion to properly work,
your listener must have a collider. Audio occlusion can be disabled when calling the method. Instantiated clips can also be
told to follow a specific transform after being created using an overload function.

Copy these scripts into a folder of your choice and use PlayAtPoint.PlayClip to instantiate audio objects.