docker compose up -d db

docker exec -it db psql -U postgres

CREATE TABLE "users" (
  "id" SERIAL PRIMARY KEY,
  "name" VARCHAR(50) NOT NULL,
  "email" VARCHAR(100) NOT NULL,
  "address" VARCHAR(255) NOT NULL,
  "date_birth" DATE NOT NULL
);

CREATE TABLE "customers" (
  "id" SERIAL PRIMARY KEY,
  "name" VARCHAR(50) NOT NULL,
  "email" VARCHAR(100) NOT NULL,
  "address" VARCHAR(255) NOT NULL,
  "date_birth" DATE NOT NULL
);

CREATE TABLE "books" (
  "id" SERIAL PRIMARY KEY,
  "name" VARCHAR(50) NOT NULL,
  "rack_no" INTEGER NOT NULL,
  "publisher" VARCHAR(255) NOT NULL,
  "publish_date" DATE NOT NULL
);

CREATE TABLE "racks" (
  "id" SERIAL PRIMARY KEY,
  "name" VARCHAR(50) NOT NULL,
  "room_no" INTEGER NOT NULL
);

CREATE TABLE "rooms" (
  "id" SERIAL PRIMARY KEY,
  "name" VARCHAR(50) NOT NULL,
  "build_no" INTEGER NOT NULL
);


docker compose build

docker compose up csharpapp


📝 Create a user

To create a new user, make a POST request to localhost:8080/api/users.

The body of the request should be like that:

{
    "name": "aaa",
    "email": "aaa@mail"
}

📝 Get a user

To get a user, make a GET request to localhost:8000/api/users/{id}.

For example GET request to localhost:8000/api/users/1.

📝 Update a user

To update a user, make a PUT request to localhost:8000/api/users/{id}.

For example PUT request to localhost:8000/api/users/2.

📝 Delete a user

To delete a user, make a DELETE request to localhost:8000/api/users/{id}.

For example DELETE request to localhost:8000/api/users/1.



On Postman you should see something like that:

https://dev.to/francescoxx/c-c-sharp-crud-rest-api-using-net-7-aspnet-entity-framework-postgres-docker-and-docker-compose-493a