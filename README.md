# SuperMarioGame
## Garbage Gathering Version
The Super Mario games follow Mario's adventures, typically in the
fictional Mushroom Kingdom with Mario as the player character.
In this project, I have changed the scenario of Super Mario in order to
create educational content related to the environment.
Accordingly, instead of collecting coins, he collects garbage during his
adventure and at the end of each level, he could distinguish them
according to organic and non-organic garbage into different recycle
bins. Also, in this version, the term “Enemy” is given to other living thing
in nature, and dealing with them will cause damage to the player, but
the player will not be allowed to kill them and just try to avoid them. I
think we should learn to respect to other creatures’ life.
However, the player can use the food resources available in nature. To
this end, there is a mushroom at every level of the game that increases
the health and growth of the player.
The player should be careful about the open holes and jump across
them, otherwise he will die.
This project contains 5 scenes and 3 levels. The player will win if he has
passed all the levels. Also, based on the amount of garbage collected, the
stars are given to him in order to encourage him to gather more garbage.
If the player dies, the game is over and he will lose.
## Quick start
for playing the game it is enough to run the SuperMario.exe in the *"ExecutableGame"* folder.
## Maintenance
the game will be started from the start scene. It is a screen of
presentation of the game.
With help of “TimerReset” Script, From this scene the game goes to
“Level01” after some seconds automatically. This scene contains some
graphics object as background, canvas for showing the name of the
project (The Canvas is the basis for the design of a user interface), sound
manager to play the theme music of this scene.
Should be mentioned that the projection of the main camera is set as
orthographic in order to ensure that the camera displays objects in true
2D with perspective.
In the first level the player passes nature on the ground, in the second
level he goes on an underground adventure, and in the third level he
passes through the space above the ground. Also, the kinds of organisms
are different depends on the environment.
In this game, the player moves around by using the keyboard arrows or
W, A, S, D keys. Furthermore, he can jump with the spacebar. It will be
done by assigning the “Player Controller” script to the player.
The enemy should move just in his life place. And have the specific
amount of damage for player. Actually we can create a damage script
for both enemy and kill zone (open holes) and assign the different
amount of damage to them.
There are some question blocks in the scenes those have a mushroom
or big garbage with more score than the rest garbage. The Player should
hit these blocks to be able to collect them. By using of “Brick Block” 
script and “Power Up Block” script the player can gather garbage twice
and eat the mushroom respectively.
In the end of each level there are two recycle bins for organic and nonorganic garbage.
The player can put the garbage which gather through
the level by contacting the recycle bins. And after this, the recycle bins
will be fulling of garbage. The player can reach noticeable amount of
score by this part of the game. (recycle bin script)
There is a castle after the recycle bins that navigate the player to the
next level. For this, we can set a box collider 2D component on the
entrance of it and assign the “NavPanel” script to the castle.
In this game the camera should move and follow the player. So we need
a script to have this action. This script called “Camera follow”
There is two canvas in the levels of the game through which the player
can be informed of the saved scores and his remaining health. For each
of them we need a related script: "scoreManager" and "healthBar" script.
The end scene is loaded automatically, whenever the player dies or
completes all three levels in good health. In this scene there are two
buttons for restart or quit the game, the text to determine the result of
the game and also some stars that will appear depends on the amount
of the final score. All these will be done through the “Score Menu” and
the “Star Manager” scripts. 
