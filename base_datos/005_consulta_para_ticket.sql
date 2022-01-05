select * FROM sistema_escolar.cobros_caja;

SELECT cobros_caja.idcobros_caja AS "# TICKET", 
/*cobros_mensuales.Id_cobros_mensuales,*/ 
/*DATOS ALUMNO*/
datos_alumno.id_alumno AS "MATRICULA:", datos_alumno.nombre AS "NOMBRE DEL ALUMNO:", datos_alumno.apellido_paterno AS "APELLIDO PATERNO:", datos_alumno.apellido_materno AS "APELLIDO MATERNO",
/*DATOS ESCOLARES*/
escuela_plantel.Nombre AS "ESCUELA:", niveles_educativos.Nombre_nivel AS "NIVEL EDUCATIVO:",
/*DATOS COBRANZAS*/
conceptos_cobranza.Concepto AS "CONCEPTO:", conceptos_cobranza.Precio AS "PRECIO:",
/*DATOS DE LA VENTA*/
cobros_caja.Fecha AS "FECHA:", cobros_caja.Descuentos AS "DESCUENTOS:", cobros_caja.Recargos AS "RECARGOS:", cobros_caja.Metodo_Pago AS "METODO DE PAGO:", cobros_caja.Total AS "TOTAL:"
FROM sistema_escolar.cobros_caja
INNER JOIN cobros_mensuales ON cobros_caja.id_cobros_mensuales = cobros_mensuales.Id_cobros_mensuales
INNER JOIN cobros_alumno ON cobros_mensuales.id_cobros_alumno = cobros_alumno.idcobros_alumno
INNER join conceptos_cobranza ON cobros_alumno.conceptos_cobranza_id_Folio_cobranza = conceptos_cobranza.id_Folio_cobranza
INNER JOIN servicio_escolar ON cobros_alumno.id_servicio_escolar = servicio_escolar.id_servicio_escolar
INNER JOIN datos_alumno ON servicio_escolar.id_alumno = datos_alumno.id_alumno
INNER JOIN planteles_niveles ON servicio_escolar.id_clave_programa_educativo = planteles_niveles.clave_programa_educativo 
INNER JOIN escuela_plantel ON planteles_niveles.plantel_id_plantel = escuela_plantel.id_plantel 
INNER JOIN niveles_educativos ON planteles_niveles.niveles_educativos_id_nivel = niveles_educativos.id_nivel
Where  cobros_mensuales.Id_cobros_mensuales = 5122; /* ESTE ES EL ID DE LA MENSUALIDAD QUE SE SELECCIONO EN EL GRID AL MOMENTO DE HACER EL PAGO */