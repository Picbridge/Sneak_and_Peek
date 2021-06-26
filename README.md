# Sneak_and_Peak

![Main](/IMAGE/main.png)

## Game/Project Summary 

2.5D based stealth game.

The player plays the role of a thief who tries to steal the jewelry. 

The main concept of the game is to escape the city without getting caught by the guards. 

## Target Demographic

Sneak and peek takes players to an escape in which, the pretext of ensuring the security. It will be appealing to avoid people solving problems with hiding.

## Target Play Time

* Atom: Players will have time to complete an atom of small puzzle games, the future levels or quest would be harder. This will occur approximately every 1 to 3 minutes.

* Session: The whole quest will consist of 3 small levels, which will take between 15 to 20 minutes. 

## AI

### Behavior tree

![Chasing](/IMAGE/Chase.gif)

Agent has 6 behaviors.

* Idle: doing nothing for a while
* Wander: Move to random position in range
* Detect: Always checking if the player is inside the vision, or if the sound is near.
* Approach: Appoach towards the player if detected
* Check arrival: Check if the agent is near the desired position, and if player is recently found, search around
* Catch: Catch the player if the player is near agent.

### Vision cone: 

![VisionCone](/IMAGE/Vision.gif)

Implemented in three steps. 

* Is suspicious thing within the view distance? 
* Is it also in view angle? 
* Is it visible through obstacles? 

If true, then agent detected it. 

### Agent awareness: 

 ![DetectStanding](/IMAGE/Detected.png)

The height of the sight also can make a lot of difference. If the starting point of the ray is from agent’s eyes, 
it probably won’t be able to detect the player if crouching. However, it won’t make sense if a real person can’t detect other people just because they are crouching. 
This is why AI needs to change its behavior based on player’s status. Agent should look down at player when they are crouching.

![DetectCrouching](/IMAGE/NotDetected.png)
 
AI doesn’t always need to shoot rays in two different angle every time. It can just be switched through player’s status. 
If the player is crouching, agent no more needs to detect higher position, vice versa.


![DetectExample](/IMAGE/Ducking.gif)
        
## Download link

To play the game, visit [download page](https://github.com/Picbridge/Sneak_and_Peak/raw/main/SneakAndPeek_Setup.exe) and download the installer.

## Assets

Subway station scene - Bench: https://assetstore.unity.com/packages/3d/props/exterior/street-bench-656
Subway station scene - Train: https://assetstore.unity.com/packages/3d/vehicles/land/subway-train-13482
Bank scene - Money pack: https://assetstore.unity.com/packages/3d/props/money-pack-84433
Main scene - Housing: https://assetstore.unity.com/packages/3d/environments/urban/brooklyn-home-112900


