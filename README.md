# in-class-activities
## Devlogs
### W1
Camera was previously a child object of Cat GameObject. When it is moved off, it no longer inherits the properties, such as coordinate and direction, from the parent object Cat. So when we start the game, the Camera would stay still while the Cat walks in the scene.

Here's the itch.io link:

https://nikolai16.itch.io/classpractice20260928

### W2
The r, g, b variables are floats because they have to store digits smaller than 1, since RGB values divided by 255 would be smaller numbers.


The _bounce is an int since the number of bounces are integer number. 


I forgot what is was specifically, but it should be like "Don't forget to add 'f' after a float and semi colon after eveery line."



### W3
Activity 1


1. public string GetResponse(int friendshipLevel, bool flag);
In a visual novel , the frienship level should be a whole number. The flag, since it is telling whether or not you know the secret, should be a boolean. And we were asked to give out a text response, so the output should be string. 

2. public void SetLightDimness(float sanityLevel);
Here, sanity level is supposed to be a decimal number, so float best fits the parameter.

3. public boolean DidPlayerHitBeat(float actualHitTime);


Activity 2


A class is like a car part manufactured in some factories, and a component is a specific functioning part on a Volkswagen, like a wheel or something.

Activity 3


This is because we wrote a line to calculate the velocity of the ball and then updates the color in renderer using value from the velocity calculation.


### W4
**Table: 9**


1. The cat and the soccerball needs RigidBody since we want them to be able to bounce on each other. The goal is triggered on since the ball has to go through and we don't want it to actually collide, so it needs to detect whether a goal is made.

2. I didn't use the update method in Unity but instead made up one, so when I playtested the timer it didn't work. I then asked my peers how they solved it and used update.




### W5
1. We would need Transform & NavMeshAgent in the class. 

2. I would use Start() in this class, since we want the deer to start walking toward the target at the very beginning.

3. The method should pass the value in NavMeshAgent in the inspector, which contains the necessary information for navigating the deer.


Also, target.position should be used to gets the position of the target from Transform. 

### W7
**Part 1**
1. https://docs.google.com/document/d/1crDX6_ljdbrT8OOdQbNwN7QxS_CrQY8VUW1fGK32XYQ/edit?tab=t.5n8krrz8s4x2#heading=h.n5b8vb26zho

**Part 2**
1. We need a Transform to store the location of player character and a float to store the speed.

2. We would use Monobehviour(), Update() and two void methods.

3. We need Monobehaviour() to add this script as a component to Unity and Update() to move in each frame. The two void methods will be used to enable and disable the movement.


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 