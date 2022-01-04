DELIMITER |
CREATE TRIGGER actualizarEstatusMensualidad AFTER INSERT ON cobros_caja
  FOR EACH ROW BEGIN
		UPDATE cobros_mensuales SET Estatus = 'PAGADO' WHERE (Id_cobros_mensuales = NEW.id_cobros_mensuales);
  END
|
DELIMITER ;