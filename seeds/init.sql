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