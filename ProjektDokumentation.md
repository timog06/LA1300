# Projekt-Dokumentation

##Popcorn || Lai, Willi, Evans, Atputharasa, Goedertier

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

In unserem Porjekt geht es um das Kindheitsspiel-Spiel "Schiffe versenken".

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
| 9    |Kann             |Qualität  |Als Benutzer möchte ich ein Punktesystem mit Highscore haben.|
| 10   |Kann             |Qualität  |Als Benutzer möchte ich sehen, wie viele Spiele ich schon Gewonnen habe.|
| 11   |Kann             |Qualität  |Als Benutzer möchte ich, dass das Programm schön aussieht.|
| 12   |Muss             |Rand      |Das Programm soll in C# geschrieben werden.|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |              |         |                   |
| 1.2  |              |         |                   |
| 1.3  |              |         |                   |
| 2.1  |              |         |                   |
| 2.2  |              |         |                   |
| 2.3  |              |         |                   |
| 3.1  |              |         |                   |
| 3.2  |              |         |                   |
| 3.3  |              |         |                   |
| 4.1  |              |         |                   |
| 4.2  |              |         |                   |
| 4.3  |              |         |                   |
| 5.1  |              |         |                   |
| 5.2  |              |         |                   |
| 5.3  |              |         |                   |
| 6.1  |              |         |                   |
| 6.2  |              |         |                   |
| 6.3  |              |         |                   |
| 7.1  |              |         |                   |
| 7.2  |              |         |                   |
| 7.3  |              |         |                   |
| 8.1  |              |         |                   |
| 8.2  |              |         |                   |
| 8.3  |              |         |                   |
| 9.1  |              |         |                   |
| 9.2  |              |         |                   |
| 9.3  |              |         |                   |
| 10.1 |              |         |                   |
| 10.2 |              |         |                   |
| 10.3 |              |         |                   |

### 1.4 Diagramme

<img src="https://user-images.githubusercontent.com/110891995/203274456-490e96cd-e41f-4f27-b333-9d2a5852b24d.jpg" alt="drawing" width="50%"/>

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |              |         |                   |
| 1.B  |              |         |                   |
| 1.C  |              |         |                   |
| 2.A  |              |         |                   |
| 2.B  |              |         |                   |
| 2.C  |              |         |                   |
| 3.A  |              |         |                   |
| 3.B  |              |         |                   |
| 3.C  |              |         |                   |
| 4.A  |              |         |                   |
| 4.B  |              |         |                   |
| 4.C  |              |         |                   |
| 5.A  |              |         |                   |
| 5.B  |              |         |                   |
| 5.C  |              |         |                   |
| 6.A  |              |         |                   |
| 6.B  |              |         |                   |
| 6.C  |              |         |                   |
| 7.A  |              |         |                   |
| 7.B  |              |         |                   |
| 7.C  |              |         |                   |
| 8.A  |              |         |                   |
| 8.B  |              |         |                   |
| 8.C  |              |         |                   |
| 9.A  |              |         |                   |
| 9.B  |              |         |                   |
| 9.C  |              |         |                   |
| 10.A |              |         |                   |
| 10.B |              |         |                   |
| 10.C |              |         |                   |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

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
