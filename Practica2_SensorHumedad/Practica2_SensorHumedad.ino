#include "DHT.h"

#define DHTPIN 6      // Pin donde esta conectado el DHT11
#define DHTTYPE DHT11 //Tipo de sensor DHT

DHT dht(DHTPIN, DHTTYPE);

void setup () {
  Serial.begin(9600);
  dht.begin();

}

void loop() {
  delay(2000); //espera 2 segundos entre lecturas

  float h = dht.readHumidity();
  float t = dht.readTemperature();

  if (isnan(h) || isnan(t)) {
    Serial.println ("error al leer el sensor DHT11");
    return;
  }


  Serial.print("humedad: ");
  Serial.print(h);
  Serial.print(" %\t");
  Serial.print("Temperatura: ");
  Serial.print(t);
  Serial.print(" *C");
}
