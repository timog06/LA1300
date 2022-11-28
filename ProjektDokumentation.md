# Projekt-Dokumentation

##Popcorn || Lai, Willi, Evans, Atputharasa, Goedertier

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|22.11.2022|0.0.1 |Wir haben heute die User Stories erstellt und zugeteilt. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

In unserem Projekt geht es um das Kindheitsspiel-Spiel "Schiffe versenken".

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |Muss             |Funktional|Als Benutzer möchte ich die Postiton meiner Schiffe bestimmen können.|
| 2    |Muss             |Funktional|Als Programmierer möchte ich, dass das Programm nicht zweimal auf die selbe Stelle schiesst.|
| 3    |Muss             |Funktional|Als Programmierer möchte ich, dass falsche Eingaben abgefangen werden.|
| 4    |Kann             |Qualität  |Als Benutzer möchte ich sehen, auf welche Felder ich schon geschossen habe.|
| 5    |Muss             |Funktional|Als Benutzer möchte ich wissen, ob ich ein Schiff des Gegners getroffen oder zerstört habe.|
| 6    |Muss             |Funktional|Als Programmierer möchte ich, dass das Programm nicht immer die gleiche Position der Schiffe einnimmt.|
| 7    |Kann             |Qualität  |Als Benutzer möchte ich das Spiel wiederholen können.|
| 8    |Kann             |Qualität  |Als Benutzer möchte ich, dass die Wasserfelder, die abgeschossen wurden, eine andere Farbe haben als die getroffenen Schiffe. |
| 9    |Kann             |Qualität  |Als Benutzer möchte ich ein Punktesystem haben.|
| 10   |Kann             |Qualität  |Als Benutzer möchte ich sehen, wie viele Spiele ich schon Gewonnen habe.|
| 11   |Kann             |Qualität  |Als Benutzer möchte ich, dass das Programm schön aussieht.|
| 12   |Muss             |Rand      |Das Programm soll in C# geschrieben werden.|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm gestartet|Start des Spiels|Erscheinung eines Fensters.|
| 1.2  | Das Programm zeigt die verschiedenen Schiffe die man anweisen kann.|Postionsbestimmung eingeben|Anzeige der Positionen der verschiedenen Schiffe.|
| 1.3  | Das Programm sagt mir dass ich die Positionen meiner Schiffe bestimmen sollte.|Eingabe Positionen meiner Schiffe|Anzeige der Schiffe auf dem Spielfeld.|
| 2.1  | Spieler Nr.2 "AI" wählt ein Feld             | C4        |  Kein Schiff wurde getroffen.                 |
| 2.2  | Spieler Nr.2 "AI" wählt ein Feld            |  A2       | Ein Schiff wurde getroffen.                  |
| 2.3  | Spieler Nr.2 "AI" wählt ein Feld             |    B3     |  Ein Schiff wurde versenkt.                 |
| 3.1  | Spieler wählt ein Feld            |  YZ       |   Dieses Feld existiert nicht. Geben Sie ein Feld ein, welches existiert.               |
| 3.2  | Spieler bestimmt die Position seiner Schiffe | Setzt die Schiffe ausserhalb des Spielfelds | Setzen Sie die Schiffe innerhalbs des Feldes                   |
| 3.3  | Spieler will das Spiel wiederholen           | hdfuhdsfuihaih        | Geben Sie Ja oder Nein ein                  |
| 4.1  |              |         |                   |
| 4.2  |              |         |                   |
| 4.3  |              |         |                   |
| 5.1  | Der Benutzer gibt einen Punkt an, an dem er schiesst.|Eingabe des Punktes|Anzeige der Position des angegeben Schusses.|
| 5.2  | Das Programm zeigt die Stelle an, an dem der Benutzer geschossen hat.|Eingabe des Punktes an die geschossen wird|Anzeige der Stelle.|
| 5.3  | Das Programm zeigt diese Stelle an und zeigt ob der Benutzer ein gegenerisches Schiff getroffen hat.|Eingabe des Punktes|Anzeige einer getroffenen/nicht getroffenen. Stelle.|
| 6.1  | Spieler Nr.2 "AI" positioniert seine Schiffe             | ...        | Schiffe sind positioniert worden und Spieler Nr.1 kann diese nicht sehen.                  |
| 6.2  | Spieler Nr.2 "AI" positioniert seine Schiffe             | ...        | Schiffe werden zufällig positioniert und Spieler Nr.1 kann diese nicht sehen.        |         
| 6.3  | Spieler Nr.2 "AI" positioniert seine Schiffe             | ...        | Schiffe werden zufällig positioniert (nicht gleich wie vorher) und Spieler Nr.1 kann diese nicht sehen.                  |
| 7.1  | Der Spieler hat das Spiel gewonnen/verloren             |  Enter       | Möchten Sie das Spiel wiederholen?                  |
| 7.2  | Möchten Sie das Spiel wiederholen?              |  Ja       |  Eine neue Runde beginnnt                 |
| 7.3  | Möchten Sie das Spiel wiederholen?             |  Nein       | Dieses Programm wird beemdet                  |
| 8.1  |              |         |                   |
| 8.2  |              |         |                   |
| 8.3  |              |         |                   |
| 9.1  |Spiel wurde gestartet|Gegnerisches Schiff wurde getroffen|Punkte +100|
| 9.2  |Spiel wurde gestartet|Gegnerisches Schiff wurde verfehlt|Punktestand verändert sich nicht|
| 9.3  |Spiel wurde gestartet|Eigenes Schiff wurde Getroffen|Punkte -30|
| 10.1 |Spiel wurde gestartet|Spiel wird gewonnen|History Log updated(+1 Win)|
| 10.2 |Spiel wurde gestartet|Spiel wird verloren|History Log updated(+1 Lost)|
| 10.3 |Spiel wurde gestartet|Spiel wurde geschlossen vor Abschluss|No Log changes|

