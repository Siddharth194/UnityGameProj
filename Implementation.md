# The steps I followed during the course of the completion of this Project:

## 1. The idea:

I have always been fascinated by top-down/Isometric camera angle video games, and games like the Last Day On Earth on mobile was an inspiration behind the game.

## 2. Sprites, Animation and Map:

This was the most time-consuming stage of the project (and should have been done in lesser time than I took for it).

### Main Character sprites:

The character sprite of the Protagonist was downloaded from OpenGameArt (linked in README.md). 

### Animation:

After acquiring images of the body parts, they were put together in GIMP, and animations were created manually using Unity's Skeletal animation, Inverse Kinematics and Sprite Library features. This was a time consuming process. I used this as opposed to animating in frames using images, as this gives more freedom with range of movement, as one doesn't have to create entire sprites for a single frame of animation.

### Other sprites:

Most weapon sprites were downloaded, but a few were created on GIMP. The Resource box sprite was also created. Buildings and Road images were also downloaded. The game map was created using Unity's tilemap feature. The map is a 100 x 100 grid (for scale, the player is about 1.3 x 1.3)

### Enemy Sprites and Animation:

Enemy sprites were downloaded from OpenGameArt too, but the frames for the death animation had to be created manually. Unlike the player, the enemy has been animated frame by frame using images, due to a limited range of actions associated with the enemy (movement, attacks and death).

## 3. Player Movement and Animation:

The first bit of actual coding was writing the scripts for player movements and camera settings. The player moves with simple WASD controls, and is constantly rotated in the direction of the mouse pointer.
The created animations for attack were then put together in the animator, and the parameters were adjusted to their desireable values in scripts.

## 4. Loot and Inventory:

A script was created to spawn ten instances of the resource box prefab (spawned at random locations from a list of possible locations), which would contain weapons and consumables (determined randomly). The inventory and the Loot UI were created using simple rectangular panels and buttons created manually on GIMP, and buttons were added for equipping, removing and picking up. Corresponding scripts were written too.

## 5. Enemies:

The process of assigning sprites and animations was repeated for creating the enemy prefab. I imported Utilites from the A star pathfinding project, which contains scripts for the enemies to navigate around a map which contains obstacles, like buildings in this case.

## 6. Attacks:

The attacking controls are fairly straightforward: Click on an opponent (hold down in the case of the automatic rifle) and deal damage. If using a melee weapon (or bare fists), your range would be limited. 

The enemy deals damage in gaps of 1 second if the player is within range. Their attacks are melee only, but initial plans did include a zombie that deals ranged damage. The interval of the attacks was determined using a Coroutine.

## 7. Final updates:

Spawning enemies in waves which increment by 6, with enemies spawning randomly at locations from a pre-determined, hardcoded list of 41 locations.
