--Create database Loto


Create Table newloto
(
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
numero_jokerplus	int ,
devise varchar( 20),

);

create oldloto
(  


)
