/*==============================================================*/
/* Nom de SGBD :  PostgreSQL 8                                  */
/* Date de cr�ation :  13/05/2024 10:19:01                      */
/*==============================================================*/


drop table ACTIVITE;

drop table CARECTERISTIQUE;

drop table CATEGORIE;

drop table CONCERNE;

drop table DETAIL_CARACTERISTIQUE;

drop table EMPLOYE;

drop table MATERIEL;

drop table RESERVATION;

drop table SITE;

drop table TYPE_MATERIEL;

/*==============================================================*/
/* Table : ACTIVITE                                             */
/*==============================================================*/
create table ACTIVITE (
   NUM_ACTIVITE         SERIAL               not null,
   NOM_ACTIVITE         VARCHAR(100)         null,
   constraint PK_ACTIVITE primary key (NUM_ACTIVITE)
);

/*==============================================================*/
/* Table : CARECTERISTIQUE                                      */
/*==============================================================*/
create table CARECTERISTIQUE (
   NUM_CARACTERISTIQUE  INT4                 not null,
   NOM_CARACTERISTIQUE  VARCHAR(50)          null,
   constraint PK_CARECTERISTIQUE primary key (NUM_CARACTERISTIQUE)
);

/*==============================================================*/
/* Table : CATEGORIE                                            */
/*==============================================================*/
create table CATEGORIE (
   NOM_CATEGORIE        VARCHAR(30)          not null,
   constraint PK_CATEGORIE primary key (NOM_CATEGORIE)
);

/*==============================================================*/
/* Table : CONCERNE                                             */
/*==============================================================*/
create table CONCERNE (
   NUM_RESERVATION      INT4                 not null,
   NUM_MATERIEL         INT4                 not null,
   constraint PK_CONCERNE primary key (NUM_RESERVATION, NUM_MATERIEL)
);

/*==============================================================*/
/* Table : DETAIL_CARACTERISTIQUE                               */
/*==============================================================*/
create table DETAIL_CARACTERISTIQUE (
   NUM_MATERIEL         INT4                 not null,
   NUM_CARACTERISTIQUE  INT4                 not null,
   VALEUR_CARACTERISTIQUE VARCHAR(30)          null,
   constraint PK_DETAIL_CARACTERISTIQUE primary key (NUM_MATERIEL, NUM_CARACTERISTIQUE)
);

/*==============================================================*/
/* Table : EMPLOYE                                              */
/*==============================================================*/
create table EMPLOYE (
   NUM_EMPLOYE          SERIAL               not null,
   NUM_SITE             INT4                 not null,
   LOGIN                CHAR(6)              null,
   MDP                  VARCHAR(20)          null,
   constraint PK_EMPLOYE primary key (NUM_EMPLOYE)
);

/*==============================================================*/
/* Table : MATERIEL                                             */
/*==============================================================*/
create table MATERIEL (
   NUM_MATERIEL         SERIAL               not null,
   NOM_CATEGORIE        VARCHAR(30)          not null,
   NUM_SITE             INT4                 not null,
   NUM_TYPE             INT4                 not null,
   NOM_MATERIEL         VARCHAR(50)          not null,
   LIEN_PHOTO           VARCHAR(200)         not null,
   MARQUE               VARCHAR(50)          not null
      constraint CKC_MARQUE_MATERIEL check (MARQUE in ('Peli','Euromast','Martinas','Menfire','Softshell','Haix','Europa Kimanche')),
   DESCRIPTION          VARCHAR(300)         not null,
   PUISSANCE_CV         DECIMAL(4,2)         not null,
   PUISSANCE_W          INT4                 null,
   COUT_UTILISATION     DECIMAL(4,2)         not null,
   constraint PK_MATERIEL primary key (NUM_MATERIEL)
);

/*==============================================================*/
/* Table : RESERVATION                                          */
/*==============================================================*/
create table RESERVATION (
   NUM_RESERVATION      SERIAL               not null,
   NUM_ACTIVITE         INT4                 not null,
   DATE_RESERVATION     DATE                 not null,
   DUREE_RESERVATION    INT4                 not null,
   constraint PK_RESERVATION primary key (NUM_RESERVATION)
);

/*==============================================================*/
/* Table : SITE                                                 */
/*==============================================================*/
create table SITE (
   NUM_SITE             INT4                 not null,
   NOM_SITE             VARCHAR(20)          not null,
   ADRESSE_RUE          VARCHAR(100)         not null,
   NOM_RESPONSABLE      VARCHAR(50)          not null,
   HORAIRE              VARCHAR(50)          null,
   constraint PK_SITE primary key (NUM_SITE)
);

/*==============================================================*/
/* Table : TYPE_MATERIEL                                        */
/*==============================================================*/
create table TYPE_MATERIEL (
   NUM_TYPE             INT4                 not null,
   NOM_TYPE             VARCHAR(40)          null,
   constraint PK_TYPE_MATERIEL primary key (NUM_TYPE)
);

alter table CONCERNE
   add constraint FK_CONCERNE_CONCERNE_RESERVAT foreign key (NUM_RESERVATION)
      references RESERVATION (NUM_RESERVATION)
      on delete restrict on update restrict;

alter table CONCERNE
   add constraint FK_CONCERNE_CONCERNE2_MATERIEL foreign key (NUM_MATERIEL)
      references MATERIEL (NUM_MATERIEL)
      on delete restrict on update restrict;

alter table DETAIL_CARACTERISTIQUE
   add constraint FK_DETAIL_C_DETAIL_CA_MATERIEL foreign key (NUM_MATERIEL)
      references MATERIEL (NUM_MATERIEL)
      on delete restrict on update restrict;

alter table DETAIL_CARACTERISTIQUE
   add constraint FK_DETAIL_C_DETAIL_CA_CARECTER foreign key (NUM_CARACTERISTIQUE)
      references CARECTERISTIQUE (NUM_CARACTERISTIQUE)
      on delete restrict on update restrict;

alter table EMPLOYE
   add constraint FK_EMPLOYE_APPARTIEN_SITE foreign key (NUM_SITE)
      references SITE (NUM_SITE)
      on delete restrict on update restrict;

alter table MATERIEL
   add constraint FK_MATERIEL_A_TYPE_MAT foreign key (NUM_TYPE)
      references TYPE_MATERIEL (NUM_TYPE)
      on delete restrict on update restrict;

alter table MATERIEL
   add constraint FK_MATERIEL_LIE_CATEGORI foreign key (NOM_CATEGORIE)
      references CATEGORIE (NOM_CATEGORIE)
      on delete restrict on update restrict;

alter table MATERIEL
   add constraint FK_MATERIEL_RATTACHE_SITE foreign key (NUM_SITE)
      references SITE (NUM_SITE)
      on delete restrict on update restrict;

alter table RESERVATION
   add constraint FK_RESERVAT_POUR_ACTIVITE foreign key (NUM_ACTIVITE)
      references ACTIVITE (NUM_ACTIVITE)
      on delete restrict on update restrict;

