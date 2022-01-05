/* VISTA PREVIA A PAGAR EN FORMULARIO REALIZAR COBROS*/

/* frm_cobranzas_CrearMensualidades.cs */

-- EN BASE A LA MATRICULA QUE SE INGRESE EN LA INTERFAZ, SE MOSTRARÁ LA INFORMACION DEL ALUMNO Y 
SELECT cobros_alumno.idcobros_alumno, datos_alumno.nombre, datos_alumno.apellido_paterno, datos_alumno.apellido_materno,
conceptos_cobranza.Concepto, conceptos_cobranza.Precio
FROM sistema_escolar.cobros_alumno
INNER JOIN conceptos_cobranza ON cobros_alumno.conceptos_cobranza_id_Folio_cobranza = conceptos_cobranza.id_Folio_cobranza
INNER JOIN servicio_escolar ON cobros_alumno.id_servicio_escolar = servicio_escolar.id_servicio_escolar
INNER JOIN datos_alumno ON servicio_escolar.id_alumno = datos_alumno.id_alumno
where datos_alumno.id_alumno = 1; /* < -- CONDICIONAL ID MATRICULA ALUMNO */