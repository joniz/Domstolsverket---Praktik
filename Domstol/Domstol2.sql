BEGIN TRANSACTION;
CREATE TABLE Questions (
questionID INTEGER PRIMARY KEY AUTOINCREMENT,
questionYesID INTEGER,
questionNoID INTEGER,
questionText TEXT NOT NULL,
questionImageName TEXT,
FOREIGN KEY (questionID) REFERENCES Problems(firstQuestionID)
ON UPDATE CASCADE ON DELETE CASCADE
);
INSERT INTO `Questions` VALUES (1,2,4,'Låter det som att uppringssignaler går fram?',NULL);
INSERT INTO `Questions` VALUES (2,NULL,3,'Kontakta personen som ska ta emot samtalet för att kontrollera att hen sitter i rummet och väntar. Går det att koppla upp videokonferenssamtalet?',NULL);
INSERT INTO `Questions` VALUES (3,NULL,6,'Tryck på knapp "Avsluta" och "Avsluta förhandling"
Starta förhandligen igen genom attt trycka på "Pårop". Gör uppkopplingen av videokonferenssamtalet igen. Hör salen fjärrparten?',NULL);
INSERT INTO `Questions` VALUES (4,NULL,5,'Kontrollera att du har fått rätt nummer.
Om du ringer inom Sveriges Domstolar ska det vara ett femsiffrigt nummer.
Om du ringer utanför Sveriges Domstolar är det antingen ett IP-nummer eller ett 
ISDN-nummer. Ett IP-nummer innehåller tecken som punkter eller @. 
Till exempel: 194.45.16.16 eller moss@domstol.no
Ett ISDN-nummer ser ut som ett telefonnummer. Till exempel 036478390.
OBS! Om det är ett ISDN-nummer måste du lägga till en 0:a före numret. Alltså 0036478390.
Går det att koppla upp videokonferenssamtalet?',NULL);
INSERT INTO `Questions` VALUES (5,2,6,'Låter det som att uppringningssignaler går fram?',NULL);
INSERT INTO `Questions` VALUES (6,7,8,'Koppla upp ett videokonferenssamtal till Tekniksupportens videokonferenssystem 3600. Alternativt till testsystemet 3699 där det spelas upp ljud och en kamera filmar en skärm på vad fjärrparten ser. Går det att koppla upp till Tekniksupportens videokonferenssystem?',NULL);
INSERT INTO `Questions` VALUES (7,NULL,NULL,'Problemet är troligen hos fjärrparten. Be fjärrparten kontakta sin videokonferensansvariga för att felsöka fjärrpartens system. 
',NULL);
INSERT INTO `Questions` VALUES (8,NULL,NULL,'Kontakta Tekniksupporten på 036-4422000',NULL);
INSERT INTO `Questions` VALUES (9,10,11,'Är salens mikrofoner aktiverade. Kontrollera detta i
pekskärmen -> Inställningar -> Ljud',NULL);
INSERT INTO `Questions` VALUES (10,12,13,'Fungerar salens mikrofoner?
Kontrollera detta genom att lyssna
i en hörsnäcka. Kommer det ljud i
hörsnäckan?',NULL);
INSERT INTO `Questions` VALUES (11,NULL,10,'Aktivera salens mikrofoner. Hör
fjärrparten vad som sägs i salen?',NULL);
INSERT INTO `Questions` VALUES (12,14,NULL,'Har fjärrparten höjt
volymen på sitt ljud från
högtalarna?',NULL);
INSERT INTO `Questions` VALUES (13,NULL,15,'Koppla ner videokonferenssamtalet
och koppla upp det igen.
Hör fjärrparten vad som
sägs i salen? ',NULL);
INSERT INTO `Questions` VALUES (14,16,NULL,'Har fjärrparten höjt
volymen på
videokonferenssystemet?',NULL);
INSERT INTO `Questions` VALUES (15,NULL,17,'Tryck på knapp ”Avsluta” och
”Avsluta förhandling”
Starta förhandlingen igen genom
att trycka på ”Pårop”. Gör
uppkopplingen av
videokonferenssamtalet igen.
Hör fjärrparten salen?',NULL);
INSERT INTO `Questions` VALUES (16,'',18,'Koppla ner
videokonferenssamtalet och
koppla upp det igen. Hör
fjärrparten vad som sägs i
salen? ',NULL);
INSERT INTO `Questions` VALUES (17,NULL,19,'Starta om racket.
Starta sedan förhandlingen
igen genom att trycka på
”Pårop”. Gör uppkopplingen av
videokonferenssamtalet igen.
Hör fjärrparten salen?',NULL);
INSERT INTO `Questions` VALUES (18,NULL,19,'Tryck på knapp ”Avsluta” och ”Avsluta förhandling”
Starta förhandlingen igen genom att trycka på
”Pårop”. Gör uppkopplingen av
videokonferenssamtalet igen. Hör fjärrparten salen?',NULL);
INSERT INTO `Questions` VALUES (19,20,21,'Koppla upp ett
videokonferenssamtal till
Tekniksupportens
videokonferenssystem 3600.
Alternativt till testsystemet 3699
där det spelas upp ljud och en
kamera filmar en skärm på vad
fjärrparten ser. Hör
Tekniksupporten salen?',NULL);
INSERT INTO `Questions` VALUES (20,NULL,NULL,'Problemet är troligen hos
fjärrparten. Be fjärrparten kontakta
sin videokonferensansvariga för att
felsöka fjärrpartens system.',NULL);
INSERT INTO `Questions` VALUES (21,NULL,NULL,'Kontakta Tekniksupporten på 036-44 22 000',NULL);
CREATE TABLE Problems(
problemID INTEGER PRIMARY KEY AUTOINCREMENT,
firstQuestionID INTEGER,
problemDescription TEXT NOT NULL,
problemCategory TEXT NOT NULL,
problemTypeOfRoom TEXT NOT NULL,
FOREIGN KEY (firstQuestionID) REFERENCES Questions(questionsID)
);
INSERT INTO `Problems` VALUES (2,NULL,'Salen ser ingen bild från fjärrparten','Video','Sal');
INSERT INTO `Problems` VALUES (3,NULL,'Salen hör inte fjärrparten','Ljud','Sal');
INSERT INTO `Problems` VALUES (4,NULL,'Fjärrparten hör inte salen','Ljud','Sal');
INSERT INTO `Problems` VALUES (5,1,'Kan inte koppla upp videokonferenssamtal','Video','Sal');
INSERT INTO `Problems` VALUES (6,NULL,'Fjärrparten ser ingen bild från salen','Video','Sal');
COMMIT;
