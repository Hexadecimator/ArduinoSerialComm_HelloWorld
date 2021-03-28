int RED_LED   = 2;
int GREEN_LED = 3;
int BLUE_LED  = 4;
  
void setup() {
  pinMode(RED_LED, OUTPUT);
  pinMode(GREEN_LED, OUTPUT);
  pinMode(BLUE_LED, OUTPUT);

  digitalWrite(RED_LED, LOW);
  digitalWrite(GREEN_LED, LOW);
  digitalWrite(BLUE_LED, LOW);
  
  Serial.begin(9600);
}

void loop() {

  char serial_in = Serial.read();

  switch (serial_in) {
    case '1':
      digitalWrite(RED_LED, HIGH);
      break;
    case '2':
      digitalWrite(GREEN_LED, HIGH);
      break;
    case '3':
      digitalWrite(BLUE_LED, HIGH);
      break;
    case '4':
      digitalWrite(RED_LED, LOW);
      break;
    case '5':
      digitalWrite(GREEN_LED, LOW);
      break;
    case '6':
      digitalWrite(BLUE_LED, LOW);
      break;  
  }
  
  
}
