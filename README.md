# Lern-Periode 4

14.2 bis 4.4

## Grob-Planung

1. Wo stehen Sie mit Ihren Noten? In welchen Modulen waren Sie besonders stark; in welchen sind die ungenügend? Welche davon sind besonders wichtig? Meine Noten sind gerade oke. Ich war einfach in dem Modul mit UMl nicht so stark aber in den Programmier Modulen war ich nicht schlecht.
2. Was wäre ein geeignetes Projekt für diese LP4? Können Sie mit diesem Projekt zeigen, wie Sie sich selbständig in eine Problemstellung einarbeiten können und eine überzeugende Lösung programmieren können? Ich denke für diese Lernperiode möchte ich ein Passwortmanager machen. Ich denke es ist ein gutes Projekt um selbständig an einer Problemstellung zu arbeiten.
Dieser Passwortmanager soll wichtige Passwörter speichern von Apps oder wensites  und er soll noch ein Passwortgenerator haben.


## Fertiges Projekt
Ich habe ein Passwort Manager Programmiert. In diesem Programm kann man seine Passwörter speichern. Damit die Passwörter auch sicher sind gibt es am Anfang ein Login für das ganze programm. Alles was man eingeben muss ist die App oder die Webseite und dann noch das jeweilige Passwort dazu, wenn die Eingabe gespeichert wurden ist werden die passwörter immer zum nachschauen in einer Liste aufgeschrieben. Falls man das Passwort nicht mehr braucht kann man auch einfach auf das Passwort in der Liste klicken und auf delete drücken.

