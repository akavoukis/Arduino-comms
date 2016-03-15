/*


#include <cstring>
#include <iostream>

#include <TimerOne.h>           // Avaiable from http://www.arduino.cc/playground/Code/Timer1

volatile int i=0;               // Variable to use as a counter
volatile boolean zero_cross=0;  // Boolean to store a "switch" to tell us if we have crossed zero
int AC_pin = 11;                // Output to Opto Triac
int dim = 110;                    // Dimming level (0-128)  0 = on, 128 = 0ff
int inc=1;                      // counting up or down, 1=up, -1=down
int OnPeak = 130;
int OffPeak = 0;

int freqStep = 65;    // This is the delay-per-brightness step in microseconds.

String inputString = "";         // a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete
char inChar[20]; // Allocate some space for the string
char ReadedChar;
byte index = 0; // Index into array; where to store the character
int VolumeLevel=0;
int ledPin = 3;

void zero_cross_detect() {    
  zero_cross = true;               // set the boolean to true to tell our dimming function that a zero cross has occured
  i=0;
  digitalWrite(AC_pin, LOW);       // turn off TRIAC (and AC)
}                                 

// Turn on the TRIAC at the appropriate time
void dim_check() {                   
  if(zero_cross == true) {              
    if(i>=dim) {                     
      digitalWrite(AC_pin, HIGH); // turn on light       
      i=0;  // reset time step counter                         
      zero_cross = false; //reset zero cross detection
    } 
    else {
      i++; // increment time step counter                     
    }                                
  }                                  
}        

void setup() {
  // initialize serial:
  Serial.begin(115200);
   pinMode(ledPin, OUTPUT);     
  // reserve 200 bytes for the inputString:
  
  pinMode(AC_pin, OUTPUT);                          // Set the Triac pin as output
  attachInterrupt(0, zero_cross_detect, RISING);   // Attach an Interupt to Pin 2 (interupt 0) for Zero Cross Detection
  Timer1.initialize(freqStep);                      // Initialize TimerOne library for the freq we need
  Timer1.attachInterrupt(dim_check, freqStep);      
}

void loop() 
{
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
       Serial.print(VolumeLevel);
       Serial.print("\t");
       dim = map (VolumeLevel,0,100,OffPeak,OnPeak);
       dim = constrain(dim, OnPeak, OffPeak);

    }
    else if (inChar[0] == 'P' && inChar[1] == 'N')
    {
      char OffPeakChar[3];
     
     
      OffPeakChar[0] = inChar[4];
      OffPeakChar[1] = inChar[5];
      OffPeakChar[2] = inChar[6];
      
      OffPeak = atoi(OffPeakChar);
      
    }
    else if (inChar[0] == 'P' && inChar[1] == 'F')
    {
       char OnPeakChar[3];
      OnPeakChar[0] = inChar[4];
      OnPeakChar[1] = inChar[5];
      OnPeakChar[2] = inChar[6];
      
      OnPeak = atoi(OnPeakChar);

    }
    else if  (inChar[0] == 'O' && inChar[1] == 'N')
    {
      
      dim = 0;
      Serial.print("SET TO:");
      Serial.println(dim);
    }
    else if  (inChar[0] == 'F' && inChar[1] == 'F')
    {
      
      dim = 150;
      Serial.print("SET TO:");
      Serial.println(dim);
    }
    else if  (inChar[0] == 'D' && inChar[1] == 'I')
    {
       char Level[3];
       Level[0] = inChar[5];
       Level[1] = inChar[6];
       Level[2] = inChar[7];
    
       dim = atoi(Level);
       
       dim = 150 - dim;
       
       Serial.print("SET TO:");
       Serial.println(dim);
    }
    inputString = "";
    stringComplete = false;
  }
}


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
