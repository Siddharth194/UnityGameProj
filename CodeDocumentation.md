# Code Documentation

## The Assets Folder
### Contents:
#### 1. Scripts:
##### Player Scripts:
<ul> AnimationSet.cs: Sets the punching hand of the player every time he attacks. </ul>
<ul> Attack.cs: Handles the attacks and all the mechanics and animations that entail them. Uses a RayCast to check if the mouse collides with an opponent, and then deals the damage associated to the weapon currently being wielded. Also handles animations and the showing of the flash for guns, as well as regulating fire rate. </ul>
<ul> Attributes.cs: Handles the 2 key attributes of the player, i.e. his health and the weapon he is using currently.</ul>
<ul> PlayerMovement.cs: Simple player movement script. </ul>
<ul> RotationSprite.cs: Handles rotation of the player, to ensure that the player is always facing the direction of the mouse. </ul>
<ul> HandSpriteSet.cs: Handles the changing of sprites when the player changes the weapon currently being used (changing the weapon held) </ul>

##### Inventory Scripts:
<ul> EnableInventory.cs: Enables and disables the inventory display when the user presses 'I'</ul>
<ul> EquipAndUse.cs: Allows a player to equip/use an item (based on whether the item is a weapon or a consumable respectively) once the inventory is open. </ul>
<ul> InventoryCheck.cs: Basically just a testing file containing functions to create items and add them to the inventory. Pretty much redundant after the inventory testing. </ul>
<ul> InventoryScript.cs: Instantiates the inventory object from the InventoryScript class, which contains a list (the lis serves as the inventory, containing items) </ul>
<ul> InventoryUpdate.cs: Handles the updation of the inventory, both the UI and the backend. It detects button clicks and applies action accordingly. </ul>
<ul> ItemScriptInv.cs: Contains the definition of Item class, which contains necessary attributes for the Item (classifying it into a Consumable or a Weapon, the damage/HP healed, the range, durability etc) </ul>

##### Resource Box Scripts:
<ul> ResourceBox.cs: Contains the Resource Box class, which consists of the list that holds the items that would be present in the Resource Box</ul>
<ul> CreateResourceBoxes.cs: Spawns the Resource Box prefab at 10 randomly selected locations from a list of 28 hardcoded locations. </ul>
<ul> PickUpItems.cs: Allows the player to pick up items from the pick up menu of a resource box. </ul>
<ul> PlayerCollisionBox.cs: Allows the player to see the Pick Up Menu if they press 'P' when near the resource box</ul>
<ul> PopulateResourceBox.cs: Populates the existing resource boxes with random weapons and consumables.</ul>

##### Enemy Scripts:

<ul> Enemy Attributes.cs: Maintains the health of the enemy and some other parameters.</ul>
<ul> Enemy Sprite Rotation: Manages the rotation of the sprite in the direction the player is. Also handles enemy attacks.</ul>
<ul> Death.cs: Plays the death animation when the animation dies. </ul>
<ul> Enemy Spawn.cs: Handles the spawning of enemies in random locations. </ul>

##### Miscellaneous:

<ul> TimerForWave.cs: Handles the timer before every wave, and calls the function in Enemy Spawn whenever a new wave has to begin. </ul>
<ul> HealthBar.cs: Displays the player's current health. </ul>
