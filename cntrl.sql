create database commercia

use commercia

create table client
(
Num_C smallint primary key identity,
Nom varchar(50),
Prenom varchar(50),
Telephone varchar(20),
Email varchar(50),
Ville varchar(20),
Adresse varchar(50)
)

create table fournisseur
(
Num_F smallint primary key identity,
Nom_Entreprise varchar(50),
Telephone varchar(20),
Email varchar(50),
Ville varchar(20),
Adresse varchar(50)
)

create table type_produit
(
Libelle varchar(50) primary key
)

create table produit
(
Num_P smallint primary key identity,
Libelle varchar(50),
Type_P varchar(50) foreign key references type_produit(Libelle),
Prix float,
Image_Nom varchar(20),
Image_P image,
Description_P varchar(max),
Quantite int
)

create table utilisateur
(
num_utl smallint identity primary key,
Nom varchar(50),
Prenom varchar(50),
Email varchar(50),
Mot_De_Passe varchar(50),
Type_U varchar(50) check( Type_U='gérant' or Type_U='vendeur' or Type_U='magasinier' )
)

create table commande_vente
(
Num_C_V smallint primary key identity,
Date_C datetime,
Client smallint foreign key references client(Num_C)
)

create table ligne_commande_vente
(
Commande_V smallint foreign key references commande_vente(Num_C_V),
Produit smallint foreign key references produit(Num_P),
Quantite int,
primary key(Commande_V,Produit)
)

create table commande_achat
(
Num_C_A smallint primary key identity,
Date_C datetime,
Fournisseur smallint foreign key references fournisseur(Num_F)
)

create table ligne_commande_achat
(
Commande_A smallint foreign key references commande_achat(Num_C_A),
Produit smallint foreign key references produit(Num_P),
Quantite int
primary key(Commande_A,Produit)
)


--client
select * from client  
insert into client values ('kissi','abdelaziz','06XXXXXXX','kissi@XXXX.com','oujda','hay el mohammadi'),
                          ('tahiri','rajae','06XXXXXXX','tahiri@XXXX.com','oujda','Qods'),
                          ('nouri','houssam','06XXXXXXX','nouri@XXXX.com','nador','hay el mohammadi')

 

--type_produit
select * from type_produit  
insert into type_produit values ('smart phone'),('ordinateur'),('smart TV'),('smart speaker'),('tablette')

 

--produit
select * from produit  
insert into produit values ('samsunge','smart phone',1000,'samsunge.jpeg','xxxxx',10),
                           ('HP','ordinateur',4000,'hp.png','xxxxx',5),
                           ('LG','smart TV',1500,'lg.jpg','xxxxx',9),
                           ('JBL','smart speaker',700,'jbl.jpg','xxxxx',20),
                           ('samsungetab','tablette',2000,'samsungetab.jpg','xxxxx',10)

 


--fournisseur
select * from fournisseur
insert into fournisseur values('F1','XXXXXX','F1XXX@.COM','NY','USA'),
                              ('F2','XXXXXX','F2XXX@.COM','LA','USA'),
                              ('F3','XXXXXX','F3XXX@.COM','Paris','FRANCE')

 

--commande_achat
select * from commande_achat
insert into commande_achat values('05/02/2021',1),
                                 ('05/03/2021',2),
                                 ('05/05/2021',3)
--ligne commande_achat
select * from ligne_commande_achat
insert into ligne_commande_achat values(5,1,10),
                                       (6,4,20),
                                        (7,2,10)

 

--commande_vente
select * from commande_vente
insert into commande_vente values('15/02/2021',1),
                                 ('25/03/2021',3),
                                 ('30/05/2021',2)

 

--ligne commande_vente
select * from ligne_commande_vente
insert into ligne_commande_vente values(4,1,1),
                                       (3,2,3),
                                       (5,3,2)