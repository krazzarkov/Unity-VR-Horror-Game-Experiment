# [WIP] Unity VR Horror Game Experiment
 A test/experiment to create a convincing horror game in VR using Unity. Inspired by Valem's "making a horror game in VR" tutorial. 

![Alt Text](https://media.giphy.com/media/eJ9OZulDk7Y2agj5fz/giphy.gif)

The idea of the game was to create a dark forest environment in Unity using the built in Terrain tools as well as trees and foliage provided by Unity's standard assets.

I also imported some free assets found on the Unity Asset store to quickly prototype a scary environment. 

![Alt Text](https://media.giphy.com/media/kG9UDgIiJCeVQDxvwa/giphy.gif)

The premise of the game is that your car breaks down in a strange forest. Using only a flashlight you have to navigate the forest and find parts to fix your car such as tires, spark plugs, and a car battery. After finding these items you need to carry them back to your car so that you can repair it. 

![Alt Text](https://media.giphy.com/media/mEPrQW10dQM4sdZQrR/giphy.gif)

Currently, there is only one implemented item that you need to bring back to your car in order to fix it although more will be added soon as this project is a work in progress. There is also no enemy AI however that will also be added soon in the form of a creature that follows you around and tries to stop you from escaping the forest. 

To repair your car, you simply need to bring the spare tire you found and put it in the spot where the car is missing a tire from where your vehicle will automatically repair and show the user a new model that is not broken. 

![Alt Text](https://media.giphy.com/media/h3zX81uO0tcbKqJ9mE/giphy.gif)

Since VR games can be quite expensive to run for this project, I also spent time learning optimization techniques to make my game run better. I am currently using baked lighting in my scene as well as occlusion culling that only renders what the player sees which helps the game with performance and should help keep performance consistent if the game is every scaled up and expanded on.

![Alt Text](https://media.giphy.com/media/lpzKGnnGjH7bqCxAvg/giphy.gif)
