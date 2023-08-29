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
