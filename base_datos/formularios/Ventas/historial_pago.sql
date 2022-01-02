SELECT cobros_caja.idcobros_caja,
conceptos_cobranza.Concepto, conceptos_cobranza.Precio,
cobros_caja.Fecha, cobros_caja.Descuentos, cobros_caja.Recargos, cobros_caja.Metodo_Pago, cobros_caja.Total FROM sistema_escolar.cobros_caja
INNER JOIN cobros_alumno ON cobros_caja.cobros_alumno_idcobros_alumno = cobros_alumno.idcobros_alumno
INNER JOIN conceptos_cobranza ON cobros_alumno.conceptos_cobranza_id_Folio_cobranza = conceptos_cobranza.id_Folio_cobranza;

SELECT * FROM sistema_escolar.cobros_caja;	


/*TABLA DE PAGOS ANTERIORES */
SELECT cobros_caja.idcobros_caja,
datos_alumno.id_alumno, datos_alumno.nombre, datos_alumno.apellido_paterno, datos_alumno.apellido_materno,
conceptos_cobranza.Concepto, conceptos_cobranza.Precio,
cobros_caja.Fecha, cobros_caja.Descuentos, cobros_caja.Recargos, cobros_caja.Metodo_Pago, cobros_caja.Total FROM sistema_escolar.cobros_caja
INNER JOIN cobros_alumno ON cobros_caja.cobros_alumno_idcobros_alumno = cobros_alumno.idcobros_alumno
INNER JOIN conceptos_cobranza ON cobros_alumno.conceptos_cobranza_id_Folio_cobranza = conceptos_cobranza.id_Folio_cobranza
INNER JOIN servicio_escolar ON cobros_alumno.id_servicio_escolar = servicio_escolar.id_servicio_escolar
INNER JOIN datos_alumno ON servicio_escolar.id_alumno = datos_alumno.id_alumno
WHERE datos_alumno.id_alumno = 1;