### 1.4 Diagramme

<img src="https://user-images.githubusercontent.com/110891995/203274456-490e96cd-e41f-4f27-b333-9d2a5852b24d.jpg" alt="drawing" width="50%"/>

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |06.11.2022|T. Evans|                   |          |
| 1.B  |06.11.2022|T. Evans|                   |          |
| 1.C  |06.11.2022|T. Evans|                   |          |
| 2.A  |06.11.2022|L. Lai  |                   |          |
| 2.B  |06.11.2022|L. Lai  |                   |          |
| 2.C  |06.11.2022|L. Lai  |                   |          |
| 3.A  |06.11.2022|A. Atputharasa|             |          |
| 3.B  |06.11.2022|A. Atputharasa|             |          |
| 3.C  |06.11.2022|A. Atputharasa|             |          |
| 4.A  |06.11.2022|R. Willi|                   |          |
| 4.B  |06.11.2022|R. Willi|                   |          |
| 4.C  |06.11.2022|R. Willi|                   |          |
| 5.A  |06.11.2022|T. Evans|                   |          |
| 5.B  |06.11.2022|T. Evans|                   |          |
| 5.C  |06.11.2022|T. Evans|                   |          |
| 6.A  |06.11.2022|L. Lai  |                   |          |
| 6.B  |06.11.2022|L. Lai  |                   |          |
| 6.C  |06.11.2022|L. Lai  |                   |          |
| 7.A  |06.11.2022|A. Atputharasa|             |          |
| 7.B  |06.11.2022|A. Atputharasa|             |          |
| 7.C  |06.11.2022|A. Atputharasa|             |          |
| 8.A  |06.11.2022|R. Willi|                   |          |
| 8.B  |06.11.2022|R. Willi|                   |          |
| 8.C  |06.11.2022|R. Willi|                   |          |
| 9.A  |06.11.2022|T. Goedertier|Punktesystem erstellen und Punkte addieren bei Treffer|90'|
| 9.B  |06.11.2022|T. Goedertier|Keine veränderungen im Punktestand bei Fehlschüsse|20'|
| 9.C  |06.11.2022|T. Goedertier|Punkte subtraktion bei Treffern vom Gegner|60'|
| 10.A |06.11.2022|T. Goedertier|History Log erstellen und Win updates|120'|
| 10.B |06.11.2022|T. Goedertier|Loose Updates im Log|75'|
| 10.C |06.11.2022|T. Goedertier|Bei Crashes oder gewolltem schliessen vom Programm keine Log veränderungen|30'|

Total: 
Wir haben Total 30 Arbeitspakete.

## 3 Entscheiden

Wir haben uns schnell entschieden ein Schiffe versenken Spiel zu machen mit der Idee Spieler vs. KI. Um dem Spieler mehr Motivation zu geben haben wir uns auch für ein Punktesystem entschieden.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
