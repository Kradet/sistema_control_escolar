-- creacion base de datos
create database sistema_escolar;
use sistema_escolar;

-- ! creación tablas 

-- ? tabla datos_alumno
create table if not exists datos_alumno(
    id_alumno int primary key auto_increment,
    nombre varchar(45) not null,
    apellido_paterno varchar(45) not null,
    apellido_materno varchar(45) not null,
    sexo varchar(1) not null,
    curp varchar(18) not null,
    fecha_nacimiento date not null,
    nacionalidad varchar(45) not null,
    email varchar(45)
);

-- ? tabla contacto_alumno
create table if not exists contacto_alumno(
    id_contacto int primary key auto_increment,
    id_alumno int not null,
    nombre_tutor varchar(45) not null,
    telefono varchar(10) not null,
    email varchar(45),
    direccion varchar(45),
    foreign key(id_alumno) references datos_alumno
(id_alumno) on delete cascade on update cascade
);

-- -----------------------------------------------------
-- Planteles
-- -----------------------------------------------------

CREATE TABLE IF NOT EXISTS escuela_plantel (
  id_plantel INT NOT NULL AUTO_INCREMENT,
  Nombre VARCHAR(25) NOT NULL,
  PRIMARY KEY (id_plantel));

-- -----------------------------------------------------
-- Niveles Educativos
-- -----------------------------------------------------

CREATE TABLE IF NOT EXISTS niveles_educativos (
  id_nivel INT NOT NULL AUTO_INCREMENT,
  Nombre_nivel VARCHAR(45) NOT NULL,
  PRIMARY KEY (id_nivel));

-- -----------------------------------------------------
-- Escuela con Diferentes Niveles Educativos
-- -----------------------------------------------------

CREATE TABLE IF NOT EXISTS planteles_niveles (
  clave_programa_educativo INT NOT NULL AUTO_INCREMENT,
  plantel_id_plantel INT NOT NULL,
  niveles_educativos_id_nivel INT NOT NULL,
  PRIMARY KEY (clave_programa_educativo),
  FOREIGN KEY (plantel_id_plantel) references escuela_plantel(id_plantel) on delete cascade on update cascade,
  FOREIGN KEY (niveles_educativos_id_nivel) references niveles_educativos(id_nivel) on delete cascade on update cascade
  );

/* FIN DE MODIFICACIONES PLANTELES - NIVELES */

-- ? tabla servicio_escolar
create table if not exists servicio_escolar(
    id_servicio_escolar int primary key auto_increment,
    id_clave_programa_educativo int not null,
    id_alumno int not null,
    grado varchar(5) not null,
    grupo varchar(5) not null,
    estatus varchar(45) not null,
    foreign key(id_clave_programa_educativo) references planteles_niveles(clave_programa_educativo) on delete cascade on update cascade,
    foreign key(id_alumno) references datos_alumno (id_alumno) on delete cascade on update cascade
);

-- ? tabla tipo_usuario
create table if not exists tipo_usuario(
    id_tipo_usuario int primary key auto_increment,
    tipo_usuario varchar(45) not null
);

-- ? tabla usuario
create table if not exists usuario(
    id_usuario int primary key auto_increment,
    id_tipo_usuario int not null,
    username varchar(45) not null,
    nombre varchar(45) not null,
    contrasenia varchar(45) not null,
    foreign key(id_tipo_usuario) references tipo_usuario(id_tipo_usuario) on delete cascade on update cascade
);


-- -----------------------------------------------------
-- Cajas
-- -----------------------------------------------------


CREATE TABLE IF NOT EXISTS caja(
  idcaja INT NOT NULL,
  Caja_Num VARCHAR(5) NOT NULL,
  PRIMARY KEY (idcaja));


-- -----------------------------------------------------
-- Conceptos de Cobro
-- -----------------------------------------------------

CREATE TABLE IF NOT EXISTS conceptos_cobranza (
  id_Folio_cobranza int primary key auto_increment not null,
  Concepto VARCHAR(50) NULL,
  Precio FLOAT NULL
 );
  
-- -----------------------------------------------------
-- Cobros de Alumnos
-- -----------------------------------------------------


