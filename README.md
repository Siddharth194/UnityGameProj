# Game Title

Outbreak: A 2D Top-Down RPG-Style Survival game

## Table of Contents

- Introduction
- Features
- Installation
- Controls
- Gameplay
- External Utilities used
- Credits
- Challenges Faced
- Future Scope
  
## Introduction

Outbreak is a 2D survival game created on Unity. It features enemies spawning in waves, which the player has to fight off with weapons they can acquire from resource boxes scattered around the map

## Origin of Idea

The game heavily draws from the Battle Royale format of games which focuses on survival while starting empty handed with no resources. The character design is inspired from Joel of 'The Last Of Us'. The weapons and the initially planned feature of weapon crafting stemmed from the mobile game, Last Day On Earth.  

## Features

- Combat - Melee and Ranged. The player can use a variety of weapons in his arsenal to fight off zombies that spawn in waves of increasing sizes.
- Consumables - The consumables picked up by the player restore HP.
- Randomised Resource Spawns - Resource crates spawn randomly around the map, and these crates contain loot which are generated with a random probability.
- Enemies spawn in waves and track the player. The enemies use a pathfinding system to find their way around the map and attack the player.
- Weapon durability - Weapons soon break after excessive use, and one needs to have reserves of weapons to face waves that only get larger.

## Installation

Download 'my project final.exe' and run the file to play the game.

## Controls

- Movement: WASD
- Looking Around: The mouse
- Attack: Left Click. Click on the opponent you wish to target
- Inventory: Press I to access your inventory at any time. Click an item to equip or use it, and the close button helps you free up some inventory space.
- Resource Boxes: Pressing P near a resource box opens up the resource box menu, from which one can add items to their own inventory.

## Gameplay

The player spawns with no equipment in their inventory when the game begins. A 30 second window begins instantly, where the player can explore the map, and has a chance to arm themselves with weapons from resource boxes scattered around the map. The first wave begins subsequently, and the player has to kill enemies while taking mimimal damage. A break between waves allows the player to heal from any wounds sustained in the previous round.

## External Utilites used:

- The A Star Pathfinding Project, for making enemies follow a path while seeking the player.
- CodeMonkey Unity Utilities, for damage popup.

## Credits

- Artwork and Sprites: 


  Character Sprites: 
  [Riley Gombart on OpenGameArt](https://opengameart.org/art-search-advanced?keys=riley+gombart&title=&field_art_tags_tid_op=and&field_art_tags_tid=&name=&field_art_type_tid%5B%5D=9&sort_by=count&sort_order=DESC&items_per_page=24&Collection=)
  
  Building Sprites: [CraftPix on Dribbble.com](https://dribbble.com/craftpix_net)
- Animations: All animations created manually using Unity's Skeletal animation system
- Learning Resources Used:
  
  [Brackeys on YouTube](https://www.youtube.com/@Brackeys)
  
  [CodeMonkey on YouTube](https://www.youtube.com/@CodeMonkeyUnity)

## Challenges Faced:

- Creation of sprites and a Limited availability of desired assets online: To create certain animations, sprites had to be created on GIMP manually to complement the sprites already downloaded from OpenGameArt.
- Managing EventSystems: To avoid the frequent warnings of multiple EventSystems being active at the same time, it had to be ensured that only one EventSystem was active at any given point. This however, lead to unforseen bugs that happen sometimes, like certain buttons being unresponsive, which couldn't be fixed even till the end.
- Commonality of NullReferenceErrors: Fixing the various NullReferenceErrors encountered at almost every stage of the project ate into days of my time, as I just could not figure out the source of these errors, and the fixes are often very trivial with no real logic associated with them. (Like a simple change from Start() to Awake() in some class definitions, functions that do virtually the same thing when the Script is already enabled)

## Future Scope:

1. Finishing the weapon crafting system.
2. Smoother animations for the firing of automatic weapons.
3. More types of enemies (Bosses, ranged attacks, etc.)
4. More attributes to the player (Experience, hunger, thirst, stamina etc.)
5. Adding shadows for assets.

## Other files:

- [Implementation](https://github.com/Siddharth194/UnityGameProj/edit/main/Implementation.md)
- [Code Documentation](https://github.com/Siddharth194/UnityGameProj/edit/main/CodeDocumentation.md)
