--Creacion de Base de Datos
CREATE DATABASE IF NOT EXISTS SCHEDULSISTEM;

--Creacion de Usuario de administrcion de base datos 
CREATE USER 'horarios'@'localhost' IDENTIFIED BY 'horarios';
GRANT ALL PRIVILEGES ON horarios.* TO 'horarios'@'localhost';
FLUSH PRIVILEGES;

--seleccionar la base de datos
USE SCHEDULSISTEM;


--Creacion de Tablas independientes
CREATE TABLE maestros(
    id_maestro int unsigned AUTO_INCREMENT PRIMARY key, 
    nombre text
);
CREATE TABLE materia(
    id_materia int unsigned AUTO_INCREMENT PRIMARY KEY, 
    materia text
);
CREATE TABLE grados(
    id_grados int unsigned AUTO_INCREMENT PRIMARY KEY, 
    grados text
);
CREATE TABLE grupos(
    id_grupo int unsigned AUTO_INCREMENT PRIMARY KEY, 
    grupo text
);
CREATE TABLE hora_inicio(
    id_inicio int unsigned AUTO_INCREMENT PRIMARY KEY, 
    hora text
);
CREATE TABLE hora_fin(
    id_fin int unsigned AUTO_INCREMENT PRIMARY KEY, 
    hora text
);
    

CREATE TABLE horarios(
    id_horario INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    id_maestro int UNSIGNED,
    id_materia int UNSIGNED,
    id_grados int UNSIGNED,
    id_grupo int UNSIGNED,
    id_inicio int UNSIGNED,
    id_fin int UNSIGNED,
    FOREIGN KEY (id_maestro) REFERENCES maestros(id_maestro),
    FOREIGN KEY (id_materia) REFERENCES materia(id_materia),
    FOREIGN KEY (id_grados) REFERENCES grados(id_grados),
    FOREIGN KEY (id_grupo) REFERENCES grupos(id_grupo),
    FOREIGN KEY (id_inicio) REFERENCES hora_inicio(id_inicio),
    FOREIGN KEY (id_fin) REFERENCES hora_fin(id_fin)
);

--insercion de datos en las tablas
---atbla maestros
insert into maestros(nombre) values ('Padilla Maynez Xochitl Maria ');
insert into maestros(nombre) values ('Meza de Luna Miguel Angel  ');
insert into maestros(nombre) values ('Francisco Alejandro Robles Ramirez ');
insert into maestros(nombre) values ('Lopez Lopez Juan Jose ');
insert into maestros(nombre) values ('Lamas Gonzales Wendy Raquel ');
insert into maestros(nombre) values ('Castillo Rosales Paula ');
insert into maestros(nombre) values ('CASTORENA MIGLIUOLO CLAUDIA');
insert into maestros(nombre) values ('Francisco Javier Ornelas Zapata ');
insert into maestros(nombre) values (' ');
insert into maestros(nombre) values ('Alejandro Padilla Diaz  ');
insert into maestros(nombre) values (' Graciela Gomez Urzua, ');
insert into maestros(nombre) values (' ');
insert into maestros(nombre) values ('DIAZ DE LEON GONZALEZ ANTONIO ');
insert into maestros(nombre) values (' ');
insert into maestros(nombre) values ('Manuel López Chaves ');
insert into maestros(nombre) values (' ');
insert into maestros(nombre) values (' ');
insert into maestros(nombre) values (' ');
insert into maestros(nombre) values (' ');
insert into maestros(nombre) values (' ');

--tabla Hora_inicio
insert into hora_inicio(hora) values ('07:00 ');
insert into hora_inicio(hora) values ('07:50 ');
insert into hora_inicio(hora) values ('08:40 ');
insert into hora_inicio(hora) values ('09:30 ');
insert into hora_inicio(hora) values ('09:50 ');
insert into hora_inicio(hora) values ('10:40 ');
insert into hora_inicio(hora) values ('11:30 ');
insert into hora_inicio(hora) values ('12:20 ');
insert into hora_inicio(hora) values ('13:10 ');
insert into hora_inicio(hora) values ('14:00 ');
insert into hora_inicio(hora) values ('14:50 ');
insert into hora_inicio(hora) values ('15:40 ');
insert into hora_inicio(hora) values ('16:30 ');
insert into hora_inicio(hora) values ('17:00 ');
insert into hora_inicio(hora) values ('17:50 ');
insert into hora_inicio(hora) values ('18:40 ');
insert into hora_inicio(hora) values ('19:30 ');

