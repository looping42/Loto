--Create database Loto
drop table newloto;

Create Table newloto
(
annee_numero_de_tirage int,
jourtirage varchar(20),
date_de_tirage date primary key,
date_de_forclusion date ,
boule_1 smallint ,
boule_2	smallint ,
boule_3 smallint,
boule_4	smallint,
boule_5	smallint ,
numero_chance smallint,
combinaison_gagnante_en_ordre_croissant varchar(50),
nombre_de_gagnant_au_rang1	int,
rapport_du_rang1	int ,
nombre_de_gagnant_au_rang2	int,
rapport_du_rang2	int ,
nombre_de_gagnant_au_rang3	int,
rapport_du_rang3	int,
nombre_de_gagnant_au_rang4 int,
rapport_du_rang4	int,
nombre_de_gagnant_au_rang5 int,
rapport_du_rang5	int, 
nombre_de_gagnant_au_rang6	int, 
rapport_du_rang6	int ,
numero_jokerplus	varchar(20) ,
devise varchar( 20),

);



ALTER TABLE dbo.nouveau_loto
ADD PRIMARY KEY (annee_numero_de_tirage)

BEGIN TRANSACTION
BEGIN TRY
BULK INSERT newloto
   FROM 'E:\projetvisualstudio\Loto\ResultatLoto\nouveau_loto.csv'
   WITH 
      (
	  FIRSTROW = 2,
		MAXERRORS  =50,
         FIELDTERMINATOR =';',
         ROWTERMINATOR = ' ' 
		
      );
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH

--create oldloto
--(  


--)
