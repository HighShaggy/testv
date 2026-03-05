Запуск проекта
1. Запустить Docker контейнер c MS SQL 2022
docker compose up -d

Проверить контейнер:

docker ps


2. Подключение к базе данных

Параметры подключения:

Server=localhost,7102
User=sa
Password=StrongPass!123
Database=master

3. Запуск Web API

Открыть проект Web API и запустить его.

По умолчанию API будет доступен по адресу:

https://localhost:7002

4. Запуск WinForms

Запустить WinForms приложение.

Приложение отправляет HTTP запросы в Web API.