--tabla hora_fin
insert into hora_fin(hora) values ('07:50 ');
insert into hora_fin(hora) values ('08:40 ');
insert into hora_fin(hora) values ('09:30 ');
insert into hora_fin(hora) values ('09:50 ');
insert into hora_fin(hora) values ('10:40 ');
insert into hora_fin(hora) values ('11:30 ');
insert into hora_fin(hora) values ('12:20 ');
insert into hora_fin(hora) values ('13:10 ');
insert into hora_fin(hora) values ('14:00 ');
insert into hora_fin(hora) values ('14:50 ');
insert into hora_fin(hora) values ('15:40 ');
insert into hora_fin(hora) values ('16:30 ');
insert into hora_fin(hora) values ('17:00 ');
insert into hora_fin(hora) values ('17:50 ');
insert into hora_fin(hora) values ('18:40 ');
insert into hora_fin(hora) values ('19:30 ');
insert into hora_fin(hora) values ('20:20 ');

--tabla grupos
insert into grupos(grupo) values ('A ');
insert into grupos(grupo) values ('B ');
insert into grupos(grupo) values ('C ');
insert into grupos(grupo) values ('D ');
insert into grupos(grupo) values ('E ');
insert into grupos(grupo) values ('F ');
insert into grupos(grupo) values ('G ');
insert into grupos(grupo) values ('H ');
insert into grupos(grupo) values ('I ');
insert into grupos(grupo) values ('J ');
insert into grupos(grupo) values ('K ');
insert into grupos(grupo) values ('L ');
insert into grupos(grupo) values ('M ');
insert into grupos(grupo) values ('N ');

--tabla grados
insert into grados(grados) values (1);
insert into grados(grados) values (2);
insert into grados(grados) values (3);
insert into grados(grados) values (4);
insert into grados(grados) values (5);
insert into grados(grados) values (6);

--tabla materias
insert into materia(materia) values ('Base de Datos Relacionales ');
insert into materia(materia) values ('Implementa Software de Sist. Informaticos ');
insert into materia(materia) values ('Codifica Software de Sist.Informaticos ');
insert into materia(materia) values ('Diseña Software de Sist. Informaticos ');
insert into materia(materia) values ('Redes de Computadoras  ');
insert into materia(materia) values ('Aplicaciones Moviles para IOS  ');
insert into materia(materia) values ('Temas Selectos de Matematicas I ');
insert into materia(materia) values ('Tutoria Y/O Socio Emocional ');
insert into materia(materia) values ('Cultura Digital II ');
insert into materia(materia) values ('Aplicaciones Moviles para IOS ');
insert into materia(materia) values ('Lengua y Comunicación ');
insert into materia(materia) values ('Instala y Configura Equipo de Computo y Periferico ');
insert into materia(materia) values ('INSTALA Y CONFIGURA SISTEMAS OPERATIVOS ');
insert into materia(materia) values ('PLATAFORMAS DIGITALES ');
insert into materia(materia) values (' Bases de datos no relacionales  ');
insert into materia(materia) values (' Plataformasdigitales. ');
insert into materia(materia) values ('APLICACIONES MOVILES PARA ANDROID ');
insert into materia(materia) values ('USO DE DISPOSITIVOS MOVILES ');
insert into materia(materia) values ('  ');
insert into materia(materia) values ('Redes de Computadoras  ');
insert into materia(materia) values ('INGLES IV ');
insert into materia(materia) values ('CONCIENCIA HISTORICA  ');
insert into materia(materia) values ('TEMAS SELECTOS MATEMATICAS 1 ');
insert into materia(materia) values ('TEMAS DE FILOSOFIA  ');
insert into materia(materia) values ('CONCIENCIA HISTORICA  ');
insert into materia(materia) values ('REACCIONES QUIMICAS  ');
insert into materia(materia) values ('TEMAS DE ADMINISTRACION  ');
insert into materia(materia) values ('Gestiona Archivos y Dispositivos Ofimaticos ');
