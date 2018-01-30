CREATE TABLE AgriCommodity (Commodity NVARCHAR(100), PlantedAcreage FLOAT,
                            HarvestedGrainAcreage FLOAT, Production FLOAT,
							YieldPerAcre FLOAT, WeightedAvgPrice FLOAT, 
							LoanRate FLOAT, Year DATE)

--Corn
INSERT INTO AgriCommodity VALUES ('Corn', '79.55', '72.44', '9,915.05', '136.90', '1.85', '1.89', '2000');
INSERT INTO AgriCommodity VALUES ('Corn','75.70','68.77','9,502.58','138.20','1.97','1.89','2001');
INSERT INTO AgriCommodity VALUES ('Corn','78.89','69.33','8,966.79','129.30','2.32','1.98','2002');
INSERT INTO AgriCommodity VALUES ('Corn','78.60','70.94','10,087.29','142.20','2.42','1.98','2003');
INSERT INTO AgriCommodity VALUES ('Corn','80.93','73.63','11,805.58','160.30','2.06','1.95','2004');
INSERT INTO AgriCommodity VALUES ('Corn','81.78','75.12','11,112.19','147.90','2.00','1.95','2005');
INSERT INTO AgriCommodity VALUES ('Corn','78.33','70.64','10,531.12','149.10','3.04','1.95','2006');
INSERT INTO AgriCommodity VALUES ('Corn','93.53','86.52','13,037.88','150.70','4.20','1.95','2007');
INSERT INTO AgriCommodity VALUES ('Corn','85.98','78.57','12,091.65','153.90','4.06','1.95','2008');
INSERT INTO AgriCommodity VALUES ('Corn','86.38','79.49','13,091.86','164.70','3.55','1.95','2009');
INSERT INTO AgriCommodity VALUES ('Corn','88.19','81.45','12,446.87','152.80','5.18','1.95','2010');
INSERT INTO AgriCommodity VALUES ('Corn','91.94','83.99','12,359.61','147.20','6.22','1.95','2011');
INSERT INTO AgriCommodity VALUES ('Corn','97.16','87.38','10,780.30','123.40','6.89','1.95','2012');
INSERT INTO AgriCommodity VALUES ('Corn','95.37','87.67','13,925.15','158.80','4.55','1.95','2013');
INSERT INTO AgriCommodity VALUES ('Corn','91.69','84.30','13,935.00','165.30','4.55','1.95','2014');

--Barley
INSERT INTO AgriCommodity VALUES ('Barley','4.951','4.273','248.329','58.1','2.22','1.6527','2000');
INSERT INTO AgriCommodity VALUES ('Barley','5.008','4.123','226.906','55','2.72','1.88','2001');
INSERT INTO AgriCommodity VALUES ('Barley','5.348','4.727','278.283','58.9','2.83','1.88','2002');
INSERT INTO AgriCommodity VALUES ('Barley','4.527','4.021','279.743','69.6','2.48','1.85','2003');
INSERT INTO AgriCommodity VALUES ('Barley','3.875','3.269','211.896','64.8','2.53','1.85','2004');
INSERT INTO AgriCommodity VALUES ('Barley','3.452','2.951','180.165','61.1','2.85','1.85','2005');
INSERT INTO AgriCommodity VALUES ('Barley','4.018','3.502','210.11','60','4.02','1.85','2006');
INSERT INTO AgriCommodity VALUES ('Barley','4.246','3.779','240.193','63.6','5.37','1.85','2007');
INSERT INTO AgriCommodity VALUES ('Barley','3.567','3.113','227.323','73','4.66','1.85','2008');
INSERT INTO AgriCommodity VALUES ('Barley','2.872','2.465','180.268','73.1','3.86','1.95','2009');
INSERT INTO AgriCommodity VALUES ('Barley','2.559','2.239','155.78','69.6','5.35','1.95','2010');
INSERT INTO AgriCommodity VALUES ('Barley','3.637','3.244','220.284','67.9','6.43','1.95','2011');
INSERT INTO AgriCommodity VALUES ('Barley','3.48','3','215.078','71.7','6.05','1.95','2012');
INSERT INTO AgriCommodity VALUES ('Barley','3.165','2.8','196','70','5.25','1.95','2013');

--Oats
INSERT INTO AgriCommodity VALUES ('Oats','4.473','2.325','149.165','64.2','1.1','1.16','2000');
INSERT INTO AgriCommodity VALUES ('Oats','4.401','1.911','117.602','61.5','1.59','1.21','2001');
INSERT INTO AgriCommodity VALUES ('Oats','4.995','2.058','116.002','56.4','1.81','1.35','2002');
INSERT INTO AgriCommodity VALUES ('Oats','4.597','2.22','144.383','65','1.48','1.35','2003');
INSERT INTO AgriCommodity VALUES ('Oats','4.085','1.787','115.695','64.7','1.48','1.33','2004');
INSERT INTO AgriCommodity VALUES ('Oats','4.246','1.823','114.859','63','1.63','1.33','2005');
INSERT INTO AgriCommodity VALUES ('Oats','4.166','1.564','93.522','59.8','1.87','1.33','2006');
INSERT INTO AgriCommodity VALUES ('Oats','3.763','1.504','90.43','60.1','2.63','1.33','2007');
INSERT INTO AgriCommodity VALUES ('Oats','3.247','1.4','89.135','63.7','3.15','1.33','2008');
INSERT INTO AgriCommodity VALUES ('Oats','3.404','1.379','93.081','67.5','2.02','1.33','2009');
INSERT INTO AgriCommodity VALUES ('Oats','3.138','1.263','81.19','64.3','2.52','1.39','2010');
INSERT INTO AgriCommodity VALUES ('Oats','2.496','0.939','53.649','57.1','3.49','1.39','2011');
INSERT INTO AgriCommodity VALUES ('Oats','2.76','1.045','64.024','61.3','3.89','1.39','2012');
INSERT INTO AgriCommodity VALUES ('Oats','3.01','1.03','65.879','64','3.73','1.39','2013');
INSERT INTO AgriCommodity VALUES ('Oats','2.794','1.1','71','64.5','3.30','1.39','2014');
