

/* ESTRUCTURA GENERAL */

SELECT id_servicio_escolar AS "ID_SE", 
escuela_plantel.Nombre AS "Plantel", 
niveles_educativos.Nombre_nivel AS "Nivel Educativo", 
datos_alumno.id_alumno AS "Matricula", datos_alumno.nombre AS "Nombre", datos_alumno.apellido_paterno AS "Apellido Paterno", datos_alumno.apellido_materno AS "Apellido Materno", 
servicio_escolar.grado AS "Grado", servicio_escolar.grupo AS "Grupo", servicio_escolar.estatus AS "Estatus" FROM servicio_escolar
INNER JOIN planteles_niveles ON servicio_escolar.id_clave_programa_educativo = planteles_niveles.clave_programa_educativo /* TABLA PADRE, SE DECLARA PARA QUE PODAMOS OBTENER INFORMACION DE LAS HIJAS*/
INNER JOIN escuela_plantel ON planteles_niveles.plantel_id_plantel = escuela_plantel.id_plantel /* TABLA HIJA de planteles_niveles*/
INNER JOIN niveles_educativos ON planteles_niveles.niveles_educativos_id_nivel = niveles_educativos.id_nivel /* TABLA HIJA de planteles_niveles*/
INNER JOIN datos_alumno ON servicio_escolar.id_alumno = datos_alumno.id_alumno /* SOLO SE DECLARA, NO TIENE TABLAS HIJAS */
WHERE datos_alumno.id_alumno = '1'; /* MATRICULA QUE SE SELECCIONO EN EL FORMULARIO DE ASIGNACION DE CONCEPTOS*/


/* frm_cobranzas_AsignarConceptos */

# Se va a trabajar con sobre la tabla -->'cobros_alumno'<-- , en donde se añadirá la informacion con el alias
# "ID_SE" en el campo "id_servicio social", el campo "conceptos_cobranza_id_Folio_cobranza" se añadirá la opcion que elija el 
# usuario dentro del dvgConceptos 


SELECT id_servicio_escolar AS "ID_SE", 
datos_alumno.id_alumno AS "Matricula", datos_alumno.nombre AS "Nombre", datos_alumno.apellido_paterno AS "Apellido Paterno", datos_alumno.apellido_materno AS "Apellido Materno", 
niveles_educativos.Nombre_nivel AS "Nivel Educativo" FROM servicio_escolar

INNER JOIN planteles_niveles ON servicio_escolar.id_clave_programa_educativo = planteles_niveles.clave_programa_educativo /* TABLA PADRE, SE DECLARA PARA QUE PODAMOS OBTENER INFORMACION DE LAS HIJAS*/
INNER JOIN datos_alumno ON servicio_escolar.id_alumno = datos_alumno.id_alumno /* SOLO SE DECLARA, NO TIENE TABLAS HIJAS */
INNER JOIN niveles_educativos ON planteles_niveles.niveles_educativos_id_nivel = niveles_educativos.id_nivel /* TABLA HIJA de planteles_niveles*/

WHERE datos_alumno.id_alumno = '1'; /* MATRICULA QUE SE SELECCIONO EN EL FORMULARIO DE ASIGNACION DE CONCEPTOS*/


