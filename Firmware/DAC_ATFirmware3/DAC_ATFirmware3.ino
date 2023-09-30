// Include the SPI library
#define R_NOP 0x00
#define R_DEVICEID 0x01
#define R_STATUS 0x02
#define R_SPICONFIG 0x03
#define R_GENCONFIG 0x04
#define R_BRDCONFIG 0x05
#define R_SYNCCONFIG 0x06
#define R_DACPWDWN 0x09
#define R_DACRANGE0 0x0A
#define R_DACRANGE1 0x0B
#define R_DACRANGE2 0x0C
#define R_DACRANGE3 0x0D
#define R_TRIGGER 0x0E
#define R_BRDCAST 0x0F
#define DAC0 0x17
#define DAC1 0x16
#define DAC2 0x15
#define DAC3 0x14
#define DAC4 0x13
#define DAC5 0x12
#define DAC6 0x11
#define DAC7 0x10
#define DAC8 0x1F
#define DAC9 0x1E
#define DAC10 0x1D
#define DAC11 0x1C
#define DAC12 0x1B
#define DAC13 0x1A
#define DAC14 0x19
#define DAC15 0x18


//0x17,0x16,0x15,0x14,0x13,0x12,0x11,0x10,0x1F,0x1E,0x1D,0x1C,0x1B,0x1A,0x19,0x18
// SPICONFIG masks
#define TEMPALM_EN(x) (x << 11)
#define DACBUSY_EN(x) (x << 10)
#define CRCALM_EN(x) (x << 9)
#define SOFTTOGGLE_EN(x) (x << 6)
#define DEV_PWDWN(x) (x << 5)
#define CRC_EN(x) (x << 4)
#define STR_EN(x) (x << 3)
#define SDO_EN(x) (x << 2)
#define FSDO(x) (x << 1)
// read mask
#define RREG 0xC0

#define totalDAC 10

#define debug 0

#define latchPin 6
#define clockPin 7
#define dataPin 5

#define CS_PIN 10
#include <SPI.h>
#include <MultiShiftRegister.h>

// Define the SPI settings
//SPISettings spiSettings(1000000, MSBFIRST, SPI_MODE0);
byte OutputAdress[] = { 0x17, 0x16, 0x15, 0x14, 0x13, 0x12, 0x11, 0x10, 0x1F, 0x1E, 0x1D, 0x1C, 0x1B, 0x1A, 0x19, 0x18 };
bool Change = false;
int numberOfRegisters = 20;
int actVoltage = 20000;
MultiShiftRegister msr(numberOfRegisters, latchPin, clockPin, dataPin);
uint16_t data[160];
bool BoolArray[160];
byte bitArray[20];
byte mode = 0;         // Variable to store mode value
byte on_off = 0;       // Variable to store on_off value
uint16_t voltage = 0;  // Variable to store voltage value


