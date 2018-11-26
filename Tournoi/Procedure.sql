create proc addPlayer
(
	@nom varchar(100),
	@prenom varchar(100),
	@numeros int,
	@nationalites varchar (50),
	@date_naissance date,
	@id_poste int,
	@id_team int
)
as 
begin
	insert into Player (nom_p, prenom_p, numeros, nationalites, date_naissance, id_poste, id_team)
	values (@nom, @prenom, @numeros, @nationalites, @date_naissance, @id_poste, @id_team)
end;

create proc addTeam
(
	@nom_equipe varchar(100),
	@nb_joueur int,
	@pays varchar(50)
)
as 
begin
	insert into Team (nom_t, nombre_joueur, pays)
	values (@nom_equipe, @nb_joueur, @pays)
end 

drop proc addTeam;
drop proc addPlayer;
