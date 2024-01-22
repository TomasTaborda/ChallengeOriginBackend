# ChallengeOrigin

Este es el backend del Challenge para Origin.

El proyecto utiliza Entity Framework aplicando Code First para la creacion de la base de datos.
Ademas aplica el patron Repository.
Se incluye tambien un script llamado wait-for-it.sh para que primero se levante la base de datos y luego nuestra aplicacion.

## Cómo empezar
Para clonar el proyecto debemos ejecutar el comando git clone https://github.com/TomasTaborda/ChallengeOriginBackend.git
El proyecto esta dockerizado, para poder levantarlo debemos tener docker instalado y en ejecucion.

1. Moverse a la carpeta ChallengeOrigin
2. Ejecutar el comando docker-compose up.

Eso levantara el backend en el puerto 8080 y la base de datos con docker.

Para ver la documentacion de la API:

https://localhost:8080/swagger/index.html

En swagger podemos ejecutar el endpoint /api/Tarjeta/GetTarjetas para obtener la lista de tarjetas y elegir el numero de tarjeta
que queramos para la prueba.
Alli podemos ver datos como el pin y el saldo disponible.