void setup() {
  // Initialize the SPI bus

  Serial.begin(115200);
  //Serial.println("...........................");
  //Serial.println("Antenna Controller");
  //Serial.println("...........................");
  pinMode(latchPin, OUTPUT);
  pinMode(clockPin, OUTPUT);
  pinMode(dataPin, OUTPUT);
  pinMode(CS_PIN, OUTPUT);
  digitalWrite(CS_PIN, HIGH);
  SPI.begin();

  for (int i = 0; i < 160; i++) {
    msr.clear(i);
    msr.shift();
    data[i] = 0;
    BoolArray[i] = 0;
    DACSetVoltage(0, i);
  }
  //delay(5000);
  //SPI.setRX(16);
  //SPI.setTX(16);
  //SPI.setSCK(18);
  if (debug) {
    while (!Serial)
      ;
  }
  initDAC(0);
  initDAC(1);
  initDAC(2);
  initDAC(3);
  initDAC(4);
  initDAC(5);
  initDAC(6);
  initDAC(7);
  initDAC(8);
  initDAC(9);
  //Serial.println("...........................");
  //Serial.println("All DACs initialized");
  //Serial.println("...........................");
  for (int i = 0; i < 160; i++) {
    DACSetVoltage(0, i);
  }
}
#define DAC71416_MAX_VALUE 16383  // Max value for 14-bit DAC
#define CHANNEL1_ADDRESS 0x01     // Assuming channel 1 has an address of 0x01
void setChannel1ToMax() {
  // Split the 14-bit max value into two bytes
  byte lowByte = (byte)(DAC71416_MAX_VALUE & 0xFF);
  byte highByte = (byte)((DAC71416_MAX_VALUE >> 8) & 0xFF);

  SPI.beginTransaction(SPISettings(8000000, MSBFIRST, SPI_MODE1));
  digitalWrite(CS_PIN, LOW);

  // Send the address byte for channel 1
  SPI.transfer(CHANNEL1_ADDRESS);

  // Send the high and low bytes of the max value
  SPI.transfer(highByte);
  SPI.transfer(lowByte);

  digitalWrite(CS_PIN, HIGH);
  SPI.endTransaction();
}
void loop() {

  ATRoutine();

  if (Change == true && on_off == 1) {
    Change = false;
    for (int i = 0; i < 160; i++) {
      if (BoolArray[i]) {
        if (mode == 0) {
            DACSetVoltage(voltage, i);
        } else {
          DACSetVoltage(data[i], i);
        }
      } else {
        DACSetVoltage(0, i);
      }
    }
    LED_Drive();
  }
  if (Change == true && on_off == 0) {
    {
      Change = false;
      for (int i = 0; i < 160; i++) {
        DACSetVoltage(0, i);
        msr.clear(i);
        msr.shift();
      }
    }
  }

  /*
  if (Change == true && on_off == 1) {
    Change = false;
    for (int i = 0; i < 160; i++) {
      msr.set(i);
      msr.shift();
    }
    delay(500);
    for (int i = 0; i < 160; i++) {
      msr.clear(i);
      msr.shift();
    }
  }
  */
}


inline void tcsh_delay() {
  delayMicroseconds(1);
}
void LED_Drive() {
  for (int i = 0; i < 160; i++) {
    if (BoolArray[i]) {
      msr.set(i);
      msr.shift();
    } else {
      msr.clear(i);
      msr.shift();
    }
  }
}
bool checkBit(int pos) {
  int byteIndex = pos / 8;
  int bitPos = pos % 8;

  return (bitArray[byteIndex] & (1 << bitPos)) != 0;
}
void ATRoutine() {

  byte temp;
  if (Serial.available() > 29) {
    String prefix = Serial.readStringUntil(':');
    if (prefix.startsWith("AT+STSS")) {
      on_off = Serial.read();
      mode = Serial.read();
      for (int i = 0; i < 20; i++) {
        byte value = Serial.read();
        for (int j = 0; j < 8; j++) {
          BoolArray[i * 8 + j] = (value >> j) & 1;
        }
      }
      if (mode == 0) {
        byte highByte = Serial.read();
        byte lowByte = Serial.read();
        voltage = (highByte << 8) | lowByte;
      } else if (mode == 1) {
        for (int i = 0; i < 160; i++) {

          byte highByte = Serial.read();
          byte lowByte = Serial.read();
          uint16_t j = (highByte << 8) | lowByte;
          /*
          mySerial.print(i);
          mySerial.print(" High Byte : ");
          mySerial.print(lowByte);
          mySerial.print(" Low Byte : ");
          mySerial.print(highByte);
          mySerial.print(" Value : ");
          mySerial.println(j);
          */
          delay(1);
          data[i] = j;
        }
      }
      if (Serial.available()) {
        temp = Serial.read();
      }
      Serial.println("AT+ACK");
      Change = true;
      /*
      if (on_off == 1) {
        mySerial.print("On ");
      } else {
        mySerial.print("Off ");
      }
      if (mode == 0) {
        mySerial.println("Mode1 ");
        for (int i = 0; i < 160; i++) {
          if (BoolArray[i]) {
            mySerial.print("1");
          } else {
            mySerial.print("0");
          }
          mySerial.print(" ");
          if ((i + 1) % 16 == 0)  // +1 because indices start from 0
          {
            mySerial.write('\n');  // This will print a newline character.
          }
        }
        mySerial.println(" ");
        mySerial.println("Voltage: ");
        mySerial.println(voltage);
        Serial.println("AT+ACK");
      } else if (mode == 1) {
        mySerial.println("Mode2 ");
        mySerial.println("SW Status ");
        for (int i = 0; i < 160; i++) {
          if (BoolArray[i]) {
            mySerial.print("1");
          } else {
            mySerial.print("0");
          }
          mySerial.print(" ");
          if ((i + 1) % 16 == 0)  // +1 because indices start from 0
          {
            mySerial.write('\n');  // This will print a newline character.
          }
        }
        mySerial.println(" ");
        mySerial.println("Voltage: ");
        for (int i = 0; i < 160; i++) {
          int j = data[i];
          mySerial.print(j);
          mySerial.print(" ");
          if ((i + 1) % 16 == 0)  // +1 because indices start from 0
          {
            mySerial.write('\n');  // This will print a newline character.
          }
        }
        Serial.println("AT+ACK");
      } else {
        mySerial.print("Mode error ");
      }
      */
    } else {
      if (Serial.available()) {
        temp = Serial.read();
      }
    }
  }
}


