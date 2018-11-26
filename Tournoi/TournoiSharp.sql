create database TournoiCSharp;

use TournoiCSharp;

drop table Player;
drop table Team;
drop table Poste;

create table Poste
(
	id_poste int identity(1,1) not null,
	libelle_poste varchar(20) not null,
	constraint id_poste_PK primary key (id_poste)
)


create table Player
(
	id_p int identity(1,1) not null,
	nom_p varchar(100) not null,
	prenom_p varchar(100) not null,
	numeros int,
	nationalites varchar(50) not null,
	date_naissance date not null,
	id_team int not null,
	id_poste int not null,
	constraint id_p_PK primary key (id_p),
	constraint id_poste_FK foreign key (id_poste) references Poste(id_poste),
	constraint id_team_FK foreign key (id_team) references Team(id_t)
)
insert into Player (nom_p, prenom_p, numeros, nationalites, date_naissance, id_poste, id_team)
values ('BOUGEARD', 'Antonin', 1, 'Français', '1998-09-18', 1, 3)

select * from Player 

create table Team
(
	id_t int identity(1,1) not null,
	nom_t varchar(100) not null,
	nombre_joueur int not null,
	pays varchar(50) not null,
	point int default (0),
	constraint id_t_PK primary key (id_t)
	
)

insert into Poste (libelle_poste)
values ('Gardien'), ('Défenseur'), ('Milieu'), ('Attaquant'), ('Coach')

insert into Team (nom_t, nombre_joueur, pays, point)
values ('Barcelone', 23, 'Espagne', 13)

select * from Poste

select * from Player

select * from Team

SELECT nom_t FROM Team WHERE nom_t like 'Barcelone'

delete from Team where nom_t = 'Barcelone'
