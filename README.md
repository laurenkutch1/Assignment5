Extensions:

1. Blade light that lights up the scene. I added a Point Light to the blade and wrote BladeLight.cs. The light flickers a little using Perlin noise, and it gets dimmer as the blade retracts so it matches the blade. I added a plane, a cube, and a sphere so you can see the glow spill onto objects around the saber. I also lowered the Directional Light so the blade light is easier to see.

2. Double-bladed saber. I duplicated the blade setup and flipped it 180 degrees so there is a second blade coming out of the other end of the hilt. It has its own point light, and both blades extend and retract together when you press Space.