void initDAC(int DACIndex) {
  //Serial.print("Init DAC Number : ");
  //Serial.println(DACIndex);
  writeRegister(R_SPICONFIG, 0x0a84, DACIndex);
  //Serial.print("R_SPICONFIG = ");
  //Serial.println(readRegister(R_SPICONFIG, DACIndex), HEX);
  writeRegister(R_GENCONFIG, 0x3F00, DACIndex);
  //Serial.print("R_GENCONFIG = ");
  //Serial.println(readRegister(R_GENCONFIG, DACIndex), HEX);
  //Serial.print("ID = ");
  //Serial.println(readRegister(R_DEVICEID, DACIndex), HEX);
  writeRegister(0x09, 0x0000, DACIndex);
  writeRegister(0x0A, 0x2222, DACIndex);
  writeRegister(0x0B, 0x2222, DACIndex);
  writeRegister(0x0C, 0x2222, DACIndex);
  writeRegister(0x0D, 0x2222, DACIndex);
  //Serial.println(".................................");
}
void writeRegister(byte reg, uint16_t val, int deviceIndex) {
  byte lowByte = (byte)(val & 0xff);
  byte highByte = (byte)((val >> 8) & 0xff);

  SPI.beginTransaction(SPISettings(8000000, MSBFIRST, SPI_MODE1));
  digitalWrite(CS_PIN, LOW);

  for (int i = 0; i < totalDAC; i++) {
    if (i == (totalDAC - deviceIndex) - 1) {
      SPI.transfer(reg);
      SPI.transfer(highByte);
      SPI.transfer(lowByte);
    } else {
      SPI.transfer(0x00);  // Writing 0x0000 to non-specified DACs
      SPI.transfer(0x00);
      SPI.transfer(0x00);
    }
  }

  digitalWrite(CS_PIN, HIGH);
  SPI.endTransaction();
}

uint16_t readRegister(byte reg, int deviceIndex) {
  uint16_t val = 0;

  SPI.beginTransaction(SPISettings(8000000, MSBFIRST, SPI_MODE1));
  digitalWrite(CS_PIN, LOW);
  for (int i = 0; i < totalDAC; i++) {
    if (i == (totalDAC - deviceIndex) - 1) {
      SPI.transfer(reg | 0x80);
      SPI.transfer(0x00);
      SPI.transfer(0x00);
    } else {
      SPI.transfer(0x00);
      SPI.transfer(0x00);
      SPI.transfer(0x00);
    }
  }
  tcsh_delay();
  digitalWrite(CS_PIN, HIGH);
  tcsh_delay();
  digitalWrite(CS_PIN, LOW);
  int i = 0;
  while (i < (totalDAC - deviceIndex)) {
    i++;
    byte valz = SPI.transfer(0x00);
    val = SPI.transfer(0x00) << 8;
    val |= SPI.transfer(0x00);
  }
  //Serial.print("");

  tcsh_delay();
  digitalWrite(CS_PIN, HIGH);

  SPI.endTransaction();
  return val;
}

void DACSetVoltage(unsigned long vol, byte outputIndex) {
  byte tempaddress;
  byte regindex;

  // Update the tempaddress calculation
  tempaddress = outputIndex / 16;

  // Update regindex calculation
  regindex = outputIndex % 16;

  uint16_t DACValue;
  unsigned long RAWDAC = (vol * 16383) / actVoltage;
  DACValue = RAWDAC;
  DACValue = DACValue << 2;
  
  writeRegister(OutputAdress[regindex], DACValue, tempaddress);
}