--Inserciones en la tabla tipo_usuario
describe tipo_usuario;
insert into tipo_usuario (tipo_usuario) 
values 
("administrador"), 
("cobranza"), 
("cajero"), 
("servicios escolares"), 
("alumno");
select * from tipo_usuario;

-- Insersiones en la tabla usuario
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (1, "admin", "Carlos Stroop", "admin");
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (2, "cobranza", "Diana Maximino", "cobranza");
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (3, "cajero", "Raquel Diaz", "cajero");
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (4, "servicios", "Yamil Ruiz", "servicios");
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (5, "alumno", "Victoria Solis", "alumno");

insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (5, 'geadie0', 'Gray Eadie', 'YSeGX0b0');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (3, 'gmatitiaho1', 'Goraud Matitiaho', 'f0dD2HaCKIyx');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (3, 'hwilcot2', 'Hillyer Wilcot', 'wxM2sBmtL8');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (5, 'rpole3', 'Rozanna Pole', 'wvRrmmfn5');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (3, 'mtuite4', 'Marianne Tuite', 'eXxhat');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (4, 'cdanielkiewicz5', 'Carlyle Danielkiewicz', 'p36nNMLns2B');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (5, 'phawkslee6', 'Paulina Hawkslee', '1VfWOd');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (3, 'ggreger7', 'Glynda Greger', 'KTdcdW');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (4, 'baguirrezabal8', 'Burg Aguirrezabal', 'ta8ig998YmgF');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (3, 'bisitt9', 'Billie Isitt', 'sgsY97CnxB');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (5, 'apoznana', 'Ashia Poznan', 'nAFWHXQr');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (5, 'jscriverb', 'Jsandye Scriver', 'zg07n8s9Z');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (5, 'rhearsonc', 'Roze Hearson', '2yVhur4tK');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (5, 'jklaasd', 'Jacenta Klaas', 'dXvJtEDzXHQ');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (2, 'cingledewe', 'Corilla Ingledew', '59hn5wU');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (5, 'bocridiganf', 'Bernardine O''Cridigan', 'CD17Z388QzWC');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (4, 'ehaldeng', 'Eugenius Halden', 'zjs9KPzLJic');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (4, 'rescotth', 'Rosemary Escott', 'RsnVihZdtib');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (5, 'kskoughi', 'Kaitlin Skough', 'wQ9WAkxIdsu');
insert into usuario (id_tipo_usuario, username, nombre, contrasenia) values (2, 'rvanj', 'Ruperta Van der Linde', 'jOT7nFiABmb');
select * from usuario;

