# git for csharp
----------

﻿# TP-220609 / SGBDR > Bases Réelles

Formateur | Date | Sujet
:---|:---|:---
François Capon | 04/03/2022 | ?


## Introduction

Ce TP va être l'occasion de découvrir :
* le SGBDR MySQL version 5.7
* DBeaver Community : *DBeaver est un logiciel permettant l'administration et le requêtage de base de données. Pour les bases de données relationnelles, il utilise un driver JDBC. Pour les autres bases de données, il utilise des pilotes de base de données propriétaire.*
* des bases "réelles"

### Serveur MySQL

* connexion
  * tp220301 / LaSécuritéR3p0zeSURlalongueurdesmotsdeP4SS3!
  * tunnel SSH :  
      * 127.0.0.1:3306:127.0.0.1:3306 tp220301@94.250.202.191
   * MySQL :
      * tp220301

La procédure à indiquer dans le compte rendu

* bases :
    * *user* : votre base (vous y avez tous les droits)
    * bases d'exemples
        * `employees` et `sakila`
        * `select` uniquement autorisé
        
### Accès à une autre base en SQL

Il suffit de préfixer le nom de la table (ou la vue) par le nom de la base :

```sql
-- base de travail employees ou sakila
select *
from fcapon.view_test;

```

### SQL Sous-requête - SQL.sh

