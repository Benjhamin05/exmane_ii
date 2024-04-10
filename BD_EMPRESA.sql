CREATE DATABASE EMPRESA

USE EMPRESA

CREATE TABLE TRABAJADOR(
id_tra int primary key,
nombre varchar(100) not null,
apellido varchar(100) not null,
sueldo_b money not null,
categoria varchar(20) not null,
)