CREATE TABLE IF NOT EXISTS cobros_alumno(
  idcobros_alumno INT NOT NULL AUTO_INCREMENT,
  id_servicio_escolar INT NOT NULL,
  conceptos_cobranza_id_Folio_cobranza INT NOT NULL,
  Ciclo_Escolar VARCHAR(45) NULL,
  PRIMARY KEY (idcobros_alumno),
  FOREIGN KEY (id_servicio_escolar) references servicio_escolar(id_servicio_escolar) on delete cascade on update cascade,
  FOREIGN KEY (conceptos_cobranza_id_Folio_cobranza) references conceptos_cobranza(id_Folio_cobranza) on delete cascade on update cascade
  );


-- !!!!!!!!!!!!!! CAMBIOS !!!!!!!!!!!!!!!!!!!!!!!!!! (no te enojes krnal ":v) x2

-- CREACION DE TABLA PARA SABER QUE MES VA A PAGAR EL MORRO Y SI YA LO PAGÓ 

CREATE TABLE IF NOT EXISTS cobros_mensuales (
	id_cobros_mensuales INT NOT NULL AUTO_INCREMENT,
    id_cobros_alumno INT NOT NULL,
    Mes_Pago INT NOT NULL,
    Estatus VARCHAR(45),
    primary key (id_cobros_mensuales),
    foreign key (id_cobros_alumno) references cobros_alumno(idcobros_alumno) on delete cascade on update cascade
);

-- NECESITAMOS EL ID DE LA MENSUALIDAD PARA QUE SE PAGUE EN CAJA 

-- -----------------------------------------------------
-- Cobro de Conceptos de Alumnos en Caja
-- -----------------------------------------------------

CREATE TABLE IF NOT EXISTS cobros_caja (
  idcobros_caja INT NOT NULL AUTO_INCREMENT,
  id_cobros_mensuales INT NOT NULL, /* LLAVE FORANEA CAMBIADA */
  Fecha DATE NULL,
  Descuentos FLOAT NULL,
  Recargos FLOAT NULL,
  Metodo_Pago VARCHAR(10) NULL,
  Total FLOAT NULL,
  PRIMARY KEY (idcobros_caja),
  FOREIGN KEY (id_cobros_mensuales) references cobros_mensuales (id_cobros_mensuales) on delete cascade on update cascade
  );


-- -----------------------------------------------------
-- Sesion de la Caja
-- -----------------------------------------------------

CREATE TABLE IF NOT EXISTS sesion_caja(
  idsesion_caja INT NOT NULL AUTO_INCREMENT,
  usuario_id_usuario INT NOT NULL,
  caja_idcaja INT NOT NULL,
  Estatus VARCHAR(45) NOT NULL,
  hora_apertura TIME NOT NULL,
  hora_cierre TIME NOT NULL,
  cantidad_inicial FLOAT NOT NULL,
  PRIMARY KEY (idsesion_caja),
  FOREIGN KEY (usuario_id_usuario) references usuario(id_usuario) on delete cascade on update cascade,
  FOREIGN KEY (caja_idcaja) references caja(idcaja) on delete cascade on update cascade
  );



-- -----------------------------------------------------
-- Detalle de la Sesión de Cajas
-- -----------------------------------------------------

CREATE TABLE IF NOT EXISTS detalle_sesion_caja(
  iddetalle_sesion_caja INT NOT NULL AUTO_INCREMENT,
  sesion_caja_idsesion_caja INT NOT NULL,
  Cobros FLOAT NULL,
  Egresos FLOAT NULL,
  Otros_Montos FLOAT NULL,
  Total_Corte FLOAT NULL,
  PRIMARY KEY (iddetalle_sesion_caja),
  FOREIGN KEY (sesion_caja_idsesion_caja) references sesion_caja(idsesion_caja) on delete cascade on update cascade
  );

-- !!!!!!!!!!!!!! CAMBIOS !!!!!!!!!!!!!!!!!!!!!!!!!! (no te enojes krnal ":v)
-- -----------------------------------------------------
-- Bitacora de Cobros de las cajas (UPDATE)
-- -----------------------------------------------------

CREATE TABLE IF NOT EXISTS bitacora_cobros_sesion_cajas(
  id_bitacora_cobros_sesion INT NOT NULL auto_increment primary key,
  id_cobros_caja INT NOT NULL,
  id_sesion_caja INT NOT NULL,
  FOREIGN KEY (id_cobros_caja) REFERENCES cobros_caja(idcobros_caja) on delete cascade on update cascade,
  FOREIGN KEY (id_sesion_caja) REFERENCES sesion_caja (idsesion_caja) on delete cascade on update cascade
  );
  
  