Flappy-Bird
==================================================================

- Name and Surname: Asel Esra Ozyilmaz
- Email: esra.ozyilmaz@iaau.edu.kg
- Computer Science Department of Alatoo International University.
- Individual midterm project for Computer Oraganization & Architecture class.

## Description Of The Project

A game created by C# language and Visual Studio IDE. this project is created with ".net desktop development" framework.

### Design
Design is easily created with the help of "Windows Form App" template. Below you can see we have a toolbox where we take the tools we need in order to design our game.

<img src="https://user-images.githubusercontent.com/64264345/161948445-393edec3-7840-4097-b741-b0b992e3a1a7.jpeg" width="250">  <img src="https://user-images.githubusercontent.com/64264345/161946845-67bc16cc-1b87-49a0-ab05-45ffefc81ed1.jpeg" width="500">

`The design above is the final design where I have used tools such as: PictureBox, TextBox in order to design it. `

### Functionality

- Below you can see some methods which helps us to give rules for our game. For example, gameTimerEvent() function will help us to move our pipes while we play, also it helps us to determine when to end the game. If our bird's border crosses any of the pipe's border or ground's border our program will call endGame() method where the program stops the timer to finish the game.

- We have some attributes like: pipeSpeed, gravity and score. "score" attribute is used inside a function in order to increase the score of the game when a pipe is passed. "pipeSpeed" attribute is increased with the increasing score in order to make the game harder. Finally "gravity" attribute is used inside our gameKeysUp() & gameKeysDown() functions where we decide when and how the bird moves whenever we press the space keyword.

<img src="https://user-images.githubusercontent.com/64264345/161953671-c3ca58f3-6bb9-44c4-900f-603b2d452027.jpeg" width="400">    <img src="https://user-images.githubusercontent.com/64264345/161953664-32eb4841-6e5c-4c0e-992d-8806b5d95ad5.jpeg" width="420">