*Dans le langage [SQL une sous-requête](https://sql.sh/cours/sous-requete) (aussi appelé “requête imbriquée” ou “requête en cascade”) consiste à exécuter une requête à l’intérieur d’une autre requête. Une requête imbriquée est souvent utilisée au sein d’une clause WHERE ou de HAVING pou remplacer une ou plusieurs constante.*

### Les bases d'exemples
* [Employees Sample Database](https://dev.mysql.com/doc/employee/en/)
* [Sakila Sample Database](https://dev.mysql.com/doc/sakila/en/)

Vous devez procéder vous-même à une rétroconception de chacune de ces bases.

### Rendu

Vous devez rendre dans un fichier `TP-XX-PrenomNom.md` comprenant pour chaque question :
* la question
* la requête SQL qui doit toujours donner un résultat explicitement ordonné
* des explications textuelles
* un échantillon ou le total du résultat de la requête au format texte est demandée
* GitHub Classroom : TODO

#### Exemple
1. Donner le nombre de départements de l'entreprise ?
```sql
select count(*) (2)
from departments (1)
;
(1) la table departments contient la liste de tous les départements de l'entreprise
(2) il suffit de compter count(*) le nombre de lignes de la table
```
1. Autre question

### Norme de codage

Tous les noms que vous créés (alias, vue,...) doivent respecter la norme de codage [Snake case](https://fr.wikipedia.org/wiki/Snake_case) comme c'est le cas pour les noms existants ainsi que la mise au pluriel.


### Ressources

* [MySQL 5.7 Reference Manual](https://dev.mysql.com/doc/refman/5.7/en/)
* [About DBeaver](https://github.com/dbeaver/dbeaver/wiki)
* [SQL.sh](https://sql.sh/)
* [Vue](https://fr.wikipedia.org/wiki/Vue_(base_de_donn%C3%A9es))

## Base `employees`

> :information_source: Chaque question correspond à une et une seule requête monotable.
>
> :soccer: Le résultat monocellule d'une requête peut-être utilisé comme une valeur.
>
> :eyes: Si la requête porte sur plusieurs tables, vous devez décrire textuellement les relations entre ces tables.

### Table `employees`
1. Quel est le nombre total d'employés de l'entreprise depuis la création de la base ?
1. Quels sont le nombre total d'employés hommes et le nombre total d'employés femmes ?
1. Quelles sont les dates de naissance du plus vieux et du plus jeune employé ?
1. Donnez la liste de ces employés.
1. Des employés portent-ils le même nom et le même prénom ? 
1. Si oui, donnez la liste de ces couples de nom et prénom avec pour chacun le nombre d'employés les portant le tout trié de manière à mettre en avant les couples nom et prénom les plus remarquables.

### Table `salaries`

1. Quelle est la somme totale des salaires versés aux employés depuis la mise en place de la base ?
1. Quel est actuellement le nombre total de salaires versés par l'entreprise ?

### Table `titles`
1. Donnez la liste des postes ayant été occupés ou des postes actuellement occupés par les employés.
1. Donnez la liste des postes occupés actuellement par les employés ainsi que le nombre d'employés occupant ce poste.
1. Comptez le nombre de postes actuellement attribués aux employés.
1. Vérifiez la cohérence avec le nombre de salaires actuellement versés, la requête devra présenter le résultat exactement sous cette forme
```
table    | nombre
=================
salaries | xxxx
titles   | xxxx
```
L'`union` peut vous être d'un grand secours : https://sql.sh/cours/union

> :information_source: Chaque question correspond à une et une seule requête multitables.

### Tables `employees`, `titles` et `salaries`
1. Écrivez une requête permettant de "regrouper" l'ensemble des informations contenues dans les deux tables `employees` et `titles`, vous présenterez trois variantes d'écriture de cette requête. Créez la vue correspondante.
2. À l'aide de la vue créée en 1., écrivez une requête qui permet de donner pour chaque employé le nombre de postes qu'il a occupés durant sa carrière.
3. Écrivez une requête permettant de donner la situation actuelle des employés toujours salariés de l'entreprise et créez la vue correspondante (informations de la table employees, intitulé poste occupé, poste occupé depuis le, "salaire" depuis le)
4. Écrivez une requête permettant de donner la situation actuelle de tous les employés de l'entreprise et créez la vue correspondante. Les informations inexistantes pour les ex-employés seront mises à `null`.
5. Écrivez une requête permettant de vérifier la cohérence de la situation actuelle des employées (employé ayant un salaire, mais pas de poste ou vice-versa). Peu d'employés se plaignent dans le premier cas, c'est pourquoi il est nécessaire de le vérifier !
6. Donnez le nombre d'ex-employées en vous appuyant sur la vue créée en 4.
7. Donnez le nombre actuel d'employées en vous appuyant sur la vue créée en 4.
8. Écrivez une requête permettant de vérifier la cohérence de 6. et 7. La requête devra renvoyer un booléen.

## Base `sakila`

> :information_source: Chaque question correspond à une et une seule requête multitables.
>
> :soccer: Le résultat monocolonne d'une requête peut-être utilisé comme une liste de valeur.
> :soccer: Il existe un mot clef qui permet de ne retourner que les valeurs distinctes d'une colonne.
>
> :eyes: Si la requête porte sur plusieurs tables, vous devez décrire textuellement les relations entre ces tables.

### Tables `country`, `city` et `address`
1. Écrivez une requête permettant de donner l'ensemble des informations "adresse" et créez la vue correspondante.

### Tables `customer`, `country`, `city` et `address`
1. Écrivez une requête permettant de donner pour chaque ville le nombre de clients actifs.

### Films et catégories

1. Écrivez une requête donnant le nombre de catégories de chaque film et créez la vue correspondante.
2. À l'aide de la vue créée en 1., comptez le nombre de films ayant plus d'une catégorie.
3. À l'aide du résultat du 2., vous pouvez vérifiez que tous les films ont une catégorie, la requête devra présenter le résultat exactement sous cette forme
```
table    | nombre
=================
film     | xxxx
category | xxxx
```
3. Concluez sur cette partie du modèle de la base `sakila` et proposez en une modification.

### Films et acteurs

1. Écrivez une requête donnant pour chaque film ses acteurs et créez la vue correspondante.
2. À l'aide de la vue créée en 1., donnez la liste des films ayant plus d'un acteur en mettant en avant les films ayant le plus d'acteurs.
3. Écrivez une requête qui donne le nombre de film sans acteurs.
4. Donnez la liste de ces films.

### Table `address`
Cette table présente une caractéristique spécifique qui la distingue des autres tables de la base. Identifiez cette caractéristique et expliquez son intérêt.

### Table orpheline
Il y a une table orpheline (ou zombie) dans le modèle, identifiez-la et expliquez s'il vous semble qu'elle est utile ou non.

## Rendu

* Sur GitHub Classroom : https://classroom.github.com/a/xHmf37xI
* **Date limite : 15/06/22 à 09:00**