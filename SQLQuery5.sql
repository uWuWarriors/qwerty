USE demka_bd_PR31
GO
SELECT master_table.name_master, ser_table.name_service, application_table.status, COUNT (*)
from ser_table join application_service on ser_table.id_servise = application_service.id_sevice 
               join master_table on master_table.id_master = application_service.id_master
			   join application_table on application_table.id_app = application_service.id_app
WHERE application_table.status = 'обработка'
GROUP BY master_table.name_master, ser_table.name_service, application_table.status
ORDER BY COUNT (dbo.application_table.status) desc
GO