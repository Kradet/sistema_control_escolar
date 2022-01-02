SELECT * FROM sistema_escolar.cobros_mensuales;

/*BASE */
SELECT cobros_mensuales.Id_cobros_mensuales, cobros_alumno.idcobros_alumno, datos_alumno.id_alumno, datos_alumno.nombre, datos_alumno.apellido_paterno, datos_alumno.apellido_materno,
conceptos_cobranza.Concepto, conceptos_cobranza.Precio, cobros_mensuales.Mes_Pago, cobros_mensuales.Estatus
FROM sistema_escolar.cobros_mensuales
INNER JOIN cobros_alumno ON cobros_mensuales.id_cobros_alumno = cobros_alumno.idcobros_alumno
INNER join conceptos_cobranza ON cobros_alumno.conceptos_cobranza_id_Folio_cobranza = conceptos_cobranza.id_Folio_cobranza
INNER JOIN servicio_escolar ON cobros_alumno.id_servicio_escolar = servicio_escolar.id_servicio_escolar
INNER JOIN datos_alumno ON servicio_escolar.id_alumno = datos_alumno.id_alumno
Where datos_alumno.id_alumno = 1;

SELECT cobros_mensuales.Id_cobros_mensuales, conceptos_cobranza.Concepto, conceptos_cobranza.Precio, cobros_mensuales.Mes_Pago, cobros_mensuales.Estatus
FROM sistema_escolar.cobros_mensuales
INNER JOIN cobros_alumno ON cobros_mensuales.id_cobros_alumno = cobros_alumno.idcobros_alumno
INNER join conceptos_cobranza ON cobros_alumno.conceptos_cobranza_id_Folio_cobranza = conceptos_cobranza.id_Folio_cobranza
INNER JOIN servicio_escolar ON cobros_alumno.id_servicio_escolar = servicio_escolar.id_servicio_escolar
INNER JOIN datos_alumno ON servicio_escolar.id_alumno = datos_alumno.id_alumno;