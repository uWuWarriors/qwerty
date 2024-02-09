USE demka_bd_PR31
GO
select a.f, TOTAL, servic, (total + servic) as PRIKOL
from  (SELECT application_table.id_app as f,  sum(res_table.sum_res) AS TOTAL
FROM application_table join app_res on application_table.id_app = app_res.id_app
						join res_table on app_res.id_res = res_table.id_res 
group by 	application_table.id_app ) AS A

join

(SELECT application_table.id_app as d,  sum(ser_table.sum) AS servic
FROM application_table join application_service on application_table.id_app = application_service.id_app
						join ser_table on application_service.id_sevice = ser_table.id_servise
group by 	application_table.id_app) as B
 on A.f = B.d