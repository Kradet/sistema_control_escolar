SELECT * FROM sistema_escolar.servicio_escolar;

SELECT servicio_escolar.id_servicio_escolar, datos_alumno.nombre AS "NOMBRE", datos_alumno.apellido_paterno AS "APELLIDO PATERNO", datos_alumno.apellido_materno AS "APELLIDO MATERNO",
escuela_plantel.Nombre AS "Plantel", niveles_educativos.Nombre_nivel AS "NIVEL ACADEMICO" from servicio_escolar
INNER JOIN datos_alumno ON servicio_escolar.id_alumno = datos_alumno.id_alumno
INNER JOIN planteles_niveles ON servicio_escolar.id_clave_programa_educativo = planteles_niveles.clave_programa_educativo /* TABLA PADRE, SE DECLARA PARA QUE PODAMOS OBTENER INFORMACION DE LAS HIJAS*/
INNER JOIN escuela_plantel ON planteles_niveles.plantel_id_plantel = escuela_plantel.id_plantel /* TABLA HIJA de planteles_niveles*/
INNER JOIN niveles_educativos ON planteles_niveles.niveles_educativos_id_nivel = niveles_educativos.id_nivel /* TABLA HIJA de planteles_niveles*/


