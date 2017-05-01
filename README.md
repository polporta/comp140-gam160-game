# Comp140-gam160-game
Repository for Assignment 1 of COMP140-GAM160
# Game Proposal: Pol Porta
## Core Mechanics
The game Is a running type game which would involve music, the main mechanic is that as you get close to the wall with a compass drawn in it that blocks your path, a pattern will be displayed in the screen and you must repeat it with the controller, that will destroy the door and with the correct timing will make the song clear.
### Game Description
The game will be seen from a First Person point of view and the pattern will be displayed in the center of the screen, the player won’t have any control over the character so it will move forward without stopping, if the character hits a wall it's game over and the player has to restart the game, the level will have a straight linear path with different combinations of notes, they will display different patterns depending on the compass of the partiture, the difficulty will increase when after a few walls the patterns will stop popping on the screen and the player will have to memorize the controllers.
The music will mostly be instrumental and the player will emit sounds when using the controller, this sounds will be a bass drum, snare drum, high tom-tom, medium tom-tom, high hat and the crash cymbal depending on the pattern that he/she will have to follow.



# Controller
The controller i'll design will contain the following materials:
1. 2 Joysticks
2. 1 Button
3. 10 Jumper Wires
4. Breadboard
5. 2 SparkFun Thumb Joystick Breakout
The controller will have one joystick control the cymbals and the floor Tom-tom while the other joystick will control the other parts of the drums and the Middle button will pause the game, i have seen some controllers that use 1 joystick and 4 buttons or 2 joysticks when i prefer to have a button to have some control over the game apart from only playing it, the joysticks will be placed on top of the SparkFun Thumb Joystick Breakouts and the button will be in the center of the Breadboard, they will be connected together through the Jumper Wires maybe some resistors depending on the energy intake.

(http://www.ebay.com/p/Joystick-Breakout-Module-Shield-Joystick-Ps2-Game-Controller-for-Arduino/1748459619 "A similar look to my design")


# ARDUINO
```
int xPin = A1;
int yPin = A0;
int buttonPin = 2;
int x2Pin = A3;
int y2Pin = A4;
int button2Pin = 4;

int xPosition = 0;
int yPosition = 0;
int buttonState = 0;
int x2Position = 0;
int y2Position = 0;
int button2State = 0;

void setup() {
  // initialize serial communications at 9600 bps:
  Serial.begin(9600); 
  
  pinMode(xPin, INPUT);
  pinMode(yPin, INPUT);
   pinMode(x2Pin, INPUT);
  pinMode(y2Pin, INPUT);

  //activate the button resistor
  pinMode(buttonPin, INPUT_PULLUP); 
  pinMode(button2Pin, INPUT_PULLUP);
  
}

void loop() { //Reading the values of the pins
  xPosition = analogRead(xPin);
  yPosition = analogRead(yPin);
  buttonState = digitalRead(buttonPin);
  x2Position = analogRead(x2Pin);
  y2Position = analogRead(y2Pin);
  button2State = digitalRead(button2Pin);
  //printing the values
  Serial.print("X: ");
  Serial.print(xPosition);
  Serial.print(" | Y: ");
  Serial.print(yPosition);
  Serial.print(" | Button: ");
  Serial.println(buttonState);
   Serial.print("X2: ");
  Serial.print(x2Position);
  Serial.print(" | Y2: ");
  Serial.print(y2Position);
  Serial.print(" | Button2: ");
  Serial.println(button2State);

  delay(500); // add some delay between reads
}

  ```
