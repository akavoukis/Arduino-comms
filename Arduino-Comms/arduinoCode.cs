/*
#include <cstring>
#include <iostream>

String inputString = "";         // a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete
char inChar[20]; // Allocate some space for the string
char ReadedChar;
byte index = 0; // Index into array; where to store the character
int VolumeLevel=0;
int ledPin = 13;

void setup() {
  // initialize serial:
  Serial.begin(9600);
   pinMode(ledPin, OUTPUT);     
  // reserve 200 bytes for the inputString:
}

void loop() {
  // print the string when a newline arrives:
  if (stringComplete) 
  {
    if (inChar[0] == 'V' && inChar[1] == ':')
    {
       char Volume[3];
       Volume[0] = inChar[3];
       Volume[1] = inChar[4];
       Volume[2] = inChar[5];
    
       VolumeLevel = atoi(Volume);
       //String test = inChar;
       //Serial.println(test);
       Serial.println(VolumeLevel);
       analogWrite(ledPin, map (VolumeLevel,0,100,0,255));
    }
    inputString = "";
    stringComplete = false;
  }
}

/*
  SerialEvent occurs whenever a new data comes in the
 hardware serial RX.  This routine is run between each
 time loop() runs, so using delay inside loop can delay
 response.  Multiple bytes of data may be available.
 */
/*
void serialEvent() {
  while (Serial.available()) 
  {
    if(index < 19) // One less than the size of the array
    {
      ReadedChar = (char)Serial.read(); // Read a character
      inChar[index] = ReadedChar; // Store it
      index++; // Increment where to write next
    }
    else
    {
      stringComplete = true;
      index = 0;
    }
    if (ReadedChar == '\n') 
    {
      index = 0;
      stringComplete = true;
      
    }
  }
}

*/