Login für das Programm:
![Screenshot 2025-04-04 094326](https://github.com/user-attachments/assets/5a4ec91f-13c4-4616-86a0-c036b4eb93e2)
![Screenshot 2025-04-04 094345](https://github.com/user-attachments/assets/9ef8d52c-a77d-4dd8-940a-6b5fcea40957)

Mit new Passwords kann man neue Passwörter speichern und mit Saved Passwords kann man die gespeicherten Passwörter anschauen.
![Screenshot 2025-04-04 094354](https://github.com/user-attachments/assets/9a2a5881-5b48-4431-b535-8bf162081bb7)

New Passwords:
![Screenshot 2025-04-04 094415](https://github.com/user-attachments/assets/a1ff1393-6df0-4a22-8cd5-56974bef3a6b)
Neues Password eingeben und speichern:
![Screenshot 2025-04-04 094512](https://github.com/user-attachments/assets/542a4ef0-739e-42e0-9975-e30e3932dc6f)

Saved Passwords:
![Screenshot 2025-04-04 094526](https://github.com/user-attachments/assets/294d9b61-7b70-49c5-a9ce-54f7da2e0b9c)

Passwort löschen:
![Screenshot 2025-04-04 094605](https://github.com/user-attachments/assets/8ab5cf57-c9d0-4b1c-a7d4-f8fb7e1609c9)
![Screenshot 2025-04-04 094619](https://github.com/user-attachments/assets/088e31e6-e4a2-4db1-9c6e-44a90268f8e1)

## 14.2: Explorativer Wegwerf-Prototyp

- [x] Rausfinden wie man Anfangen kann
- [ ] Grundgerüst des managers machen

✍️ Heute habe ich... (50-100 Wörter)
bisschen rausgefunden wie ich in dieses Projekt starten möchte. Ich habe ganz simple gestarten und auch das gemacht was Herr Colic vorher im Call uns gezeigt hat. Ich habe einen Button mit Save new Passwort, wenn man auf den klickt kommt man auf ein neues Fenster wo drauf steht eingabe Passwort. Darunter ist eine Textbox in der Man dann das Passwort eingeben kann.
☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## 21.2: Explorativer Wegwerf-Prototyp

- [x] Design des Passwort manegers machen: Passwort eingeben, Webseite oder app dazu, Auf erstem Fenster zweiter Knopf für alle gespeicherten Passw. anzeigen (dieses AP sollte offline, also ohne Laptop zu bearbeiten sein)
- [x] Arrays oder Lists für zum abspeichern
- [X] An Modul 164 arbeiten

✍️ Heute habe ich... (50-100 Wörter)
Beim AP offline habe ich das Deign meines Passwort savers gezeichnet und alles was im Programm sein sollte. Dann habe ich im zweiten AP angefangen zu Programmieren und jetzt wennman auf den Button saved passwords klickt kommt man zu einem neuen screen wo jetzt drei passwörter stahen die ich in einem eindimensionalen Array über Code gespeichert habe. In den letzten beiden Ap musst ich dann am Mittwochs Modul arbeiten da wir eine Abgabe haben.
☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## 28.2: Kern-Funktionalität
- [x] Array zweidimensional machen damit ich die app und das Passwort kann speichern
- [x] Den zweiten screen Programmieren mit der eingabe für ein neus Passwort.
- [ ] Passwort soll aufgefasst werden( im array) --Weis nicht ob es passiert ist--
- [ ] Passwort soll ausgegeben werden bei saved passwords --Weis nicht ob es passiert ist--
Heute habe ich...
Ich habe heute das array zwei dimensional gemacht und ich habe versucht die eingabe bei save new Password zu programmieren. Aber nun wenn ich die buttons im Hauptprogramm drücke gehen die screens von savedpassword und eingabePassword nicht mehr auf.
## 7.3: Kern-Funktionalität
- [x] Fehler finden warum die anderen Screens nicht aufgehen
- [x] Fehler korrigieren
- [x] Passwort soll aufgefasst werden( im array) 
- [x] Passwort soll ausgegeben werden bei saved passwords

Heute habe ich...
Ich habe lange nach dem Fehler gesucht. Es hat sich herausgestellt das die Buttons nicht mit dem Event verknüpft waren. Weil ich warscheinlich irgenwie vorher mal irgendewas geändert habe oder geläscht habe. Dann gab es irgenwie ein fehler im Desiner wo ich dann musste beheben(da habe ich Chatgpt um hilfe gebeten) Dann habe ich es geschafft das es meine Passwörter in einer Liste speichert. Jedoch hat es nicht für immer gespeichert, immer wenn ich das Programm geschlossen habe und wieder geöffnet habe waren die Passwörter weg. Ich habe dann das Speichern mit JSON gemacht. Nun immer wenn ich das Programm schliesse speichert es alle meine Passwörter.

## 14.3: Architektur ausbauen

- [x] Die Test Texte aus dem Programm löschen: Da wo noch steht ...wurde geöffnet und man dann noch Ok drücken muss
- [x] Passwörter wieder aus der Liste löschen können
- [ ] Heraus finden wie man das Programm kann sichern damit nicht jeder die Passwörter kann anschauen
- [ ] Passwort zum ins Programm können machen.(dieses Passwort im kopf behalten oder auf papier aufschreiben)

Heute habe ich...
Ich habe die Test Texte aus dem Programm gelöscht und dann habe ich einen neuen Button bei saved Passwords hinzugefügt. Mit diesem button kann man nun wieder Passwörter löschen wenn man diese nicht mehr in der Liste haben möchte. Dann habe ich angefangen zu über legen wie ich das Programm mit einem code sichern kann. Leider habe ich immernoch keine ahnug wie ich das angehen sollte. Ich habe auch recherchiert aber irgendwie nichts wirklich gefunden. Ich muss das nächstes mal noch genauer anschauen.
## 21.3: Architektur ausbauen
- [x] Genaue recherche wieman das programm sichert
- [x] Sicherung programmieren
- [x] Oder  ganz am annfang noch ein fenster hinzufügen wo eine abfrage hat. man muss dann dort etwas bestimmtes eingeben damit man zum orginal fenster kommt. Das kann vielleicht mit einem if statement funktionieren.

Heute habe ich...
Die sicherung Programmiert für das Programm. Ich musste ein extra Form machen -> LoginForm, da habe ich ein if statement reingepackt wo man nun ein Passwort eingeben muss. Nun funktioniert es aber nicht ganz, weil Forms1 nicht aufmacht. Vielleicht funtioniert der Login Knopf nicht. 
## 28.3: Auspolieren
- [x] Herausfinden was der Fehler ist.
- [x] Fehler korrigieren
- [x] Design ändern
Heute habe ich...
Der Fehler lag wieder am  button er musste erstmal mit dem Hauptprogramm verbunden werden. Dann hat das Programm wieder funktioniert. Zum AUspolieren habe ich dann die Screens ein bisschen grösser gemacht, alles zurecht gerichtet, das heisst alles ins Zentrum. Dann habe ich die Hintergrundfarbe gewechselt damit es nicht so langweilig ist.
## 4.4: Auspolieren & Abschluss

- [ ] Screens gleich gross machen, so das der Text immer zentriert ist
- [ ] Code organisieren
