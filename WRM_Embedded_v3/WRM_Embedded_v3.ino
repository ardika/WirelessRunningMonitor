#include <MMA7455.h>
#include <Wire.h>

byte isTransmissionOn = 0;
String embeddedSoftwareDescription = "Universitas Negeri Semarang\nWireless Running Monitor - Embedded Software Version: 3\0";
String creator = "Nurkholish Ardi Firdaus";
String help = "Available Command:\n"
                 "t: Toogle Transmision\n"
                 "h: Menampilkan Page Ini\n"
                 "w: Menampilkan Versi Embedded Software\n"
                 "d: Author Embedded Software\n"
                 "p: Ping";
MMA7455 Accelerometer = MMA7455();

void (* resetFunc) (void) = 0; 

void setup()
{
   Accelerometer.InitSensor(2,0,0,0);
   Serial.begin(9600);
   while (!Serial) {};   
}


void loop()
{
  if (Serial.available() > 0) {
    char command = 0;
    command = Serial.read();
    switch (command) {
      case 't':
        isTransmissionOn = !isTransmissionOn;
        break;
      case 'h':
        Serial.print(help);
        break;
      case 'w':
        Serial.print(embeddedSoftwareDescription);
        break;
      case 'd':
        Serial.print(creator);
        break;
      case 'p':
        Serial.print("unnes!");
        break;
      case 'r':
        if (Serial) {
          Serial.end();
          resetFunc();
        }
        break;
      default:
        Serial.print("Invalid Command!");
        break;
    }   
  }
  if (isTransmissionOn) {
    Serial.print("X");
    Serial.print(Accelerometer.ReadXAxis(),DEC);
    Serial.print("Y");
    Serial.print(Accelerometer.ReadYAxis(),DEC);
    Serial.print("Z");
    Serial.print(Accelerometer.ReadZAxis(),DEC);
    Serial.print("\n");
  }
     
}


